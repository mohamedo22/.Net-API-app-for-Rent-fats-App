using test.Dto;
using test.Model;

namespace test.Interface
{
    public interface IRegisterRepo
    {
        bool ForgetPassword(ForgetDto forgetDto);
        bool SignUp(UserDto registerDto);
        User? Login(LoginDto registerDto);
        User? GetUser(int id);
        bool EditProfile(EditProfileDto editProfileDto);
    }
}
