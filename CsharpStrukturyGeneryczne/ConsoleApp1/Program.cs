// C# Program to check whether the
// element is present in the List
// or not
using System;
using System.Collections;
using System.Collections.Generic;

class Geeks
{

    // Main Method
    public static void Main(String[] args)
    {

        // Creating an List<T> of String
        List<String> firstlist = new List<String>();

        // Adding elements to List
        firstlist.Add("Geeks");
        firstlist.Add("For");
        firstlist.Add("Geeks");
        firstlist.Add("GFG");
        firstlist.Add("C#");
        firstlist.Add("Tutorials");
        firstlist.Add("GeeksforGeeks");

        // Checking whether Java is present
        // in List or not
        Console.Write(firstlist.Contains("Java"));
        Console.ReadLine();
    }
}
