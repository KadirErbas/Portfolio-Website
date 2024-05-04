using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface ISkillsRepository
{
    IEnumerable<Skills> GetAll();


}