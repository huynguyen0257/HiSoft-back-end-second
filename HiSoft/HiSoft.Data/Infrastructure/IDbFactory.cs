using System;
using System.Collections.Generic;
using System.Text;

namespace HiSoft.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HiSoftDbContext Init();
    }
}
