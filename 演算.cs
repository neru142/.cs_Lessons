using System;

class MyApp {

    static void Main(){
        // + - * / %
        var x = 10; //int
        Console.WriteLine(x / 3);// 3
        Console.WriteLine(x % 3);// 1
        Console.WriteLine(x / 3.0);// 3.333...
        Console.WriteLine(x / (double)3);// 3.333...


        var z = 6;
        // z = z + 10;
        z += 10;

        // AND OR NOT
        //  &  || !
        var flag = true;
        Console.WriteLine(!flag);
    }
}
