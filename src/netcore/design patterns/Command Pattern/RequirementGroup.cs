using System;
namespace Command_Pattern {
    public class RequirementGroup : Group {
        //客户要求需求组过去和他们谈
        public override void find () {
            Console.WriteLine ("找到需求组···");
        }

        public override void add () {
            Console.WriteLine ("客户要求增加一个需求···");
        }

        public override void delete () {
            Console.WriteLine ("客户要求删除一个需求···");
        }

        public override void change () {
            Console.WriteLine ("客户要求修改一个需求···");
        }

        public override void plan () {
            Console.WriteLine ("客户要求需求变更计划···");
        }
    }
}