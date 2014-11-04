using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Win
{
   public class GetContentSample:IGetContent
    {

        public string[] GetContent()
        {
            string[] msgs = new string[] { "1(三行)　李商隐，字义山，号玉溪生、樊南生，唐代著名诗人，祖籍河内（今河南省焦作市）沁阳，出生于郑州荥阳。他擅长诗歌写作，骈文文学价值也很高，是晚唐最出色的诗人之一，和杜牧合称“小李杜”，与温庭筠合称为“温李”，", 
            "2(两行)相见时难别亦难，东风无力百花残。相见时难别亦难，东风。", 
            "3(一行)春蚕到死丝方尽，蜡炬成灰泪始干。",
            "4(三行)晓镜但愁云鬓改，夜吟应觉月光寒。李商隐，字义山，号玉溪生、樊南生，唐代著名诗人，祖籍河内（今河南省焦作市）沁阳，出生于郑州荥阳。他擅长诗歌写作，骈文文学价值也很高，是晚唐最出色的诗人之一，和杜牧合称“小李杜”，与温庭筠合称为“温李”，",
            "5(一行)蓬山此去无多路，青鸟殷勤为探看。"
 
            };
            return msgs;
        }
    }
}
