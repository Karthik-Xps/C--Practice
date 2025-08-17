// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using C__Practice_Problems;

//Palindrome pal_obj = new Palindrome();
//Console.WriteLine(pal_obj.IsPalindrome("GADAG"));

//NonRepeatingChar nonRepChar= new NonRepeatingChar();
//Console.WriteLine(nonRepChar.NonRepchar("Hello"));

//Anagram checkAnagram = new Anagram();
//Console.WriteLine(checkAnagram.IsAnagram("Listen","Silent"));

//Duplicate checkduplicate = new Duplicate();
//Dictionary<char, int> duplicates = checkduplicate.CountDuplicates("Hello World");
////List<char> duplicateChars = new List<char>();
//foreach (var i in duplicates)
//{
//    if (i.Value > 1)
//    {
//        Console.WriteLine($"{i.Key}");
        
//    }
//}

//Compress compressobj = new Compress();
//Console.WriteLine(compressobj.CompressString("aaabbbcccddeeeffgggghhhiiijjjkkklllmmmnnnooo"));

Rotation rotationobj = new Rotation();
Console.WriteLine(rotationobj.IsRotation("abcde", "prtv"));