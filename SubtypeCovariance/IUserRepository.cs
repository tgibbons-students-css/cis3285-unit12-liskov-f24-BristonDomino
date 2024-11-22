using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public interface IUserRepository : IEntityRepository<User>
    {
        User GetByEmail(string email);
    }
}
