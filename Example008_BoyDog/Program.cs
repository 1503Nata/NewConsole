int distans = 10000;
int firstfrendspeed = 1;
int secondfrendspeed = 2;
int dogspeed = 5;
int frend = 2;

int count = 0; 

while (distans > 10)
  {
    if (frend == 1)
    time = distans/(firstfrendspeed + dogspeed);
    frend = 2;
    count = count+1;
  }
  {
    if (frend == 2)
    time = distans/(secondfrendspeed - dogspeed);
    frend = 1;
    count = count+1;
  }

  Console.Write("Coбака пробежала", count, "раз");
  Console.WriteLine(count);