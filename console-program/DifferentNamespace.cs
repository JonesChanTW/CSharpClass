namespace DifferentNamespace
{

    /*
    在namespace 中宣告的元素(類別,變數...等等的)存取修飾詞 預設為public
    可以不寫,那就是預設,
    也可以寫public,但無法寫為public以外的任何修飾詞
    */
    class OtherNamespaceClass
    {
        /*
        但非namespace中的則預設為private,
        如果不特別寫public 外部無法使用
        */
        public class OtherClassInOtherClass
        {
            public OtherClassInOtherClass()
            {

            }
        }
        public OtherNamespaceClass()
        {

        }
    }
}