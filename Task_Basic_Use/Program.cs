
/*Task task = new Task(Work);
task.Start();*/

Task.Run(Work);


Console.ReadLine();
void Work()
{
    Console.WriteLine("I Love SnowFox");
}