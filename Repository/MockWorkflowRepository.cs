using portfolioProject.Models;

namespace portfolioProject.Repository;

public class MockWorkflowRepository : IWorkflowRepository
{
    private List<Workflow> _workflowList;

    public MockWorkflowRepository(){
        _workflowList = new List<Workflow>(){
            new Workflow {
            Id = 1,
            Description = "Cross-Platformda mobil uygulamalar geliştirebilirim",
            },
            new Workflow {
            Id = 2,
            Description = "Responsive dizayn ile hem masaüstü cihazlar hem de mobil cihazlara uygun tasarımlar yapabilirim",
            },
            new Workflow {
            Id = 3,
            Description = "Ekipçe çalışabilirim",
            },
            new Workflow {
            Id = 4,
            Description = "Agile proje geliştirme metadolojisine uyarım",
            }
        };
    }

    public IEnumerable<Workflow> GetAll(){
        return _workflowList;
    }
}