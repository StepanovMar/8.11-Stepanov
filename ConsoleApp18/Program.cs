    int зарплата;
    Random rand = new Random();
    int[,] arr = new int[12, 3];
    int[] рабочие = new int[12];
    int[] месяцы = new int[3];
    for (int i = 0; i < 12; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine("Введите зарплату " + (i + 1) + " работника за " + (j + 1) + " месяц");
            зарплата = int.Parse(Console.ReadLine());
            зарплата = rand.Next(1, 100);
            arr[i, j] = зарплата;
        }
    }
    зарплата = 0;
    for (int i = 0; i < 12; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(arr[i, j] + " ");
            рабочие[i] += arr[i, j];
            месяцы[j] += arr[i, j];
            зарплата += arr[i, j];
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Общая сумма, выплаченная за квартал всем работникам - " + зарплата);
    Console.WriteLine();
    Console.WriteLine("Зарплата, полученная за квартал каждым работником: ");
    for (int i = 0; i < 12; i++)
    {
        Console.WriteLine("Работник " + i + " получил: " + рабочие[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Общая зарплата всех работников за каждый месяц: ");
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Месяц " + j + " выплачено: " + месяцы[j] + " ");
    }