using test.Dto;

namespace test.Interface
{
    public interface IFlatRepo
    {
        public bool PostFlat(PostFlatDto postFlatDto);

        public bool EditFlat(PostFlatDto postFlatDto, int id);

        public List<GetFlatDto> GetFlat();

        public GetFlatDto GetFlatById(int id);

        public bool RemoveFlat(int FlatId);
        public bool updateFlatState(int FlatId, bool state);
    }
}
 