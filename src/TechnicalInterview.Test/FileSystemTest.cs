using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalInterview.App.Tasks;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class FileSystemTest
    {
        [TestMethod]
        public void RecursivelyDoFolderMagicCompletesWithoutException()
        {
            var fileSystemClass = new FileSystemClass();
            fileSystemClass.RecursivelyDoFolderMagic(@"C:\Folder");
        }

        [TestMethod]
        public void IterativelyDoFolderMagicCompletesWithoutException()
        {
            var fileSystemClass = new FileSystemClass();
            fileSystemClass.IterativelyDoFolderMagic(@"C:\Folder");
        }
    }
}