using Xunit;
using System.Collections.Generic;
public class Tests{
    [Fact]
    public void VerifyTripletsCounting()
    {
        var  list=new List<long>(){1,5,5,25,125};
        long r=5;
        long result=TripletsHelper.countTriplets(list, r);
        Assert.Equal(4,result);
        r=3;
        list=new List<long>(){1,3,9,9,27,81};
        result=TripletsHelper.countTriplets(list, r);
        Assert.Equal(6,result);
    }
}