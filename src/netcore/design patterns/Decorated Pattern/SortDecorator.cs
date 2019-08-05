using System;
namespace Decorated_Pattern
{
    public class SortDecorator : Decorator
    {
        public SortDecorator(SchoolReport sr) : base(sr)
        {
        }

        //告诉老爸学校的排名情况
        private void reportSort()
        {
            Console.WriteLine("我是排名第38名...");
        }

        //老爸看完成绩单后再告诉他，加强作用
        public override void report()
        {
            base.report();
            this.reportSort();
        }

    }
}