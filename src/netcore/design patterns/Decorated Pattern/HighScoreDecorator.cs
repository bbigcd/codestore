using System;
namespace Decorated_Pattern
{
    public class HighScoreDecorator : Decorator
    {
        //构造函数
        public HighScoreDecorator(SchoolReport sr) : base(sr)
        { }

        //我要汇报最高成绩
        private void reportHighScore()
        {
            Console.WriteLine("这次考试语文最高是75，数学是78，自然是80");
        }

        //我要在老爸看成绩单前告诉他最高成绩，否则等他一看，就抡起扫帚揍我，我哪里还有机会说啊
        public override void report()
        {
            this.reportHighScore();
            base.report();
        }
    }
}