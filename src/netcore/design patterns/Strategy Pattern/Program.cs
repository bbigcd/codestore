using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            //刚刚到吴国的时候拆第一个
            Console.WriteLine("---刚刚到吴国的时候拆第一个---");
            context = new Context(new BackDoor()); //拿到妙计
            context.operate();  //拆开执行
            //刘备乐不思蜀了，拆第二个了
            Console.WriteLine("---刘备乐不思蜀了，拆第二个了---");
            context = new Context(new GivenGreenLight());
            context.operate();  //执行了第二个锦囊
            //孙权的小兵追来了，咋办？拆第三个
            Console.WriteLine("---孙权的小兵追来了，咋办？拆第三个---");
            context = new Context(new BlockEnemy());
            context.operate();  //孙夫人退兵
        }
    }
}
