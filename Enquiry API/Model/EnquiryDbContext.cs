using Microsoft.EntityFrameworkCore;

namespace Enquiry_API.Model
{
    public class EnquiryDbContext:DbContext
    {
        public EnquiryDbContext(DbContextOptions<EnquiryDbContext> options):base(options)
        {

        }
    }
}
