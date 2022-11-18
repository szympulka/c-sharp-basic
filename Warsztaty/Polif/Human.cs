using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polif
{
    public interface IHuman
    {
        public string GetName();
    }

    public interface IPerson
    {
        public string GetAge();
    }

    public class Kevin : IHuman, IPerson
    {
        public string Name { get; set; }

        public string GetAge()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return Name;
        }
    }
}
