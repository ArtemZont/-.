using Domain.Interfaces;
using Domain.Models;
using DataAccess.Repositories;
using DataAccess.Interfaces;

namespace DataAccess.Wrapper
{
    public class RepositoryWrapper : Domain.Wrapper.IRepositoryWrapper
    {
        private WebShopContext _repoContext;
        private Domain.Interfaces.IUserRepository _user;
        public Domain.Interfaces.IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }
        }
        public RepositoryWrapper(WebShopContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public async Task Save()
        {
            await _repoContext.SaveChangesAsync();
        }
    }
}
