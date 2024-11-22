using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class UserRepository : EntityRepository, IUserRepository
    {
        //public override Entity GetByID(Guid id)
        public override User GetByID(Guid id)
        {
            return new User(id);
        }

        public User GetByEmail(string email)
        {
            return new User(Guid.NewGuid()) { EmailAddress = email };
        }

        public IEnumerable<User> GetByDateOfBirth(DateTime dateOfBirth)
        {
            // Example implementation (you'd replace this with actual logic)
            return new List<User>
            {
                new User(Guid.NewGuid()) { DateOfBirth = dateOfBirth }
            };
        }
    }
}
