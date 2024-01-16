int n = 10;
int[] array = { 2, 4, 3, 22, 41, 6, 7, 13, 11, 8 };
int i = 0;

while(i < n)
{
    if(array[i] % 2 == 0) 
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}