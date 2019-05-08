using HiSoft.Data;
using HiSoft.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace VAS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        HiSoftDbContext dbContext;

        public HiSoftDbContext Init()
        {
            return dbContext ?? (dbContext = new HiSoftDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
