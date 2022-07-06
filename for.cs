using System;

class MyApp {

    static void Main(){
        // for
        // 0 - 9

        // continue それ以降の処理を中止して次のループへ
        // break
        for (int i = 0; i < 10; i++){
            /*if (i == 5){
                continue;
            }*/
            if (i == 5)
            {
                break;
            }
            Console.WriteLine(i);
    }
}
