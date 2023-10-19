using System;
using System.Runtime.CompilerServices;
namespace Test1
{
    public class mycoe
    {
        public static void Main()
        {
            while (true)
            {
                Calculator calc = new Calculator();

                string welcome = "Welcome to Calulator app please follow the following Syntax:\r\n";
                string inputex = "1) Add eg. 3 + 3\r\n2) Sub eg. 3 - 3\r\n3) Mul eg. 3 x 3\r\n4) Div eg. 3 / 3\r\n";
                string userinput = "Please Provide your Input:\r\n";

                calc.Display(welcome + inputex + userinput);
                string? calcstr = calc.Input();
                if (calcstr != null && calcstr.Length > 0)
                {
                    string[] vals = calcstr.Split(" ");
                    if (vals.Length == 3)
                    {
                        int opd1 = 0, opd2 = 0;
                        string operation = "";
                        bool flag = true;
                        try
                        {
                            opd1 = Int32.Parse(vals[0]);
                        }
                        catch
                        {
                            flag = false;
                        }
                        try
                        {
                            opd2 = Int32.Parse(vals[2]);
                        }
                        catch
                        {
                            flag = false;
                        }
                        try
                        {
                            operation = vals[1];

                            if (operation.Length == 1)
                            {
                                switch (operation)
                                {
                                    case "+":
                                        calc.Add(opd1, opd2);
                                        break;
                                    case "-":
                                        calc.Sub(opd1, opd2);
                                        break;
                                    case "x":
                                        calc.Mul(opd1, opd2);
                                        break;
                                    case "/":
                                        calc.Div(opd1, opd2);
                                        break;
                                    default:
                                        flag = false;
                                        break;
                                }
                            }
                            else
                                flag = false;
                        }
                        catch
                        {
                            flag = false;
                        }
                        if (!flag)
                            calc.Display("Invalid Input");
                        calc.Display("Press \"any key\" to continue \"e\" to exit");
                        var opt =calc.InputKey();
                        if(opt.Key==ConsoleKey.E)
                        {
                            break;
                        }
                        
                        calc.Clear();
                    }
                    else
                        calc.Display("Invalid Input");
                }
                else
                    calc.Display("Invalid Input");

            }
        }
       
    }
}
 