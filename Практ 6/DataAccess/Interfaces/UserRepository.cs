using Domain.Models;
using DataAccess.Repositories;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Interfaces
{
    public class UserRepository : RepositoryBase<User>, Domain.Interfaces.IUserRepository
    {
        public UserRepository(WebShopContext repositoryContext) : base(repositoryContext) { }
    }
}
