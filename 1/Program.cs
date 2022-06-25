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


int[] array = new int[24];
Console.Write("Input number for compare: ");
int number = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(array);
Console.WriteLine("Your number: " + number);
bool answer = SearchAndCompare(array);    //1 variant
//bool answer = false;                        //2 variant
//SearchAndCompare(answer, array);            //2 variant
Console.Write("Answer: " + answer);

void FillArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(-32, 33);
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
            //break; //так не работает
    }
    return ans;
}

/*void SearchAndCompare(bool d, int[] e)
{
    for(int i = 0; i < e.Length; i++)
    {
        if(e[i] == number)
            d = true;
            //break; //так не работает
    }
}*/