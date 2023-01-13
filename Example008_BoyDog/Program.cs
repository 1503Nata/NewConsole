int distans = 10000;
int firstfrendspeed = 1;
int secondfrendspeed = 2;
int dogspeed = 5;
int frend = 2;
int time = 0;

int count = 0; 

while (distans > 1000)
{
      if (frend == 1)
     { time = distans/(firstfrendspeed + dogspeed);
      distans = distans - (firstfrendspeed + secondfrendspeed)*time;
      frend = 2;
      }      
  
      if (frend == 2)
     {  time = distans/(secondfrendspeed + dogspeed);
      distans = distans - (firstfrendspeed + secondfrendspeed)*time;
      frend = 1;
      }
count = count+1;
}

Console.Write("Coбака пробежала ");
Console.WriteLine( count );