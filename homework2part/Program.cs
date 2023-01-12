// See https://aka.ms/new-console-template for more information
// ввод данных
Console.WriteLine("Eneter N");
int n = Convert.ToInt32(Console.ReadLine());

// сгенерировать массив случайных чисел
int[] nums = new int[n];
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 26);
}

// посчитать кол-во четных и не четных
int oddCount = 0;
int evenCount = 0;
for(int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        evenCount++;
    }
    else
        oddCount++;
}

// разложить случайные числа в отдельные массивы
int[] evenNums = new int[evenCount];
int[] oddNums = new int[oddCount];
evenCount = 0;
oddCount = 0;
for (int i =0; i < nums.Length;i++)
{
    if (nums[i] % 2 == 0)
    {
        evenNums[evenCount] = nums[i];
        evenCount++;
    }
    else
    {
        oddNums[oddCount] = nums[i];
        oddCount++;
    }
}

// вывод на экран случайных чисел в массивах четных/нечетных
Console.WriteLine();
Console.WriteLine("Even: ");
for (int i = 0; i < evenNums.Length; i++)
{
    Console.Write(evenNums[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Odd: ");
for (int i = 0; i < oddNums.Length; i++)
{
    Console.Write(oddNums[i] + " ");
}

// трансформируем случайные числа в буквы
char[] abc = new [] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

char[] oddChars = new char[oddNums.Length];
for(int i = 0; i < oddNums.Length; i++)
{
    oddChars[i] = abc[oddNums[i] - 1];
}

char[] evenChars = new char[evenNums.Length];
for (int i = 0; i < evenNums.Length; i++)
{
    evenChars[i] = abc[evenNums[i] - 1];
}

// заменить определенные буквы на буквы в верхнем регистре
int evenCharsCount = 0;
for (int i = 0; i < evenChars.Length; i++)
{
    if (evenChars[i] == 'a' ||
        evenChars[i] == 'e' ||
        evenChars[i] == 'i' ||
        evenChars[i] == 'd' ||
        evenChars[i] == 'h' ||
        evenChars[i] == 'j')
    {
        evenChars[i] = char.ToUpper(evenChars[i]);
        evenCharsCount++;
    }
}

int oddCharsCount = 0;
for (int i = 0; i < oddChars.Length; i++)
{
    if (oddChars[i] == 'a' ||
        oddChars[i] == 'e' ||
        oddChars[i] == 'i' ||
        oddChars[i] == 'd' ||
        oddChars[i] == 'h' ||
        oddChars[i] == 'j')
    {
        oddChars[i] = char.ToUpper(oddChars[i]);
        oddCharsCount++;
    }
}

// сравниваем количество элементов в массивах в верхенем регистре больше 
Console.WriteLine();
Console.WriteLine();
if (evenCharsCount > oddCharsCount)
{
    Console.WriteLine("Even Chars: " + evenCharsCount);
}
else if (evenCharsCount < oddCharsCount)
{
    Console.WriteLine("Odd Chars Count: " + oddCharsCount);
}
else
{
    Console.WriteLine("Even Chars: " + evenCharsCount);
    Console.WriteLine("Odd Chars Count: " + oddCharsCount);
}

// вывод результата на экран
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Even Chars: ");
for (int i = 0; i < evenChars.Length; i++)
{
    Console.Write(evenChars[i] + " ");

}
Console.WriteLine();
Console.WriteLine("Odd Chars: ");

for (int i = 0; i < oddChars.Length; i++)
{
    Console.Write(oddChars[i]+ " ");

}

Console.ReadKey();






