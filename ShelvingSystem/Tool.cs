using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelvingSystem
{
    internal class Tool : Good
    {

        public double Weight { get; set; }
        public Tool(int id, double weight) : base(id)
        {
            Weight = weight;
        }

        public override string Description()
        {
            return $"#{Id} Werkzeug {Weight} kg"; 
        }

        public override string Kurzzeichen()
        {
            return "W";
        }
    }
}
