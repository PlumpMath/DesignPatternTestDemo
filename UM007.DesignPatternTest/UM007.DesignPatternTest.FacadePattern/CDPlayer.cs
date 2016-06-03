using System;

namespace UM007.DesignPatternTest.FacadePattern
{
    public class CDPlayer
    {
        public void On()
        {
            Console.WriteLine("打开了CD播放机,开始观看电影");
        }

        public void Off()
        {
            Console.WriteLine("关闭了CD播放机,结束观看电影");
        }
    }
}
