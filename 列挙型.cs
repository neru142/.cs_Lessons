using System;

// 列挙型

enum Direction {
    Stay = 1,// 0 = を付けると指定できる
    Right,// 1
    Left// 2
}


class MyApp{
    static void Main() {
        Direction dir = Direction.Right;
        Console.WriteLine((int)Direction.Right);

        switch (dir) {
            case Direction.Stay:
                // そのまま
                break;
            case Direction.Right:
                // 右へ
                break;
            case Direction.Left:
                // 左へ
                break;
        }
    }
}