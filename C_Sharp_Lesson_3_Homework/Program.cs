using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Lesson_3_Homework
{
    class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            //your code here
            //int[,] matrixOfIntegers = new int[3, 3];
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                Console.WriteLine("The central element is " + matrixOfIntegers[matrixOfIntegers.GetLength(0) / 2, 
                    matrixOfIntegers.GetLength(1) / 2]);
            }
            else Console.WriteLine("This matrix doesn t have a central element");

        }

            public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            //your code here
            //int[,] matrixOfIntegers = new int[3, 3];

            Console.WriteLine("Print matrix:");
            for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                {
                    Console.Write(matrixOfIntegers[i, j] + "     ");
                }
                Console.WriteLine();
            }

            int diag1 = 0, diag2 = 0;
            if (matrixOfIntegers.GetLength(0) >= matrixOfIntegers.GetLength(1))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {

                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        // Condition for principal
                        // diagonal
                        if (i == j)
                            diag1 += matrixOfIntegers[i, j];

                        // Condition for secondary
                        // diagonal
                        if ((i + j) == (matrixOfIntegers.GetLength(1) - 1))
                            diag2 += matrixOfIntegers[i, j];
                    }

                }
                Console.WriteLine("First Diagonal:" + diag1);

                Console.WriteLine("Second Diagonal:" + diag2);
            }
            else 
                Console.WriteLine("This matrix doesn't have a diagonals");
        }
        
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here

            int i, j, n;
            n = triangleHight;
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }

        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here
            //IList<int> listOfNumbers = new List<int>();

            var sorted = new List<int>(listOfNumbers);
            sorted.Sort();
            Console.WriteLine(string.Join("  ", sorted));
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);
        }

    }
}
