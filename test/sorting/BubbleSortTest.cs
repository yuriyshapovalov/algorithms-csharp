using NUnit.Framework;
using AaDS.Sorting;
using AaDS.Helper;

[TestFixture]
public class BubbleSortTest
{
    private ISort<int> sorter;
    private DataProvider provider;
    private Validator validator;

    [SetUp]
    public void Init()
	{
        this.sorter = new BubbleSort<int>();
        this.provider = DataProvider.GetDataProvider();
        this.validator = Validator.GetValidator();
	}

    [Test]
    public void BubbleSort_RandomIntegerSequence_Success()
    {
        int[] temp = sorter.Sort((int[])provider.GetRandomData1K());

        if (!validator.ValidateOrder<int>(temp))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void BubbleSort_EmptyArray_Success()
    {
        int[] temp = sorter.Sort((int[])provider.GetEmptyIntegerArray());

        if (!validator.ValidateOrder<int>(temp))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void BubbleSort_OneElementArray_Success()
    {
        int[] temp = sorter.Sort((int[])provider.GetOneElementIntegerArray());

        if (!validator.ValidateOrder<int>(temp))
        {
            Assert.Fail();
        }
    }
}
