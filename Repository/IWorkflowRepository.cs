using portfolioProject.Models;

namespace portfolioProject.Repository;

public interface IWorkflowRepository
{
    IEnumerable<Workflow> GetAll();


}