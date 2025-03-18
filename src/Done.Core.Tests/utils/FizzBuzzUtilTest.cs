using Done.Core.utils;
using JetBrains.Annotations;
using NUnit.Framework;

namespace Done.Core.Tests.utils;

[TestFixture]
[TestSubject(typeof(FizzBuzzUtil))]
public class FizzBuzzUtilTest
{
    private FizzBuzzUtil _fizzBuzzUtil;

    public FizzBuzzUtilTest()
    {
        _fizzBuzzUtil = new FizzBuzzUtil();
    }

    [TestCase(1, false)]
    [TestCase(2, false)]
    [TestCase(3, true)]
    public void IsFizzTest(int input, bool expected)
    {
        var actual = _fizzBuzzUtil.IsFizz(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(3, false)]
    [TestCase(4, false)]
    [TestCase(5, true)]
    public void IsBuzzTest(int input, bool expected)
    {
        var actual = _fizzBuzzUtil.IsBuzz(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(1, "1")]
    [TestCase(3, "Fizz")]
    [TestCase(5, "Buzz")]
    [TestCase(15, "FizzBuzz")]
    public void GetFizzBuzzTest(int input, string expected)
    {
        var actual = _fizzBuzzUtil.GetFizzBuzz(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
