using test.Dto;

namespace test.Interface
{
    public interface ISocialHouse
    {
        public bool addSocialHouse(SocialHouseDTO socialHouseDTO);
        public bool removeSocialHouse(int socialHouseID);
        public bool editeSocialHouse(SocialHouseDTO socialHouseDTO, int socialHouseID);
        public List<SocialHouseGetDTO> returnAllSocialHouses();
    }
}
