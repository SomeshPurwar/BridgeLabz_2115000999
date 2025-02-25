using NUnit.Framework;
using FileHandling;
namespace FileHandlingTest
{
    [TestFixture]
    public class Class1
    {
        private const string TestFileName = "testfile.txt";

        [SetUp]
        public void SetUp()
        {
            // Clean up any existing test files
            if (File.Exists(TestFileName))
            {
                File.Delete(TestFileName);
            }
        }

        [TearDown]
        public void TearDown()
        {
            // Cleanup after each test
            if (File.Exists(TestFileName))
            {
                File.Delete(TestFileName);
            }
        }

        [Test]
        public void WriteToFile_WhenCalled_CreatesFileWithContent()
        {
            string content = "Hello, NUnit!";
            FileProcessor.WriteToFile(TestFileName, content);

            Assert.That(File.Exists(TestFileName), Is.True);
            Assert.That(File.ReadAllText(TestFileName), Is.EqualTo(content));
        }

        [Test]
        public void ReadFromFile_WhenFileExists_ReturnsCorrectContent()
        {
            string content = "Test Content";
            File.WriteAllText(TestFileName, content);

            string result = FileProcessor.ReadFromFile(TestFileName);

            Assert.That(result, Is.EqualTo(content));
        }

        [Test]
        public void ReadFromFile_WhenFileDoesNotExist_ThrowsIOException()
        {
            var ex = Assert.Throws<IOException>(() => FileProcessor.ReadFromFile(TestFileName));
            Assert.That(ex.Message, Does.Contain("File not found."));
        }
    }
}
