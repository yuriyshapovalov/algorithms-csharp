using NUnit.Framework;
using Algorithms.Sorting;
using Algorithms.Tests.Helper;

[TestFixture]
public class CoctailSortTest
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
    public void CoctailSort_RandomIntegerSequence_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(1000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void CoctailSort_EmptyArray_Success()
    {
        int[] testDataset = provider.GetEmptyIntegerArray();

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void MergeSort_OneElementArray_Success()
    {
        int[] testDataset = provider.GetOneElementIntegerArray();

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void CoctailSort_OddElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(51, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void CoctailSort_EvenElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(50, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void CoctailSort_StringArray_Success()
    {
        string[] testDataset = provider.GetRandomStringsArray(10000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void CoctailSort_EmptyStringArray_Success()
    {
        string[] testDataset = provider.GetEmptyStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void CoctailSort_OneElementStringArray_Success()
    {
        string[] testDataset = provider.GetOneElementStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        CoctailSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

}
