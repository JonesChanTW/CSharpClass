using System;

namespace myprogram
{
    static class Day1
    {
        static public void test()
        {
            Byte testID = 14;
            // Console.WriteLine("請選擇執行項目");
            // Console.WriteLine("0. P13 Test");
            // Console.WriteLine("1. 自己的輸入測試");
            // Console.WriteLine("2. P26");
            // Console.WriteLine("3. P15");
            // Console.WriteLine("4. P27");
            // Console.WriteLine("5. P32 ");

            switch(testID)
            {
                case 0:
                {
                    Console.WriteLine("{0},和{1}出遊\n{0}帶了餅乾\n{1}帶了飲料","王小明","陳小英");
                    Console.WriteLine("Hello World!13123");
                }
                break;
                case 1:
                {
                    int num1 = 0;
                    string var2 = "";
                    Console.WriteLine("What is your name?");
                    Console.WriteLine(Console.ReadLine()+"你好");

                    Console.WriteLine("輸入測試 ReadLine()");
                    var2 = Console.ReadLine();
                    Console.WriteLine("你輸入了: "+ var2);

                    Console.WriteLine("輸入測試 ReadKey()");
                    Console.WriteLine("你輸入了: "+Console.ReadKey());

                    Console.WriteLine("輸入測試 Read()");
                    num1 = Console.Read();
                    Console.WriteLine("你輸入了: "+ num1);
                }
                break;
                case 2:
                {
                    Console.WriteLine("請輸入身高:");
                    Console.WriteLine("您有{0}公分高呢"+Console.ReadLine());
                    Console.ReadKey();
                }
                break;
                case 3:
                {
                    string name = "";
                    Console.Write("請輸入姓名:");
                    name = Console.ReadLine();
                    Console.WriteLine("{0}您好!!", name);
                }
                break;
                case 4:     //P27
                {
                    string name = "";
                    string sex = "";
                    Console.Write("請輸入姓名:");
                    name = Console.ReadLine();
                    Console.Write("請輸入性別:");
                    sex = Console.ReadLine();
                    Console.WriteLine("{0}您好!!\n我猜{0}您一定是{1}", name, sex);
                }
                break;
                case 5: ///P32
                {
                    string name = "";
                    int height = 0;

                    Console.Write("請輸入姓名:");
                    name = Console.ReadLine();
                    Console.Write("請輸入身高:");
                    height = Convert.ToInt32( Console.ReadLine() );
                    Console.WriteLine("{0}您有{1}公分高呢!!", name, height);
                }
                break;
                case 6:     ///P33
                {
                    string name = "";
                    string pNumber = "";
                    Byte year, month, day = 0;

                    Console.Write("請輸入姓名:");
                    name = Console.ReadLine();
                    Console.Write("請輸入電話:");
                    pNumber = Console.ReadLine();
                    Console.Write("請輸入出生民國年:");
                    year = Byte.Parse(Console.ReadLine());
                    Console.Write("請輸入出生的月份:");
                    month = Byte.Parse(Console.ReadLine());
                    Console.Write("請輸入出生的日期:");
                    day = Byte.Parse(Console.ReadLine());

                    Console.WriteLine("{0}你{1}{2}{3}出生，電話號碼為{4}", name, year, month.ToString().PadLeft(2, '0'), day.ToString().PadLeft(2, '0'), pNumber);

                }
                break;
                case 7:
                {
                    double d=23.14;
                    double i=d;
                    int i2=123;
                    int s=i2;
                    string s2="12345";
                    string i3=s2;
                    long L=12345;
                    long b=L;
                }
                break;
                case 8:
                {
                    double height = 0;
                    double weight = 0;

                    Console.WriteLine("BMI計算");
                    Console.Write("請輸入身高:");
                    height = Convert.ToDouble( Console.ReadLine())/100;

                    Console.Write("請輸入體重:");
                    weight = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("BMI值為:{0}", weight/(height*height));
                }
                break;
                case 9:     ///p44
                {
                    int num1 = 0, num2 = 0;
                    Console.Write("請依序輸入第一個整數a:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("請依序輸入第二個整數b:");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("a+b={0}", num1+num2);
                    Console.WriteLine("a-b={0}", num1-num2);
                    Console.WriteLine("a*b={0}", num1*num2);
                    Console.WriteLine("a/b={0}", (double)num1/(double)num2);
                }
                break;
                case 10:
                {
                    Byte num = 0;
                    int numa = 300;

                    num = (Byte)numa;
                    Console.WriteLine("結果為{0}", num);
                }
                break;
                case 11:        ///P47
                {
                    Byte char1 = 0, char2 = 0;
                    Console.Write("請輸入第一個字元:");
                    char1 = (Byte)Console.Read();
                    Console.ReadLine();         ///這只是為了把Read()沒吃完的給吃完,至於吃到甚麼不重要,反正都要丟掉
                    Console.Write("請輸入第二個字元:");
                    char2 = (Byte)Console.Read();

                    Console.WriteLine("{0}", char1 > char2);
                }
                break;
                case 12:        ///P49
                {
                    Console.WriteLine("{0}",((3>2) && (2>1)) && (1>2));
                    Console.WriteLine("{0}",(4>3) || ('a'=='b'));
                    Console.WriteLine("{0}",! ((4<3)||(5>1)));
                    
                }
                break;
                case 13:
                {
                    int length = 0;

                    Console.Write("請輸入正方形一邊的邊長:");
                    length = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("正方形面積為:{0}", (length *= length));
                }
                break;
                case 14:            //P54
                {
                    int num1 = 0, num2 = 0;
                    int a = 0, b = 0;
                    Console.Write("請輸入整數a:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("請輸入整數b:");
                    num2 = int.Parse(Console.ReadLine());

                    
                    for(int i=0;i<7;i++)
                    {
                        a = num1;
                        b = num2;
                        Console.WriteLine("a+=b++後的a為?");
                        a += b++;
                        Console.WriteLine(a == int.Parse(Console.ReadLine()));
                    }
                    
                    
                }
                break;
                case 100:
                {
                    int num1 = 0, num2 = 0, num3 = 0;
                    int max = 0, min = 0;
                    Console.Write("請輸入第一個數字");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("請輸入第二個數字");
                    num2 = int.Parse(Console.ReadLine());
                    Console.Write("請輸入第三個數字");
                    num3 = int.Parse(Console.ReadLine());

                    //max = (num1 > num2 ? num1 : num2) > num3 ? (num1 > num2 ? num1 : num2) : num3;

                    max = ( num1 > num2 ? ( num1 > num3 ? num1:num3): ( num2 > num3 ? num2:num3) );

                    //max = num1 > num2 ? num1 : num2;
                    //max = max > num3 ? max : num3;

                    //min = (num1 < num2 ? num1 : num2) < num3 ? (num1 < num2 ? num1 : num2) : num3;
                    min = ( num1 < num2 ? ( num1 < num3 ? num1:num3): ( num2 < num3 ? num2:num3) );

                    //min = num1 < num2 ? num1 : num2;
                    //min = min < num3 ? min : num3;

                    Console.WriteLine("最大值為{0}, 最小值為{1}", max, min);
                }
                break;
                default:
                {
                    Console.WriteLine("Result = {0}", 5/3*3);
                }
                break;
            }

            Console.ReadKey();
        }
    }
}