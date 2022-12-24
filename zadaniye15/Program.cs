{int input = int.Parse(Console.ReadLine());

            if (input > 0 & input < 6)
            {
                Console.WriteLine("Будний день");
            }
            else if (input >= 6 & input <= 7)
            {
                Console.WriteLine("Выходной");
            }
            else
            {
                Console.WriteLine("Нет такого дня");
            }
}          
