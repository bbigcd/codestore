using System;
namespace ChainOfResponsibility {
    public class Father : Handler {
        // //未出嫁的女儿来请示父亲
        // public void HandleMessage (IWomen women) {
        //     Console.WriteLine ("女儿的请示是：" + women.getRequest ());
        //     Console.WriteLine ("父亲的答复是:同意");
        // }

        //父亲只处理女儿的请求
        public Father () : base (Handler.FATHER_LEVEL_REQUEST) { }
        //父亲的答复
        protected override void response (IWomen women) {
            Console.WriteLine ("--------女儿向父亲请示-------");
            Console.WriteLine (women.getRequest ());
            Console.WriteLine ("父亲的答复是:同意\n");
        }
    }
}