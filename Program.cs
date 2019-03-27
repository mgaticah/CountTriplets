using System;
using System.Collections.Generic;
namespace CountTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
              var  list=new List<long>(){1,5,5,25,125};
        long r=5;
        long result=TripletsHelper.countTriplets(list, r);
     
        }
    }
}
