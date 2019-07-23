namespace Abstract_Factory_Pattern
{
    public interface IHuman
    {
        //每个人种都有相应的颜色
        void getColor();
        //人类会说话
        void talk();
        //每个人都有性别
        void getSex();
    }
}