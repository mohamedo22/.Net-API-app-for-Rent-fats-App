using test.Dto;

namespace test.Interface
{
    public interface IAdmin
    {
        public bool ForgetPassword(ForgetDto forgetDto);
        public bool SignUp(AdminDTO adminDTO);
        public bool Login(AdminDTO adminDTO);
    }
}
