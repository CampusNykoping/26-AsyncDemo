using System.Diagnostics;

var sw = new Stopwatch();

sw.Start();
var task1 = File.ReadAllTextAsync(@"../../../TextFile1.txt");
var task2 = File.ReadAllTextAsync(@"../../../TextFile2.txt");
var task3 = File.ReadAllTextAsync(@"../../../TextFile3.txt");
var task4 = File.ReadAllTextAsync(@"../../../TextFile4.txt");
sw.Stop();
var elapsed = sw.ElapsedMilliseconds;
Console.WriteLine("Declaed tasks. Elapsed time: {0}", elapsed);

Console.WriteLine("Doing some work...");

sw.Reset();
sw.Start();
var tasks = new Task[] { task1, task2, task3, task4 };
sw.Stop();
elapsed = sw.ElapsedMilliseconds;
Console.WriteLine("Declared tasks array. Elapsed time: {0}", elapsed);

sw.Reset();
sw.Start();
Console.WriteLine("Wait for tasks to complete");
Task.WaitAll(tasks);
sw.Stop();
elapsed = sw.ElapsedMilliseconds;
Console.WriteLine("Waited for taks. Elapsed time: {0}", elapsed);

var content1 = await task1;
var content2 = await task2;
var content3 = await task3;
var content4 = await task4;

Console.WriteLine("content1 length: {0}", content1.Length);
Console.WriteLine("content2 length: {0}", content2.Length);
Console.WriteLine("content3 length: {0}", content3.Length);
Console.WriteLine("content4 length: {0}", content4.Length);


Console.ReadKey();