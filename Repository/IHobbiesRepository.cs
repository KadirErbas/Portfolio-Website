using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface IHobbiesRepository
{
    IEnumerable<Hobbies> GetAll();


}