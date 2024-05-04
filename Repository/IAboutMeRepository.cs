using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface IAboutMeRepository
{
    IEnumerable<AboutMe> GetAll();


}