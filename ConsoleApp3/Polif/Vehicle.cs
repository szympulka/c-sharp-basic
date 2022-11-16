using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polif
{
    public abstract class Vehicle
    {
        public abstract string GetBrand();

        [Required]
        public string Name { get; set; }

        internal virtual string GetColor()
        {
            return "Black";
        }
    }

    public class Car : Vehicle
    {
        public override string GetBrand()
        {
            throw new NotImplementedException();
        }
    }

    public class Moto : Vehicle
    {
        public override string GetBrand()
        {
            throw new NotImplementedException();
        }
    }
}
