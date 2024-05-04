using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolioProject.Models
{
    public class Education
    {
    public int Id { get; set;}
    public string Title { get; set;} = string.Empty;

    public string Subtitle { get; set;} = string.Empty;    
   
    public string Description { get; set;} = string.Empty;
    public string GNO { get; set;} = string.Empty;
    public string Date { get; set;} = string.Empty;
    }
}