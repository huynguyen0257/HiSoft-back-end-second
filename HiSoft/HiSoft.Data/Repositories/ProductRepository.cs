using HiSoft.Data.Infrastructure;
using HiSoft.Model;
using System;
using System.Collections.Generic;
using System.Text;
using VAS.Data.Infrastructure;

namespace HiSoft.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
