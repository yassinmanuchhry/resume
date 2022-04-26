using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Artical
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Artical(long id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
