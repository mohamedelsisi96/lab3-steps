namespace assignment4
{
    internal class Program
    {
        #region prob1
        static double CalcNum(double num1,double num2,string operation) {
            if (operation == "+")
            {
                return num1 + num2;
            }else if (operation == "-")
            {
                return num1 - num2;
            }else if(operation == "*")
            {
                return num1 * num2;
            }else if (operation == "/")
            {
                if (num2 > 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("the number 2 should be grater than 0");

                    return 0;
                }
            }
            else if (operation == "%")
            {
                return (num1 %(double) num2) ;
            }
            else
            {
                Console.WriteLine("Invalid operation");
                return 0;
            }
          
        }

        #endregion
        #region prob2

        static void CountOcurance(int[] arr,int num)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    counter++;
                }

            }
            Console.WriteLine($"the number {num} dublicate {counter} time");
        }
        #endregion
        #region prob3
        static int[] ReverseArr(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
        #endregion


        #region prob4
        static int[] RemovDupl(int[] arr)
        {
            int[] uniqArray = arr.Distinct().ToArray();
            for(int i = 0; i < uniqArray.Length; i++)
            {
                Console.WriteLine(uniqArray[i]);
            }
            return arr.Distinct().ToArray();
        }

        #endregion
        static void Main(string[] args)
        {
            double x=20,y=4;
            Console.WriteLine($"the sum of {x} and {y} is { CalcNum(x,y,"+")}");
            Console.WriteLine($"the sub of {x} and {y} is {CalcNum(x, y, "-")}");
            Console.WriteLine($"the mul of {x} and {y} is {CalcNum(x, y, "*")}");
            Console.WriteLine($"the div of {x} and {y} is {CalcNum(x, y, "/")}");
            Console.WriteLine($"the rem of {x} and {y} is {CalcNum(x, y, "%")}");
       


            int[] array = { 1, 2, 3, 5, 1, 52, 1, 25, 2, 5, 7, 6, 5 };
            int c = 2;
            CountOcurance(array, c);
            int[] array2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", array2));
            int[] RevArr = ReverseArr(array2);
            Console.WriteLine(string.Join(", ", RevArr));
            Console.WriteLine(string.Join(", ", array2));
            int[] DubArray = { 1, 2, 3, 4, 5, 2, 6, 6, 8,8,7, 9, 10 };
            int[] RmvDub = RemovDupl(DubArray);
            Console.WriteLine(RemovDupl(DubArray));
            Console.WriteLine("{"+ string.Join(",", RmvDub)+ "}");
        }
    }
}
