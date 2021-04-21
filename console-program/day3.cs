using System;
using MyFullTypeStack;

namespace myprogram
{
    static class Day3
    {
        const int MAX_NUMS = 6;

        static public void GetRandomNumNotSame(int iGetCount, out int[] iNums)
        {
            int[] nums = new int[iGetCount];
            int iGets = 0;
            Random rnd = new Random();
            bool hasSame = false;


            for(;iGets < iGetCount;)
            {
                hasSame = false;
                nums[iGets] = rnd.Next(1, 50);
                for(int i=0;i<iGets;i++)
                {
                    if(nums[i] == nums[iGets])
                    {
                        hasSame = true;
                        break;
                    }
                }
                if(!hasSame)
                {
                    iGets++;
                }
            }

            iNums = nums;
        }

        static private void ShowLottle()
        {
            int[] iNums = new int[MAX_NUMS];

            GetRandomNumNotSame(MAX_NUMS, out iNums);

            for(int i = 0; i < MAX_NUMS; i++)
            {
                if(i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write("{0}", iNums[i]);
            }
        }

        static private void CaculeAvgScore()
        {
            int[] iScores = new int[5];
            float fAvg = 0;

            int i = 0;
            do
            {    
                Console.Write("請輸入第{0}個學生的成績:", i+1);
                while(!int.TryParse(Console.ReadLine(), out iScores[i]))
                {
                    Console.WriteLine("成績必須數數字!!");
                    Console.Write("請輸入第{0}個學生的成績:", i+1);
                }
                fAvg += iScores[i];
                i++;
            }while( i < 5);
            fAvg /= 5;

            Console.WriteLine("學生平均成績為:{0}", fAvg);
        }

        /// in int a 這裡的參數a 在這個Function中相當於是唯讀的存在,無法被寫值
        static private void FuncInTest(in int a)
        {
            int i = a;
        }

        ///巴斯卡三角形
        /*
        輸入層數 產生巴斯卡三角形 例如輸入5 則產生如下圖
                    1
                   1 1
                  1 2 1
                 1 3 3 1
                1 4 6 4 1
        */
        static void CreateBasca()
        {
            int iLevel = 0;
            int iStart = 0;
            int iMaxValue = 0;

            Console.Write("請輸入大於1的階層數已產生巴斯卡三角形:");

            //為了防止程式當掉,為了確保執行順利,所以以下檢查是必要的
            do
            {
                while(!int.TryParse(Console.ReadLine(), out iLevel))
                {
                    Console.WriteLine("輸入的必須是數字");
                    Console.Write("請輸入階層數:");
                }
                if(iLevel > 1)
                {
                    break;
                }
                else
                {
                    Console.Write("階層數必須大於1,請再次輸入:");
                }
            }while(true);

            
            
            ///產生巴斯卡三角形的...數字
            /*
            這裡的做法是每個階層的一維陣列都是處理到該階層時才去依照該階層所需長度產生
            因此每個階層的一維陣列長度都不同
            
            假設
            i=目前階層數
            j=目前的欄位數
            */
            int[][] iRes = new int[iLevel][];       ///先產生總共需要的階層數,但各階層所需的一維陣列先不產生
            for(int i = 0; i < iLevel; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    ///先判斷該階層所需的一維陣列產生了沒
                    if(iRes[i] == null)
                    {
                        ///沒有就生一個
                        iRes[i] = new int[i+1];
                    }
                    if(i < 1)
                    {
                        iRes[i][j] = 1;         ///這是 {0,0}的情況
                    }
                    else
                    {
                        if(j == 0 || j == i)
                        {
                            ///判斷每個階層的左/右邊界 左:0+1 右:1+0 所以左右都為1 乾脆直接寫了XD
                            iRes[i][j] = 1;
                        }
                        else
                        {
                            ///如果不適邊界 就老實的計算吧...
                            iRes[i][j] = iRes[i-1][j-1] + iRes[i-1][j];
                        }
                    }
                    
                    iMaxValue = iMaxValue < iRes[i][j] ? iRes[i][j] : iMaxValue;        ///為了排版方便加入的計算最大位數
                }
            }

            ///輸出巴斯卡
            iStart = iLevel;
            int iDigital = iMaxValue.ToString().Length;         ///取得最大位數有幾位數
            string sTmp = "";

            ///有幾個位數就補幾個空白,以此充當 一個看不到的數字
            for(int i = 0; i < iDigital; i++)
            {
                sTmp += " ";
            }
            
            for(int i = 0; i < iLevel; i++)
            {
                int iSpace = 0;
                for(int j = 0, iCnt = 0; j < iRes[i].Length; iCnt++)
                {
                    if(iCnt < (iStart - i))
                    {
                        Console.Write("{0} ", sTmp);
                    }
                    else
                    {
                        if(iSpace % 2 == 0)
                        {
                            Console.Write("{0} ", iRes[i][j].ToString().PadLeft(iDigital, ' '));
                            j++;
                        }
                        else
                        {
                            Console.Write("{0} ", sTmp);
                        }
                        iSpace++;
                    }
                }
                Console.WriteLine("");
            }
        }

