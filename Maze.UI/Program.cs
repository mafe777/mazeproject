
using maze.logic;
Console.WriteLine("----------MAZE----------");
Console.ForegroundColor = ConsoleColor.White;
var maze = new MyMaze(25,70);
Console.Write(maze);
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;


var yesornot = maze.CouldFindWayOut();

if (yesornot)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("¡ Se pudo salir del laberinto !");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red; ;
    Console.WriteLine("¡ No se pudo llegar al final del laberinto !");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine();
}