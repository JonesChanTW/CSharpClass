using System;

namespace myprogram
{
    public class Basca
    {
        int iMiddle = 0;
        int iMaxValue = 0;
        int iDigital = 0;
        bool bCreateSuccess = false;
        string sTmp = "";
        int[][] iBascaData;

        public Basca()
        {

        }

        public bool CreateBasca(int iLevel)
        {
            if(iLevel < 1)
            {
                Console.WriteLine("階層必須大於1");
            }
            else
            {
                if(bCreateSuccess)
                {
                    Reset();
                }
                ///產生巴斯卡的...數字
                /*
                假設
                i=目前階層數
                j=目前的欄位數
                */
                iMiddle = iLevel;                   ///取三角形中間點

                iBascaData = new int[iLevel][];       ///先產生總共需要的階層數,但各階層所需的一維陣列先不產生
                for(int i = 0; i < iLevel; i++)
                {
                    ///先判斷該階層所需的一維陣列產生了沒
                    if(iBascaData[i] == null)
                    {
                        ///沒有就生一個
                        iBascaData[i] = new int[i+iLevel+3];         ///請參考上方說明的三角形圖形,簡單說 頭一個0 尾 兩個0 為了方便計算
                    }
                    for(int j = 0; j < iBascaData[i].Length; j++)
                    {
                        if(i == 0)
                        {
                            ///第一階
                            iBascaData[i][j] = j == iMiddle ? 1 : 0;
                        }
                        else
                        {
                            ///第二階開始
                            if(j >= (iMiddle - i) && j + 1 < (iBascaData[i - 1].Length))
                            {
                                iBascaData[i][j] = iBascaData[i - 1][j - 1] + iBascaData[i - 1][j + 1];
                            }
                            else
                            {
                                /*
                                兩種狀況
                                1.還沒到開始計算的地方
                                2.超出上一階最大邊界,表示這裡其實已經不用算了,直接給0就好
                                */
                                iBascaData[i][j] = 0;
                            }
                        }
                        iMaxValue = iMaxValue < iBascaData[i][j] ? iBascaData[i][j] : iMaxValue;        ///為了排版方便加入的計算最大位數
                    }
                }
                iDigital = iMaxValue.ToString().Length;         ///取得最大位數有幾位數
                ///製作用來取代原本巴斯卡陣列中的0的字串
                ///有幾個位數就補幾個空白,以此充當 一個看不到的數字
                for(int i = 0; i < iDigital; i++)
                {
                    sTmp += " ";
                }
                bCreateSuccess = true;
            }

            return bCreateSuccess;
        }

        public void ShowBasca()
        {
            if(!bCreateSuccess)
            {
                Console.WriteLine("還沒產生資料...無法顯示!!!");
                return;
            }
            ///開始繪製巴斯卡三角形
            for(int i = 0; i < iBascaData.Length; i++)
            {
                for(int j = 0; j < iBascaData[i].Length; j++)
                {
                    if(iBascaData[i][j] == 0)
                    {
                        Console.Write("{0} ", sTmp);
                    }
                    else
                    {
                        Console.Write("{0} ", iBascaData[i][j].ToString().PadLeft(iDigital, ' ') );
                    }
                }
                Console.WriteLine("");
            }
        }

        public void Reset()
        {
            iBascaData = null;
            iMiddle = 0;
            iMaxValue = 0;
            iDigital = 0;
            bCreateSuccess = false;
            sTmp = "";
        }
    }
}