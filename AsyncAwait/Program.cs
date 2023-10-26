Console.WriteLine(PerformAsyncOperation().Result);

static async Task<int> PerformAsyncOperation()
{
    Console.WriteLine("Асинхронная операция начата");
    await Task.Delay(2000);
        
    Console.WriteLine("Асинхронная операция завершена");

    return 42;
}