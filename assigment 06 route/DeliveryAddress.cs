using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_06_route
{
    internal class DeliveryAddress
    {
        public string? city;
        public string? street;
        public int buldingnumber;
        public DeliveryAddress()
        {
            city = city;
            street= street;
            buldingnumber= buldingnumber;
        }
        public override string ToString()
        {
            return $"{city},{street},{buldingnumber}";
        }
    }
     
    }
