using TemplateRestAPI.IServices;
using TemplateRestAPI.Models.Common;
using TemplateRestAPI.Models.Data;

namespace TemplateRestAPI.Services
{
    public class AccountService : IAccountService
    {
        public Task<GenericResult<AccountDTO>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
