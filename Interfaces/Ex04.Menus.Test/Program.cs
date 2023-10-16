namespace Ex04.Menus.Test
{
    using Ex04.Menus.Delegates;
    using Ex04.Menus.Interfaces;

    public class Program
    {
        public static void Main()
        {
            testInterfaceBasedSolution();
            testDelegateBasedSolution();
            System.Console.WriteLine("Press Return.");
            System.Console.ReadLine();
        }

        private static void testInterfaceBasedSolution()
        {
            System.Console.WriteLine("Interface Based Solution Demo:{0}{0}{0}", System.Environment.NewLine);

            NestableMenuInterfaceBased mainWindow = new NestableMenuInterfaceBased("Main");

            NestableMenuInterfaceBased dateOrTime = new NestableMenuInterfaceBased("Show Date/Time");
            NestableMenuInterfaceBased verOrSpace = new NestableMenuInterfaceBased("Version And Spaces");

            mainWindow.AddNewAction(dateOrTime);
            mainWindow.AddNewAction(verOrSpace);

            dateOrTime.AddNewAction(new InterfaceBasedSolutionShowTime());
            dateOrTime.AddNewAction(new InterfaceBasedSolutionShowDate());

            verOrSpace.AddNewAction(new InterfaceBasedSolutionCountSpaces());
            verOrSpace.AddNewAction(new InterfaceBasedSolutionShowVersion());

            mainWindow.PerformOnCallAction();

            System.Console.WriteLine("{0}{0}{0}Interface Based Solution Demo Finished.{0}{0}{0}", System.Environment.NewLine);
        }

        private static void testDelegateBasedSolution()
        {
            System.Console.WriteLine("Delegate Based Solution Demo:{0}{0}{0}", System.Environment.NewLine);

            NestableMenuDelegateBased mainWindow = new NestableMenuDelegateBased("Main");

            NestableMenuDelegateBased dateOrTime = new NestableMenuDelegateBased("Show Date/Time");
            NestableMenuDelegateBased verOrSpace = new NestableMenuDelegateBased("Version And Spaces");

            mainWindow.AddNewAction("Show Date Or Time", dateOrTime.PerformOnCallAction);
            mainWindow.AddNewAction("Show Version Or Space", verOrSpace.PerformOnCallAction);

            dateOrTime.AddNewAction("Show Time", DelegateBasedSolutionActionImplementations.ShowTime);
            dateOrTime.AddNewAction("Show Date", DelegateBasedSolutionActionImplementations.ShowDate);

            verOrSpace.AddNewAction("Count Spaces", DelegateBasedSolutionActionImplementations.CountSpaces);
            verOrSpace.AddNewAction("Show Version", DelegateBasedSolutionActionImplementations.ShowVersion);

            mainWindow.PerformOnCallAction();

            System.Console.WriteLine("{0}{0}{0}Delegate Based Solution Demo Finished.{0}{0}{0}", System.Environment.NewLine);
        }
    }
}
