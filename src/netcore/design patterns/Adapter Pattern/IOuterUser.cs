using System.Collections.Generic;

namespace Adapter_Pattern
{
    public interface IOuterUser
    {
        //基本信息，比如名称、性别、手机号码等
        Dictionary<string, string> getUserBaseInfo();
        //工作区域信息
        Dictionary<string, string> getUserOfficeInfo();
        //用户的家庭信息
        Dictionary<string, string> getUserHomeInfo();
    }
}