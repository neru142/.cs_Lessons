using System;

// アクセス修飾子
// - public どのクラスからでもアクセスが出来る
// - protected そのクラスおよび、そのクラスの派生クラスからのみアクセスが出来る
// - private そのクラスからのみアクセスが出来る

class User
{
    //public string name;
    //protected string name;
    private string name;
    public User(string name){
        this.name = name;
    }
    public virtual void SayHi()
    {
        // Console.WriteLine($"hi {this.name}");
        Console.WriteLine($"hi {name}");
    }
}

class AdminUser: User
{
    public AdminUser(string name) : base(name)
    {

    }
    public void SayHello()
    {
        Console.WriteLine($"hello {name}");
    }
    public override void SayHi() //override 親クラスのメソッドを上書きする
    {
        Console.WriteLine($"[admin] hi {name}");
    }
}
class MyApp
{
    static void Main() {

        User tom = new User("Tom");
        Console.WriteLine(tom.name);
        tom.SayHi();

        AdminUser bob = new AdminUser("Bob");
        bob.SayHi();
        bob.SayHello();

    }
}