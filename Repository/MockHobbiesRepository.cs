using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockHobbiesRepository : IHobbiesRepository
{
    private List<Hobbies> _hobbiesList;

    public MockHobbiesRepository(){
        _hobbiesList = new List<Hobbies>(){
            new Hobbies {
            Id = 1,
            Hobby = "Yazılım Mühendisliği öğrencisi olmamın yanısıra. Gitar veya Bağlama enstrumanlarını çalıp vaktimi geçiririm.",
            },
            new Hobbies {
            Id = 2,
            Hobby = "Belgesel izlemekten ve bilim kurgu roman tarzı kitaplar okumaktan keyf alırım.",
            },
            

        };
    }

    public IEnumerable<Hobbies> GetAll(){
        return _hobbiesList;
    }
}