int a = 5;
int b = 7;
int a2 = 2;
int b2 = 10;
int a3 = -9;
int b3 = -3;

int max = a;
int max2 = a2;
int max3 = a3;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( a2 > max2 ) max2 = a2;
if ( b2 > max2 ) max2 = b2;
if ( a3 > max3 ) max3 = a3;
if ( b3 > max3 ) max3 = b3;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("max2 = ");
Console.WriteLine(max2);

Console.Write("max3 = ");
Console.WriteLine(max3);
