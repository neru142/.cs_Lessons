using System;
using CsharpLessonspace;

// 名前空間

namespace CsharpLessonspace {
    class User {
        public void SayHi() {
            //Console.WriteLine("hi!");
            System.Console.WriteLine("hi!");
        }
    }
}


class MyApp{
    static void Main() {
        //CsharpLessonspace user = new CsharpLessonspace.User();
        User user = new User();
        user.SayHi();
    }
}