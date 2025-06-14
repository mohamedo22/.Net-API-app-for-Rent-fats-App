using test.Dto;

namespace test.Interface
{
    public interface IContactUsRequests
    {
        bool Request_Flat(ContactUsDto contactUs);
        List<ContactUsDto> GetContactUs();
    }
}
