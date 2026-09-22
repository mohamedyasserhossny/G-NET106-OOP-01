using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_oop_1
{
    internal struct delevarycenter
    {
        private Shipment[] shipments;
        public delevarycenter()
        {
            shipments = new Shipment[10];
        }
        public Shipment this[int index ]
        {
            get
            {
                if (index>=0&&index<shipments.Length)
                {
                    return shipments[index];
                }
                return default;
                
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingcode]
        {
            get
            {
                for(int i=0;i<shipments.Length;i++)
                {
                    if (shipments[i].trackingcode==trackingcode)
                    {
                        return shipments[i];
                    }
                }
                return default;
            }
        }
        public bool addshipment(Shipment shipment)
        {
            for(int i=0;i<shipments.Length;i++)
            {
                if (shipments[i].trackingcode==null)
                {
                    shipments[i] = shipment;
                    return true;
                }

            }
            return false;
        }


    }
}
