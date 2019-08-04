using System;
namespace ChainOfResponsibility {
    public class Son : Handler {
        // public void HandleMessage (IWomen women) {
        //     Console.WriteLine ("母亲的请示是：" + women.getRequest ());
        //     Console.WriteLine ("儿子的答复是:同意");
        // }

        //儿子只处理母亲的请求
        public Son () : base (Handler.SON_LEVEL_REQUEST) { }
        //儿子的答复
        protected override void response (IWomen women) {
            Console.WriteLine ("--------母亲向儿子请示-------");
            Console.WriteLine (women.getRequest ());
            Console.WriteLine ("儿子的答复是：同意\n");
        }
    }
}