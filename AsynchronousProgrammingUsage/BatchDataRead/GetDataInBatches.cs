namespace AsynchronousProgrammingUsage.BatchDataRead;

public class GetDataInBatches
{
    /// <summary>
    /// Dummy data
    /// This data usually we get from DB or API or files
    /// </summary>
    /// <param name="MinValue">The minimum value.</param>
    /// <param name="MaxValue">The maximum value.</param>
    /// <returns></returns>
    private IList<int> DummyData(int MinValue, int MaxValue)
    {
        //Preparing Dummy Data
        List<int> list = new List<int>();
        for (int i = MinValue; i <= MaxValue; i++)
        {
            list.Add(i);
        }
        return list;
    }


    public async IAsyncEnumerable<List<int>> Get(int offset, int limit)
    {
        //Suppose we are getting data from db
        var db = DummyData(1, 478);

        do
        {
            //We are preparing batch
            var list = db.Skip(offset).Take(limit).ToList();
            if (!list.Any())
            {
                Console.WriteLine("Reached to the end, Breaking from loop.");
                break;
            }
            await Task.Delay(1);
            offset += limit;
            yield return list;
        } while (true);
    }
}
