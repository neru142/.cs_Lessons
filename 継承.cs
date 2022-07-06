using System;

// 継承
// User(親クラス、スーパークラス) -> AdminUser(子クラス、サブクラス)

class User
{
    public string name;
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
        tom.SayHi();

        AdminUser bob = new AdminUser("Bob");
        bob.SayHi();
        bob.SayHello();

    }
}