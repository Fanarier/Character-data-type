//Символьный тип данных. Плотников Кирилл Андреевич 22-ИСП-2/2
//№варианта:16; Средний уровень 
//Введите массив символов из 11 элементов. Убрать лишние пробелы (более одного подряд).

Console.ForegroundColor = ConsoleColor.Yellow;

char[] mas = new char[11];
Random rand = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = (char)rand.Next(60, 128);
    Console.Write(mas[i] + "");
}
for (int i = 0; i < mas.Length; i++)
{
    int z = (int)mas[i];
    mas[i] = (char)z;
    Console.Write(mas[i] + "");
}

Console.ForegroundColor = ConsoleColor.Green;
