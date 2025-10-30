using Common;
using SessionOne.Example_01;
using SessionOne.Example_02;
using SessionOne.Example_03;
using SessionOne.Stract;
using System.Drawing;

namespace SessionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class libraries
            //Product product = new Product();

            //product.Id = 10;
            //product.Name= "Youssef";
            //product.Price= 50;
            //product.Quntaty = 3;
            #endregion

            #region Access modifers
            //TypeA typeA = new TypeA();
            //typeA.x = 4;//invalid ==>valid in its scop only
            //typeA.y = 5; // invalid ==>valid in their scope and thier project only
            // typeA.z = 6;// valid at any project


            #endregion

            #region enum Ex 01 Male and Female
            //Person p1;
            //// refreance [stack ] 4 bytes
            //p1 = new Person();
            //// allocate num of bytes in heap
            //// inialize with the default values
            //// call user define ctor (if exist)
            //// assign refrence to the instance in heap


            //p1.Id = 1;
            //p1.Name = "Joe";
            //p1.Gender = Gender.female;

            //// p1.Gender = (Gender)2;


            //Console.WriteLine(p1.Gender);
            #endregion

            #region Enum Ex 02 Grades
            //Grad g1; // variable like int x;
            //g1 = Grad.A;
            //Console.WriteLine(g1);


            //Person p1 = new Person();
            //p1.grad = Grad.A;

            //int num = (int)Grad.C;
            //Console.WriteLine(num);


            //Person p1 = new Person() { 
            //Id = 1,
            //Name = "joe",
            //Gender = Gender.male,
            //grad = Grad.A
            //};

            //if(p1.grad == Grad.A)

            //    Console.WriteLine("bravo");
            //else
            //    Console.WriteLine("Work Harder");

            #endregion

            #region Ex 2
            //User user;
            //user = new User()
            //{
            //    Id = 1,
            //    Name = "Joe",
            //    Gender = Gender.m,
            //    Grad = Grad.A,
            //    Branch = Branch.Dokki,

            //};

            //Console.WriteLine(user.Grad);
            //Console.WriteLine(user.Gender);
            //Console.WriteLine(user.Branch);



            //User user = new User();
            //Console.WriteLine("Please enter the student info");
            //bool isParsed;
            //int stdID;
            //do
            //{
            //    Console.WriteLine("Please enter the student id");
            //    stdID = user.Id;
            //    isParsed = int.TryParse(Console.ReadLine(), out stdID); 
            //} while (!isParsed);

            //Console.WriteLine("please enter the valid name");
            //user.Name = Console.ReadLine();
            //string stName = user.Name;
            //object? gender;
            ////bool isParesed;
            //do
            //{
            //    Console.WriteLine("Please enter the valid gender {Male / Female}");
            //    isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), out gender);

            //} while (!isParsed);

            //Grad grad;
            //do
            //{

            //    Console.WriteLine("Please enter the valid grad");
            //    isParsed = Enum.TryParse<Grad>(Console.ReadLine(), out grad);

            //} while (!isParsed);

            //Branch branch;
            //do
            //{

            //    Console.WriteLine("Please enter the valid Branch");
            //    isParsed = Enum.TryParse<Branch>(Console.ReadLine(), out branch);
            //} while (!isParsed);

            //Console.Clear();
            //Console.WriteLine($"Hello {stdID} {stName}");
            //Console.WriteLine($"Your Gender {gender}");
            //Console.WriteLine($"Your grad {grad}");
            //Console.WriteLine($"Your branch {branch}");




            #endregion


            #region Ex 03
            //User user = new User();
            //user.Id = 1;
            //user.Premissions = (Premissions)1;
            //Console.WriteLine(user.Premissions);

            //user.Premissions ^= Premissions.execute;
            //Console.WriteLine(user.Premissions);

            ////user.Premissions ^= Premissions.delete;
            ////Console.WriteLine(user.Premissions);

            //// & check
            //if((user.Premissions & Premissions.delete) == Premissions.delete)
            //{
            //    Console.WriteLine("Premission delete already exist");
            //}else
            //{
            //    user.Premissions ^= Premissions.delete;

            //}
            #endregion


            #region Stract

            //Pointt p1;

            //p1 = new Pointt(10,10);
            //// new ==> value type [constractor selection]
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);

            //Console.WriteLine(p1); // boxing
            //Console.WriteLine(p1.ToString());

            #endregion



            #region OOP

            #endregion


        }
    }
}
