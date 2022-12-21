using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplicationWEBAPIloginPageAngular.Model;

namespace WebApplicationWEBAPIloginPageAngular.Model
{
    public class DataBasedbContext:DbContext
    {

        public DataBasedbContext()
        {

        }
        public DataBasedbContext(DbContextOptions<DataBasedbContext> options) : base(options)
        {

        }

      public virtual DbSet<TblRegistration> TblRegistration { get; set; }


    }
}