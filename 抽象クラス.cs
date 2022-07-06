using System;

// 抽象クラス(他のクラスに継承してもらうことを前提にしているクラスで、それ自身をインスタンス化することはできない)
// User -> Japanese, American

abstract class User {
    public abstract void SayHi();
}

class Japanese: User {
    public override void SayHi() {
        Console.WriteLine("こんにちは");
    }
}

class American : User {
    public override void SayHi() {
        Console.WriteLine("hi!");
    }
}

class MyApp{
    static void Main() {
        Japanese aki = new Japanese();
        aki.SayHi();
        American tom = new American();
        tom.SayHi();
    }
}