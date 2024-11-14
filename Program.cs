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

        #region prob5

        static int SearchValue(int[] arr,int num)
        {
            if (arr.Contains(num))
            {
                int ind=Array.IndexOf(arr,num);
                Console.WriteLine($"{num} in index {ind} in array");
                return ind;


            }
            else
            {
                Console.WriteLine($"{num} not found in array");
                return -1;
            }
        }


        #endregion

        #region prob6
        static int[] SortInArray(int[] arr ,string sorttypr)
        {
            if (sorttypr == "ass")
            {
                Array.Sort(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
               
            }else if (sorttypr == "des")
            {
                Array.Reverse(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
               
            }
            else
            {
                Console.WriteLine("Invalid sort type provided.");
                
            }
            return arr;
        }


        #endregion


        #region prop7
        static int SecondLargest (int[] arr)
        {
            int[] SortArr = (int[])arr.Clone();
            Array.Sort(SortArr);
            return SortArr[SortArr.Length - 2];
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
            //prob 5
            Console.WriteLine("--------------------- problem 5 --------------------");
            int[] SarchArr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(SearchValue(SarchArr,9));
            //prob 6
            Console.WriteLine("--------------------- problem 6 --------------------");
            int[] ArrSort = {1,2,6,9,31,4,8,53,96};
            SortInArray(ArrSort, "ass");
            SortInArray(ArrSort, "des");

            //prob  7
            Console.WriteLine("--------------------- problem 7 --------------------");
            int[] findTwo = { 1, 2, 6, 9, 31, 4, 8, 53, 96,112 };
            int LargestTwoNum=SecondLargest(findTwo);
            Console.WriteLine(LargestTwoNum);



        }
    }
}
