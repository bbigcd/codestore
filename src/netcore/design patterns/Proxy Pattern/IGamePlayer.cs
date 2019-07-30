namespace Proxy_Pattern
{
    public interface IGamePlayer
    {
        // 登录游戏
        void login(string user, string password);

        // 杀怪，网络游戏的主要特色
        void killBoss();

        // 升级
        void upgrade();

        // 获取自己的代理
        IGamePlayer getProxy();
    }
}