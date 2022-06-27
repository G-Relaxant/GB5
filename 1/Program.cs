/*
bool Check(int a, int b)
{
    return a == b;
}
*/


/*
int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}
PrintArray(array);
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        sumPositive += array[i];
    else
        sumNegative += array[i];    
}

Console.WriteLine($"Сумма положительных = {sumPositive}, сумма отрицательных = {sumNegative}");

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/

/*
int[] array = new int[32];
FillArray(array);
PrintArray(array);
InverseArray(array);
Console.WriteLine();
PrintArray(array);

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length)
            Console.Write(", ");
        else
            Console.Write("]");
    }
}

void InverseArray(int[] c)
{
    for(int i = 0; i < c.Length; i++)
    {
        c[i] = c[i] * -1;
    }
}
*/

/*    // Играемся с массивами
//int size = InputArrayData("Input array size: ");         // Вариант с задаваемым массивом из консоли
//int[] array = new int[size];                             // Вариант с задаваемым массивом из консоли
//int[] array = new int[24];                               // Вариант с заданным массивом
int[] array = {2, 4, 3, 5, 22, 43, 81, 12, 32, 7};       // Вариант с заданным и заполненным массивом
Console.Write("Input number for compare: ");
int number = Convert.ToInt32(Console.ReadLine());
//FillArrayConsole(array);                                 // Вариант с заполнением массива из консоли
//FillArrayRandom(array);                                  // Вариант со случайным авто заполнением массива
Console.WriteLine();
PrintArray(array);
Console.WriteLine("Your compare number: " + number);
bool answer = SearchAndCompare(array);                  //1 variant
//bool answer = false;                                    //2 variant - не работает
//SearchAndCompare(answer, array);                        //2 variant - не работает
Console.Write("Answer: " + answer);

void FillArrayRandom(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-32, 33);
    }
}

void FillArrayConsole(int[] f)
{
    for(int i = 0; i < f.Length; i++)
    {
        f[i] = InputArrayData("Введите значение ячейки: ");
    }
}

void PrintArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}

bool SearchAndCompare(int[] c)
{
    bool ans = false;
    for(int i = 0; i < c.Length; i++)
    {
        if(c[i] == number)
            ans = true;
            //break;   //так не работает
    }
    return ans;
}

void SearchAndCompare(bool d, int[] e)        // Не работает
{
    for(int i = 0; i < e.Length; i++)
    {
        if(e[i] == number)
            d = true;
            //break;   //так не работает
    }
}

int InputArrayData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
*/


/*        // Массив из 123 чисел
int[] array = new int[InputArrayData("Input array size: ")];
FillArrayRandom(array);
PrintArray(array);
int answer = CountFilterNumbers(array);
Console.Write("Answer: " + answer);



int InputArrayData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 124);
    }
}

void PrintArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}

int CountFilterNumbers(int[] c)
{
    int count = 0;
    for(int i = 0; i < c.Length; i++)
    {
        if(c[i] > 9 && c[i] < 100)
            count++;
    }
    return count;
}
*/



int[] array = new int[InputArrayData("Input array size: ")];
FillArrayRandom(array);
PrintArray(array);
int sizeSecondArray = 0;
if(array.Length % 2 == 0)
{
    sizeSecondArray = array.Length / 2;
}
else
{
    sizeSecondArray = array.Length / 2 + 1;
}
int[] array2 = new int[sizeSecondArray];
MultiplicationAndFillArraySecond(array, array2);
PrintArray(array2);

int InputArrayData(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(1, 10);
    }
}

void MultiplicationAndFillArraySecond(int[] c, int[] d)
{
    if(c.Length % 2 == 0)
    {
        int j = c.Length - 1;
        int k = 0;
        for(int i = 0; i < c.Length / 2; i++)
        {
            d[k] = c[i] * c[j];
            k++;
            j--;
        }
    }
    else
    {
        int j = c.Length - 1;
        int k = 0;
        for(int i = 0; i < c.Length / 2; i++)
        {
            d[k] = c[i] * c[j];
            k++;
            j--;
        }
        d[k] = c[k];
    }
}    

void PrintArray(int[] b)
{
    Console.Write("[");
    for(int i = 0; i < b.Length; i++)
    {
        Console.Write(b[i]);
        if(i < b.Length - 1)
            Console.Write(", ");
        else
            Console.WriteLine("]");
    }
}