        /*
        新想法巴斯卡三角形
        					1					
                        1	0	1				
                    1	0	2	0	1			
                1	0	3	0	3	0	1		
            1	0	4	0	6	0	4	0	1	
        1	0	5	0	10	0	10	0	5	0	1
        每個階層所需的欄數為 n*2-1
        以上圖最大階層為6 則最大欄數為 6*2-1 = 11
        (11 - 1) / 2 = 5 此為本三角形最中間的位置
        為了方便計算轉變為下圖
        0   0	0	0	0	0	1	0	0				
        0   0   0   0   0	1	0	1	0	0			
        0   0   0   0	1	0	2	0	1	0	0		
        0   0   0	1	0	3	0	3	0	1	0	0	
        0   0	1	0	4	0	6	0	4	0	1	0	0
        0	1	0	5	0	10	0	10	0	5	0	1	0   0
        得在頭尾補上0以方便計算,因此得到每階所需的欄位數公式為
        每個階層所需的欄數為 n*2+1
        可得 m列n欄 計算公式為 {m,n} = {(m-1),(n-1)}+{(m+1),(n+1)}
        */
        static void CreateBasca2()
        {
            int iLevel = 0, iMiddle = 0, iMaxValue = 0;


            Console.Write("請輸入大於1的階層數已產生巴斯卡三角形:");

            //為了防止程式當掉,為了確保執行順利,所以以下檢查是必要的
            do
            {
                while(!int.TryParse(Console.ReadLine(), out iLevel))
                {
                    Console.WriteLine("輸入的必須是數字");
                    Console.Write("請輸入階層數:");
                }
                if(iLevel > 1)
                {
                    break;
                }
                else
                {
                    Console.Write("階層數必須大於1,請再次輸入:");
                }
            }while(true);

            ///產生巴斯卡的...數字
            /*
            假設
            i=目前階層數
            j=目前的欄位數
            */
            iMiddle = iLevel;                   ///取三角形中間點
            int[][] iRes = new int[iLevel][];       ///先產生總共需要的階層數,但各階層所需的一維陣列先不產生
            for(int i = 0; i < iLevel; i++)
            {
                ///先判斷該階層所需的一維陣列產生了沒
                if(iRes[i] == null)
                {
                    ///沒有就生一個
                    iRes[i] = new int[i+iLevel+3];         ///請參考上方說明的三角形圖形,簡單說 頭一個0 尾 兩個0 為了方便計算
                }
                for(int j = 0; j < iRes[i].Length; j++)
                {
                    if(i == 0)
                    {
                        ///第一階
                        iRes[i][j] = j == iMiddle ? 1 : 0;
                    }
                    else
                    {
                        ///第二階開始
                        if(j >= (iMiddle - i) && j + 1 < (iRes[i - 1].Length))
                        {
                            iRes[i][j] = iRes[i - 1][j - 1] + iRes[i - 1][j + 1];
                        }
                        else
                        {
                            /*
                            兩種狀況
                            1.還沒到開始計算的地方
                            2.超出上一階最大邊界,表示這裡其實已經不用算了,直接給0就好
                            */
                            iRes[i][j] = 0;
                        }
                    }
                    iMaxValue = iMaxValue < iRes[i][j] ? iRes[i][j] : iMaxValue;        ///為了排版方便加入的計算最大位數
                }
            }
            
            ///接著輸出畫面
            int iDigital = iMaxValue.ToString().Length;         ///取得最大位數有幾位數
            string sTmp = "";

            ///製作用來取代原本巴斯卡陣列中的0的字串
            ///有幾個位數就補幾個空白,以此充當 一個看不到的數字
            for(int i = 0; i < iDigital; i++)
            {
                sTmp += " ";
            }

            ///開始繪製巴斯卡三角形
            for(int i = 0; i < iRes.Length; i++)
            {
                for(int j = 0; j < iRes[i].Length; j++)
                {
                    if(iRes[i][j] == 0)
                    {
                        Console.Write("{0} ", sTmp);
                    }
                    else
                    {
                        Console.Write("{0} ", iRes[i][j].ToString().PadLeft(iDigital, ' ') );
                    }
                }
                Console.WriteLine("");
            }
        }

        ///進制轉換,輸入一個數字, 以及要被轉成的進制 輸出結果,陣列版本
        static void BaseConvert(int iNum, int iBase)
        {
            int[] iResult = new int[3];
            int iCurrentMaxNums = 3, iCount = 0;
            int iRemainder = 0;
            
            do
            {
                iRemainder = iNum % iBase;
                iNum = iNum / iBase;
                iResult[iCount] = iRemainder;
                iCount++;
                if(iCurrentMaxNums <=  iCount)
                {
                    iCurrentMaxNums *= 2;
                    Array.Resize<int>(ref iResult, iCurrentMaxNums);
                }
            }while(iRemainder < iNum );
            iResult[iCount] = iNum;
            iCount++;

            Array.Reverse(iResult);

            for(int i = 0; i < iCount; i++)
            {
                Console.Write("{0} ", iResult[i]);
            }
        }

