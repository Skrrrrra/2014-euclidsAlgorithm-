using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace euclidsAlgorithm
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //путь

            string inputpath = "D:\\SolutionsForSpaceApp\\2014\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2014\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.Create);
            fsout.Close();


            string lineWithTwonNumbers;
            using (var reader = new StreamReader(inputpath))
            {
                lineWithTwonNumbers = reader.ReadLine();  // записываем в переменную
            }
            //запись из строки в массив строк с разделением
            string[] secondLineToInt = lineWithTwonNumbers.Split(' ');

            int[] A;
            A = new int[2];
            int count = 0;
            foreach (var s in secondLineToInt)
            {
                A[count] = Convert.ToInt32(s);
                count++;
            }

            int firstNumber = A[0];
            int secondNumber = A[1];

           
            int nod = gcd(firstNumber, secondNumber);

            File.WriteAllText(outputpath, nod.ToString());


        }
        static int gcd(int a, int b)
        {
            return b != 0 ? gcd(b, a % b) : a; ;
        }
    }
}
