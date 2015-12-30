using NUnit.Framework;
using Algorithms.Sorting;
using Algorithms.Tests.Helper;

[TestFixture]
public class SelectionSortTest
{
    private ISort<int> sorter;
    private DataProvider provider;
    private Validator validator;

    [SetUp]
    public void Init()
    {
        sorter = new SelectionSort<int>();
        provider = DataProvider.GetDataProvider();
        validator = Validator.GetValidator();
    }

    [Test]
    public void SelectionSort_RandomIntegerSequence_Success()
    {
        int[] temp = sorter.Sort(provider.GetRandomIntegerArray(1000));

        if (!validator.ValidateOrder<int>(temp))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void SelectionSort_EmptyArray_Success()
    {
        int[] temp = sorter.Sort(provider.GetEmptyIntegerArray());

        if (!validator.ValidateOrder<int>(temp))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void SelectionSort_OneElementArray_Success()
    {
        int[] temp = sorter.Sort(provider.GetOneElementIntegerArray());

        if (!validator.ValidateOrder<int>(temp))
        {
            Assert.Fail();
        }
    }
}
