using System;
namespace Singleton_Pattern
{
    public class Emperor
    {
        private static readonly Emperor emperor = new Emperor();

        private Emperor()
        {

        }

        public static Emperor getInstance()
        {
            return emperor;
        }

        public static Emperor Instance
        {
            get { return emperor; }
        }

        public void say(string word = null)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("我就是皇帝某某某...");
            }
            else
            {
                Console.WriteLine(word);
            }
        }
    }
}