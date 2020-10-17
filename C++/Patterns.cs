/*Note: Add appropriate method call to invoke the function in main program file*/
/*This file only contains the finctions*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class PatternCodes
    {
        //Half Pyraminds

        public void HalfPyramind()
        {
            //half pyramid
            int i, j;
            Console.WriteLine("Rows?");
            int rows = int.Parse(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public void NumHalfPyramind()
        {
            //Numeric Half Pyramind
            int i, j;
            Console.WriteLine("Rows?:");
            int rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(" " + i);
                Console.WriteLine();

            }
        }

        public void AlphabeticHalfPyramind()
        {
            int i, j;
            char alph = 'A';
            Console.WriteLine("Rows?:");
            int rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(" " + alph);
                Console.WriteLine();
                alph++;

            }

        }

        //Inverted Half Pyramids

        public void InvertedHalfPyramid()
        {
            int i, j;
            Console.Write("Rows?; ");
            int rows = int.Parse(Console.ReadLine());

            for (i = rows; i >= 1; --i)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        public void InvertedofNumbers()
        {
            int i, j;
            Console.Write("Rows?; ");
            int rows = int.Parse(Console.ReadLine());

            for (i = rows; i >= 1; --i)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(" " + j);
                Console.WriteLine();
            }
        }

        //Full pyramids
        public void FullPyramind()
        {

            int i, space, k = 0;
            Console.Write("Rows:? ");

            int rows = int.Parse(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                k = 0;
                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }
                while (k != (2 * i - 1))
                {
                    Console.Write("*");
                    k++;
                }
                Console.WriteLine();
            }

        }

        public void fullnumPyramid()
        {
            int i, space, num = 1, k = 0;
            Console.WriteLine("Rows:? ");
            int rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                k = 0;
                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }
                while (k != (2 * i - 1))
                {
                    Console.Write(" " + num);
                    k++;
                    num++;
                }
                Console.WriteLine();
            }
        }

        public void numMirrorPyramid()
        {
            int i, space, k;
            int count = 0, count1 = 0; ;
            Console.Write("Rows:? ");
            int rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                k = 0; count = 0; count1 = 0;
                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                    ++count;
                }
                while (k != 2 * i - 1)
                {
                    if (count <= rows - 1)
                    {
                        Console.Write((i + k));
                        count++;
                    }
                    else
                    {
                        ++count1;
                        Console.Write((i + k - 2 * count1));
                    }
                    k++;
                }
                Console.WriteLine();
            }
        }

        public void FullInvertedPyramind()
        {
            int i, j, space;
            Console.Write("Rows:?");
            int rows = int.Parse(Console.ReadLine());

            for (i = rows; i >= 1; i--)
            {
                for (space = 0; space < rows - i; space++)
                {
                    Console.Write(" ");
                }
                // Console.WriteLine();

                for (j = i; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }

                for (j = 0; j < (i - 1); j++)
                    Console.Write("*");
                Console.WriteLine();

            }
        }

        public void PascalTriangle()
        {
            int coef = 1, space, i, j;
            Console.Write("Rows:?");
            int rows = int.Parse(Console.ReadLine());

            for (i = 0; i < rows; i++)
            {
                for (space = 1; space <= rows - i; space++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        if (i == 0)
                            coef = 1;
                    }
                    else
                        coef = coef * (i - j + 1) / j;

                    Console.Write(coef + " ");
                }
                Console.WriteLine();
            }
        }

        public void Floyd()
        {
            int i, j;
            Console.Write("Rows:?");
            int rows = int.Parse(Console.ReadLine());
            int num = 1;
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        public void oddnumPyramid()
        {
            int k, i, space, num = 1;
            Console.Write("n=?: ");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (space = 1; space <= n - i; space++)
                {
                    Console.Write("  ");
                }
                for (k = 1; k <= (2 * i - 1); k++)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    num++;
                }
                Console.WriteLine();
            }
            num = 1;
            for (i = n; i >= 1; i--)
            {
                for (space = n - 1; space >= i; space--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (2 * i - 1); k++)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                    num++;
                }
                Console.WriteLine();
            }
        }

        public void Patt1_32_654(){
            Console.Write("n:? ");
            int n = int.Parse(Console.ReadLine());
            int count = 0, a;

            for (int i = 1; i <= n; i++)
            {
                count += i;
                a = count;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + a);
                    a--;

                }
                Console.WriteLine();
            }
        }
    }
}
