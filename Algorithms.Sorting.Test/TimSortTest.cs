using NUnit.Framework;
using Algorithms.Sorting;
using Algorithms.Tests.Helper;

[TestFixture]
[Ignore("Not implemented")]
public class TimSortTest
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
    public void TimSort_RandomIntegerSequence_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(1000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void TimSort_EmptyArray_Success()
    {
        int[] testDataset = provider.GetEmptyIntegerArray();

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void TimSort_OneElementArray_Success()
    {
        int[] testDataset = provider.GetOneElementIntegerArray();

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void TimSort_OddElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(51, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void TimSort_EvenElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(50, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void TimSort_StringArray_Success()
    {
        string[] testDataset = provider.GetRandomStringsArray(10000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void TimSort_EmptyStringArray_Success()
    {
        string[] testDataset = provider.GetEmptyStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void TimSort_OneElementStringArray_Success()
    {
        string[] testDataset = provider.GetOneElementStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        TimSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

}
