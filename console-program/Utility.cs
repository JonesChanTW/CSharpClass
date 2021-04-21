using System;

namespace Utility
{
    class Utility
    {
        static bool ReadInputNumberInt(string strInput, int iLimitDigital, out int outVal)
        {
            int iTmp = 0;
            outVal = 0;

            if(!int.TryParse(strInput, out iTmp))
            {
                return false;
            }

            return true;
        }

        T ReadInputNumber<T>(string strInput, int iLimitDigital, out bool bSuccess)
        {
            bSuccess = false;
            T outVal = default(T);

            int iTmp = 0;
            bSuccess = int.TryParse(strInput, out iTmp);

            //outVal = new Converter<int, T>(iTmp);

            // Func<int> name(int) => { return 1; };
            // (int) => {}
            
            return outVal;
        }

        /*
        bool ReadInputNumber<T>(string strInput, int iLimitDigital, out T outVal)
        {
            
            var oTmp = default(object);
            outVal = default(T);


            if(!int.TryParse(strInput, out outVal))
            {
                return false;
            }
            outVal = (T)oTmp;
            return true;
        }
        */
    }
    
}