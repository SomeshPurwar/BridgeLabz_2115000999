using NUnit.Framework;
using List;
namespace ListTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AddElement_GivenElement_AddsElementToList()
        {
            var list = new List<int> { 1, 2, 3 };
            int element = 4;
            ListOperarations.AddElement(list, element);
            Assert.That(list, Does.Contain(element));
        }

        [Test]
        public void RemoveElement_GivenElement_RemovesElementFromList()
        {
            var list = new List<int> { 1, 2, 3 };
            int element = 2;
            ListOperarations.RemoveElement(list, element);
            Assert.That(list, Does.Not.Contain(element));
        }

        [Test]
        public void GetSize_AfterAddingElement_ReturnsUpdatedSize()
        {
            var list = new List<int> { 1, 2, 3 };
            ListOperarations.AddElement(list, 4);
            int size = ListOperarations.GetSize(list);
            Assert.That(size, Is.EqualTo(4));
        }

        [Test]
        public void GetSize_AfterRemovingElement_ReturnsUpdatedSize()
        {
            var list = new List<int> { 1, 2, 3 };
            ListOperarations.RemoveElement(list, 2);
            int size = ListOperarations.GetSize(list);
            Assert.That(size, Is.EqualTo(2));
        }


    }
}
