using Shopping.API.Repository.Contracts;

namespace Shopping.API.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IProductRepo ProductRepo { get; }

        Task<int> SaveChanges();
    }
}
