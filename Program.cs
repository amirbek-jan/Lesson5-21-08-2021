using System;

class Program {

    static void Main() {
        // Первое ДЗ
        Console.Write("ВВедите размер массива: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значения массива:");
        int[] arr = new int[n];
        for (int i = 0; i < n; ++i) {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0], min = arr[0], sum = 0;
        for (int i = 0; i < n; ++i) {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
            sum += arr[i];


        }
        double arif = 1.0 * sum / arr.Length;
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Минимум: {min}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Ср.Ариф: {arif}");
        Console.Write("Нечётные числа: ");
        for (int i = 0; i < n; ++i)
            if (arr[i] % 2 != 0) {
                Console.Write($"{arr[i]} ");
            }

        // Второе ДЗ
        Console.Write("ВВедите размер массива: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значения массива:");
        int [] m = new int [n];
        int [] rez = new int [n];
        for (int i = 0; i < n; i++) {

            m[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; ++i) {
            rez[i] = m[m.Length - i - 1];
        }
        for (int i =0 ; i < n; ++i) {
            Console.Write($"{rez[i]} ");
        }

        // Третье ДЗ
        Console.Write("Введите размер массива: ");
        int.TryParse(Console.ReadLine(), out int n);
        Console.Write("Введите значения массива: ");
        int[] arr = new int [n];
        for (int i = 0; i < n; ++i) {
            arr[i] = int.Parse(Console.ReadLine());
        }
            Console.Write("массив: ");
            foreach (int i in arr) {
            Console.Write($"{i} ");}
        Console.Write("\nВведите count: ");
        int count = int.Parse(Console.ReadLine());
        Console.Write("Введите index: ");
        int index = int.Parse(Console.ReadLine());
        

        int[] newArr = new int[count];
        int newArrSize = 0;
        for (int i = index; i < Math.Min(count, n); ++i) {
            newArr[newArrSize++] = arr[i];
        }
        if (newArrSize < count) {
            int ostatok = count - newArrSize;
            for (int i = 0; i < ostatok; ++i) {
                newArr[newArrSize++] = 1;
            }
        }
        for (int i = 0; i < newArrSize; ++i) {
            Console.Write($"{newArr[i]} ");
        }
    }

}