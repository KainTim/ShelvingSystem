using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelvingSystem
{
    internal abstract class Good
    {
        protected int Id {  get; set; }
        public Good(int id) => this.Id = id;
        public abstract String Description();
        public abstract String Kurzzeichen();
    }
}
