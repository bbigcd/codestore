using System;
namespace Command_Pattern {
    public class CodeGroup : Group {
        //客户要求代码组过去和他们谈
        public override void find () {
            Console.WriteLine ("找到代码组...");
        }
        //客户要求增加一项功能
        public override void add () {
            Console.WriteLine ("客户要求增加一项功能...");
        }
        //客户要求修改一项功能
        public override void change () {
            Console.WriteLine ("客户要求修改一项功能...");
        }
        //客户要求删除一项功能
        public override void delete () {
            Console.WriteLine ("客户要求删除一项功能...");
        }
        //客户要求给出变更计划
        public override void plan () {
            Console.WriteLine ("客户要求代码变更计划...");
        }
    }
}