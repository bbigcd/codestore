using System.Collections.Generic;

namespace Adapter_Pattern
{
    public class OuterUser : IOuterUser
    {
        // 用户的基本信息
        public Dictionary<string, string> getUserBaseInfo()
        {
            Dictionary<string, string> baseInfoDic = new Dictionary<string, string>();
            baseInfoDic.Add("userName", "这个员工叫混世魔王...");
            baseInfoDic.Add("mobileNumber", "这个员工电话是...");
            return baseInfoDic;
        }

        // 员工的家庭信息
        public Dictionary<string, string> getUserHomeInfo()
        {
            Dictionary<string, string> homeInfoDic = new Dictionary<string, string>();
            homeInfoDic.Add("homeTelNumbner", "员工的家庭电话是...");
            homeInfoDic.Add("homeAddress", "员工的家庭地址是...");
            return homeInfoDic;
        }

        // 员工的工作信息，比如，职位等
        public Dictionary<string, string> getUserOfficeInfo()
        {
            Dictionary<string, string> officeInfoDic = new Dictionary<string, string>();
            officeInfoDic.Add("jobPosition", "这个人的职位是BOSS...");
            officeInfoDic.Add("officeTelNumber", "员工的办公电话是...");
            return officeInfoDic;
        }
    }
}