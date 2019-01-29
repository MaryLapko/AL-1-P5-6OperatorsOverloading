using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            Random rnd = new Random();
            //var circle1 = new Circle(3);
            //var circle2 = new Circle(5);

            //var square1 = new Square(2);
            //var square2 = new Square(4);

            //var trianlge1 = new Triangle(2);
            //var triangle2 = new Triangle(5);

            //var arr = new Figure[] { circle1, circle2, square1, square2, trianlge1, triangle2 };
            //for (int i = 0; i < 6; i++)
            //{
            //    //arr[i].CalcArea();
            //    Console.WriteLine(arr[i].CalcArea());

            Figure [,] arr  = new Figure[3, 10];
            for (int i = 0; i < 3; i++)
            {             
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        arr[i, j] = new Circle((int)rnd.Next(10));
                    }
                    else if (i == 1)
                    {
                        arr[i, j] = new Square((int)rnd.Next(10));
                    }
                    else if (i == 2)
                    {
                        arr[i, j] = new Triangle((int)rnd.Next(10));
                    }
                    Console.WriteLine(arr[i,j].CalcArea());                 
                }
            }
        }

        class Circle : Figure
        {
            private int rad;
            public Circle(int rad)
            {
                this.rad = rad;
            }
            public override double CalcArea()
            {
                return Math.PI * rad * rad;
            }

        }

        class Square : Figure
        {
            private int side;
            public Square(int side)
            {
                this.side = side;
            }
            public override double CalcArea()
            {
                return side * side;
            }

        }

        class Triangle : Figure
        {
            private int sideTriangle;

            public Triangle(int sideTriangle)
            {
                this.sideTriangle = sideTriangle;
            }
            public override double CalcArea()
            {
                return 0.5 * sideTriangle * 2;
            }
        }

            class Figure
            {
                public virtual double CalcArea()
                {
                    throw new NotImplementedException();
                }
            }

        /// <summary>
        /// A.L1.P5_6. Перегрузить следующие операторы для Fuelcar <(меньше), >(больше), ==(равно), !=(не равно) на базе значения мощности двигателя Engine.
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P5_6_OperatorsOverloading()
        {
            FuelCar f1 = new FuelCar { Engine = 2.0f};
            FuelCar f2 = new FuelCar { Engine = 1.6f };
            bool result = f1 > f2;
            bool result2 = f1 != f2;
            Console.WriteLine(result + " " + result2);
        }

        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
            {
            }

            /// <summary>
            /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
            /// Продемонстрировать использование в коде. 
            /// </summary>
            public static void A_L1_P7_OperatorsOverloading()
            {
            }
        }
    }

