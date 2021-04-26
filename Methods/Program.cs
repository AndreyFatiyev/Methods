using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            //11.Написать программу, которая будет спрашивать имя и возраст двух человек


            string name1 = "";
            string name2 = "";
            int age1 = 0;
            int age2 = 0;

            name1 = IsName1(name1);
            name2 = IsName2(name2);
            age1 = IsAge1(age1);
            age2 = IsAge2(age2);

            Switch(name1, name2, age1, age2);

            Console.ReadKey();
        }
        static string IsName1(string name1)
        {

            bool isName = true;

            while (isName)
            {
                try
                {
                    Console.WriteLine("First user name:");
                    name1 = Console.ReadLine();
                    isName = false;
                }
                catch
                {
                    Console.WriteLine("enter leggit symbols in name1 =>>>");
                    isName = true;
                }
            }
            Console.Clear();
            return name1;
        }
        static int IsAge1(int age1)
        {
            bool isAge = true;
            while (isAge)
            {

                try
                {
                    Console.WriteLine("First user age:");
                    age1 = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    if (age1 > 0 && age1 < 101)
                    {
                        isAge = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter age from 1 to 100");
                    }

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("enter numbers please =>>>");
                    isAge = true;
                }


            }
            Console.Clear();
            return age1;
        }

        static string IsName2(string name2)
        {
            bool isName2 = true;
            while (isName2)
            {
                try
                {
                    Console.WriteLine("Second user name: ");
                    name2 = Console.ReadLine();
                    Console.Clear();
                    isName2 = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("enter leggit symbols in name2 =>>>");
                    isName2 = true;
                }

            }
            Console.Clear();
            return name2;
        }
        static int IsAge2(int age2)
        {
            bool isAge2 = true;
            while (isAge2)
            {
                try
                {
                    Console.WriteLine("Second user age: ");
                    age2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (age2 > 0 && age2 < 101)
                    {
                        isAge2 = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter age from 1 to 100");
                    }


                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("enter numbers please =>>>");
                    isAge2 = true;
                }

            }
            Console.Clear();
            return age2;
        }
        static void Switch(string name1, string name2, int age1, int age2)
        {
            bool sw = true;

            while (sw)
            {
                Console.WriteLine($"\nwho is older ?\n if {name1} press '1' , if {name2} press '2' ");
                int user = Convert.ToInt32(Console.ReadLine());

                if (user == 1 || user == 2)
                {
                    switch (user)
                    {
                        case 1:
                            Console.Clear();
                            if (age1 > age2)
                            {
                                Console.WriteLine($"Right , {name1} is {age1 - age2} year(s) older than {name2} ");
                            }
                            else
                                Console.WriteLine($"Not true , {name1} is {age2 - age1} year(s) younger than {name2} ");
                            break;
                        case 2:
                            Console.Clear();
                            if (age2 > age1)
                            {
                                Console.WriteLine($"Right , {name2} is {age2 - age1} year(s) older than {name1} ");
                            }
                            else
                                Console.WriteLine($"Not true , {name2} is {age1 - age2} year(s) younger than {name1} ");
                            break;
                    }
                    sw = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter number '1' or number '2'");
                    sw = true;
                }
            }



        }

    }
}
