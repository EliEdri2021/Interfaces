namespace Ex04.Menus.Interfaces
{
    public interface IMenuItem
    {
        void PerformOnCallAction();

        void PerformOnCallAction(int i_Level);

        string GetOptionName();
    }
}
