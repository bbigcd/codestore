using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //没有与外系统连接的时候，是这样写的
            // IUserInfo youngGirl = new UserInfo();
            // //从数据库中查到101个
            // for (int i = 0; i < 101; i++)
            // {
            //     youngGirl.getMobileNumber();
            // }

            //我们只修改了这句话
            IUserInfo youngGirl1 = new OuterUserInfo();
            //从数据库中查到101个
            for (int i = 0; i < 101; i++)
            {
                youngGirl1.getMobileNumber();
            }
        }
    }
}
