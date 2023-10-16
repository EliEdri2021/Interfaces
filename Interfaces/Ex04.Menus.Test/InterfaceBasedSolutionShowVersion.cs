namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    internal class InterfaceBasedSolutionShowVersion : IMenuItem
    {
        private const string k_Version = "22.3.4.8650";

        public string GetOptionName()
        {
            return "Show Version";
        }

        public void PerformOnCallAction()
        {
            this.PerformOnCallAction(0);
        }

        public void PerformOnCallAction(int i_Level)
        {
            // System.Environment.NewLine
            System.Console.WriteLine("(Level:{0}){1}Version:{2}{1}Press Return.", i_Level, System.Environment.NewLine, k_Version);
            System.Console.ReadLine();
        }
    }
}
