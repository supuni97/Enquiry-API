using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Enquiry_API.Model;


namespace Enquiry_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnquiryMasterController : ControllerBase
    {
        private readonly EnquiryDbContext _context;
        public EnquiryMasterController(EnquiryDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllStatus")]
        public List<EnquiryStatus> GetEnquiryStatus()
        {
            var list = _context.EnquiryStatus.ToList();
            return list;

        }

        [HttpGet("GetAllTypes")]

        public List<EnquiryType> GetAllTypes()
        {
            var list = _context.EnquiryType.ToList();
            return list;

        }

        [HttpGet("GetAllEnquiry")]

        public List<EnquiryModel> GetAllEnquiry()
        {
            var list = _context.EnquiryModel.ToList();
            return list;

        }

        [HttpPost("CreateNewEnquiry")]

        public EnquiryModel AddNewEnquiry(EnquiryModel obj)
        {
            obj.createdDate = DateTime.Now;
            _context.EnquiryModel.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        [HttpPut("UpdateEnquiry")]

        public EnquiryModel Update(EnquiryModel obj)
        {
            var record = _context.EnquiryModel.SingleOrDefault(m=> m.enquiryId==obj.enquiryId);   
            if(record != null)
            {
                record.resolution = obj.resolution;
                record.enquiryStatusId = obj.enquiryStatusId;
                _context.SaveChanges();
            }

            return obj;
           
        }

        [HttpDelete("DeleteEnquiryById")]

        public bool DeleteEnquiryById(int id)
        {
            var record = _context.EnquiryModel.SingleOrDefault(m => m.enquiryId == id);
            if (record != null)
            {
               _context.EnquiryModel.Remove(record);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

            

        }

    }
}
