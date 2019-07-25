using System.Collections.Generic;
using System;
using System.Collections;

namespace Builder_Pattern
{
    public abstract class CarModel
    {
        //这个参数是各个基本方法执行的顺序
        private List<string> sequence = new List<string>();
        //模型是启动开始跑了
        protected abstract void start();
        //能发动，还要能停下来，那才是真本事
        protected abstract void stop();
        //喇叭会出声音，是滴滴叫，还是哔哔叫
        protected abstract void alarm();
        //引擎会轰隆隆地响，不响那是假的
        protected abstract void engineBoom();
        //那模型应该会跑吧，别管是人推的，还是电力驱动，总之要会跑
        public void run()
        {
            //循环一边，谁在前，就先执行谁
            for (int i = 0; i < this.sequence.Count; i++)
            {
                string actionName = this.sequence[i].ToString();
                if (actionName.Equals("start", StringComparison.OrdinalIgnoreCase))
                {
                    this.start();  //启动汽车
                }
                else if (actionName.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    this.stop(); //停止汽车   
                }
                else if (actionName.Equals("alarm", StringComparison.OrdinalIgnoreCase))
                {
                    this.alarm(); //喇叭开始叫了
                }
                else if (actionName.Equals("engine boom", StringComparison.OrdinalIgnoreCase))
                {
                    //如果是engine boom关键字
                    this.engineBoom();  //引擎开始轰鸣
                }
            }
        }
        //把传递过来的值传递到类内
        public void setSequence(List<string> sequence)
        {
            this.sequence = sequence;
        }
    }
}