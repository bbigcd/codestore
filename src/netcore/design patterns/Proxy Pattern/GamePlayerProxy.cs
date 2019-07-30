using System;
namespace Proxy_Pattern
{
    public class GamePlayerProxy : IGamePlayer, IProxy
    {
        private IGamePlayer _gamePlayer = null;
        //通过构造函数传递要对谁进行代练
        public GamePlayerProxy(IGamePlayer gamePlayer)
        {
            try
            {
                _gamePlayer = gamePlayer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //代练杀怪
        public void killBoss()
        {
            _gamePlayer.killBoss();
        }
        //代练登录
        public void login(string user, string password)
        {
            _gamePlayer.login(user, password);
        }
        //代练升级
        public void upgrade()
        {
            _gamePlayer.upgrade();

            count();
        }

        //代理的代理暂时还没有，就是自己
        public IGamePlayer getProxy()
        {
            return this;
        }

        //计算费用
        public void count()
        {
            Console.WriteLine("升级总费用是：150元");
        }
    }
}