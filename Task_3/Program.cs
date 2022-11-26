Console.Clear();

Console.WriteLine("Введите день недели");
int a = int.Parse(Console.ReadLine());


if (a >=6 && a <= 7)
	Console.WriteLine("Выходной день");
if (a >= 1 && a <= 5)
	Console.WriteLine("Рабочий день");
if (a >= 8 || a <= 0)
Console.WriteLine("Такой день отсутствует в 7ми дневной неделе");