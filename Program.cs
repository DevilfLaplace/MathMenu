using System;
using System.Collections.Generic;

namespace MathMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);
            StartPage();
        }
        static void StartPage()
        {
            Console.Title = "MathMenu";
            Console.Clear();
            Console.Write("\n  1= Calculator\n  2= Sum of Consecutive Numbers\n  3= Area-Perimeter Calculation\n  4= Area-Volume Calculation\n  5= Basic Number Prediction Game\n  6= Exit\n\n  Choose > ");
            switch (Console.ReadLine())
            {
                case "1":
                    Case1();
                    break;
                case "2":
                    Case2();
                    break;
                case "3":
                    Case3();
                    break;
                case "4":
                    Case4();
                    break;
                case "5":
                    Case5();
                    break;
                case "6":
                    break;
                default:
                    CaseError();
                    break;
            }
        }
        static void Case1()
        {
            Console.Title = "MathMenu\\Calculator";
            Console.Clear();
            Case1StartPage();
            static void Case1StartPage()
            {
                Console.Clear();
                Console.Write("\n  1= Addition\n  2= Subtraction\n  3= Multiplication\n  4= Divison\n  5= Exponentiation\n  6= Factorial\n  7= Square Root\n  8= Go Back\n\n  Choose > ");
                switch (Console.ReadLine())
                {
                    #region Case1
                    case "1":
                        Console.Title = "MathMenu\\Calculator\\Addition";
                        Console.Clear();
                        long c11result = 0;
                        Console.Clear();
                        Console.Write("\n  0= Result\n\n");
                        long c11z;
                        int c11i = 0;
                        var c1111 = new List<long>();
                        do
                        {
                            Console.Write("  Input > ");
                            try
                            {
                                c1111.Add(Convert.ToInt64(Console.ReadLine()));
                            }
                            catch
                            {
                                CaseError();
                                break;
                            }
                            c11z = c1111[c11i];
                            if (c11z == 0)
                            {
                                for (int j = 0; j < c1111.Count; j++)
                                {
                                    c11result += c1111[j];
                                }
                                Console.Write($"\n\n  Result:  {c11result}");
                                CaseEnd();
                            }
                            c11i++;
                        } while (c11z != 0);
                        break;
                    #endregion
                    #region Case2
                    case "2":
                        long c121, c122;
                        Console.Title = "MathMenu\\Calculator\\Subtraction";
                        Console.Clear();
                        try
                        {
                            Console.Write("\n  Number 1: ");
                            c121 = Convert.ToInt64(Console.ReadLine());
                            Console.Write("  Number 2: ");
                            c122 = Convert.ToInt64(Console.ReadLine());
                            Console.Write($"\n\n  Answer: {c121 - c122}");
                            CaseEnd();
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case3
                    case "3":
                        long c13result = 1;
                        Console.Title = "MathMenu\\Calculator\\Multiplication";
                        Console.Clear();
                        Console.Write("\n  0= Result\n\n");
                        long c13z;
                        int c13i = 0;
                        var c132 = new List<long>();
                        do
                        {
                            Console.Write("  Input > ");
                            try
                            {
                                c132.Add(Convert.ToInt64(Console.ReadLine()));
                            }
                            catch
                            {
                                CaseError();
                                break;
                            }
                            c13z = c132[c13i];
                            if (c13z == 0)
                            {
                                c132.Remove(c132[c13i]);
                                for (int j = 0; j < c132.Count; j++)
                                {
                                    c13result *= c132[j];
                                }
                                Console.Write($"\n\n  Result: {c13result}");
                                CaseEnd();
                            }
                            c13i++;
                        } while (c13z != 0);
                        break;
                    #endregion
                    #region Case4
                    case "4":
                        double c141, c142;
                        Console.Title = "MathMenu\\Calculator\\Division";
                        Console.Clear();
                        try
                        {
                            Console.Write("\n  Number 1: ");
                            c141 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("  Number 2: ");
                            c142 = Convert.ToDouble(Console.ReadLine());
                            double c145 = c141 / c142;
                            Console.Write($"\n\n  Answer: {Math.Round(c145, 3)}");
                            CaseEnd();
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case5
                    case "5":
                        Console.Title = "MathMenu\\Calculator\\Exponentiation";
                        Console.Clear();
                        int base_, power, c15answer = 1;
                        try
                        {
                            Console.Write("\n  Base  : ");
                            base_ = Convert.ToInt16(Console.ReadLine());
                            Console.Write("  Power : ");
                            power = Convert.ToInt16(Console.ReadLine());
                            for (int i = 0; i < power; i++)
                            {
                                c15answer *= base_;
                            }
                            Console.WriteLine($"\n\n  Answer: {base_}^{power} = {c15answer}");
                            CaseEnd();
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case6
                    case "6":
                        Console.Title = "MathMenu\\Calculator\\Factorial";
                        Console.Clear();
                        byte c16input;
                        ulong c16answer = 1;
                        try
                        {
                            Console.Write("\n  Number: ");
                            c16input = Convert.ToByte(Console.ReadLine());
                            for (byte i = c16input; i > 0; i--)
                            {
                                c16answer = i * c16answer;
                            }
                            if (c16input > 65)
                            {
                                Console.Write($"\n  Out of the range!\n  Max 65");
                            } else
                            {
                                Console.Write($"\n\n  Factorial: {c16input}! = {c16answer}");
                            }
                            CaseEnd();
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case7
                    case "7":
                        Console.Title = "MathMenu\\Calculator\\SquareRoot";
                        Console.Clear();
                        int c17input;
                        try
                        {
                            Console.Write("\n  Number: ");
                            c17input = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"\n\n  Square Root: {Math.Round(Math.Sqrt(c17input), 3)}");
                            CaseEnd();
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case8_9
                    case "8":
                        StartPage();
                        break;
                    default:
                        CaseError();
                        break;
                        #endregion
                }
            }
        }
        static void Case2()
        {
            Console.Title = "MathMenu\\SumOfConsecutiveNumbers";
            Console.Clear();
            double initial, end, increase, numberOfTerms, result;
            try
            {
                Console.Write("\n  Initial Value       : ");
                initial = Convert.ToDouble(Console.ReadLine());
                Console.Write("  End Value           : ");
                end = Convert.ToDouble(Console.ReadLine());
                Console.Write("  The Increase Amount : ");
                increase = Convert.ToDouble(Console.ReadLine());
                numberOfTerms = ((end - initial) / increase) + 1;
                result = numberOfTerms * ((initial + end) / 2);
                Console.Write("\n\n  Sum = {0}", result);
                CaseEnd();
            }
            catch
            {
                CaseError();
            }
        }
        static void Case3()
        {
            Console.Clear();
            Case3StartPage();

            static void Case3StartPage()
            {
                Console.Write("\n  1= Rectangle\n  2= Triangle\n  3= Circle\n  4= Parallelogram\n  5= Trapezoidal\n  6= Go Back\n\n  Choose > ");
                switch (Console.ReadLine())
                {
                    #region Case1
                    case "1":
                        Console.Clear();
                        Console.Title = "MathMenu\\Area-PerimeterCalculation\\Rectangle";
                        int c31edge1, c31edge2;
                        try
                        {
                            Console.Write("\n  1= Area Calculating\n  2= Perimeter Calculating\n  3= Go Back to The Main Menu\n\n  Choose > ");
                            string c311 = Console.ReadLine();
                            Console.Clear();
                            if (c311 == "1")
                            {
                                Console.Write("\n  Edge 1: ");
                                c31edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Edge 2: ");
                                c31edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Area: {Math.Abs(c31edge1) * Math.Abs(c31edge2)}");
                                CaseEnd();
                            } else if (c311 == "2")
                            {
                                Console.Write("\n  Edge 1: ");
                                c31edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Edge 2: ");
                                c31edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Perimeter: {(Math.Abs(c31edge1) + Math.Abs(c31edge2)) * 2}");
                                CaseEnd();
                            } else if (c311 == "3")
                            {
                                StartPage();
                            } else
                            {
                                CaseError();
                            }
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case2
                    case "2":
                        try
                        {
                            Console.Clear();
                            Console.Title = "MathMenu\\Area-PerimeterCalculation\\Triangle";
                            Console.Write("\n  1= Area Calculating\n  2= Perimeter Calculating\n  3= Go Back to The Main Menu\n\n  Choose > ");
                            string c321 = Console.ReadLine();
                            Console.Clear();
                            if (c321 == "1")
                            {
                                int c32height, c32flooredge;
                                Console.Write("\n  Floor Edge: ");
                                c32flooredge = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Height    : ");
                                c32height = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Area: {Math.Abs(c32height * c32flooredge) / 2}");
                                CaseEnd();
                            } else if (c321 == "2")
                            {
                                int c322 = 0;
                                Console.WriteLine();
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.Write($"  Edge {i + 1}: ");
                                    c322 += Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write($"\n\n  Perimeter: {c322}");
                                CaseEnd();
                            } else if (c321 == "3")
                            {
                                StartPage();
                            } else
                            {
                                CaseError();
                            }
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case3
                    case "3":
                        Console.Clear();
                        Console.Title = "MathMenu\\Area-PerimeterCalculation\\Circle";
                        try
                        {
                            Console.Write("\n  1= Area Calculating\n  2= Perimeter Calculating\n  3= Go Back to The Main Menu\n\n  Choose > ");
                            string c331 = Console.ReadLine();
                            Console.Clear();
                            double c33pi, c33radius, c33answer;
                            if (c331 == "1")
                            {
                                Console.Write("\n  Radius: ");
                                c33radius = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Pi    : ");
                                c33pi = Convert.ToDouble(Console.ReadLine());
                                c33answer = c33pi * c33radius * c33radius;
                                Console.Write($"\n\n  Area: {Math.Round(c33answer, 3)}");
                                CaseEnd();
                            } else if (c331 == "2")
                            {
                                Console.Write("\n  Radius: ");
                                c33radius = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Pi: ");
                                c33pi = Convert.ToDouble(Console.ReadLine());
                                c33answer = 2 * c33pi * c33radius;
                                Console.Write($"\n\n  Perimeter: {Math.Round(c33answer, 3)}");
                                CaseEnd();
                            } else if (c331 == "3")
                            {
                                StartPage();
                            } else
                            {
                                CaseError();
                            }
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case4
                    case "4":
                        Console.Clear();
                        Console.Title = "MathMenu\\Area-PerimeterCalculation\\Parallelogram";
                        Console.Write("\n  1= Area Calculating\n  2= Perimeter Calculating\n  3= Go Back to The Main Menu\n\n  Choose > ");
                        try
                        {
                            string c341 = Console.ReadLine();
                            Console.Clear();
                            if (c341 == "1")
                            {
                                int c341flooredge, c341height;
                                Console.Write("\n  Floor Edge: ");
                                c341flooredge = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Height    : ");
                                c341height = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Area: {Math.Abs(c341height * c341flooredge)}");
                                CaseEnd();
                            } else if (c341 == "2")
                            {
                                int c342edge1, c342edge2;
                                Console.Write("\n  Edge 1: ");
                                c342edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Edge 2: ");
                                c342edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Perimeter: {Math.Abs((c342edge2 + c342edge1) * 2)}");
                                CaseEnd();
                            } else if (c341 == "3")
                            {
                                StartPage();
                            } else
                            {
                                CaseError();
                            }
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case5
                    case "5":
                        Console.Clear();
                        Console.Title = "MathMenu\\Area-PerimeterCalculation\\Trapezoidal";
                        Console.Write("\n  1= Area Calculating\n  2= Perimeter Calculating\n  3= Go Back to The Main Menu\n\n  Choose > ");
                        try
                        {
                            string c351 = Console.ReadLine();
                            Console.Clear();
                            if (c351 == "1")
                            {
                                int c351edge1, c351edge2, c351height;
                                Console.Write("\n  Floor Edge: ");
                                c351edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Top Edge: ");
                                c351edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Height: ");
                                c351height = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Area: {Math.Abs(((c351edge1 + c351edge2) / 2) * c351height)}");
                                CaseEnd();
                            } else if (c351 == "2")
                            {
                                int c352 = 0;
                                Console.WriteLine();
                                for (int i = 1; i < 5; i++)
                                {
                                    Console.Write($"  Edge {i}: ");
                                    c352 += Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write($"\n\n  Perimeter: {c352}");
                                CaseEnd();
                            } else if (c351 == "3")
                            {
                                StartPage();
                            } else
                            {
                                CaseError();
                            }
                        }
                        catch
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Other
                    case "6":
                        StartPage();
                        break;
                    default:
                        CaseError();
                        break;
                    #endregion
                }
            }
        }
        static void Case4()
        {
            Console.Clear();
            Case4StartPage();
            static void Case4StartPage()
            {
                Console.Write("\n  1= Cube - RectangularPrism - SquarePrism\n  2= TrianglePrism\n  3= Cylinder\n  4= Sphere\n  5= Cone\n  6= Rectangle Floor Pyramid\n  7= Back\n\n  Choose > ");
                switch (Console.ReadLine())
                {
                    #region Case1
                    case "1":
                        Console.Clear();
                        Console.Title = "MathMenu\\Volume-AreaCalculation\\Cube-Rectangular-Square";
                        Console.Write("\n  1= Area Calculating\n  2= Volume Calculating\n  3= Back to The Main Menu\n\n  Choose > ");
                        string c411 = Console.ReadLine();
                        Console.Clear();
                        int c412edge1, c412edge2, c412edge3;
                        if (c411 == "1")
                        {
                            try
                            {
                                Console.Write("\n  Edge 1: ");
                                c412edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Edge 2: ");
                                c412edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Edge 3: ");
                                c412edge3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"\n\n  Area: {((c412edge1 * c412edge2) + (c412edge2 * c412edge3) + (c412edge3 * c412edge1)) * 2}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c411 == "2")
                        {
                            try
                            {
                                Console.Write("\n  Edge 1: ");
                                c412edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Edge 2: ");
                                c412edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Edge 3: ");
                                c412edge3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"\n\n  Area: {c412edge1 * c412edge2 * c412edge3}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c411 == "3")
                        {
                            StartPage();
                        }else
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case2
                    case "2":
                        Console.Clear();
                        Console.Title = "MathMenu\\Volume-AreaCalculation\\TrianglePrism";
                        Console.Write("\n  1= Area Calculating\n  2= Volume Calculating\n  3= Back to The Main Menu\n\n  Choose > ");
                        string c421 = Console.ReadLine();
                        Console.Clear();
                        int c42trianglefloor, c42triangleedge2, c42triangleedge3, c42triangleheight, c42lateraledge;
                        if (c421 == "1")
                        {
                            try
                            {
                                Console.Write("\n  Triangle Floor Edge : ");
                                c42trianglefloor = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Triangle Second Edge: ");
                                c42triangleedge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Triangle Third Edge : ");
                                c42triangleedge3 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Triangle Height     : ");
                                c42triangleheight = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Lateral Edge        : ");
                                c42lateraledge = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Area: {(c42trianglefloor * c42triangleheight) + ((c42trianglefloor + c42triangleedge2 + c42triangleedge3) * c42lateraledge)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c421 == "2")
                        {
                            try
                            {
                                Console.Write("\n  Triangle Floor Edge: ");
                                c42trianglefloor = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Triangle Height    : ");
                                c42triangleheight = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Lateral Edge       : ");
                                c42lateraledge = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Volume: {c42trianglefloor * c42triangleheight / 2 * c42lateraledge}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c421 == "3")
                        {
                            StartPage();
                        } else
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case3
                    case "3":
                        Console.Clear();
                        Console.Title = "MathMenu\\Volume-AreaCalculation\\Cylinder";
                        Console.Write("\n  1= Area Calculating\n  2= Volume Calculating\n  3= Back to The Main Menu\n\n  Choose > ");
                        string c431 = Console.ReadLine();
                        Console.Clear();
                        double c43pi, c43radius, c43height, c43answer;
                        if (c431 == "1")
                        {
                            try
                            {
                                Console.Write("\n  Radius: ");
                                c43radius = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Height: ");
                                c43height = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Pi    : ");
                                c43pi = Convert.ToDouble(Console.ReadLine());
                                c43answer = ((c43pi * c43radius * c43radius) * 2) + (2 * c43pi * c43radius * c43height);
                                Console.Write($"\n\n  Area: {Math.Round(c43answer, 3)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c431 == "2")
                        {
                            try
                            {
                                Console.Write("\n  Radius: ");
                                c43radius = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Height: ");
                                c43height = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Pi    : ");
                                c43pi = Convert.ToDouble(Console.ReadLine());
                                c43answer = c43pi * c43radius * c43radius * c43height;
                                Console.Write($"\n\n  Perimeter: {Math.Round(c43answer, 3)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c431 == "3")
                        {
                            StartPage();
                        } else
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case4
                    case "4":
                        Console.Clear();
                        Console.Title = "MathMenu\\Volume-AreaCalculation\\Sphere";
                        Console.Write("\n  1= Area Calculating\n  2= Volume Calculating\n  3= Back to The Main Menu\n\n  Choose > ");
                        string c441 = Console.ReadLine();
                        double c442radius, c442pi, c442answer;
                        Console.Clear();
                        if (c441 == "1")
                        {
                            try
                            {
                                Console.Write("\n  Radius: ");
                                c442radius = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Pi    : ");
                                c442pi = Convert.ToDouble(Console.ReadLine());
                                c442answer = 4 * c442pi * c442radius * c442radius;
                                Console.Write($"\n\n  {Math.Round(c442answer, 3)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c441 == "2")
                        {
                            try
                            {
                                Console.Write("\n  Radius: ");
                                c442radius = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Pi    : ");
                                c442pi = Convert.ToDouble(Console.ReadLine());
                                c442answer = 1.33333 * c442pi * c442radius * c442radius * c442radius;
                                Console.Write($"\n\n  Volume: {Math.Round(c442answer, 3)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c441 == "3")
                        {
                            StartPage();
                        } else
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case5
                    case "5":
                        Console.Clear();
                        Console.Title = "MathMenu\\Volume-AreaCalculation\\Cone";
                        Console.Write("\n  1= Area Calculating\n  2= Volume Calculating\n  3= Back to The Main Menu\n\n  Choose > ");
                        string c451 = Console.ReadLine();
                        double c452height, c452radius, c452pi, c452answer;
                        Console.Clear();
                        if (c451 == "1")
                        {
                            try
                            {
                                Console.Write("\n  Radius: ");
                                c452radius = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Pi    : ");
                                c452pi = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Height: ");
                                c452height = Convert.ToDouble(Console.ReadLine());
                                c452answer = c452pi * c452radius * (c452radius + Math.Sqrt((c452height * c452height) + (c452radius * c452radius)));
                                Console.Write($"\n\n  Area: {c452answer}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c451 == "2")
                        {
                            try
                            {
                                Console.Write("\n  Radius: ");
                                c452radius = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Pi    : ");
                                c452pi = Convert.ToDouble(Console.ReadLine());
                                Console.Write("  Height: ");
                                c452height = Convert.ToDouble(Console.ReadLine());
                                c452answer = 0.333333 * c452pi * c452radius * c452radius * c452height;
                                Console.Write($"\n\n  Perimeter: {Math.Round(c452answer, 1)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c451 == "3")
                        {
                            StartPage();
                        } else
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Case6
                    case "6":
                        Console.Clear();
                        Console.Title = "MathMenu\\Volume-AreaCalculation\\RectangleFloorPyramid";
                        Console.Write("\n  1= Area Calculating\n  2= Volume Calculating\n  3= Back to The Main Menu\n\n  Choose > ");
                        string c461 = Console.ReadLine();
                        int c462edge1, c462edge2, c462height;
                        Console.Clear();
                        if (c461 == "1")
                        {
                            try
                            {
                                Console.Write("\n  First Floor Edge : ");
                                c462edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Second Floor Edge: ");
                                c462edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Height           : ");
                                c462height = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Perimeter: {Math.Round(((Math.Sqrt(c462height) + Math.Sqrt(c462edge2 / 2)) * c462edge1) + ((Math.Sqrt(c462height) + Math.Sqrt(c462edge1 / 2)) * c462edge2) + (c462edge1 * c462edge2), 3)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c461 == "2")
                        {
                            try
                            {
                                Console.Write("\n  First Floor Edge : ");
                                c462edge1 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Second Floor Edge: ");
                                c462edge2 = Convert.ToInt32(Console.ReadLine());
                                Console.Write("  Height           : ");
                                c462height = Convert.ToInt32(Console.ReadLine());
                                Console.Write($"\n\n  Volume: {Math.Round(0.333333 * c462edge1 * c462edge2 * c462height, 3)}");
                                CaseEnd();
                            }
                            catch
                            {
                                CaseError();
                            }
                        } else if (c461 == "3")
                        {
                            StartPage();
                        } else
                        {
                            CaseError();
                        }
                        break;
                    #endregion
                    #region Other
                    case "7":
                        StartPage();
                        break;
                    default:
                        CaseError();
                        break;
                        #endregion
                }
            }
        }
        static void Case5()
        {
            Console.Title = "MathMenu\\BasicNumberPrediction";
            Console.Clear();
            int lowerRange = 0, upperRange = 0, secretNumber = 0, prediciton = 0, counter = 0;
            Console.WriteLine("     ¨¨¨¨¨¨¨¨¨Welcome To Prediction Game¨¨¨¨¨¨¨¨¨");
            try
            {
                Console.Write("\n  Write the Lower Range: ");
                lowerRange = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n  Write the Upper Range: ");
                upperRange = Convert.ToInt32(Console.ReadLine());
                Random range = new Random();
                secretNumber = range.Next(lowerRange, upperRange + 1);
                Console.Clear();
                do
                {
                    counter++;
                    Console.Write("\n  Predict the Number: ");
                    prediciton = Convert.ToInt32(Console.ReadLine());
                    if (prediciton > secretNumber)
                    {
                        Console.WriteLine("  You Said A So Big Number");
                        Console.Write("  Try Again\n");
                    } else if (prediciton < secretNumber)
                    {
                        Console.WriteLine("  You Said A So Small Number");
                        Console.Write("  Try Again\n");
                    } else
                    {
                        Console.Clear();
                        Console.WriteLine($"  Congrats Right Answer In {counter}. Try!  \\\\{prediciton}\n  Wanna Play Again?");
                        Console.Write("\n\n  1= Play Again\n  2= Go Back to The Main Menu\n  3= Exit\n\n  Choose > ");
                        string c5 = Console.ReadLine();
                        if (c5 == "1")
                        {
                            Case5();
                        } else if (c5 == "2")
                        {
                            StartPage();
                        } else if (c5 == "3")
                        {

                        } else
                        {
                            CaseError();
                        }
                    }
                } while (prediciton != secretNumber);
            }
            catch
            {
                CaseError();
            }
        }
        static void CaseError()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Error!";
            Console.Clear();
            Console.Write("\n\n\n\n\n\t\a    Empty or Invalid Input!\n\t     1= Go Back\n\t     2= Exit\n\n\t     Choose > ");
            string decision = Console.ReadLine();
            if (decision == "1")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                StartPage();
            } else if (decision == "2")
            {

            } else
            {
                CaseError();
            }
        }
        static void CaseEnd()
        {
            Console.Title = "MathMenu";
            Console.Write("\n\n  1= Back to The Main Menu \n  2= Exit\n\n  Choose > ");
            string caseEnd1 = Console.ReadLine();
            if (caseEnd1 == "1")
            {
                StartPage();
            } else if (caseEnd1 == "2")
            {

            } else
            {
                CaseError();
            }
        }
    }
}