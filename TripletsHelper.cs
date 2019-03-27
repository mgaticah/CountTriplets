using System;
using System.Collections;
using System.Collections.Generic;
public static class TripletsHelper
{
    public static long countTriplets(List<long> arr, long r)
    {
        var triplets=new Hashtable();
        long[] array = arr.ToArray();
        for (int firstIndex = 0; firstIndex < array.Length - 2; firstIndex++)
        {
            long expectedSecond=array[firstIndex]*r;
            long expectedThird=array[firstIndex]*r*r;
            List<int> secondValuePositions= new List<int>();
            List<int> thirdValuePositions= new List<int>();
            for(int secondIndex=firstIndex+1;secondIndex<array.Length-1;secondIndex++)
            {
                for(int thirdIndex=secondIndex+1;thirdIndex<array.Length;thirdIndex++)
                {
                    if(array[secondIndex]==expectedSecond && array[thirdIndex]==expectedThird)
                    {
                        
                        var tripletHash=string.Format("{0}|{1}|{2}",firstIndex,secondIndex,thirdIndex);
                         if(!triplets.ContainsKey(tripletHash))
                        {
                            triplets.Add(tripletHash,1);
                            Console.WriteLine(tripletHash);
                        }
                    }     
                    else if(array[thirdIndex]>expectedThird )
                    break;
                        
                }
                if(array[secondIndex]>expectedSecond )
                        break;
            }
            
        }
        return triplets.Count;

    }

}