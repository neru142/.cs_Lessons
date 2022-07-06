using System;

class User
{
    private string name = "me!";// 基本的には private とか protected にしておいて必要な時だけメソッドを
    //プロパティ               // 通じてアクセスすることが安全なプログラムを書くために推奨されていたりします
    public string Name
    { // この中にフィールドにアクセスするための処理
        get { return this.name; }// 値を取得する処理を getter 値を設定する処理を setter 両方合わせてアクセサ
        set
        {
            if (value != "")
            {
                this.name = value;
            }
        }
    }
    //public string Name { get; set; } = "me";

    class MyApp
    {
        static void Main()
        {

            User user = new User();
            Console.WriteLine(user.Name);
            user.Name = "taguchi";
            Console.WriteLine(user.Name);
            user.Name = "";
            Console.WriteLine(user.Name);

        }
    }
}