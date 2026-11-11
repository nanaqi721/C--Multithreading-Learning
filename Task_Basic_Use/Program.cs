
/*Task task = new Task(Work);
task.Start();*/

var task = Task.Run(Work);
int result = task.Result;
Console.WriteLine($"This task result:{result}");

Console.ReadLine();
int Work()
{
    Console.WriteLine("I Love SnowFox");
    Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
    int result = 100;
    return result;
}