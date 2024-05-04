using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockHobbiesRepository : IHobbiesRepository
{
    private List<Hobbies> _hobbiesList;

    public MockHobbiesRepository(){
        _hobbiesList = new List<Hobbies>(){
            new Hobbies {
            Id = 1,
            Hobby = "müzikle uğraşırım bağlama çalmak beni ruhen dinlendirir. Yürüyüş yaparım.",
            },

        };
    }

    public IEnumerable<Hobbies> GetAll(){
        return _hobbiesList;
    }
}