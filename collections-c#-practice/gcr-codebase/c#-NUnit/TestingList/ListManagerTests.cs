using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    ListManager manager;
    List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void AddElement_IncreasesSize()
    {
        manager.AddElement(list, 10);
        Assert.AreEqual(1, manager.GetSize(list));
    }
}
