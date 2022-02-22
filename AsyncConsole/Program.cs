
using System.Diagnostics;

var sw = new Stopwatch();
sw.Start();

// Alt 1: synkron körning
//f1();
//f2();
//f3();
//sw.Stop();
//var elapsed = sw.ElapsedMilliseconds;
//Console.WriteLine($"Synchronous - elapsed time: {elapsed} ms");

// Alt 2: parallell körning
sw.Restart();
Task.WaitAll(f1Async(), f2Async(), f3Async());
sw.Stop();
var elapsed = sw.ElapsedMilliseconds;
Console.WriteLine($"Asynchronous - elapsed time: {elapsed} ms");
Console.ReadKey();


#region Synkrona metoder
static void f1()
{
    Console.WriteLine("f1 called");
    Thread.Sleep(4000);
}

static void f2()
{
    Console.WriteLine("f2 called");
    Thread.Sleep(7000);
}

static int f3()
{
    Console.WriteLine("f3 called");
    Thread.Sleep(2000);
    return 1;
}
#endregion

#region Asynkrona metoder
static async Task f1Async()
{
    await Task.Delay(4000);
    Console.WriteLine("Asyncf1 called");
    
}

static async Task f2Async()
{
    await Task.Delay(7000);
    Console.WriteLine("Asyncf2 called");
    
}

static async Task<int> f3Async()
{
    await Task.Delay(2000);
    Console.WriteLine("Asyncf3 called");
   
    return 1;
 
}

#endregion