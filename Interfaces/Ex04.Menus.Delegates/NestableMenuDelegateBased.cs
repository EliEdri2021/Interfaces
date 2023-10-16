using System.Collections.Generic;
using System.Linq;

namespace Ex04.Menus.Delegates
{
    public class NestableMenuDelegateBased
    {
        private readonly string r_ItemName;

        private readonly Dictionary<string, System.Action<int>> r_MenuOptionsActions;

        private readonly string[] r_ReturnToPreviousLevel = { "Back", "Exit", "0" };

        public NestableMenuDelegateBased(string i_ItemName)
        {
            this.r_ItemName = i_ItemName;
            this.r_MenuOptionsActions = new Dictionary<string, System.Action<int>>();
        }

        public string GetOptionName()
        {
            return this.r_ItemName;
        }

        public void PerformOnCallAction()
        {
            PerformOnCallAction(0);
        }

        public void PerformOnCallAction(int i_Level)
        {
            bool isFinished = false;

            while (!isFinished)
            {
                System.Console.WriteLine("(Level:{0}) {1}{2}==========================", i_Level, this.GetOptionName(), System.Environment.NewLine);

                int index = 1;

                foreach (string menuItemKey in this.r_MenuOptionsActions.Keys)
                {
                    System.Console.WriteLine("{0}. {1}", index, menuItemKey);
                    index += 1;

                }
                System.Console.WriteLine("0. {0}", getBackOrExitOptionName(i_Level));

                int chosenAction = this.getIntegerInputValue(1, this.r_MenuOptionsActions.Count);

                if (chosenAction >= 1)
                {
                    System.Console.Clear();
                    this.r_MenuOptionsActions.Values.ToArray()[chosenAction - 1].Invoke(i_Level + 1);
                }
                else
                {
                    isFinished = true;
                }

                System.Console.Clear();
            }
        }


        public void AddNewAction(string i_MenuActionToAdd, System.Action<int> i_NewMenuItemToAdd)
        {
            this.r_MenuOptionsActions.Add(i_MenuActionToAdd, i_NewMenuItemToAdd);
        }

        private int getIntegerInputValue(int i_Minimum, int i_Maximum)
        {
            System.Console.Write("Enter Your Request: ");
            int? resultingIntegerValue = null;

            while (!resultingIntegerValue.HasValue)                                                         // Repeat Until Assignment, assignment doubles as a flag for success.
            {
                string userInputStr = System.Console.ReadLine();

                if (r_ReturnToPreviousLevel.Contains(userInputStr))                                                         // If specially designated value was selected,
                {
                    resultingIntegerValue = -1;                                                                                 // Will return an appropriate value
                }
                else
                {                                                                                                      // If the input is expected to be a parse-able integer value,

                    bool parseSuccess = int.TryParse(userInputStr, out int tempResultingIntegerValue);                          // Will check if it is, in-fact, parse-able.

                    if (parseSuccess)                                                                                       // If input can be parsed, 
                    {
                        bool inRangeSuccess = tempResultingIntegerValue >= i_Minimum && tempResultingIntegerValue <= i_Maximum; // Will Verify in-range conditions.

                        if (inRangeSuccess)                                                                                  // If All checks have passed successfully,
                        {
                            resultingIntegerValue = tempResultingIntegerValue;                                                  // will assign it to result value.
                        }
                        else                                                                                                // If input was invalid due to a range issue, 
                        {
                            System.Console.Write("Your Input was Out Of Range {0} trough {1}.",                                 // will notify the user of the issue.
                                i_Minimum, System.Math.Max(i_Minimum, i_Maximum));
                        }
                    }
                    else                                                                                                    // If input was invalid due to a passing issue
                    {
                        System.Console.Write("{0}Your Input Was Not A Single Integer Digit.", System.Environment.NewLine);      // will notify user of the issue.
                    }
                }
            }

            return resultingIntegerValue.GetValueOrDefault();
        }

        private static string getBackOrExitOptionName(int i_Level)
        {
            return i_Level == 0 ? "Exit" : "Back";
        }

    }
}
