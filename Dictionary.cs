using System;
using System.Collections.Generic;

// Collection
// - List
// - HashSet 
// - Dictionary


class MyApp {
    static void Main() {
        Dictionary<string, int> users = new Dictionary<string, int>() {
            {"taguchi", 50 },
            {"fkoji", 80},
        };
        users.Add("CSharpLesson", 40);
        Console.WriteLine(users["fkoji"]); // 80
        users["taguchi"] = 60;
        foreach (KeyValuePair<string, int> user in users) {
            Console.WriteLine($"{user.Key}:{user.Value}");
        }
    }
}