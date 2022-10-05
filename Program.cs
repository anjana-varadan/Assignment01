using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static int RectangleLength;
        static int RectangleWidth;
        static int option;
        static void Main(string[] args)
        {
            //Length of a rectangle
            bool isValidLength = true;
            do
            {
                Console.WriteLine("Enter the length of the rectangle");
                isValidLength = int.TryParse(Console.ReadLine(), out var rectLength);
                if (isValidLength)
                {
                    if (rectLength <= 0)
                    {
                        Console.WriteLine("Length of the rectangle cannot be equal to or less than 0. Enter a number greater than Zero ");
                        isValidLength = false;
                    }
                    else
                    {
                        RectangleLength = rectLength;
                    }
                }
                else
                {
                    Console.WriteLine("Enter an integer");
                }
            } while (!isValidLength);


            //Width of a rectangle
            bool isValidWidth = true;
            do
            {
                Console.WriteLine("Enter the width of the rectangle");
                isValidWidth = int.TryParse(Console.ReadLine(), out var rectWidth);
                if (isValidWidth)
                {
                    if (rectWidth <= 0)
                    {
                        Console.WriteLine("Width of the rectangle cannot be equal to or less than 0. Enter a number greater than Zero ");
                        isValidWidth = false;
                    }
                    else
                    {
                        RectangleWidth = rectWidth;
                    }
                }
                else
                {
                    Console.WriteLine("Enter an integer");
                }
            } while (!isValidWidth);
            Options();
        }

        public static void Options()
        {
            bool isValidOption = true;
            bool exit = false;
            do
            {
                do
                {
                    Console.WriteLine("******Options******");
                    Console.WriteLine("Please select an option.");
                    Console.WriteLine("1. Get Rectangle Length \n2. Change Rectangle Length \n3. Get Rectangle Width \n4. Change Rectangle Width \n5. Get Rectangle Perimeter \n6. Get Rectangle Area \n7. Exit ");
                    isValidOption = int.TryParse(Console.ReadLine(), out var userSelect);
                    if (isValidOption)
                    {
                        if (userSelect < 1 || userSelect > 7)
                        {
                            Console.WriteLine("Please select a valid option.");
                            isValidOption = false;
                        }
                        else
                        {
                            option = userSelect;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number.");
                    }
                } while (!isValidOption);

                // Menu functions
                Rectangle rectangle = new Rectangle(RectangleLength, RectangleWidth);
                if(option == 1)
                {
                    var length = rectangle.GetCurrentLength();
                    Console.WriteLine("Length of rectangle is :" + length);
                }
                else if(option == 2)
                {
                    bool isValidLength = true;
                    do
                    {
                        Console.WriteLine("Enter the new length of the rectangle.");
                        isValidLength = int.TryParse(Console.ReadLine(), out var rectLength);
                        if (isValidLength)
                        {
                            if (rectLength <= 0)
                            {
                                Console.WriteLine("Please enter a number greater than zero.");
                                isValidLength = false;
                            }
                            else
                            {
                                RectangleLength = rectLength;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter an integer value.");
                        }

                    } while (!isValidLength);
                    var newLength = rectangle.SetNewLength(RectangleLength);
                    Console.WriteLine("New length of rectangle is :" + newLength);
                }
                else if(option == 3)
                {
                    var width = rectangle.GetCurrentWidth();
                    Console.WriteLine("Width of rectangle is :" + width);
                }
                else if(option == 4)
                {
                    bool isValidWidth = true;
                    do
                    {
                        Console.WriteLine("Enter the new width of the rectangle.");
                        isValidWidth = int.TryParse(Console.ReadLine(), out var rectWidth);
                        if (isValidWidth)
                        {
                            if (rectWidth <= 0)
                            {
                                Console.WriteLine("Please enter a number greater than zero.");
                                isValidWidth = false;
                            }
                            else
                            {
                                RectangleWidth = rectWidth;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter an integer value.");
                        }

                    } while (!isValidWidth);
                    var newWidth = rectangle.SetNewWidth(RectangleWidth);
                    Console.WriteLine("New width of rectangle is :" + newWidth);
                }
                else if(option == 5)
                {
                    var perimeter = rectangle.GetPerimeter();
                    Console.WriteLine("Perimeter of rectangle is :" + perimeter);
                }
                else if(option == 6)
                {
                    var area = rectangle.GetArea();
                    Console.WriteLine("Area of rectangle is :" + area);
                }
                else
                {
                    exit = true;
                }
                Console.WriteLine();
            } while (!exit);

            Console.ReadLine();
        }
    }
}
