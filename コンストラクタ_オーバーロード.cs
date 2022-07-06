using System;

// コンストラクタ

class User
{
    public string name;
    //public User() {
    //    this.name = "ME";
    //}

    public User(string name){
        this.name = name;
    }
    //public User()
    //{ //オーバーロード
    //    this.name = "nobody";
    //}

    public User():this("nobody"){ 
    }

    public void SayHi()
    {
        // Console.WriteLine($"hi {this.name}");
        Console.WriteLine($"hi {name}");
    }
}

class MyApp
{
    static void Main()
    {
        //User user = new User();// インスタンス
        //user.SayHi();

        User tom = new User("Tom");
        tom.SayHi();

        User user = new User();
        user.SayHi();

    }
}