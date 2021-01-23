using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will add new projects");

            MyDictionary<int, string> myProjects = new MyDictionary<int, string>();
            myProjects.Add(100, "Project1");
            myProjects.Add(101, "Project2");
            myProjects.Add(103, "Project3");
            myProjects.Add(110, "Project6");
            myProjects.Add(120, "Project80");

            Console.WriteLine("--------");

    }
}
