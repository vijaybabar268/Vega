using System.Collections.ObjectModel;
using API.Models;

namespace API.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }        
        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set; }

        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}