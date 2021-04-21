using System;

namespace myprogram
{
    static class Day2
    {
        enum WEEKDAY:Byte
        {
            SUNDAY = 0,
            MONDAY = 1,
            TUESDAY = 2,
            WINESDAY = 3,
            FOURTHDAY = 4,
            FRIDAY = 5,
            SETURDAY = 6
        }

        enum SEX:Byte {
            female = 0,
            male = 1

        }
        struct Student {
            public string Name;
            public Byte Age;
            public SEX Sex;
            public Byte Id;
        }
        static public void Test()
        {
            int testID = 255;
            switch(testID)
            {
                case 0:
                {
                    Console.WriteLine(WEEKDAY.MONDAY + " is " + (Byte)WEEKDAY.MONDAY);
                }
                break;
                case 1:     ///Struct
                {
                    Student john = new Student();

                    john.Name = "john";
                    john.Age = 12;
                    john.Id = 1;
                    john.Sex = SEX.male;

                    Student mary = new Student();

                    mary.Name = "mary";
                    mary.Age = 11;
                    mary.Id = 2;
                    mary.Sex = SEX.female;

                    Console.WriteLine("學生姓名:" + john.Name + ", 年紀:" + john.Age + ", 學號:" + john.Id + ", 性別:" + john.Sex);
                    Console.WriteLine("學生姓名:" + mary.Name + ", 年紀:" + mary.Age + ", 學號:" + mary.Id + ", 性別:" + mary.Sex);
                }
                break;
                case 2:    ///隨機產生亂數
                {
                    Random rdn = new Random();

                    Console.WriteLine("隨機產生6個1~100數字為:");
                    for(int i=0;i<6;i++)
                    {
                        Console.WriteLine(rdn.Next(1,101));
                    }

                    Console.WriteLine("隨機產生6個1~9的小數為:");
                    for(int i=0;i<6;i++)
                    {
                        Console.WriteLine(rdn.NextDouble()*8 + 1);
                    }

                    Console.WriteLine("隨機產生6個1~9的小數為:");
                    for(int i=0;i<6;i++)
                    {
                        Console.WriteLine((double)rdn.Next(10, 100) / 10.0);
                    }
                }
                break;
                case 3:     ///猜男女
                {
                    string ans = "";
                    string name = "";
                    Random rnd = new Random();
                    int rndVal = 0;
                    Console.Write("請輸入你的名字:");
                    name = Console.ReadLine();
                    rndVal = rnd.Next(0,2);
                    //Console.WriteLine("RndVal = {0}", rndVal);
                    if(rndVal == 0)
                    {
                        Console.Write("{0}我猜你一定是女生,對嗎?(y/n)", name);
                    }
                    else
                    {
                        Console.Write("{0}我猜你一定是男生,對嗎?(y/n)", name);
                    }
                    

                    ans = Console.ReadLine();
                    if( ans == "Y" || ans == "y")
                    {
                        Console.WriteLine("我猜對了,厲害吧");
                    }
                    else if( ans == "N" || ans == "n")
                    {
                        Console.WriteLine("好吧,我猜錯了");
                    }
                    else
                    {
                        Console.WriteLine("都不是,你來亂的嗎?");
                    }
                }
                break;
                case 4:     ///剪刀石頭布
                {
                    int userInput = 0, comp = 0;
                    Random rnd = new Random();
                    Console.WriteLine("猜拳 請輸入你要出的拳 0=剪刀 1=拳頭 2=布");
                    userInput = int.Parse(Console.ReadLine());
                    comp = rnd.Next(0,3);

                    Console.WriteLine("Comp = {0}", comp);
                    if(userInput == 2 && comp == 0)
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        if(userInput > comp)
                        {
                            Console.WriteLine("You win!");
                        }else if(userInput < comp)
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("平手!");
                        }
                    }

                }
                break;
                case 5:     ///輸入三數 取最大最小
                {
                    int a = 0, b = 0, c = 0, max, min;

                    Console.Write("請輸入第一個數字:");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("請輸入第二個數字:");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("請輸入第三個數字:");
                    c = int.Parse(Console.ReadLine());


                    if(a > b)
                    {
                        if(a > c)
                        {
                            max = a;
                            if(b < c)
                            {
                                min = b;
                            }
                            else
                            {
                                min = c;
                            }
                        }
                        else
                        {
                            max = c;
                            if(a < b)
                            {
                                min = a;
                            }
                            else 
                            {
                                min = b;
                            }
                        }
                        
                    }
                    else 
                    {
                        if(b > c)
                        {
                            max = b;
                            if(a < c)
                            {
                                min = a;
                            }
                            else
                            {
                                min = c;
                            }
                        }
                        else
                        {
                            max = c;
                            if(a < b)
                            {
                                min = a;
                            }
                            else
                            {
                                min = c;
                            }
                        }
                    }
                    Console.WriteLine("max = {0}", max);
                    Console.WriteLine("min = {0}", min);
                }
                break;
                case 6:     ///選頻道  P.25
                {
                    int channel;
                    Console.WriteLine("頻道1-中華職棒");
                    Console.WriteLine("頻道2-彩虹頻道");
                    Console.WriteLine("請輸入您想看的頻道︰");
                    channel = int.Parse(Console.ReadLine());
                    switch (channel) 
                    {
                    case 1:
                    Console.WriteLine("中華職棒快打不下去了,看了傷心還是別看吧");
                    break;
                    case 2:
                    Console.WriteLine("彩虹要下雨天打開窗才可能看見喔");
                    break;
                    default:
                    Console.WriteLine("不看就算了");
                    break;
                    }
                }
                break;
                case 7:    ///P.27 這只是為了表示這種狀況的展示,這是Switch在C# 7的特殊用法
                {
                    string switchCase = "HI";

                    switch(switchCase)
                    {
                        ///這個寫法在沒有when 排除特定狀況下幾乎所有情況都會進入,很容易導致跟後面的CASE衝突到,一般來說會被禁止這樣寫
                        case string a when a != "Hi":       ///但當用when 去做條件排除的時候允許這樣寫
                        {
                            Console.WriteLine("string a, a={0}", a);
                        }
                        break;
                        case "Hi":
                        {
                            Console.WriteLine("Case HI");
                        }
                        break;
                        /// 通常這種寫法會被擺在最後面,幾乎是default之前
                        // case string a:
                        // {
                        //     Console.WriteLine("string a, a={0}", a);
                        // }
                        // break;
                        default:
                        {
                            Console.WriteLine("default");
                        }
                        break;
                    }
                }
                break;
                case 8:
                {
                    int iMonth = 0;
                    
                    while(true)
                    {
                        Console.Write("請輸入目前月份:");
                        if(!int.TryParse(Console.ReadLine(), out iMonth))
                        {
                            Console.WriteLine("月份只能是1~12的數字");
                            continue;
                        }
                        switch(iMonth)
                        {
                            case 1:
                            case 2:
                            case 3:
                            Console.WriteLine("{0}月為春季", iMonth);
                            break;
                            case 4:
                            case 5:
                            case 6:
                            Console.WriteLine("{0}月為夏季", iMonth);
                            break;
                            case 7:
                            case 8:
                            case 9:
                            Console.WriteLine("{0}月為秋季", iMonth);
                            break;
                            case 10:
                            case 11:
                            case 12:
                            Console.WriteLine("{0}月為冬季", iMonth);
                            break;
                            default:
                            Console.WriteLine("沒有{0}這個月份", iMonth);
                            break;
                        }
                        if(iMonth > 0 && iMonth < 13)
                        {
                            break;
                        }
                    }
                    

                }
                break;
                case 9:
                {
                    for(int i=0;i<10;i++)
                    {
                        Console.WriteLine("目前跑第{0}圈", i);
                    }
                }
                break;
                case 10:            ///p.39
                {
                    int col = 5, row = 4;

                    for(int i=0;i<col;i++)
                    {
                        for(int j=0;j<row;j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                }
                break;
                case 11:        ///樂透
                {
                    int[] nums = new int[6];
                    int iGets = 0;
                    Random rnd = new Random();
                    bool hasSame = false;


                    for(;iGets < 6;)
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

                    for(int i=0;i<iGets;i++)
                    {
                        Console.WriteLine(nums[i] + " ");
                    }
                }
                break;
                case 12:        ///費氏數列
                {
                    long iNum1 = 1, iNum2 = 1, iNum3 = 0;
                    int iCount = 0;
                    
                    Console.Write("請輸入要的第幾個數字:");
                    while(!int.TryParse(Console.ReadLine(), out iCount))
                    {
                        Console.WriteLine("請輸入有效的數字");
                    }
                    for(int i=2;i<iCount;i++)
                    {
                        iNum3 = iNum1 + iNum2;
                        iNum1=iNum2;
                        iNum2=iNum3; 
                    }

                    Console.WriteLine(iNum3);
                }
                break;
                case 13:        ///印 三角形
                {
                    int iLevel = 0;

                    Console.WriteLine("請輸入要印幾層:");
                    while(!int.TryParse(Console.ReadLine(), out iLevel))
                    {
                        Console.WriteLine("請輸入有效的數字");
                    }

                    for(int i=1; i<=iLevel; i++)
                    {
                        for(int j=1; j<=(iLevel-i); j++)
                        {
                            Console.Write(" ");
                        }
                        for(int j=0; j<i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine("");
                    }
                }
                break;
                case 14:        ///P.35
                {
                    int iNum = 0, iRes = 0;

                    Console.Write("請輸入一個整數X:");

                    while(!int.TryParse(Console.ReadLine(), out iNum))
                    {
                        //Console.WriteLine("");
                        Console.Write("請輸入一個整數X:");
                    }
                    for(int i=1;i<=iNum;i++)
                    {
                        iRes += i%2==0 ? 0 : i;
                    }
                    Console.WriteLine("1~{0}之間所有的奇數和為:{1}", iNum, iRes);
                }
                break;
                case 15:        ///p.40
                {
                    for(int k = 0; k < 9; k+=3)
                    {                    
                        for(int i=1; i<=9; i++)
                        {
                            for(int j=1; j<=3; j++)
                            {
                                Console.Write("{0} * {1} = {2} \t", j+k, i, i*(j+k));
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");
                    }
                }
                break;
                case 16:            ///P42
                {
                    int iNum = 0;

                    //Console.Write("請輸入一個奇數:");

                    do
                    {
                        Console.Write("請輸入一個奇數:");
                        if(!int.TryParse(Console.ReadLine(), out iNum))
                        {
                            continue;
                        }
                    }
                    while(iNum%2 == 0);

                    for(int i=1; i<=iNum; i++)
                    {
                        for(int j=1;j<=iNum; j++)
                        {
                            if(i%2 != 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                if(j%2 != 0)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
                case 17:            ///P45
                {
                    string pwd = "";
                    int iCount = 0;
                    do
                    {
                        pwd = Console.ReadLine();
                        iCount++;
                    }while(pwd != "john" && iCount < 3);
                }
                break;
                case 18:        ///終極密碼
                {
                    int iPwd = 0, iUserGuess = 0, iMin = 0, iMax = 100, iGuessCount = 0;
                    Random rnd = new Random();

                    Console.WriteLine("密碼為1~100的數字, 請猜測");
                    iPwd = rnd.Next(1, 101);

                    Console.WriteLine(iPwd);
                    while(!int.TryParse(Console.ReadLine(), out iUserGuess))
                    {
                        Console.WriteLine("請輸入數字=.=");
                    }
                    
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
                    Console.WriteLine("恭喜你猜了{0}就猜對了", iGuessCount);
                }
                break;
                case 19:        ///1A2B遊戲
                {
                    int[] iNums = new int[4];
                    int[] iUserInput = new int[4];
                    int iSamNum = 0, iSamSpace = 0, iCnt = 0, iGuessCount = 0;
                    bool isSame = false, bChkPass = true;
                    Random rnd = new Random();

                    for(; iCnt<4;)
                    {
                        isSame = false;
                        iNums[iCnt] = rnd.Next(0, 10);
                        for(int j=0; j<iCnt; j++)
                        {
                            if(iNums[iCnt] == iNums[j])
                            {
                                isSame = true;
                                break;
                            }
                        }
                        if(!isSame)
                        {
                            iCnt++;
                        }
                    }
                    Console.WriteLine("Computer List : ");
                    for(int i=0; i<4; i++)
                    {
                        Console.Write("{0}, ", iNums[i]);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("猜數字,請猜四個數字,必須位置與數字都正確才算正確");
                    do
                    {
                        int iTemp = 0;
                        for(int i=0;i<4;)
                        {
                            bChkPass = true;
                            Console.Write("請輸入第{0}個數字:", i+1);
                            string sNum = Console.ReadLine();
                            if(sNum.Length > 1)
                            {
                                Console.WriteLine("必須是一個個位數字!!");
                                bChkPass = false;
                            }
                            if(!int.TryParse(sNum, out iTemp))
                            {
                                Console.WriteLine("必須是一個個位數字!!");
                                bChkPass = false;
                            }
                            for(int j=0;j<i;j++)
                            {
                                if(iTemp == iUserInput[j])
                                {
                                    bChkPass = false;
                                    Console.WriteLine("數字不可重複!!");
                                    break;
                                }
                            }
                            if(bChkPass)
                            {
                                iUserInput[i] = iTemp;
                                i++;
                            }
                        }
                        Console.WriteLine("user List : ");
                        for(int i=0; i<4; i++)
                        {
                            Console.Write("{0}, ", iUserInput[i]);
                        }
                        iGuessCount++;
                        for(int i=0;i<4;i++)
                        {
                            for(int j=0;j<4;j++)
                            {
                                if(iUserInput[i] == iNums[j])
                                {
                                    if(i == j)
                                    {
                                        iSamSpace++;
                                    }
                                    else
                                    {
                                        iSamNum++;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("{0}A, {1}B", iSamSpace, iSamNum);
                        if(iSamSpace != 4)
                        {
                            Console.WriteLine("請繼續猜!!!");
                            iSamSpace = 0;
                            iSamNum = 0;
                        }
                    }while(iSamSpace != 4);
                    Console.WriteLine("恭喜全部正確,共猜了{0}次", iGuessCount);
                }
                break;
                case 20:        ///作業1
                {
                    int iLengtg = 0;

                    Console.Write("請輸入邊長:");
                    while(!int.TryParse(Console.ReadLine(), out iLengtg))
                    {
                        Console.WriteLine("邊長只能是數字");
                        Console.Write("請輸入邊長:");
                    }
                    for(int i = 1; i <= iLengtg ; i++)
                    {
                        for(int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                }
                break;
                case 21:        ///作業2
                {
                    int iHeight = 0, iButton = 0;
                    Console.Write("請輸入高:");
                    while(!int.TryParse(Console.ReadLine(), out iHeight))
                    {
                        Console.WriteLine("高只能是數字");
                        Console.Write("請輸入高:");
                    }
                    Console.Write("請輸入底:");
                    while(!int.TryParse(Console.ReadLine(), out iButton))
                    {
                        Console.WriteLine("底只能是數字");
                        Console.Write("請輸入底:");
                    }

                    for(int i=1; i<=iHeight; i++)
                    {
                        for(int j=1; j<iButton+i; j++)
                        {
                            if(j < i)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        Console.WriteLine("");
                    }
                    for(int i=1; i<=iHeight; i++)
                    {
                        for(int j=1; j<iButton+i; j++)
                        {
                            if(i == 1 || i == iHeight)
                            {
                                if(j < i)
                                {
                                    Console.Write(" ");
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                            else
                            {
                                if(j == i || j == (iButton+i - 1))
                                {
                                    Console.Write("*");
                                    
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            }


            Console.ReadKey();
        }
    }
}