using Chapter4.Challenge1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            MySuperGeneric<Person> genericList = new MySuperGeneric<Person>();
            Person p1 = new Person { Id = 1, Name = "MST", Gender = "MALE" };
            Person p2 = new Person { Id = 2, Name = "MDU", Gender = "MALE" };
            Person p3 = new Person { Id = 3, Name = "CIL", Gender = "FEMALE" };
            Person p4 = new Person { Id = 4, Name = "CARLA", Gender = "FEMALE" };
            Person p5 = new Person { Id = 5, Name = "CRELLE", Gender = "MALE" };
            genericList.Add(p1);
            genericList.Add(p2);
            genericList.Add(p3);
            genericList.Add(p4);

            PrintOutAllPersonsInList(genericList);

            Console.WriteLine($"The length of the list is: {genericList.Count}");
            Console.WriteLine($"Is my generic super list readonly? {genericList.IsReadOnly}");

            bool isObjectContainedInList = genericList.Contains(p1);
            Console.WriteLine($"Is object p1 contained in list? {isObjectContainedInList}");

            Console.WriteLine("Inserting object p5 at index 0!");
            genericList.Insert(0, p5);
            Console.WriteLine(); Console.WriteLine();

            PrintOutAllPersonsInList(genericList);

            Console.WriteLine("Removing object p2!");
            genericList.Remove(p2);

            PrintOutAllPersonsInList(genericList);

            int indexOfObject = genericList.IndexOf(p5);
            Console.WriteLine($"Index of {p1.Name} with ID: {p1.Id} is {indexOfObject}");
            Console.WriteLine();

            Console.WriteLine("Using index property to get object p5 based on index 0");
            Person p = genericList[0];
            Console.WriteLine($"Object of index 0 is eequal to person 5 {p.Name} with ID: {p.Id}");

            Console.WriteLine("Clearing list!");
            genericList.Clear();
            Console.WriteLine($"Clearing list. Count should be zero: {genericList.Count}");
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void PrintOutAllPersonsInList(MySuperGeneric<Person> genericList)
        {
            foreach (Person p in genericList)
            {
                Console.WriteLine($"Id: {p.Id} Name: {p.Name} Gender: {p.Gender}");
            }
            Console.WriteLine();
        }
    }
}
