using System;
namespace Command_Pattern {
    public class PageGroup : Group {
        //首先这个美工组应该能找到吧，要不你跟谁谈？
        public override void find () {
            Console.WriteLine ("找到美工组...");
        }
        //美工被要求增加一个页面
        public override void add () {
            Console.WriteLine ("客户要求增加一个页面...");
        }
        //客户要求对现有界面做修改
        public override void change () {
            Console.WriteLine ("客户要求修改一个页面...");
        }
        //甲方是老大，要求删除一些页面
        public override void delete () {
            Console.WriteLine ("客户要求删除一个页面...");
        }
        //所有的增、删、改都要给出计划
        public override void plan () {
            Console.WriteLine ("客户要求页面变更计划...");
        }
    }
}