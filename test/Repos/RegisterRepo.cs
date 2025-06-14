using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test.Configuration;
using test.Dto;
using test.Interface;
using test.Model;

namespace test.Repos
{
    public class RegisterRepo : IRegisterRepo
    {
        private readonly AppDbContext _context;

        public RegisterRepo(AppDbContext context)
        {
            _context = context;
        }
        public User? GetUser(int id)
        {
            var user = _context.User.FirstOrDefault(x=>x.UserId == id);
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public bool EditProfile(EditProfileDto editProfileDto)
        {
            var status = false;
            if (editProfileDto.Email != null)
            {
                var user = _context.User.FirstOrDefault(x => x.UserId == editProfileDto.userId);
                if (user != null)
                {
                    user.Phone = editProfileDto.Phone;
                    user.Username = editProfileDto.Username;
                    user.Address = editProfileDto.Address;
                    user.Email = editProfileDto.Email;
                    _context.User.Update(user);
                    _context.SaveChanges();
                    status = true;
                    return status;
                }
                else
                {
                    status = false;
                    return status;
                }
            }
            return false;
        }
        public bool ForgetPassword(ForgetDto forgetDto)
        {
              if (_context.User != null)
            {
                var status = false;
                var user = _context.User.FirstOrDefault(x => x.Email == forgetDto.Email);
                if (user != null)
                {
                    user.Password = forgetDto.New_Password;
                    _context.User.Update(user);
                    _context.SaveChanges();
                    status = true;
                    return status;
                }
                else
                {
                    status = false;
                    return status;
                }
            }
            return false;
        }

        public User? Login(LoginDto loginDto)
        {
            if (_context.User != null)
            {
                var user = _context.User.FirstOrDefault(x => x.Username == loginDto.Username && x.Password == loginDto.Password);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public bool SignUp(UserDto registerDto)
        {
            if(_context.User != null)
            {
                bool status = false;
                if (!string.IsNullOrWhiteSpace(registerDto.Username) &&
                    !string.IsNullOrWhiteSpace(registerDto.Password) &&
                    !string.IsNullOrWhiteSpace(registerDto.Email) &&
                    !string.IsNullOrWhiteSpace(registerDto.Address) &&
                    !string.IsNullOrWhiteSpace(registerDto.Phone) &&
                    !string.IsNullOrWhiteSpace(registerDto.National_Id)) 
                {
                    User register = new User
                    {
                        Email = registerDto.Email,
                        Username = registerDto.Username,
                        Password  = registerDto.Password,
                        BirthDate = registerDto.BirthDate,
                        Address = registerDto.Address,
                        Phone = registerDto.Phone,
                        National_Id = registerDto.National_Id
                    };
                    _context.User.Add(register);
                    _context.SaveChanges();
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            return false ;
        }
    }
}
