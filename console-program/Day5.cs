using System;
using System.Text;
using DifferentNamespace;
using TestNameSpace;
using System.Text.RegularExpressions;
using MyMapSpace;

namespace myprogram
{
    static public class Day5
    {
        static public void Test()
        {
            int iTestID = 0;

            switch(iTestID)
            {
                case 1:
                {
                    Car myCar = new Car();

                    myCar.SetID(123);
                    myCar.SetPrice(300);

                    Console.WriteLine("Car ID = {0}", myCar.GetID());
                    Console.WriteLine("Car Price = {0}", myCar.GetPrice());
                }
                break;
                case 2:
                {
                    int iVal = 100;
                    Console.WriteLine($"這次的數字是{iVal, 6}");
                }
                break;
                case 3:
                {
                    OtherNamespaceClass oc = new OtherNamespaceClass();
                    OtherNamespaceClass.OtherClassInOtherClass oc2 = new OtherNamespaceClass.OtherClassInOtherClass();
                }
                break;
                case 4:
                {
                    MyStack ms1 = new MyStack(5);
                    TestNameSpace.MyStack ms2 = new TestNameSpace.MyStack(5);


                    ms1.push(1);
                    ms1.push(2);
                    ms1.push(3);
                    ms1.push(4);
                    ms1.push(5);
                    ms1.push(6);

                    Console.WriteLine("=======這是分隔線,分隔兩個stack的push==========");

                    ms2.push(1);
                    ms2.push(2);
                    ms2.push(3);
                    ms2.push(4);
                    ms2.push(5);
                    ms2.push(6);

                    Console.WriteLine($"{ms1.pop(), 3} ");
                    Console.WriteLine($"{ms1.pop(), 3} ");
                    Console.WriteLine($"{ms1.pop(), 3} ");
                    Console.WriteLine($"{ms1.pop(), 3} ");
                    Console.WriteLine($"{ms1.pop(), 3} ");
                    Console.WriteLine($"{ms1.pop(), 3} ");
                    Console.WriteLine($"{ms1.pop(), 3} ");

                    Console.WriteLine("=======這是分隔線,分隔兩個stack的pop==========");

                    Console.WriteLine($"{ms2.pop(), 3} ");
                    Console.WriteLine($"{ms2.pop(), 3} ");
                    Console.WriteLine($"{ms2.pop(), 3} ");
                    Console.WriteLine($"{ms2.pop(), 3} ");
                    Console.WriteLine($"{ms2.pop(), 3} ");
                    Console.WriteLine($"{ms2.pop(), 3} ");

                }
                break;
                case 5:         ///Regexp
                default:
                {
                    string patton = @"^[A-Z][1,2][0-9]{8}";   ///A到Z開頭 第二個字為1或者2, 0~9出現八個字
                    string patton2 = @"[A-Z][1,2][0-9]{8}";   ///只要有A~Z任一個字後面接1或者2再接0~9八個字
                    string patton3 = @"^[A-Z][1,2][0-9]{8}$";
                    Regex reg = new Regex(patton3, RegexOptions.IgnoreCase);
                    Regex reg2 = new Regex(@"");

                    MyMap<string, string> map = new MyMap<string, string>();

                    
                    string strInput = "";
                    map.AddItem("A","10");
                    map.AddItem("J","18");
                    map.AddItem("S","26");
                    map.AddItem("B","11");
                    map.AddItem("K","19");
                    map.AddItem("T","27");
                    map.AddItem("C","12");
                    map.AddItem("L","20");
                    map.AddItem("U","28");
                    map.AddItem("D","13");
                    map.AddItem("M","21");
                    map.AddItem("V","29");
                    map.AddItem("E","14");
                    map.AddItem("N","22");
                    map.AddItem("W","32");
                    map.AddItem("F","15");
                    map.AddItem("O","35");
                    map.AddItem("X","30");
                    map.AddItem("G","16");
                    map.AddItem("P","23");
                    map.AddItem("Y","31");
                    map.AddItem("H","17");
                    map.AddItem("Q","24");
                    map.AddItem("Z","33");
                    map.AddItem("I","34");
                    map.AddItem("R","25");


                    
                    do
                    {
                        Console.Write("請輸入身分證字號:");
                        strInput = Console.ReadLine();
                        if(strInput == "q")
                        {
                            break;
                        }
                        if(reg.IsMatch(strInput))
                        {
                            int firstVal = 0;
                            

                            strInput = strInput.ToUpper();
                            string strNo = "";

                            map.Find(strInput.Substring(0,1), out strNo);
                            char[] firstChar = strNo.ToCharArray();
                            Array.Reverse(firstChar);

                            firstVal += int.Parse(firstChar[0].ToString()) * 9;
                            firstVal += int.Parse(firstChar[1].ToString());
                            

                            int iSecondVal = 0;
                            int iCnt = 0;
                            int iWeight = 0;
                            char[] secString = strInput.Substring(1).ToCharArray();

                            Array.Reverse(secString);
                            foreach(char c in secString)
                            {
                                iSecondVal += int.Parse(c.ToString()) * (iCnt < 1 ? 1 : iCnt);
                                iCnt++;
                            }
                            iWeight = firstVal + iSecondVal;
                            if(iWeight%10 == 0)
                            {
                                Console.WriteLine("這是正確的身分證字號");
                            }
                            else
                            {
                                Console.WriteLine("這是不正確的身分證字號");
                            }
                        }
                        else
                        {
                            Console.WriteLine("不符合");
                        }
                    }while(true);
                    
                }
                break;
                case 6:
                {
                    int iPwd = 0, iUserGuess = 0, iMin = 0, iMax = 100, iGuessCount = 0;
                    Random rnd = new Random();

                    
                    iPwd = rnd.Next(1, 101);

                    Console.WriteLine(iPwd);
                    while(true)
                    {
                        Console.WriteLine("密碼為1~100的數字, 請猜測");
                        try
                        {
                            iUserGuess = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch(ArgumentNullException ex)
                        {
                            ///沒輸入東西
                            Console.WriteLine($"ArgumentNullException : {ex.ToString()}");
                        }
                        catch(FormatException ex)
                        {
                            ///格是錯誤?應該是指輸入的不是數字吧...
                            Console.WriteLine($"FormatException : {ex.ToString()}");
                        }
                        catch(OverflowException ex)
                        {
                            ///輸入太多東西?
                            Console.WriteLine($"OverflowException : {ex.ToString()}");
                        }
                        catch(Exception ex)
                        {
                            ///其他沒被列入的狀況
                            Console.WriteLine($"Exception : {ex.ToString()}");
                        }
                    }
                    
                    /*
                    while(!int.TryParse(Console.ReadLine(), out iUserGuess))
                    {
                        Console.WriteLine("請輸入數字=.=");
                    }
                    */
                    
                    while(iPwd != iUserGuess)
                    {
                        iGuessCount++;
                        if(iUserGuess < iPwd)
                        {
                            if( iUserGuess > iMin )
                            {
                                iMin = iUserGuess;
                            }
                            else
                            {
                                Console.WriteLine("跟你說範圍是{0}~{1}之間了,請別亂猜", iMin, iMax);
                            }
                            
                        }
                        else
                        {
                            if(iGuessCount < iMax)
                            {
                                iMax = iUserGuess;
                            }
                            else
                            {
                                Console.WriteLine("跟你說範圍是{0}~{1}之間了,請別亂猜", iMin, iMax);
                            }
                        }
                        Console.WriteLine("猜錯,密碼範圍在{0}~{1}請再輸入", iMin, iMax);
                        while(!int.TryParse(Console.ReadLine(), out iUserGuess))
                        {
                            Console.WriteLine("請輸入數字=.=");
                        }
                    }
                }
                break;
            }

            Console.ReadKey();
        }
    }
}