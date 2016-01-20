using NUnit.Framework;
using Algorithms.Sorting;
using Algorithms.Tests.Helper;

[TestFixture]
[Ignore("Not implemented")]
public class IntroSortTest
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
    public void IntroSort_RandomIntegerSequence_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(1000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void IntroSort_EmptyArray_Success()
    {
        int[] testDataset = provider.GetEmptyIntegerArray();

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void IntroSort_OneElementArray_Success()
    {
        int[] testDataset = provider.GetOneElementIntegerArray();

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void IntroSort_OddElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(51, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void IntroSort_EvenElementArray_Success()
    {
        int[] testDataset = provider.GetRandomIntegerArray(50, 100);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void IntroSort_StringArray_Success()
    {
        string[] testDataset = provider.GetRandomStringsArray(10000);

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void IntroSort_EmptyStringArray_Success()
    {
        string[] testDataset = provider.GetEmptyStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

    [Test]
    public void IntroSort_OneElementStringArray_Success()
    {
        string[] testDataset = provider.GetOneElementStringArray();

        if (validator.ValidateOrder(testDataset))
            Assert.Inconclusive("Sorting test dataset is incorrect");

        IntroSort.Sort(testDataset);

        if (!validator.ValidateOrder(testDataset))
            Assert.Fail();
    }

}
