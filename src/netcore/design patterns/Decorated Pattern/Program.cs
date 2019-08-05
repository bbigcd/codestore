using System;

namespace Decorated_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // //把成绩单拿过来
            // SchoolReport sr = new FouthGradeSchoolReport();
            // //看成绩单
            // sr.report();
            // //签名？休想！

            // //把美化过的成绩单拿过来
            // SchoolReport sr2 = new SugarFouthGradeSchoolReport();
            // //看成绩单
            // sr2.report();
            // //然后老爸，一看，很开心，就签名了
            // sr2.sign("老三");  //我叫小三，老爸当然叫老三

            //把成绩单拿过来
            SchoolReport sr;
            //原装的成绩单
            sr = new FouthGradeSchoolReport();
            //加了最高分说明的成绩单
            sr = new HighScoreDecorator(sr);
            //又加了成绩排名的说明
            sr = new SortDecorator(sr);
            //看成绩单
            sr.report();
            //然后老爸一看，很开心，就签名了
            sr.sign("老三");  //我叫小三，老爸当然叫老三
        }
    }
}
