using System;

namespace MyFullTypeStack
{
    public class MyFullTypeStack<T>
    {
        int iMaxSize = 0;
        int iIndex = 0;
        private T[] oStore;

        public MyFullTypeStack(int iSize)
        {
            if(iSize <= 0)
            {
                throw new ArgumentException("Size 最小必須為1");
            }
            iMaxSize = iSize;
            oStore = new T[iSize];
        }

        public void Push(T value)
        {
            if(iIndex < iMaxSize)
            {
                oStore[iIndex] = value;
                iIndex++;
            }
            else
            {
                Console.WriteLine("Push失敗,堆疊已滿!!");
            }
        }

        public T Pop()
        {
            T tmp = default(T);

            if(iIndex > 0)
            {
                tmp = oStore[iIndex-1];
                iIndex--;
            }
            else
            {
                Console.WriteLine("Pop失敗,堆疊已空");
            }

            return tmp;
        }
    }
}