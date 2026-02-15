using System;
using System.Reflection;

static void table()
{
	for (int i = 0; i < 34; i++)
	{
		for (int j = 0; j < 16; j++)
		{
			if (i == 0 || i == 11 || i == 22 || i == 33 || j == 0 || j == 5 || j == 10 || j == 15)
			{
				Console.SetCursorPosition(i, j);
				Console.Write("-");
			}
		}
	}
}
static void xxoo(int startndexi, int starindexj,int stopindexi, int stopindexj,char xo)
{
    for (int i = startndexi; i < stopindexi; i++)
    {
        for (int j = starindexj; j < stopindexj; j++)
        {
			Console.SetCursorPosition(i, j);
			if(xo=='x')
				Console.ForegroundColor = ConsoleColor.Red;
			else
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(xo);
        }
    }
}
static void game()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    table();
    char xo = 'o';
    int[] Arr = new int[9];
    for (int i = 0; i < 10; i++)
    {
	    if(i%2==0)
	    {
	    	Console.ForegroundColor = ConsoleColor.Red;
	    	xo = 'x';
	    }
	    else
	    {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
	    	xo = 'o';
        }
	    Console.SetCursorPosition(50, i+2);
	    Console.WriteLine("enter index from 1 till 9");
        Console.SetCursorPosition(50, i + 3);
        int index=int.Parse(Console.ReadLine());
        switchh(index, xo);
        int stop=0;
        stop = iffinish(index, xo, Arr);
            stop=iffinish(index,xo,Arr);
            if (stop == 1)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Thread.Sleep(10);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Thread.Sleep(10);
                } 
                Console.SetCursorPosition(45, 10);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("x is win!!!!!!!");
                Thread.Sleep(3000);
                i = 10;
            }
            else
                if (stop == 2)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Thread.Sleep(10);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    Thread.Sleep(10);
                }
                Console.SetCursorPosition(45, 10);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("o is win!!!!!!!");
                Thread.Sleep(3000);
                i = 10;
            }
        switchh(index, xo);
    }
}
static void switchh (int index,char xo)
{
    switch (index)
    {
        case 1:
            xxoo(1, 1, 11, 5, xo);
            break;
        case 2:
            xxoo(12, 1, 22, 5, xo);
            break;
        case 3:
            xxoo(23, 1, 33, 5, xo);
            break;
        case 4:
            xxoo(1, 6, 11, 10, xo);
            break;
        case 5:
            xxoo(12, 6, 22, 10, xo);
            break;
        case 6:
            xxoo(23, 6, 33, 10, xo);
            break;
        case 7:
            xxoo(1, 11, 11, 15, xo);
            break;
        case 8:
            xxoo(12, 11, 22, 15, xo);
            break;
        case 9:
            xxoo(23, 11, 33, 15, xo);
            break;
    }
}
static int iffinish(int index, char xo, int[] arr )
{
    if (xo == 'x')
        arr[index-1] = 1;
    else
        arr[index-1] = 2;
    if (arr[0] == 1 && arr[1] == 1 && arr[2] == 1 || arr[3] == 1 && arr[4] == 1 && arr[5] == 1 || arr[6] == 1 && arr[7] == 1 && arr[8] == 1 || arr[0] == 1 && arr[3] == 1 && arr[6] == 1 || arr[1] == 1 && arr[4] == 1 && arr[7] == 1 || arr[2] == 1 && arr[5] == 1 && arr[8] == 1 || arr[0] == 1 && arr[4] == 1 && arr[8] == 1 || arr[2] == 1 && arr[4] == 1 && arr[6] == 1)
        return 1;
    if (arr[0] == 2 && arr[1] == 2 && arr[2] == 2 || arr[3] == 2 && arr[4] == 2 && arr[5] == 2 || arr[6] == 2 && arr[7] == 2 && arr[8] == 2 || arr[0] == 2 && arr[3] == 2 && arr[6] == 2 || arr[1] == 2 && arr[4] == 2 && arr[7] == 2 || arr[2] == 2 && arr[5] == 2 && arr[8] == 2 || arr[0] == 2 && arr[4] == 2 && arr[8] == 2 || arr[2] == 2 && arr[4] == 2 && arr[6] == 2)
        return 2;
    return 3;
}
//main
int nextgame;
do
{
    game();
    nextgame = 0;
    
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("for next game press 1");
    nextgame = int.Parse(Console.ReadLine());
}
while (nextgame == 1);
