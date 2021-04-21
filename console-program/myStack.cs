using System;

namespace myprogram
{
    public class MyStack
    {
        int iMaxSize = 0;
        int[] iContents;
        int iIndex = 0;

        public MyStack(int iSize)
        {
            if(iSize <= 0)
            {
                throw new ArgumentException("Size 最小必須為1");
            }
            iMaxSize = iSize;
            iContents = new int[iMaxSize];
            iIndex = 0;
        }

        public void push(int iNum)
        {
            if(iIndex < iMaxSize)
            {
                iContents[iIndex] = iNum;
                iIndex++;
            }
            else
            {
                Console.WriteLine("已超出最大容量,無法Push...");
            }
        }

        public int pop()
        {
            int iTmp = default(int);

            if(iIndex > 0)
            {
                iTmp = iContents[iIndex - 1];
                iIndex--;
            }
            else
            {
                Console.WriteLine("堆疊已空,pop失敗...");
            }

            return iTmp;
        }
    }
}