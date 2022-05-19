// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

string GetNumber ()
{
    return Console.ReadLine();
}


int CountNum(string str)
{
    return str.Length;
}

Console.WriteLine("Введите число: ");
int countNum = CountNum(GetNumber());

Console.WriteLine(countNum);


