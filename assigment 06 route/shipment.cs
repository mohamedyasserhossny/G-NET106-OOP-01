using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_06_route
{
    internal struct shipment
    {
        private int _trackingcode;
        private string _description;
        private double _weigth;
        private decimal _delevryfee;
        public DeliveryAddress destiontion { set; get; }
        public int trackingcode
        {
            get
            {
                return _trackingcode;
            }
            set
            {
                _trackingcode = value;
                if (value == null && value == 0)
                {
                    Console.WriteLine("no value");
                }
                else
                {
                    _trackingcode = value;
                    Console.WriteLine(value);
                }
            }






        }
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                if (value == null)
                {
                    Console.WriteLine("no value");
                }
                else
                {
                    _description = value;
                    Console.WriteLine(value);
                }
            }
        }
        public double weight
        {
            get
            {
                return _weigth;
            }
            set
            {
                _weigth = value;
                if (value > 0)
                {
                    _weigth = value;

                    Console.WriteLine(value);
                }
                else
                {

                    Console.WriteLine("invalid weight");
                }
            }
        }

        public decimal delevaryfee
        {
            get
            {
                return _delevryfee;
            }
            set
            {
                _delevryfee = value;
                if (value > 0)
                {
                    _delevryfee = value;
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }

        }
        public decimal EstimatedCost
        {
            get
            {
                return _delevryfee + ((decimal)_weigth * 5);
            }
        }
        public shipment(int _trackingcode)
        {
            this._trackingcode = _trackingcode;
            _description = "unkown";
            _weigth = 1;
            _delevryfee = 50;
            destiontion = new DeliveryAddress();
            destiontion = destiontion;
        }
        public shipment(int _trackingcode, string _description, double _weigth, decimal _delevryfee, DeliveryAddress destiontion)
        {
            this._trackingcode = _trackingcode;
            this._description = _description;
            this._weigth = _weigth;
            this._delevryfee = _delevryfee;
            this.destiontion = destiontion;
        }
        public  void UpdateDeliveryFee(decimal newfee)
        {
            if (newfee>0)
            {
                _delevryfee = newfee;
            }
        }
        public void PrintShipment()
        {
            Console.WriteLine(_trackingcode);
            Console.WriteLine(_description);
            Console.WriteLine(_weigth);
            Console.WriteLine(_delevryfee);
            Console.WriteLine(destiontion.getfulladress());
        }












    }
}