        static public void Test()
        {
            int testID = 255;


            switch(testID)
            {
                case 0:
                {
                    ShowLottle();
                }
                break;
                case 1:
                {
                    CaculeAvgScore();
                }
                break;
                case 2:
                {
                    int iInput = 0;
                    int iBase = 0;
                    //Array iResult = Array.CreateInstance(Type.)

                    Console.Write("請輸入一個數字:");
                    while(!int.TryParse(Console.ReadLine(), out iInput))
                    {
                        Console.WriteLine("輸入的必須是數字");
                        Console.Write("請輸入一個數字:");
                    }

                    Console.Write("請輸入要轉換進制,目前僅支援10進制以下");
                    while(true)
                    {
                        while(!int.TryParse(Console.ReadLine(), out iBase))
                        {
                            Console.WriteLine("輸入的必須是數字");
                            Console.Write("請輸入要轉換進制,目前僅支援10進制以下");
                        }
                        if(iBase > 0 && iBase < 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("請輸入要轉換進制,目前僅支援10進制以下");
                        }
                    }
                    BaseConvert(iInput, iBase);
                }
                break;
                case 3:
                {
                    CreateBasca();
                }
                break;
                case 4:
                {
                    Rocket r1 = new Rocket(100);
                    Rocket r2 = new Rocket(200);

                    Console.WriteLine(r1.getSpeed());
                    Console.WriteLine(r2.getSpeed());
                }
                break;
                case 5:
                {
                    MyStack mStck = new MyStack(5);

                    mStck.push(1);
                    mStck.push(2);
                    mStck.push(3);
                    mStck.push(4);
                    mStck.push(5);
                    mStck.push(6);


                    Console.WriteLine(mStck.pop());
                    Console.WriteLine(mStck.pop());
                    Console.WriteLine(mStck.pop());
                    Console.WriteLine(mStck.pop());
                    Console.WriteLine(mStck.pop());
                    Console.WriteLine(mStck.pop());
                    Console.WriteLine(mStck.pop());
                }
                break;
                case 6:     ///巴斯卡三角形 V2
                {
                    CreateBasca2();
                }
                break;
                case 7:         ///foreach test
                {
                    int[] iNums = new int[10];
                    Random rnd = new Random();

                    for(int i = 0; i < 10; i++)
                    {
                        iNums[i] = rnd.Next(0, 100);
                    }

                    foreach(int iVal in iNums)
                    {
                        Console.Write("{0}, ", iVal);
                    }
                }
                break;
                case 8:
                {
                    MyFullTypeStack<int> myNumStack = new MyFullTypeStack<int>(5);
                    MyFullTypeStack<string> myStringStack = new MyFullTypeStack<string>(5);

                    myNumStack.Push(1);
                    myNumStack.Push(2);
                    myNumStack.Push(3);
                    myNumStack.Push(4);
                    myNumStack.Push(5);
                    myNumStack.Push(6);

                    Console.WriteLine("{0}", myNumStack.Pop());
                    Console.WriteLine("{0}", myNumStack.Pop());
                    Console.WriteLine("{0}", myNumStack.Pop());
                    Console.WriteLine("{0}", myNumStack.Pop());
                    Console.WriteLine("{0}", myNumStack.Pop());
                    Console.WriteLine("{0}", myNumStack.Pop());

                    Console.WriteLine("=========改測試字串版本===============");
                    myStringStack.Push("a");
                    myStringStack.Push("b");
                    myStringStack.Push("c");
                    myStringStack.Push("d");
                    myStringStack.Push("e");
                    myStringStack.Push("f");
                    myStringStack.Push("g");
                    myStringStack.Push("h");

                    Console.WriteLine("{0}", myStringStack.Pop());
                    Console.WriteLine("{0}", myStringStack.Pop());
                    Console.WriteLine("{0}", myStringStack.Pop());
                    Console.WriteLine("{0}", myStringStack.Pop());
                    Console.WriteLine("{0}", myStringStack.Pop());
                    Console.WriteLine("{0}", myStringStack.Pop());
                }
                break;
                case 9:
                default:
                {
                    Basca ba = new Basca();

                    ba.CreateBasca(5);
                    ba.ShowBasca();
                }
                break;
            }

            Console.ReadKey();
        }

        class Rocket
        {
            private int iSpeed = 0;

            public Rocket(int speed)
            {
                iSpeed = speed;
            }

            public int getSpeed()
            {
                return iSpeed;
            }
        }
        
    }
}