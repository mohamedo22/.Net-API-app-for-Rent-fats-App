using Microsoft.EntityFrameworkCore;
using test.Configuration;
using test.Dto;
using test.Interface;
using test.Model;

namespace test.Repos
{
    public class AdminRepo : IAdmin
    {
        private readonly AppDbContext appDbContext;

        public AdminRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public bool ForgetPassword(ForgetDto forgetDto)
        {
            if (appDbContext.User != null)
            {
                var status = false;
                var user = appDbContext.User.FirstOrDefault(x => x.Email == forgetDto.Email);
                if (user != null)
                {
                    user.Password = forgetDto.New_Password;
                    appDbContext.User.Update(user);
                    appDbContext.SaveChanges();
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

        public bool Login(AdminDTO adminDTO)
        {
            if (appDbContext.User != null)
            {
                var status = false;
                var user = appDbContext.Admins.FirstOrDefault(x => x.AdminEmail == adminDTO.AdminEmail && x.AdminPassword == adminDTO.AdminPassword);
                if (user != null)
                {
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
        public bool SignUp(AdminDTO adminDTO)
        {
            if (appDbContext.User != null)
            {
                bool status = false;
                if (!string.IsNullOrWhiteSpace(adminDTO.AdminEmail) &&
                    !string.IsNullOrWhiteSpace(adminDTO.AdminPassword))
                {
                    Admin register = new Admin
                    {
                        AdminEmail = adminDTO.AdminEmail,
                        AdminPassword = adminDTO.AdminPassword
                    };
                    appDbContext.Admins.Add(register);
                    appDbContext.SaveChanges();
                    status = true;
                    return status;
                }
                else
                {
                    return status;
                }
            }
            return false;
        }
    }
}
