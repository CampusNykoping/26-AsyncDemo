using System.Diagnostics;

var sw = new Stopwatch();

sw.Start();


var count = await Method1();
await Method2();
Method3(count);

Console.ReadKey();


static async Task<int> Method1()
{
    int count = 0;

    await Task.Run(() =>
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(" Method 1");
            
            // Gör någnting
            count++;
        }

    });
    await Task.Delay(100);

    return count;
}

static async Task Method2()
{
    for (int i = 0; i < 20; i++)
    {
        Console.WriteLine(" Method 2");
        await Task.Delay(100);
    }
}
static void Method3(int count)
{
    Console.WriteLine($"Total count is {count}");
}