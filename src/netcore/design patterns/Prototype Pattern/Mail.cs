using System;
namespace Prototype_Pattern
{
    public class Mail : ICloneable
    {
        //收件人
        private string receiver;
        //邮件名称
        private string subject;
        //称谓
        private string appellation;
        //邮件内容
        private string contxt;
        //邮件的尾部，一般都是加上"XXX版权所有"等信息
        private string tail;
        //构造函数
        public Mail(AdvTemplate advTemplate)
        {
            this.contxt = advTemplate.getAdvContext();
            this.subject = advTemplate.getAdvSubject();
        }
        //以下为getter/setter方法
        public string getReceiver()
        {
            return receiver;
        }
        public void setReceiver(string receiver)
        {
            this.receiver = receiver;
        }
        public string getSubject()
        {
            return subject;
        }
        public void setSubject(string subject)
        {
            this.subject = subject;
        }
        public string getAppellation()
        {
            return appellation;
        }
        public void setAppellation(string appellation)
        {
            this.appellation = appellation;
        }
        public string getContxt()
        {
            return contxt;
        }
        public void setContxt(string contxt)
        {
            this.contxt = contxt;
        }
        public string getTail()
        {
            return tail;
        }
        public void setTail(string tail)
        {
            this.tail = tail;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}