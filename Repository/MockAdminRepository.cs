using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockAdminRepository : IAdminRepository
{
    private List<Admin> _adminList;

    public MockAdminRepository(){
        _adminList = new List<Admin>(){
            new Admin {Id = 1,Email="kadir@gmail.com", Password="123"}
        };
    }

    public IEnumerable<Admin> GetAll(){
        return _adminList;
    }
}