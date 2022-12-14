using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }      
        public int? ParentId { get; set; }
        public virtual CategoryModel Parent { get; set; }  
    }
}
