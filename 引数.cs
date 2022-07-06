using System;

class MyApp
{
    //static void SayHi(string name)
    //{
    //    Console.WriteLine($"hi!{name}");
    //}

    static void SayHi(string name ,int age = 23)
    {
        Console.WriteLine($"hi!{name} {age}");
    }

    static void Main()
    {
        SayHi("Tom",30);//tom 30
        SayHi("Bob");//bob 30
        SayHi(age: 26, name: "Steve"); //steve 26

    }
}