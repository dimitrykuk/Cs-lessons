Console.Clear();

int point1x = 0;
int point1y = 25;

int point2x = 0;
int point2y = 0;

int point3x = 70;
int point3y = 0;

Console.SetCursorPosition(point1x, point1y);
Console. WriteLine("+");
Console.SetCursorPosition(point2x, point2y);
Console. WriteLine("+");
Console.SetCursorPosition(point3x, point3y);
Console. WriteLine("+");

int xinter = (point1x + point2x)/2;
int yinter = (point1y + point2y)/2;
Console.SetCursorPosition(xinter, yinter);
Console. WriteLine("+");
int count = 0;
while (count < 10000)
{
    int n = new Random().Next(0,3);

    if (n == 0) 
    {
        xinter = (point1x + xinter)/2; 
        yinter = (point1y + yinter)/2;
    }
    
    if (n == 1) 
    {
        xinter = (point2x + xinter)/2; 
        yinter = (point2y + yinter)/2;
    }
    
    if (n == 2) 
    {
        xinter = (point3x + xinter)/2; 
        yinter = (point3y + yinter)/2;
    }
    

    Console.SetCursorPosition(xinter, yinter);
    Console. WriteLine("+");

    count++;
}