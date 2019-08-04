using System;
namespace ChainOfResponsibility {
    public class Husband : Handler {
        // public void HandleMessage (IWomen women) {
        //     Console.WriteLine ("妻子的请示是：" + women.getRequest ());
        //     Console.WriteLine ("丈夫的答复是:同意");
        // }

        //丈夫只处理妻子的请求
        public Husband () : base (Handler.HUSBAND_LEVEL_REQUEST) { }
        //丈夫请示的答复
        protected override void response (IWomen women) {
            Console.WriteLine ("--------妻子向丈夫请示-------");
            Console.WriteLine (women.getRequest ());
            Console.WriteLine ("丈夫的答复是：同意\n");
        }
    }
}