namespace _01_RefactorWithGoodNaming
{
    using System;

    class RefactorWithGoodNaming
    {
        const int MAX_COUNT = 6;

        class BoolVariable 
        {
            public void PrintBoolInConsole(bool boolToPrint) 
            {
                string boolToPrintAsString = boolToPrint.ToString();
                Console.WriteLine(boolToPrintAsString);
            }
        }

        public static void InputMethod()
        {
            BoolVariable boolVariable = new BoolVariable();
            boolVariable.PrintBoolInConsole(true);
        }
    }
}
