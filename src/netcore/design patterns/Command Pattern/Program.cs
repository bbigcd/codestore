using System;

namespace Command_Pattern {
    class Program {
        static void Main (string[] args) {
            //首先客户找到需求组说，过来谈需求，并修改
            Console.WriteLine ("-----------客户要求增加一项需求---------------");
            Group rg = new RequirementGroup ();
            //找到需求组
            rg.find ();
            //增加一个需求
            rg.add ();
            //要求变更计划
            rg.plan ();

            // 命令模式
            //定义我们的接头人
            Invoker xiaoSan = new Invoker (); //接头人就是小三
            //客户要求增加一项需求
            Console.WriteLine ("------------客户要求增加一项需求---------------");
            //客户给我们下命令来
            Command command = new AddRequirementCommand ();
            //接头人接收到命令
            xiaoSan.setCommand (command);
            //接头人执行命令
            xiaoSan.action ();
        }
    }
}