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
    }
}