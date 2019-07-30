using System;

namespace Proxy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 普通模式
            // IGamePlayer player = new GamePlayer("张三");

            // Console.WriteLine($"开始时间是：{DateTime.Now}");

            // player.login("zhangsan", "password");

            // player.killBoss();

            // player.upgrade();

            // Console.WriteLine($"结束时间是{DateTime.Now}");
            #endregion

            #region 代理模式
            //定义一个游戏的角色
            IGamePlayer player = new GamePlayer("张三");
            //开始打游戏，记下时间戳
            Console.WriteLine("开始时间是：2009-8-25 10:45");
            player.login("zhangSan", "password");
            //开始杀怪
            player.killBoss();
            //升级
            player.upgrade();
            //记录结束游戏时间
            Console.WriteLine("结束时间是：2009-8-26 03:40");

            Console.WriteLine();

            //定义一个游戏的角色
            IGamePlayer player1 = new GamePlayer("张三");
            //然后再定义一个代练者
            IGamePlayer proxy = new GamePlayerProxy(player1);
            //开始打游戏，记下时间戳
            Console.WriteLine("开始时间是：2009-8-25 10:45");
            proxy.login("zhangSan", "password");
            //开始杀怪
            proxy.killBoss();
            //升级
            proxy.upgrade();
            //记录结束游戏时间
            Console.WriteLine("结束时间是：2009-8-26 03:40");
            #endregion
        }
    }
}
