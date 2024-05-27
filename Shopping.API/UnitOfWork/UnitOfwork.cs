using Shopping.API.Data;
using Shopping.API.Repository.Contracts;

namespace Shopping.API.UnitOfWork
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfwork(ApplicationDbContext context, IProductRepo productRepo)
        {
            _context = context;
            ProductRepo = productRepo;
        }
        public IProductRepo ProductRepo { get; }

        public async Task<int> SaveChanges()
        {
         return await  _context.SaveChangesAsync();
        }

    }
}
