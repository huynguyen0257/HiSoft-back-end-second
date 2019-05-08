using HiSoft.Data.Infrastructure;
using HiSoft.Data.Repositories;
using HiSoft.Model;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace HiSoft.Service
{
    public interface IProductService
    {
        IQueryable<Product> GetProducts();
        IQueryable<Product> GetProducts(Expression<Func<Product, bool>> where);
        Product GetProduct(Guid id);
        void CreateProduct(Product Product);
        void UpdateProduct(Product Product);
        void DeleteProduct(Product Product);
        void Save();
    }   
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void CreateProduct(Product product)
        {
            _repository.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            _repository.Delete(product);
        }

        public Product GetProduct(Guid id)
        {
            return _repository.GetById(id);
        }

        public IQueryable<Product> GetProducts()
        {
            return _repository.GetAll();
        }

        public IQueryable<Product> GetProducts(Expression<Func<Product, bool>> where)
        {
            return _repository.GetMany(where);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void UpdateProduct(Product product)
        {
            var entity = _repository.GetById(product.Id);
            entity = product;
            _repository.Update(entity);
        }
    }
}
