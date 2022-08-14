// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}
int ShowQ(int n)
{
int Q = n*n*n; 
return(Q);
}

int N = Prompt("Введите N : ");

for (int i=1; i <= N; i++)
{
System.Console.WriteLine(ShowQ(i));
}





