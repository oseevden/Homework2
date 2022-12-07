
// int number = 0; 
//string text = "";
//text = Console.ReadLine(); 
//number = Convert.ToInt32(text);
//Console.WriteLine("Result: " + number * number);






// Первая задача (2) ДЗ
//int a = 5; 
//int b = 7; 
//Console.WriteLine((a > b) ? "{0} {1}" : "{1} {0}", a, b);

// Вторая задача (4) ДЗ

int a = 22;
int b = 3;
int c = 9;
int max;
int min;

if (a > b && a > c)
{
max = a;
min = (b < c) ? b : c;
}
else if (b > a && b > c)
{
max = b;
min = (a < c) ? a : c;
}
else
{
max = c;
min = (b < a) ? a : b;
}
Console.WriteLine (max);