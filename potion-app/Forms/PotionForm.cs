using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potion_app.Forms
{
    public class PotionForm
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Effect { get; set; }
        public DateTime BrewedAt { get; set; }
    }
}
