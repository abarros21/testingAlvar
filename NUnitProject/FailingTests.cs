using NUnit.Framework;

namespace TestProject;

public class FailingTests
{
    [Test]
    public void Test1()
    {
        Assert.Fail();
    }

    [Test]
    public void Test2()
    {
        Assert.Fail();
    }

    [Test]
    public void Test3()
    {
        Assert.Fail();
    }
}