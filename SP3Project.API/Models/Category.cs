using System.Collections.Generic;

namespace SP3Project.API.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new();
    }
}
