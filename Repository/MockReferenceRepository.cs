using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockReferenceRepository : IReferenceRepository
{
    private List<Reference> _referenceList;

    public MockReferenceRepository(){
        _referenceList = new List<Reference>(){
            new Reference {
            Id = 1,
            Name="Yaman",
            Surname="Akbulut",
            Email="yamanakbulut@gmail.com",
            Institution="Fırat Üniversitesi",
            Title="Doc. Dr.",

            },            new Reference {
            Id = 2,
            Name="Veysel",
            Surname="Kayık",
            Email="veyselkayik@gmail.com",
            Institution="Turkcell Global Bilgi",
            Title="Web Developer",

            },

        };
    }

    public IEnumerable<Reference> GetAll(){
        return _referenceList;
    }
}