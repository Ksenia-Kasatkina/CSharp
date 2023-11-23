//  Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.WriteLine("Введите порядковый номер дня недели ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("Понедельник");
// }

// if (number == 2)
// {
//     Console.WriteLine("Вторник");
// }

// if (number == 3)
// {
//     Console.WriteLine("Среда");
// }

// if (number == 4)
// {
//     Console.WriteLine("Четверг");
// }

// if (number == 5)
// {
//     Console.WriteLine("Пятница");
// }

// if (number == 6)
// {
//     Console.WriteLine("Суббота");
// }

// if (number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// if ((number > 7) | (number < 1))
// {
//     Console.WriteLine("Нет такого дня недели");
// }

System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        System.Console.WriteLine("Пн");
        break;
    case 2:
        System.Console.WriteLine("Вт");
        break;
    case 3:
        System.Console.WriteLine("Ср");
        break;
    case 4:
        System.Console.WriteLine("Чт");
        break;
    case 5:
        System.Console.WriteLine("Пт");
        break;
    case 6:
        System.Console.WriteLine("Сб");
        break;
    case 7:
        System.Console.WriteLine("Вс");
        break;
    default:
        System.Console.WriteLine("Такого дня недели нет");
        break;
}