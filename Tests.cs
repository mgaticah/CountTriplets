using Xunit;
class Tests{
    [Fact]
    public void VerifyTripletsCounting()
    {
        long[] array=new long[]{1,5,5,25,125};
        long r=5;
        long result=TripletsHelper.countTriplets(array, r);
    }
}