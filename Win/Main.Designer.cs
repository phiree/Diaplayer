namespace Win
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(9, 9);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(800, 122);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "　李商隐，字义山，号玉溪生、樊南生，唐代著名诗人，祖籍河内（今河南省焦作市）沁阳，出生于郑州荥阳。他擅长诗歌写作，骈文文学价值也很高，是晚唐最出色的诗人之一，和杜" +
    "牧合称“小李杜”，与温庭筠合称为“温李”，";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMsg2
            // 
            this.lblMsg2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg2.ForeColor = System.Drawing.Color.Red;
            this.lblMsg2.Location = new System.Drawing.Point(40, 146);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(101, 38);
            this.lblMsg2.TabIndex = 1;
            this.lblMsg2.Text = "label2";
            this.lblMsg2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(771, 193);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblMsg);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ScrollingForm";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblMsg2;




    }
}

