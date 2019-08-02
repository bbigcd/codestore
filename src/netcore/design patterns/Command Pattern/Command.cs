using System;
namespace Command_Pattern {
    public abstract class Command {
        //把三个组都定义好，子类可以直接使用
        protected RequirementGroup rg = new RequirementGroup (); //需求组
        protected PageGroup pg = new PageGroup (); //美工组
        protected CodeGroup cg = new CodeGroup (); //代码组   
        //只有一个方法，你要我做什么事情
        public abstract void execute ();
    }

    public class AddRequirementCommand : Command {
        public override void execute () {
            //找到需求组
            base.rg.find ();
            //增加一份需求
            base.rg.add ();
            //给出计划
            base.rg.plan ();
        }
    }

    public class DeletePageCommand : Command {
        public override void execute () {
            //找到需求组
            base.pg.find ();
            //增加一份需求
            base.pg.add ();
            //给出计划
            base.pg.plan ();
        }
    }

}