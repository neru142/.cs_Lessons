using System;

class MyApp {

    static void Main(){
        Console.WriteLine("hello" + "world");

        // \n改行, \tタブ
        Console.WriteLine("hell\no wo\trld");

        var name = "taguchi";
        var score = 52.3;

        Console.WriteLine(string.Format("{0}[{1}]",name,score));//taguchi[52.3]

        Console.WriteLine($"{name}[{score}]");
        //10文字の幅で表示 -を付けると左詰め
        Console.WriteLine($"{name,-10}[{score,10}]");
        Console.WriteLine($"{name,-10}[{score + 25 ,10:0.00}]");
    }
}
