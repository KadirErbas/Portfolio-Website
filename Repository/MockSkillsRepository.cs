using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockSkillsRepository : ISkillsRepository
{
    private List<Skills> _skillsList;

    public MockSkillsRepository(){
        _skillsList = new List<Skills>(){
            new Skills {
            Id = 1,
            Skill="HTML",
            Value="çok iyi"
            },
            new Skills {
            Id = 2,
            Skill="Javascript",
            Value="başlangıç"
            },


        };
    }

    public IEnumerable<Skills> GetAll(){
        return _skillsList;
    }
}