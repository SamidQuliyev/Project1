using Access_Modifields;
using System;
namespace Access_Modifields
{

    class Program
    {
        //#region Static
        //class Student
        //{

        //}
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public int Age { get; set; }
        //public student (string name,string surname,int age)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Age = age;
        //}



        //#endregion
        static void Main(string[] args)
        {
            //MyIntList myintList = new MyIntList();
            int[] array = { 1, 2, 3 };
            Array.Resize(ref array,array.Length+1);
            array[3] = 4;
            array[4] = 5;

        }
        class MyIntList
        {
            private int[] array;
            public MyIntList()
            {
                array = new int[0];
            }

        }
    }
}





















