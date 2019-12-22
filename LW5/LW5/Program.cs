using System;

namespace LW5
{
    class Program
    {
        enum Type:byte
        {
            B,
            C
        }
        struct Agro
        {
            public string name;
            public Type type;
            public int sqare;
            public byte productivity;
        }
        static void Main(string[] args)
        {
            Agro[] agros = new Agro[50];
            DateTime[] dateTimes = new DateTime[50];
            string [] explainer = new string[50];
            byte datepos = 0;
            agros[0].name = "Соя"; agros[0].sqare = 13000; agros[0].productivity = 45; agros[0].type = Type.B;
            agros[1].name = "Чумиза"; agros[1].sqare = 8000; agros[1].productivity = 17; agros[1].type = Type.C;
            agros[2].name = "Рис"; agros[2].sqare = 25650; agros[2].productivity = 24; agros[2].type = Type.C;
            byte pos = 3;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1)Просмотр таблицы\n2)Добавить запись\n3)Удалить запись\n4)Обновить запись\n5)Поиск записей\n6)Просмотреть лог\n7)Выход");
                string inputanswer = Console.ReadLine();
                switch (inputanswer)
                {
                    case "1":
                        CC();
                        for (int i=0; i<pos; i++)
                        {
                            Console.WriteLine($"{agros[i].name, -20}|{agros[i].type}|{agros[i].sqare, -10}|{agros[i].productivity, -5}");
                        }
                        CR();
                        CC();
                        break;
                    case "2":
                        CC();
                        Console.WriteLine("Введите имя");
                        agros[pos].name = Console.ReadLine();
                        Console.WriteLine("Введите тип");
                        agros[pos].type = (Type)Enum.Parse(typeof(Type), Console.ReadLine());
                        Console.WriteLine("Введите площадь");
                        agros[pos].sqare = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите урожайность");
                        agros[pos].productivity = byte.Parse(Console.ReadLine());
                        dateTimes[datepos] = DateTime.Now;
                        string addrec = agros[pos].name;
                        explainer[datepos] = $"добавлена запись \"{addrec}\""; 
                        datepos++;
                        pos++;
                        //CR();
                        CC();
                        break;
                    case "3":
                        CC();
                        Console.WriteLine("Введите номер удаляемой записи");
                        byte remnum = byte.Parse(Console.ReadLine());
                        string remrec = agros[remnum].name;
                        explainer[datepos] = $"удалена запись \"{remrec}\"";
                        for (int i=remnum; i < pos; i++)
                        {
                            agros[i].name = agros[i + 1].name;
                            agros[i].sqare = agros[i + 1].sqare;
                            agros[i].productivity = agros[i].productivity;
                        }
                        pos--;
                        dateTimes[datepos] = DateTime.Now;
                        datepos++;
                        CR();
                        CC();
                        break;
                    case "4":
                        CC();
                        Console.WriteLine("Введите номер редактируемой записи");
                        byte number = byte.Parse(Console.ReadLine());
                        string upderec = agros[number].name;
                        Console.WriteLine("Введите новое имя");
                        agros[number].name = Console.ReadLine();
                        Console.WriteLine("Введите новый тип");
                        agros[number].type = (Type)Enum.Parse(typeof(Type), Console.ReadLine());
                        Console.WriteLine("Введите новую площадь");
                        agros[number].sqare = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите новую урожайность");
                        agros[number].productivity = byte.Parse(Console.ReadLine());
                        dateTimes[datepos] = DateTime.Now;
                        explainer[datepos] = $"обновлена запись \"{upderec}\"";
                        datepos++;
                        //CR();
                        CC();
                        break;
                    case "5":
                        CC();
                        Console.WriteLine("Введите минимальную площадь");
                        int minsqare = int.Parse(Console.ReadLine());
                        for(int i=0; i<pos; i++)
                        {
                            if (agros[i].sqare > minsqare)
                            {
                                Console.WriteLine($"{agros[i].name, -20}|{agros[i].type}|{agros[i].sqare, -10}|{agros[i].productivity, -5}");
                            }
                        }
                        CR();
                        CC();
                        break;
                    case "6":
                        CC();
                        TimeSpan longestinaction = dateTimes[1].Subtract(dateTimes[0]);
                        for (int i=0; i<datepos; i++)
                        {
                            Console.WriteLine($"{dateTimes[i].Hour}:{dateTimes[i].Minute}:{dateTimes[i].Second} - {explainer[i]} ");
                            if ((dateTimes[i + 1].Subtract(dateTimes[i])) > longestinaction)
                            {
                                longestinaction = dateTimes[i + 1].Subtract(dateTimes[i]);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"{longestinaction.Hours}:{longestinaction.Minutes}:{longestinaction.Seconds} - Самый долгий период бездействия пользователя");
                        CR();
                        CC();
                        break;
                    case "7":
                        flag = false;
                        break;
                    default:
                        CC();
                        break;
                }
            }
        }
        static void CC()
        {
            Console.Clear();
        }
        static void CR()
        {
            Console.ReadKey();
        }
    }
}
