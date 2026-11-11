
void WriteThreadId()
{
    for(int i = 0; i < 100; i++)
    {
        // Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine(Thread.CurrentThread.Name);
        Thread.Sleep(50);
    }
   
}

// 创建线程并启动
Thread thread1 = new Thread(WriteThreadId);
Thread thread2 = new Thread(WriteThreadId);

// 为线程命名
thread1.Name = "thread1";
thread2.Name = "thread2";
Thread.CurrentThread.Name = "Main Thread";

// 设置线程优先级
// thread1.Priority = ThreadPriority.Highest;

thread1.Start();
thread2.Start();
WriteThreadId();
