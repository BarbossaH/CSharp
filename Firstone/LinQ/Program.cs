using System;
using System.Collections;
namespace Firstone.LinQ
{
	public class Program
	{
        // language integrated query

        #region
        //static int[] QueryIntArray()
        //{
        //    int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    var gt6 = from num in nums
        //              where num > 6
        //              orderby num
        //              select num;
        //    foreach(int num in gt6)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    Console.WriteLine($"Get Type : {gt6.GetType()}");

        //    var lg = gt6.ToList<int>();
        //    var ag = gt6.ToArray<int>();

        //    nums[0] = 10;
        //    foreach(int i in gt6)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    return ag;
        //}

  //      static void Main(string[] args)
		//{

  //         int[] newArr = QueryIntArray();

  //          foreach(int i in newArr)
  //          {
  //              Console.WriteLine(i);
  //          }
  //      }

        #endregion

        #region

        //static void Main(string[] args)
        //{
        //string[] dogs = { "K 9", "A B", "C D", "D B", "R T I", "Ben J", "Fiona", "KOK" };

        //var dogSpaces = from dog in dogs
        //                where dog.Contains(" ")
        //                orderby dog descending
        //                select dog.Length;

        //foreach (var i in dogSpaces)
        //{
        //    Console.WriteLine(i);
        //}
        //}
        #endregion

        static void Main(string[] args)
        {
            ArrayList animals = new ArrayList()
            {
                new Animal{Name="Dog1",Height=3,Weight=12,AnimalID=1},
                new Animal{Name="Dog2",Height=4,Weight=120,AnimalID=2},
                new Animal{Name="Dog3",Height=5,Weight=130,AnimalID=3},
                new Animal{Name="Dog4",Height=6,Weight=100,AnimalID=1},
                "String"
            };

            //foreach (var v in animals)
            //{
            //    Console.WriteLine(v);
            //}
            Owner[] owners = new[] {
                new Owner{Name="Doug Parks", OwnID=1},
                new Owner{Name="Sally Parks", OwnID=2},
                new Owner{Name="Julian Huang", OwnID=3},
            };

            // to filer the type of Animal and exclude other types
            var filteredAnimalEnum = animals.OfType<Animal>();
            //foreach(var v in famAnimalEnum)
            //{
            //    Console.WriteLine(v);
            //}
            var nameAndHeight = from nh in filteredAnimalEnum
                                select new { nh.Name,
                                nh.Height};

            foreach(var i in nameAndHeight)
            {
                Console.WriteLine("I am the need {0}",i);
                Console.WriteLine(i.GetType());
            }
            Console.WriteLine(nameAndHeight.GetType());

            Array array = nameAndHeight.ToArray();
            foreach(var i in array)
            {
                Console.WriteLine(i.ToString());
            }

            var innerjoin = from a in filteredAnimalEnum
                            join owner in owners on a.AnimalID
                            equals owner.OwnID
                            select new { OwerName = owner.Name, AnimalName = a.Name };

            var groupJoin = from owner in owners
                            orderby owner.OwnID
                            join a in filteredAnimalEnum on owner.OwnID
                            equals a.AnimalID into ownerGroup
                            select new { Owner =owner.Name,
                            Animal = from owner2 in ownerGroup
                                     orderby owner2.Name
                                     select owner2
                         };

            //foreach (var i in innerjoin)
            //{
            //    Console.WriteLine("I am test {0} and {1}",i.OwerName, i.AnimalName);
            //}

            int totoal = 0;

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animal)
                {
                    totoal++;
                    Console.WriteLine("* {0}", animal.Name);
                }
            }

            //var smA = from sa in famAnimalEnum
            //          where sa.Weight <= 100
            //          orderby sa.Name
            //          select sa;
            //foreach (var v in smA)
            //{
            //    Console.WriteLine(v);
            //}
        }
    }
}

