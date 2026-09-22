namespace assigment_oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //a) change 
            // b) doesnt change
            #endregion
            #region question2 
            // a) 1- any one can use them dirctly
            // 2- no validtion 
            // 3- can not have control on them 
            // b) 1- not any one can use dirctly
            // 2- validation 
            //3- control on them 
            #endregion
            //#region part2 question 1
            //Delevaryadress d1 = new Delevaryadress("tttt", "ccc", 2);
            //Console.WriteLine(d1.Getfulladdrees());
            //Delevaryadress d2 = d1;
            //d2.city = "rrr";
            //d2.street = "yyy";
            //d2.buldingnumber = 4;
            //Console.WriteLine(d1.Getfulladdrees()); 
            //#endregion
            #region part2 system
            delevarycenter delvarycenter = new delevarycenter();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter tarckingcode");
                string trackingcode = Console.ReadLine();
                Console.WriteLine("enter description");
                string description = Console.ReadLine();
                Console.WriteLine("enter the weight");
                decimal weight = decimal.Parse(Console.ReadLine());
                Console.WriteLine("enter delevary fee");
                decimal delevaryfee = decimal.Parse(Console.ReadLine());
                Console.WriteLine("enter city");
                string city = Console.ReadLine();
                Console.WriteLine("enter the street");
                string street = Console.ReadLine();
                Console.WriteLine("enter the bulding number");
                int buldingnumber = int.Parse(Console.ReadLine());

                Delevaryadress destiontion = new Delevaryadress(city, street, buldingnumber);
                Shipment shipment = new Shipment(trackingcode, description, weight, delevaryfee, destiontion);
                bool aded = delvarycenter.addshipment(shipment);
                if (aded)
                {
                    Console.WriteLine("succefull");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
            for (int i=0;i<3;i++)
            {
                delvarycenter[i].printshipment();
            }
            Console.WriteLine("enter tracking code for search");
            string searchcode = Console.ReadLine();
            Shipment foundshipment = delvarycenter[searchcode];
            if (foundshipment.trackingcode!=null)
            {
                foundshipment.printshipment();
            }
            else
            {
                Console.WriteLine("not found ");
            }
            #endregion

        }
    }
}
