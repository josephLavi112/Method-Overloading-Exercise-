using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 20;
            var y = 40;

            var intAdd = Add(x, y);
            var decimalAdd = Add(x, y);
            var addwithbool = Add(0, 1, true);
            Console.WriteLine(intAdd);
            Console.WriteLine(decimalAdd);
            Console.WriteLine(addwithbool);

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isSigned)
        {
            var addedNums = num1 + num2;
            if (isSigned == true && addedNums == 1)
            {
                return $"{addedNums} dollar";
            }
            else if (isSigned == true && addedNums > 1) 
            {
                return $"{addedNums} dollars";

            }
            else
            {
                return addedNums.ToString();
            }
        }

       
        
                          
        
    }
}
