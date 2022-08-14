// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// и проверяет явл. ли оно палиндромом (14212 -> нет,12821 -> да)

int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}

int N = Prompt("Введите пятизначное число : ");
int GetNum()
{
int j = N % 10;
N=N/10;
return j;
}
int [] array = new int[5];
for (int i = 0; i < 5; i++)
{
    array[i]=GetNum();
}    
if(array[0]==array[4] && array[1]==array[3])
{
    System.Console.WriteLine("Это число является палиндромом");
}
else
{
    System.Console.WriteLine("Это число не является палиндромом");
}
