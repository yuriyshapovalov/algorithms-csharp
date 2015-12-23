using NUnit.Framework;
using AaDS.Lists;
using AaDS.Helper;

[TestFixture]
public class LinkedListExtTest
{
    //private LinkedList<int> _testInstance;
    //private DataProvider _provider;

    [SetUp]
    public void Init() {
        //_testInstance = new LinkedList<int>();
        //_provider = DataProvider.GetDataProvider();
    }
    /*
	[Test]
	public void LinkedListExt_Add_IntContainerTest()
	{
        LinkedListExt<int> list = new LinkedList<int>();
		list.Add(1);
		list.Add(2);
		list.Add(3);

		Assert.AreEqual(list.Length, 3);
		Assert.AreEqual(list.Value, 1);
		Assert.AreEqual(list.Next().Value, 2);
		Assert.AreEqual(list.Next().Next().Value, 3);
		Assert.AreEqual(list.Next().Next().Next(), null);
	}

	[Test]
	public void LinkedListExt_Remove_IntContainerTest()
	{
		LinkedListExt<int> list = new LinkedList<int>();
		list.Add(1);
		list.Add(2);
		list.Add(3);
		list.Add(4);

		Assert.AreEqual(list.Length, 4);
		
		list.remove(4);
		// 1 -> 2 -> 3 -> null 
		Assert.AreEqual(list.Length, 3);
		Assert.AreEqual(list.Value, 1);
		Assert.AreEqual(list.Next().Value, 2);
		Assert.AreEqual(list.Next().Next().Value, 3);
		Assert.AreEqual(list.Next().Next().Next(), null);

		list.Remove(2);
		// 1 -> 3 -> null
		Assert.AreEqual(list.Length, 2);
		Assert.AreEqual(list.Value, 1);
		Assert.AreEqual(list.Next().Value, 3);
		Assert.AreEqual(list.Next().Next(), null);		

		list.Remove(1);
		//  3 -> null
		Assert.AreEqual(list.Length, 1);
		Assert.AreEqual(list.Value, 3);
		Assert.AreEqual(list.Next(), null);

		list.Remove(3);
		// null
		Assert.AreEqual(list.Length, 0);
		Assert.AreEqual(list.Value, null);
	}

	[Test]
	public void LinkedListExt_Length_IntContainerTest()
	{
		LinkedListExt<int> list = new LinkedList<int>();
		list.Add(1);
		list.Add(2);
		list.Add(3);

		// 1 -> 2 -> 3 -> null
		Assert.AreEqual(list.Length, 3);

		list.Add(4);

		// 1 -> 2 -> 3 -> 4 -> null
		Assert.AreEqual(list.Length, 4);

		list.Remove(4);
		list.Remove(3);

		// 1-> 2 -> null
		Assert.AreEqual(list.Length, 2);
	}
     */
}
