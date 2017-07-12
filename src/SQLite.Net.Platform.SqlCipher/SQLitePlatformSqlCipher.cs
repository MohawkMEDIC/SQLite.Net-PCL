﻿using SQLite.Net.Interop;

namespace SQLite.Net.Platform.SqlCipher
{
    public class SQLitePlatformSqlCipher : ISQLitePlatform
    {
        public SQLitePlatformSqlCipher()
        {
            SQLiteApi = new SQLiteApiSqlCipher();
            StopwatchFactory = new StopwatchFactorySqlCipher();
            ReflectionService = new ReflectionServiceSqlCipher();
            VolatileService = new VolatileServiceSqlCipher();
        }

        public ISQLiteApi SQLiteApi { get; private set; }
        public IStopwatchFactory StopwatchFactory { get; private set; }
        public IReflectionService ReflectionService { get; private set; }
        public IVolatileService VolatileService { get; private set; }
    }
}
