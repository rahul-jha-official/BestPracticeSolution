namespace AsynchronousProgrammingUsage.BatchDataRead;

public static class ReadingData
{
    public static async Task Read()
    {
        int offset = 0, limit = 100;
        int batch = 0;

        await foreach (var item in new GetDataInBatches().Get(offset: offset, limit: limit))
        {
            Console.WriteLine($"Reading Batch: {++batch}");
            Print(item);
            Console.WriteLine($"FinishedReading Batch: {batch}");
        }
    }

    public static void Print(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write($"{list[i]}{(i == list.Count - 1 ? "" : ",")} ");
        }
        Console.WriteLine();
    }
}
