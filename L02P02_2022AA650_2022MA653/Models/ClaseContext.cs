using Microsoft.EntityFrameworkCore;

namespace L02P02_2022AA650_2022MA653.Models
{
    public class ClaseContext: DbContext
    {
        public ClaseContext(DbContextOptions<ClaseContext> options) : base(options)
        {

        }
    }
}
