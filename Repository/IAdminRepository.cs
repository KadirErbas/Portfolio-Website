using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface IAdminRepository
{
    IEnumerable<Admin> GetAll();


}