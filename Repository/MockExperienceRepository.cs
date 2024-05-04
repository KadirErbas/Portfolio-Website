using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockExperienceRepository : IExperienceRepository
{
    private List<Experience> _experienceList;

    public MockExperienceRepository(){
        _experienceList = new List<Experience>(){
            new Experience {
            Id = 1,
            Title = "Fırat Üniversitesi",
            Subtitle="Öğrenci",
            Description="2. Sınıfta C# dili ile otomasyon projesi gerçekleştirdim. 3. Sınıfta Arduino ile bir proje gerçekleştirdim. Ben de dahil 4 kişilik ekibimle web projesi gerçekleştirdim",           
            Date="01.01.2023 - 31.12.2025",
            },

        };
    }

    public IEnumerable<Experience> GetAll(){
        return _experienceList;
    }
}