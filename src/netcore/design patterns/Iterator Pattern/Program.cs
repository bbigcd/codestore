using System;
using System.Collections.Generic;

namespace Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个List，存放所有的项目对象
            IProject project = new Project();
            //增加星球大战项目
            project.add("星球大战项目ddddd", 10, 100000);
            //增加扭转时空项目
            project.add("扭转时空项目", 100, 10000000);
            //增加超人改造项目
            project.add("超人改造项目", 10000, 1000000000);
            //这边100个项目
            for (int i = 4; i < 104; i++)
            {
                project.add("第" + i + "个项目", 5, 1000000);
            }
            //遍历一下ArrayList，把所有的数据都取出
            var projectIterator = project.iterator().GetEnumerator();
            while (true)
            {
                Boolean result = projectIterator.MoveNext();
                if (!result)
                {
                    break;
                }
                Console.WriteLine(((IProject)projectIterator.Current).getProjectInfo());
            }
        }
    }
}
