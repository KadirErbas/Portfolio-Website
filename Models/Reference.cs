using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolioProject.Models
{
    public class Reference
    {
    public int Id { get; set;}
    public string Name { get; set;} = string.Empty;

    public string Surname { get; set;} = string.Empty;    
   
    public string Email { get; set;} = string.Empty;
    public string Institution { get; set;} = string.Empty;    
   
    public string Title { get; set;} = string.Empty;              
    }
}