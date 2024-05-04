using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface IExperienceRepository
{
    IEnumerable<Experience> GetAll();


}