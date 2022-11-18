using TemplateRestAPI.Models.Common;
using TemplateRestAPI.Models.Data;

namespace TemplateRestAPI.IServices
{
    public interface IAccountService
    {
        Task<GenericResult<AccountDTO>> GetById(Guid id);
    }
}
