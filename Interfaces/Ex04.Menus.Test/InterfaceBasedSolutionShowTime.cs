namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    internal class InterfaceBasedSolutionShowTime : IMenuItem
    {
        public string GetOptionName()
        {
            return "Show Time";
        }

        public void PerformOnCallAction()
        {
            this.PerformOnCallAction(0);
        }

        public void PerformOnCallAction(int i_Level)
        {
            System.Console.WriteLine("(Level:{0}){1}{2}{1}Press Return.", i_Level, System.Environment.NewLine, System.DateTime.Now.ToShortTimeString());
            System.Console.ReadLine();
        } 
    }
}
