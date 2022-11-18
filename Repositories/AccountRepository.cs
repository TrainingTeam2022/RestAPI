using TemplateRestAPI.DBContext;
using TemplateRestAPI.Entities;
using TemplateRestAPI.IRepositories;

namespace TemplateRestAPI.Repositories
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(DemoDbContext context) : base(context)
        {
        }
    }
}
