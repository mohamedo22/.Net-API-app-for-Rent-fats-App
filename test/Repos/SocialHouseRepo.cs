using Microsoft.EntityFrameworkCore;
using test.Configuration;
using test.Dto;
using test.Interface;
using test.Model;

namespace test.Repos
{
    public class SocialHouseRepo : ISocialHouse
    {
        private readonly AppDbContext context;

        public SocialHouseRepo(AppDbContext context)
        {
            this.context = context;
        }

        public bool addSocialHouse(SocialHouseDTO socialHouseDTO)
        {
            SocialHouse socialHouse = new SocialHouse { 
                address = socialHouseDTO.address,
                category = socialHouseDTO.category,
                description = socialHouseDTO.description,
                terms = socialHouseDTO.terms,
                title = socialHouseDTO.title,
                socialHouseImages = new List<SocialHouseImages>()
            };
            if (socialHouseDTO.socialHouseImages != null && socialHouseDTO.socialHouseImages.Count > 0)
            {
                foreach (var imageFile in socialHouseDTO.socialHouseImages)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        imageFile.CopyTo(memoryStream);
                        socialHouse.socialHouseImages.Add(new SocialHouseImages
                        {
                            image = memoryStream.ToArray()
                        });
                    }
                }
            }
            try
            {
                context.SocialHouses.Add(socialHouse);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool editeSocialHouse(SocialHouseDTO socialHouseDTO, int socialHouseID)
        {
            SocialHouse socialHouse = context.SocialHouses.Include(im=>im.socialHouseImages).FirstOrDefault(i=>i.SocialHouseId==socialHouseID);
            if (socialHouse == null)
            {
                return false;
            }
            if (socialHouse.socialHouseImages == null)
            {
                socialHouse.socialHouseImages = new List<SocialHouseImages>();
            }
            socialHouse.title = socialHouseDTO.title;
            socialHouse.description = socialHouseDTO.description;
            socialHouse.address = socialHouseDTO.address;
            socialHouse.category = socialHouseDTO.category;
            socialHouse.terms = socialHouseDTO.terms;
            if (socialHouseDTO.socialHouseImages != null && socialHouseDTO.socialHouseImages.Count > 0)
            {
                if (socialHouse.socialHouseImages != null && socialHouse.socialHouseImages.Count > 0)
                {
                    context.SocialHouseImages.RemoveRange(socialHouse.socialHouseImages);
                }
                foreach (var imageFile in socialHouseDTO.socialHouseImages)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        imageFile.CopyTo(memoryStream);
                        socialHouse.socialHouseImages.Add(new SocialHouseImages
                        {
                            image = memoryStream.ToArray()
                        });
                    }
                }
            }
            try
            {
                context.SocialHouses.Update(socialHouse);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public bool removeSocialHouse(int socialHouseID)
        {
            SocialHouse socialHouse = context.SocialHouses.FirstOrDefault(i=>i.SocialHouseId == socialHouseID);
            if (socialHouse == null)
            {
                return false;
            }
            context.SocialHouses.Remove(socialHouse);
            context.SaveChanges();
            return true;
        }

        public List<SocialHouseGetDTO> returnAllSocialHouses()
        {
            var allSocialHouses = context.SocialHouses.Select(i=>new SocialHouseGetDTO
            {
                address = i.address,
                category = i.category,
                description = i.description,
                terms = i.terms,
                title = i.title,
                Socialid = i.SocialHouseId,
                socialHouseImages = i.socialHouseImages.Select(img=> new SocialHouseImagesGetDTO
                {
                    ImageBase64 = Convert.ToBase64String(img.image)
                }).ToList()
            }).ToList();
            return allSocialHouses;
        }
    }
}
