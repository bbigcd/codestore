using System;
using System.Collections.Generic;

namespace Adapter_Pattern
{
    public class OuterUserInfo : OuterUser, IUserInfo
    {
        // 员工的基本信息
        private Dictionary<string, string> baseInfo;

        // 员工的家庭信息
        private Dictionary<string, string> homeInfo;

        // 工作信息
        private Dictionary<string, string> officeInfo;
        public OuterUserInfo()
        {
            baseInfo = base.getUserBaseInfo();
            homeInfo = base.getUserHomeInfo();
            officeInfo = base.getUserOfficeInfo();
        }

        // 家庭地址
        public string getHomeAddress()
        {
            string homeAddress = this.homeInfo["homeAddress"];
            Console.WriteLine(homeAddress);
            return homeAddress;
        }

        // 家庭电话号码
        public string getHomeTelNumber()
        {
            string homeTelNumber = this.homeInfo["homeTelNumber"];
            Console.WriteLine(homeTelNumber);
            return homeTelNumber;
        }

        //    职位信息
        public string getJobPosition()
        {
            string jobPosition = this.officeInfo["jobPosition"];
            Console.WriteLine(jobPosition);
            return jobPosition;
        }

        //  手机号码
        public string getMobileNumber()
        {
            string mobileNumber = this.baseInfo["mobileNumber"];
            Console.WriteLine(mobileNumber);
            return mobileNumber;
        }

        // 办公电话
        public string getOfficeTelNumber()
        {
            string officeTelNumber = this.officeInfo["officeTelNumber"];
            Console.WriteLine(officeTelNumber);
            return officeTelNumber;
        }

        //  员工的名称
        public string getUserName()
        {
            string userName = this.baseInfo["userName"];
            Console.WriteLine(userName);
            return userName;
        }
    }
}