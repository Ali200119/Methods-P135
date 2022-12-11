#region Task 1

//Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//IsDivide(int.Parse(Console.ReadLine()));

//static void IsDivide (int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine($"{n} is divisible by 3 and 7");
//    }

//    else
//    {
//        Console.WriteLine($"{n} is not divisible by 3 and 7");
//    }
//}

#endregion

#region Task 2

//n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//Sum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

//static void Sum(int n, int m)
//{
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        Console.WriteLine(n + m);
//    }
//}

#endregion

#region Task 3

//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//Sum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

//static void Sum(int n, int m)
//{
//    int result = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            result += i;
//        }
//    }

//    Console.WriteLine(result);
//}

#endregion

#region Task 4

//Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

//Console.WriteLine(Sum(array));

//static int Sum(int[] array)
//{
//    int sum = 0;

//    foreach (var item in array)
//    {
//        if (item % 2 == 1)
//        {
//            sum += item;
//        }
//    }

//    return sum;
//}

#endregion

#region Task 5

//Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

//Console.WriteLine(Count(array));

//static int Count(int[] array)
//{
//    int count = 0;

//    foreach (var item in array)
//    {
//        if (item % 2 == 0)
//        {
//            count ++;
//        }
//    }

//    return count;
//}

#endregion

#region Task 6

//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//Console.WriteLine(Count(n, m));

//static int Count(int n, int m)
//{
//    int count = 0;

//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1)
//		{
//			count++;
//		}
//	}

//	return count;
//}

#endregion

#region Task 7

//Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//Console.WriteLine(Sum(n, m));

//static int Sum(int n, int m)
//{
//    int sum = 0;

//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			sum += i;
//		}
//	}

//	return sum;
//}

#endregion

#region Task 8

//Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//Console.WriteLine(Count(n, m));

//static int Count(int n, int m)
//{
//	int count = 0;

//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count++;
//		}
//	}

//	return count;
//}

#endregion

#region Task 9

//Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//Console.WriteLine(Check(int.Parse(Console.ReadLine())));

//static string Check(int number1)
//{
//    if (number1 == 1)
//    {
//        return $"{number1} is not a prime number and not a composite number";
//    }

//    else if (number1 < 1)
//    {
//        return "Please enter the correct number";
//    }

//    else
//    {
//        int count = 0;
//        int number2 = 1;


//        for (int i = number2; i <= number1; i++)
//        {
//            if (number1 % i == 0)
//            {
//                count++;
//            }
//        }

//        if (count == 2)
//        {
//            return $"{number1} is prime number";
//        }

//        else
//        {
//            return $"{number1} is composite number";
//        }
//    }
//}

#endregion

#region Task 10

//n ededinin faktorialini hesablamaq.

//Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));

//static int Factorial(int n)
//{
//    int result = 1;

//    for (int i = 1; i <= n; i++)
//    {
//        result *= i;
//    }

//    return result;
//}

#endregion