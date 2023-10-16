namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;
 
    internal class InterfaceBasedSolutionShowDate: IMenuItem
    {
        public string GetOptionName()
        {
            return "Show Date";
        }

        public void PerformOnCallAction()
        {
            PerformOnCallAction(0);
        }


        public void PerformOnCallAction(int i_Level)
        {
            System.Console.WriteLine("(Level:{0}){1}{2}", i_Level, System.Environment.NewLine, System.DateTime.Now.ToShortDateString());
            System.Console.ReadLine();
        }
    }
}
