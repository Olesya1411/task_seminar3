// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



        public void Run()
        {
            int[] numbers = ArrayHelper.CreateIntArrayInRange(10, 1, 10);

            Console.WriteLine(string.Join("; ", numbers));

            PrintLastItem(numbers);
        }
        public void PrintLastItem(int[] numbers)
        {
            if(numbers.Length == 0)
                return;

            Console.Write($"{numbers.Last()} ");
            PrintLastItem(numbers.Take(numbers.Length - 1).ToArray());
        }