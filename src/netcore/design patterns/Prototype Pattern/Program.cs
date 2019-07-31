using System.Text;
using System;

namespace Prototype_Pattern
{
    class Program
    {
        //发送账单的数量，这个值是从数据库中获得
        private static int MAX_COUNT = 6;
        static void Main(string[] args)
        {
            //模拟发送邮件
            int i = 0;
            //把模板定义出来，这个是从数据库中获得
            Mail mail = new Mail(new AdvTemplate());
            mail.setTail("XX银行版权所有");
            while (i < MAX_COUNT)
            {
                //以下是每封邮件不同的地方
                Mail cloneMail = mail.Clone() as Mail;
                cloneMail.setAppellation(GetRandomString(5) + " 先生（女士）");
                cloneMail.setReceiver(GetRandomString(5) + "@" + GetRandomString(8) + ".com");
                //然后发送邮件
                sendMail(cloneMail);
                i++;
            }
        }

        //发送邮件
        public static void sendMail(Mail mail)
        {
            Console.WriteLine($"标题：{ mail.getSubject() } 收件人 { mail.getReceiver() }...发送成功！");
        }
        //获得指定长度的随机字符串

        private static string GetRandomString(int length)
        {
            const string key = "abcdefghijklmnopqrskuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (length < 1)
                return string.Empty;

            Random rnd = new Random();
            byte[] buffer = new byte[8];

            ulong bit = 31;
            ulong result = 0;
            int index = 0;
            StringBuilder sb = new StringBuilder((length / 5 + 1) * 5);

            while (sb.Length < length)
            {
                rnd.NextBytes(buffer);

                buffer[5] = buffer[6] = buffer[7] = 0x00;
                result = BitConverter.ToUInt64(buffer, 0);

                while (result > 0 && sb.Length < length)
                {
                    index = (int)(bit & result);
                    sb.Append(key[index]);
                    result = result >> 5;
                }
            }
            return sb.ToString();
        }
    }
}
