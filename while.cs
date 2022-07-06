using System;

class MyApp {

    static void Main(){
        // while
        // 0 - 9
        //var i = 0;
        var i = 100;

        while (i < 10) {
            Console.WriteLine($"loop:{i}");
            i++;
        }

        do {
            Console.WriteLine($"loop2:{i}");
            i++;
        }while (i < 10);
    }
}
