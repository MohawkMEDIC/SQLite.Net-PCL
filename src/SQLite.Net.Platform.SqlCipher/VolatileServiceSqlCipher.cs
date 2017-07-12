using System.Threading;
using SQLite.Net.Interop;

namespace SQLite.Net.Platform.SqlCipher
{
    public class VolatileServiceSqlCipher : IVolatileService
    {
        public void Write(ref int transactionDepth, int depth)
        {
			Thread.VolatileWrite(ref transactionDepth, depth);
        }
    }
}
