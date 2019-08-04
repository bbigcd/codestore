using System;
using System.Collections.Generic;

namespace ChainOfResponsibility {
    class Program {
        static void Main (string[] args) {
            // //随机挑选几个女性
            // Random rand = new Random ();
            // List<Women> arr = new List<Women> ();
            // for (int i = 0; i < 5; i++) {
            //     arr.Add (new Women (rand.Next (4), "我要出去逛街"));
            // }
            // //定义三个请示对象
            // IHandler father = new Father ();
            // IHandler husband = new Husband ();
            // IHandler son = new Son ();
            // foreach (IWomen women in arr) {
            //     if (women.getType () == 1) { //未结婚少女，请示父亲
            //         Console.WriteLine ("\n--------女儿向父亲请示-------");
            //         father.HandleMessage (women);
            //     } else if (women.getType () == 2) { //已婚少妇，请示丈夫
            //         Console.WriteLine ("\n--------妻子向丈夫请示-------");
            //         husband.HandleMessage (women);
            //     } else if (women.getType () == 3) { //母亲请示儿子
            //         Console.WriteLine ("\n--------母亲向儿子请示-------");
            //         son.HandleMessage (women);
            //     } else {
            //         //暂时什么也不做
            //     }
            // }

            //随机挑选几个女性
            Random rand = new Random ();
            List<Women> arr = new List<Women> ();
            for (int i = 0; i < 5; i++) {
                arr.Add (new Women (rand.Next (4), "我要出去逛街"));
            }
            //定义三个请示对象
            Handler father = new Father ();
            Handler husband = new Husband ();
            Handler son = new Son ();
            //设置请示顺序
            father.setNext (husband);
            husband.setNext (son);
            foreach (IWomen women in arr) {
                father.HandleMessage (women);
            }
        }
    }
}