using NUnit.Framework;
using Algorithms.Sorting;
using Algorithms.Tests.Helper;

[TestFixture]
public class ShellSortTest
{
    private DataProvider provider;
    private Validator validator;

    [SetUp]
    public void Init()
    {
        provider = DataProvider.GetDataProvider();
        validator = Validator.GetValidator();
    }

    [Test]
    public void ShellSort_RandomIntegerSequence_Success()
    {
        ISort<int> sorter = new ShellSort<int>();
        int[] temp = sorter.Sort(provider.GetRandomIntegerArray(1000));

        if (!validator.ValidateOrder(temp))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void ShellSort_EmptyArray_Success()
    {
        ISort<int> sorter = new ShellSort<int>();
        int[] temp = sorter.Sort(provider.GetEmptyIntegerArray());

        if (!validator.ValidateOrder(temp))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void ShellSort_OneElementArray_Success()
    {
        ISort<int> sorter = new ShellSort<int>();
        int[] temp = sorter.Sort(provider.GetOneElementIntegerArray());

        if (!validator.ValidateOrder(temp))
        {
            Assert.Fail();
        }
    }
}
