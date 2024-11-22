using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class EntityRepository : IEntityRepository<Entity>
    {

        // **** This method should generate an error which you need to fix ****
        // I think it's fix. There is no errors now that I can see now.
        public virtual Entity GetByID(Guid id)
        {
            return new Entity(id);
        }
    }
}
