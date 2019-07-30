using System;

namespace Proxy_Pattern
{
    public class GamePlayer : IGamePlayer
    {
        private string name = "";

        private IGamePlayer proxy = null;
        public GamePlayer(string name)
        {
            this.name = name;
        }

        public IGamePlayer getProxy()
        {
            this.proxy = new GamePlayerProxy(this);
            return this.proxy;
        }

        //打怪，最期望的就是杀老怪
        public void killBoss()
        {
            if (this.isProxy())
            {
                Console.WriteLine($"{ this.name }在打怪！");
            }
            else
            {
                Console.WriteLine("请使用指定的代理访问");
            }
        }

        //进游戏之前你肯定要登录吧，这是一个必要条件
        public void login(string user, string password)
        {
            if (this.isProxy())
            {
                Console.WriteLine($"登录名为{ user }的用户{ this.name }登录成功！");
            }
            else
            {
                Console.WriteLine("请使用指定的代理访问");
            }
        }

        //升级，升级有很多方法，花钱买是一种，做任务也是一种
        public void upgrade()
        {
            if (this.isProxy())
            {
                Console.WriteLine($"{ this.name } 又升了一级！");
            }
            else
            {
                Console.WriteLine("请使用指定的代理访问");
            }
        }

        private bool isProxy()
        {
            return this.proxy != null;
        }
    }
}