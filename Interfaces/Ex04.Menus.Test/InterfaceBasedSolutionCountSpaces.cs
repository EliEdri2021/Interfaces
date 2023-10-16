namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;
    internal class InterfaceBasedSolutionCountSpaces : IMenuItem
    {
        public string GetOptionName()
        {
            return "Count Spaces";
        }

        public void PerformOnCallAction()
        {
            PerformOnCallAction(0);
        }

        public void PerformOnCallAction(int i_Level)
        {
            System.Console.Write("(Level:{0}){1}Please Enter Your Sentence:", i_Level, System.Environment.NewLine);
            string userInput = System.Console.ReadLine();
            
            int result = 0;

            if(userInput != null)
            {
                foreach(char character in userInput)
                {
                    if(character == ' ')
                    {
                        result++;
                    }
                }
            }

            System.Console.WriteLine("There are {0} Spaces in your sentence.{1}", result, System.Environment.NewLine);
            System.Console.ReadLine();
        }
    }
}
