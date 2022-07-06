using System;

class MyApp {

    static void Main(){
        // 配列
        // var score_1 = 10;
        // var score_2 = 30;

        /*
        int[] scores = new int[3];
        scores[0] = 10;
        scores[1] = 30;
        scores[2] = 20;

        int[] scores = new int[] { 10, 30, 20 };
        int[] scores = { 10, 30, 20 };
        */

        var scores = new[] { 10, 30, 20 };
        scores[1] = 40;
        Console.WriteLine(scores[1]);
    }
}
