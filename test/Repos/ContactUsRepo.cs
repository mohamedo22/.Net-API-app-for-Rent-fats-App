using Microsoft.EntityFrameworkCore;
using test.Configuration;
using test.Dto;
using test.Interface;
using test.Model;

namespace test.Repos
{
    public class ContactUsRepo : IContactUsRequests
    {
        private readonly AppDbContext appDbContext;

        public ContactUsRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<ContactUsDto> GetContactUs()
        {
            var allContactUs  = appDbContext.ContactUsRequests.Include(x=>x.User).Select(x=> new ContactUsDto
            {
                dataTime = x.dataTime,
                FlatCodeId = x.FlatCodeId,
                UserId =x.UserId,
                userPhone = x.User.Phone,
            }).ToList();
            return allContactUs;
        }

        public bool Request_Flat(ContactUsDto contactUs)
        {
            var newRequestFlat = new ContactUsRequest
            {
                FlatCodeId= contactUs.FlatCodeId,
                UserId = contactUs.UserId,
                dataTime = contactUs.dataTime,
            };
            try
            {
                appDbContext.ContactUsRequests.Add(newRequestFlat);
                appDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
