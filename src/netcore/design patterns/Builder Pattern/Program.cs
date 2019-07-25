using System;
using System.Collections.Generic;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              * 客户告诉XX公司，我要这样一个模型，然后XX公司就告诉我老大
              * 说要这样一个模型，这样一个顺序，然后我就来制造
              */
            BenzModel benz = new BenzModel();
            //存放run的顺序
            List<string> sequence = new List<string>();
            sequence.Add("engine boom");  //客户要求，run的时候先发动引擎
            sequence.Add("start");  //启动起来
            sequence.Add("stop");   //开了一段就停下来         
                                    //我们把这个顺序赋予奔驰车
            benz.setSequence(sequence);
            benz.run();

            //要一个奔驰车：
            BenzBuilder benzBuilder = new BenzBuilder();
            //把顺序给这个builder类，制造出这样一个车出来
            benzBuilder.setSequence(sequence);
            //制造出一个奔驰车
            BenzModel benz1 = (BenzModel)benzBuilder.getCarModel();
            //奔驰车跑一下看看
            benz1.run();

            //按照同样的顺序，我再要一个宝马
            BMWBuilder bmwBuilder = new BMWBuilder();
            bmwBuilder.setSequence(sequence);
            BMWModel bmw = (BMWModel)bmwBuilder.getCarModel();
            bmw.run();
        }
    }
}
