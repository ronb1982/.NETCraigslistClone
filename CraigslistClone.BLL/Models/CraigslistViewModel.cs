using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraigslistClone.BLL.Models
{
    public class CraigslistViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Subcategory> Subcategories { get; set; }
        public List<State> States { get; set; }
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }

        public CraigslistViewModel()
        {
            Country = new Country();
        }
    }

    public class Column
    {
        public int ColumnId { get; set; }
    }
}
