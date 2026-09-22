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
            #region part2 question 1
            Delevaryadress d1 = new Delevaryadress("tttt", "ccc", 2);
            Console.WriteLine(d1.Getfulladdrees());
            Delevaryadress d2 = d1;
            d2.city = "rrr";
            d2.street = "yyy";
            d2.buldingnumber = 4;
            Console.WriteLine(d1.Getfulladdrees()); 
            #endregion

        }
    }
}
