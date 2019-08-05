using System;
namespace Decorated_Pattern
{
    public class FouthGradeSchoolReport : SchoolReport
    {
        //我的成绩单
        public override void report()
        {
            //成绩单的格式是这个样子的
            Console.WriteLine("尊敬的XXX家长:");
            Console.WriteLine("......");
            Console.WriteLine("语文 62  数学65 体育 98  自然  63");
            Console.WriteLine(".......");
            Console.WriteLine("家长签名：       ");
        }
        //家长签名
        public override void sign(string name)
        {
            Console.WriteLine("家长签名为：" + name);
        }
    }
}