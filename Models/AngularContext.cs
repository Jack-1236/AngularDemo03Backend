using Microsoft.EntityFrameworkCore;

namespace AngularApi.Models
{
    public class AngularContext : DbContext
    {

        public AngularContext(DbContextOptions<AngularContext> options):base(options) {
        
        }

    }
}
