//Создание пустой коллекции
List<int> ints = new List<int>();
//2.
ints.Add(1);
ints.Add(10);
ints.Add(25);
ints.Add(17);
ints.Add(10);
foreach(int elem in ints)
{
    Console.Write($"{elem}\t");
}
Console.WriteLine();
ints.Add(30);
foreach (int elem in ints)
{
    Console.Write($"{elem}\t");
}
//3.Вставка элемента по указаному ин
Console.WriteLine();
ints.Insert(0, 500);
foreach (int elem in ints)
{
    Console.Write($"{elem}\t");
}
//4.Добавления в список одномерного массива
Console.WriteLine();
ints.AddRange(new[] { -5, 0, 14 });
foreach (int elem in ints)
{
    Console.Write($"{elem}\t");
}
//5. Определение количества элемента колекции
Console.WriteLine();
//int size=ints.Count;
//Console.WriteLine($"Текущее количество элементов = {size}");
Console.WriteLine($"Текущее количество элементов = {ints.Count}");
//6.Определение индекса элемента со значение 25
Console.WriteLine();
Console.WriteLine($"Индекса элемента со значением 25 = {ints.IndexOf(25)}");
//7.Удаление из колекции первого входа элемента со значением 10
ints.Remove(10);
foreach (int elem in ints)
{
    Console.Write($"{elem}\t");
}
//8. Удаление из коллекции элемента с указанным индексом 
Console.WriteLine();
ints.Remove(2);
foreach (int elem in ints)
{
    Console.Write($"{elem}\t");
}
Console.ReadLine();