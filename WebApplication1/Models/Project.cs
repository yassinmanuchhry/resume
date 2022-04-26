using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string client { get; set; }

        public Project(long id, string name, string description, string image, string client)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            this.client = client;
        }
    }
}
