using System;

class MyApp {

    static void Main(){
        //変数 :値の再代入が可能
        //定数 :値の再代入が不可能

        // 変数の型 変数名;
        //string msg;
        //msg = "Hello World";
        //string msg = "Hello World";

        ///const string msg = "Hello World";
        //定数はエラー
        //msg = "hello";


        // 文字列,文字
        // string, char
        string s = "hello";
        char c = 'a';

        // 整数値
        //byte ,short,int,long
        int i = 100;

        // 浮動小数点数
        // float, double
        double d = 114514.1919810;
        float f = 23.3f;

        // 論理値
        // bool -> true,false
        bool flag = true;

        //型推論
        var x = 5; // int
        var y = "world"; //string
    }
}
