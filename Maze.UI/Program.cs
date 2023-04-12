
using maze.logic;
Console.WriteLine(" ----------MAZE----------");
Console.ForegroundColor = ConsoleColor.White;
var maze = new MyMaze(25,100);
Console.Write(maze);
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;


var yesornot = maze.CouldFindWayOut();

if (yesornot)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("you could get out of the maze :) ");
    Console.ForegroundColor = ConsoleColor.White;
   
}
else
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red; ;
    Console.WriteLine("sorry, you could not get out of the maze :( ");
    Console.ForegroundColor = ConsoleColor.White;
    
}