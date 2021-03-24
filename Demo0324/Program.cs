using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0324
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 成績級別 Switch case

            /*
            int scoreTens;
            char grade;
            Console.WriteLine("enter your score");
            scoreTens = int.Parse(Console.ReadLine()) / 10;
            switch (scoreTens)
            {
                case 10:
                case 9:
                    grade = 'A';
                    break;

                case 8:
                    grade = 'B';
                    break;

                case 7:
                    grade = 'C';
                    break;

                case 6:
                    grade = 'D';
                    break;

                default:
                    grade = 'F';
                    break;
            }
            Console.WriteLine($"grade={grade}");

            // */

            #endregion 成績級別 Switch case

            #region Math.Round()

            /*

            decimal result = 0.0m;
            decimal positiveValue = 3.45m;
            Console.WriteLine(Math.Round(positiveValue, 1));
            result = Math.Round(positiveValue, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{result} = Math.Round({positiveValue}, 1, MidpointRounding.AwayFromZero)");

            // */

            #endregion Math.Round()

            #region 3-7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7。

            /*
            Console.WriteLine("how many inputs?");
            int num=int.Parse(Console.ReadLine());
            int i=0;
            string result="";
            while (i<num)
	{
                Console.WriteLine("enter a number");
                double temp=double.Parse(Console.ReadLine());
                result+=Math.Abs(temp)+" ";
                i++;
	}
            Console.WriteLine(result);
            // */

            #endregion 3-7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7。

            #region 輸入一個數，輸出其質因數 /*

            // */

            #endregion 輸入一個數，輸出其質因數 /*

            //第3周進度

            #region while/*

            // */

            #endregion while/*

            #region 假設輸入的都是正數，一旦讀到負數就終止

            /*

            int temp = 0;
            while (temp >= 0)
            {
                Console.WriteLine("enter a number");
                temp = int.Parse(Console.ReadLine());
            }

            // */

            #endregion 假設輸入的都是正數，一旦讀到負數就終止

            #region 輸入兩個數字，求最大公約數(GCD)

            /*

            //更相減損術
            // 1. 要求使用者輸入兩個數值
            // 2. 判斷a不等於b
            // 3. 判斷a,b大小，大減小，直至a=b退出迴圈

            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number");
            int b = int.Parse(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine(a);

            //輾轉相除法
            // 1. 要求使用者輸入兩個數值
            // 3. 判斷a,b大小，大除以小，求餘數
            // 2. 判斷餘數不等於0，若等於0退出迴圈

            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number");
            int b = int.Parse(Console.ReadLine());
            int r;
            //int temp = 0;
            if (a < b)
            {
                //temp = a;
                //a = b;
                //b = temp;
                (a, b) = (b, a);
            }
            r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            Console.WriteLine(b);
            // */

            #endregion 輸入兩個數字，求最大公約數(GCD)

            #region 計算N個數字的和

            /*

            Console.WriteLine("how many inputs?");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;
            while (i < num)
            {
                Console.WriteLine("enter a number");
                sum += int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine(sum);

            // */

            #endregion 計算N個數字的和

            #region 陣列

            /*

            //宣告四個字串變數，初始值為第七梯成員的名字
            string name1 = "Ann";
            string name2 = "Yiwen";
            string name3 = "Tissue";
            string name4 = "Ulysses";
            string[] member = new string[4];

            //將值放入陣列
            member[0] = "Ann";
            member[1] = "Yiwen";
            member[2] = "Tissue";
            member[3] = "Ulysses";

            //用迴圈列印出值
            for (int i = 0; i < member.Length; i++)
            {
                Console.WriteLine(member[i]);
            }

            // */

            #endregion 陣列

            #region 利用一維陣列求10個數字的平均值

            /*
            //宣告一維陣列
            //輸入10個數字給此陣列
            //計算十個數字的加總並求平均值
            const int size = 10;
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter a number");
                a[i] = int.Parse(Console.ReadLine());
            }
            int average = 0;

            for (int i = 0; i < size; i++)
            {
                average += a[i];
            }
            Console.WriteLine(average / size);
            //*/

            #endregion 利用一維陣列求10個數字的平均值

            #region 輸入10個數字至A[]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在

            /*

            //宣告陣列並讀入10個數值
            //逐一比對搜尋值x
            //用布林判斷是否存在於陣列
            const int size = 10; //常數
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter a number");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("which number are you looking for?");
            int x = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (a[i] == x)
                {
                    found = true;
                    Console.WriteLine($"index value of {x} is {i}");
                }
            }
            if (found == false)
            {
                Console.WriteLine($"{x} does not exist");
            }
            //*/

            #endregion 輸入10個數字至A[]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在

            #region 求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來

            /*

            //宣告三個兩列三欄的二維矩陣
            //用兩個巢狀迴圈填數字給矩陣*2
            //第三個矩陣裝相加結果

            int row = 2;
            int col = 3;
            int[,] a = new int[row, col];
            int[,] b = new int[row, col];
            int[,] c = new int[row, col];
            int i, j;
            Console.WriteLine("enter values for A array");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine($"insert the value of a[{i},{j}]");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("enter values for B array");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine($"insert the value for b[{i},{j}]");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("enter values for C array");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    //c[i, j] = a[i, j] + b[i, j];
                    c[i, j] += a[i, j] * b[i, j]; //下一題解答
                    Console.WriteLine($"value of c[{i},{j}]={c[i, j]}");
                }
            }

            // */

            #endregion 求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來

            #region 兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來/*

            //宣告三個兩列三欄的二維矩陣
            //用兩個巢狀迴圈填數字給矩陣*2
            //第三個矩陣裝相乘結果
            // */

            #endregion 兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來/*

            Console.ReadLine();
        }
    }
}