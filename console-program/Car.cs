using System;

namespace myprogram
{
    public class Car
    {
        private int iId = 0;
        private int iPrice = 0;
        public Car()
        {

        }

        public void SetPrice(int iVal)
        {
            iPrice = iVal;
        }

        public int GetPrice()
        {
            return iPrice;
        }

        public void SetID(int iVal)
        {
            iId = iVal;
        }

        public int GetID()
        {
            return iId;
        }
    }
}