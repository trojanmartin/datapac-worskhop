using System.Threading.Tasks;

namespace Workshop.Lowering;

public class AsyncTask
{
    public async Task Method()
    {
        await Task.Delay(500);
    }
}