namespace Ex04.Menus.Test
{
    internal class DelegateBasedSolutionActionImplementations
    {
        private const string k_Version = "22.3.4.8650";

        public static void ShowVersion(int i_Level)
        {
            System.Console.WriteLine("(Level:{0}){1}Version:{2}{1}Press Return.", i_Level, System.Environment.NewLine, k_Version);
            System.Console.ReadLine();
        }

        public static void ShowDate(int i_Level)
        {
            System.Console.WriteLine("(Level:{0}){1}{2}", i_Level, System.Environment.NewLine, System.DateTime.Now.ToShortDateString());
            System.Console.ReadLine();
        }

        public static void ShowTime(int i_Level)
        {
            System.Console.WriteLine("(Level:{0}){1}{2}{1}Press Return.", i_Level, System.Environment.NewLine, System.DateTime.Now.ToShortTimeString());
            System.Console.ReadLine();
        }

        public static void CountSpaces(int i_Level)
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
