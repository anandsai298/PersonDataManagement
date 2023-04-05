// See https://aka.ms/new-console-template for more information
using PersonDataManagement;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace PersonDataManagement;
class program
{
    public static void Main(string[] args)
    {
        List<Person>list = new List<Person>();
        list.Add(new Person() { SSN = 1, Name = "ask1", Address = "fghj1", Age = 20 });
        list.Add(new Person() { SSN = 2, Name = "ask2", Address = "fghj2", Age = 30 });
        list.Add(new Person() { SSN = 3, Name = "ask3", Address = "fghj3", Age = 40 });
        list.Add(new Person() { SSN = 4, Name = "ask4", Address = "fghj4", Age = 50 });
        list.Add(new Person() { SSN = 5, Name = "ask5", Address = "fghj5", Age = 60 });
        list.Add(new Person() { SSN = 6, Name = "ask6", Address = "fghj6", Age = 25 });
        list.Add(new Person() { SSN = 7, Name = "ask7", Address = "fghj7", Age = 24 });
        list.Add(new Person() { SSN = 8, Name = "ask8", Address = "fghj8", Age = 29 });
        list.Add(new Person() { SSN = 9, Name = "ask9", Address = "fghj9", Age = 55 });
        list.Add(new Person() { SSN = 10, Name = "ask10", Address = "fgh10j", Age = 36 });
        Operations op = new Operations();
        Console.WriteLine("RetriveTopRecordsOfAge(top 2) :");
        op.RetriveTopRecordsOfAge(list);
        Console.WriteLine("RetriveAllRecordsOfAge (20 to 30) :");
        op.RetriveAllRecordsOfAge(list);
    }
}

