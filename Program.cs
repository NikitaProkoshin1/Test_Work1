string[] arrayone = new string[11] { "hello", "2", "world", ":-)", "789", "21", "-2", "computer science", "USA", "MineCraft", "Kazahstan" };
string[] arraytwo = new string[arrayone.Length];
void ArrayWith(string[] arrayone, string[] arraytwo)// метод вывбора >3 элементов
{
    int count = 0;
    for (int i = 0; i < arrayone.Length; i++)
    {
        if (arrayone[i].Length <= 3)
        {
            arraytwo[count] = arrayone[i];
            count++;
        }
    }
}
void PrintArray(string[] array)// метод печати
{
    Console.WriteLine("-Результат");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }

}
ArrayWith(arrayone, arraytwo);
PrintArray(arraytwo);
