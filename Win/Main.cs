using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Win
{
    public partial class Main : Form
    {
        /**需要设置的变量***********************************/
        int text_width = 800;//文本框宽度
        int max_rows = 3;//最多显示的行数.文本自动根据text_width自动换行.
        int scroll_interal =10;//滚动效果的时间间隔(毫秒),数值越小,速度越快
        int text_change_interal = 5000;//文本显示的时间(毫秒).
        string[] msgs = new GetContentSample().GetContent();//获取内容接口.
        /**************************************************/
        
       
        int init_y = 0;//隐藏文本的初始位置
        int text_height = 0;
        public Main()
        {
            InitializeComponent();
           
            //初始化文本
            lblMsg.Text = msgs[0];
            lblMsg2.Text = msgs[1];
            Size size_row= this.CreateGraphics().MeasureString("测试高度", lblMsg.Font).ToSize();
            text_height = size_row.Height * max_rows;
            //设置文本框高度,宽度,和窗体高度==label高度
            //lblMsg2.Refresh();
            //lblMsg.Refresh();
            //隐藏边框
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Height = text_height;
            lblMsg.Height = lblMsg2.Height=text_height;
            lblMsg.Width = lblMsg2.Width = text_width;
            
            //设置第二个文本框(滚动效果展示用)的位置
            lblMsg.Location = new Point(0, 0);
            lblMsg2.Location = new Point(lblMsg.Location.X, lblMsg.Location.Y+text_height);
            
            //设置背景透明
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            //设置窗体位置至屏幕底部
            Rectangle workingArea = Screen.GetWorkingArea(this);
            
            //不可见文本的初始 
            init_y = lblMsg2.Location.Y;
            this.Location = new Point(0,
                          workingArea.Bottom -text_height+size_row.Height);//为何还需要+一行的高度???
         
          
            //定时切换显示内容.
            Timer t = new Timer();
            t.Interval = text_change_interal;
            t.Tick += new EventHandler(t_Tick);
            t.Start();

        }
        Timer t_scroll;
        int string_index = 1;
        //更换下一行文本.
        void t_Tick(object sender, EventArgs e)
        {
            int max_index = msgs.Length;
            
            
            this.BringToFront();
            t_scroll = new Timer();
            t_scroll.Interval = scroll_interal;
            t_scroll.Tick+=new EventHandler(t_scroll_Tick); //(ts,ta)=>t_scroll_Tick(ts,ta,10);
            t_scroll.Start();
 
           // lblMsg.Refresh();
            string_index += 1;
            if (string_index == max_index)
            {
                string_index = 0;
            }
        }
        int index_scroll = 0;
        //文本框滚动效果.
        void t_scroll_Tick(object sender, EventArgs e)
        {
            index_scroll++;
            lblMsg.Location = new Point(lblMsg.Location.X, lblMsg.Location.Y - 1);
            lblMsg2.Location = new Point(lblMsg2.Location.X, lblMsg2.Location.Y - 1);
            if (index_scroll * 1 == text_height)
            { 
                index_scroll = 0;
                t_scroll.Stop();
                if (lblMsg.Location.Y <0)
                { 
                    lblMsg.Location= new Point(lblMsg.Location.X, init_y);
                    lblMsg.Text = msgs[string_index];
                }
                 if (lblMsg2.Location.Y <0)
                { 
                    lblMsg2.Location= new Point(lblMsg2.Location.X, init_y);
                    lblMsg2.Text = msgs[string_index];
                }
            }
        }

    }
}
