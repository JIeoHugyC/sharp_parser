using System.Reflection.Metadata;
using sharp_parser;

namespace sharp_parser_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        User myUser = new User();
        Assert.Positive(myUser.id);
        Assert.Pass();
    }
}