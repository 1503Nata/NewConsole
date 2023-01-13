int a = 6;
int b = 10;
int c = 4;
int d = 7;
int e = 9;

int min = a;

if (a < min) min = a;
if (b < min) min = b;
if (c < min) min = c;
if (d < min) min = d;
if (e < min) min = e;

Console.Write("min = ");
Console.Write(min);