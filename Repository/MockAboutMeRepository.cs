using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockAboutMeRepository : IAboutMeRepository
{
    private List<AboutMe> _aboutMeList;

    public MockAboutMeRepository(){
        _aboutMeList = new List<AboutMe>(){
            new AboutMe {
            Id = 1,
            Name = "Abdulkadir",
            Surname="Erbaş",
            Addresses="Tilmerç Mahalesi Memursen Toki Konutları Y-3 No:7 Merkez/Batman",
            Email="akadir.erbass@gmail.com",
            Phone="05523527172",
            Note="2000 Yılında Batman'da doğdum.",
            Photo="1.jpg"
            }
        };
    }

    public IEnumerable<AboutMe> GetAll(){
        return _aboutMeList;
    }
}