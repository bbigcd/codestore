namespace Iterator_Pattern
{
    public interface IProject
    {
        //增加项目
        void add(string name, int num, int cost);
        //从老板这里看到的就是项目信息
        string getProjectInfo();
        //获得一个可以被遍历的对象
        ProjectIterator iterator();
    }
}