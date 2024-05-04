using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface IEducationRepository
{
    IEnumerable<Education> GetAll();


}