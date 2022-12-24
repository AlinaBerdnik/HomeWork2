{
            string a = Console.ReadLine();
            if (a.Length >= 3)
            {
                char[] cen_mas = new char[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    cen_mas[i] = a[i];
                }
                Console.WriteLine(cen_mas[2]);
            }
            else
            {
                Console.WriteLine("Третьего числа нет");
                Console.ReadLine();
            }
}
