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
        int[] testDataset = provider.GetRandomIntegerArray(1000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void ShellSort_EmptyArray_Success()
    {
        int[] testDataset = provider.GetEmptyIntegerArray();

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void ShellSort_OneElementArray_Success()
    {
        int[] testDataset = provider.GetOneElementIntegerArray();

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void ShellSort_OddElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(51, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void ShellSort_EvenElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(50, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void ShellSort_StringArray_Success()
    {
        string[] testDataset = provider.GetRandomStringsArray(10000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void ShellSort_EmptyStringArray_Success()
    {
        string[] testDataset = provider.GetEmptyStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void ShellSort_OneElementStringArray_Success()
    {
        string[] testDataset = provider.GetOneElementStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        ShellSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

}
