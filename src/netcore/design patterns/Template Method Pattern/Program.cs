using System;

namespace Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // XX公司要H1型号的悍马
            HummerH1Model h1 = new HummerH1Model();

            // H1 的模型显示
            h1.run();
        }
    }
}
