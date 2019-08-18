namespace Adapter_Pattern
{
    public interface IUserInfo
    {
        //获得用户姓名
        string getUserName();
        //获得家庭地址
        string getHomeAddress();
        //手机号码，这个太重要，手机泛滥呀
        string getMobileNumber();
        //办公电话，一般是座机
        string getOfficeTelNumber();
        //这个人的职位是什么
        string getJobPosition();
        //获得家庭电话，这有点不好，我不喜欢打家庭电话讨论工作
        string getHomeTelNumber();
    }
}