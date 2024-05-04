using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface IReferenceRepository
{
    IEnumerable<Reference> GetAll();


}