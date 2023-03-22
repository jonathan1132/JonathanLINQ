using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AllAndTakeWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("LINQ");

                //Kutsume LINQ meetodi välja
                All();
                TakeWhile();
            }
             static void All()
            {
                int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                // All LINQ
                bool allAreGreaterThanZero = nums.All(n => n > 0);
                Console.WriteLine($"Kõik arvud on suuremad kui 0: {allAreGreaterThanZero}");
            }
             static void TakeWhile()
            {
                int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                // TakeWhile LINQ
                var takeWhileNums = nums.TakeWhile(n => n < 5);
                Console.WriteLine("Arvud, mis on väiksemad kui 5:");

                foreach (var n in takeWhileNums)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}

//Kood kasutab LINQ-i "All" ja "TakeWhile". All meetod kontrollib kas kõik massiivi elemendid täidavad antud kriteeriumi. See kontrollib kõiki elemendid ükshaaval ja 
//tagastab boolean tulemuse. TakeWhile meetod võtab vastu kahe argumenti: massiivi ja kriteeriumi. See meetod võtab massiivist elemendid, mis täidavad kriteeriumi 
//kuni esimeseni, mis seda ei tee. Main meetodis kasutatakse neid meetodeid nii, et kontrollitakse kas kõik numbrid on suuremad kui 0 ja seejärel võetakse välja 
//kõik numbrid, mis on väiksemad kui 5.