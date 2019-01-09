using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class LazySingletonThreadSafe
    {
        private static readonly LazySingletonThreadSafe instance = new LazySingletonThreadSafe();
        public string dbConnection = "db connection";

        private LazySingletonThreadSafe()
        {
        }

        public static LazySingletonThreadSafe GetInstance()
        {
            return instance;
        }
    }
}
