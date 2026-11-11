int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int SumSegment(int start, int end)
{
    int segmentSum = 0;
    for(int i = start; i < end; i++)
    {
        Thread.Sleep(100);
        segmentSum += array[i];
    }
    return segmentSum;
}

int sum1 = 0;
int sum2 = 0;
int sum3 = 0;
int sum4 = 0;
int threadSum = 4;
var startTime = DateTime.Now;
int segementLength = array.Length / threadSum;
Thread[] threads = new Thread[threadSum];

threads[0] = new Thread(() => { sum1 = SumSegment(0, segementLength); });
threads[1] = new Thread(() => { sum2 = SumSegment(segementLength, 2 * segementLength); } );
threads[2] = new Thread(() => { sum3 = SumSegment(2 * segementLength, 3 * segementLength); } );
threads[3] = new Thread(() => { sum4 = SumSegment(3 * segementLength, array.Length); } );

foreach(var thread in threads )
{
    thread.Start();
}

foreach(var thread in threads )
{
    thread.Join();
}
var endTime = DateTime.Now;
var timeSpand = endTime - startTime;

Console.WriteLine($"The sum is {sum1 + sum2 + sum3 + sum4}");
Console.WriteLine($"The time it takes: {timeSpand.TotalMilliseconds}");


