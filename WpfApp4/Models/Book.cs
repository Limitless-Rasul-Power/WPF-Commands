using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    public class Book : Entity
    {
        public string Name { get; set; }  
        public string Author { get; set; }

        public string Genre { get; set; }
    }
}
