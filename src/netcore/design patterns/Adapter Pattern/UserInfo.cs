using System;
namespace Adapter_Pattern
{
    public class UserInfo : IUserInfo
    {

        // 获得家庭地址，下属送礼也可以找到地方
        public string getHomeAddress()
        {
            Console.WriteLine("这里是员工的家庭地址...");
            return null;
        }
        // 获得家庭电话号码       
        public string getHomeTelNumber()
        {
            Console.WriteLine("员工的家庭电话是...");
            return null;
        }

        // 员工的职位，是部门经理还是普通职员
        public string getJobPosition()
        {
            Console.WriteLine("这个人的职位是BOSS...");
            return null;
        }
        // 手机号码
        public string getMobileNumber()
        {
            Console.WriteLine("这个人的手机号码是0000...");
            return null;
        }

        // 办公室电话，烦躁的时候最好"不小心"把电话线踢掉
        public string getOfficeTelNumber()
        {
            Console.WriteLine("办公室电话是...");
            return null;
        }

        // 姓名，这个很重要
        public string getUserName()
        {
            Console.WriteLine("姓名叫做...");
            return null;
        }
    }
}