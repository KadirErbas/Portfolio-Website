using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockEducationRepository : IEducationRepository
{
    private List<Education> _educationList;

    public MockEducationRepository(){
        _educationList = new List<Education>(){
            new Education {
            Id = 1,
            Title = "Gültepe Anadolu Lisesi",
            Subtitle="Erbaş",
            Description="Tilmerç Mahalesi Memursen Toki Konutları Y-3 No:7 Merkez/Batman",
            GNO="70",
            Date="2014 - 2018 Haziran",
            },
            new Education {
            Id = 2,
            Title = "Fırat Üniversitesi",
            Subtitle="Teknoloji Fakültesi",
            Description="Yazılım Mühendisliği",
            GNO="3.2",
            Date="2020 - 2025 Haziran",
            },
        };
    }

    public IEnumerable<Education> GetAll(){
        return _educationList;
    }
}