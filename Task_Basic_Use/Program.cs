
/*Task task = new Task(Work);
task.Start();*/

var task = Task.Run(Work);
// 这其实是在阻塞主线程，然后等待任务执行完毕获取结果
// .WaitAll(task1, task2);
//int result = task.Result;
//Console.WriteLine($"This task result:{result}");

// 创建新的任务并传入上一个任务，可以获取上一个任务的结果进行处理
// 而不阻塞主线程
task.ContinueWith(t =>
{
    var result = t.Result;
    Console.WriteLine(result);
});

for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    Thread.Sleep(50);
}

Console.ReadLine();
int Work()
{
    Console.WriteLine("I Love SnowFox");
    Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
    int result = 100;
    return result;
}