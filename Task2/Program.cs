// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine ("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());


string st = number.ToString();
if (st.Length >= 3) {
    Console.WriteLine (st[2]);
    }
    else {
        Console.WriteLine ("no 3d number");
    }

//Console.WriteLine(st[1]);