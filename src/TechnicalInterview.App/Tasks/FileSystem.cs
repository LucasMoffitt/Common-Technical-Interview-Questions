using System.Collections.Generic;
using System.IO;

namespace TechnicalInterview.App.Tasks
{
    public class FileSystemClass
    {
        //Task: 
        /*
         * Design a solution that iteratively and recursively walks a directory tree
         * and preforms an operation on the curent folder.
         */

        public void RecursivelyDoFolderMagic(string root)
        {
            var folders = Directory.GetDirectories(root);
            foreach (var folder in folders)
            {
                // Do Magic On Folder

                RecursivelyDoFolderMagic(folder);
            }
        }

        public void IterativelyDoFolderMagic(string root)
        {
            var directories = new Stack<string>();

            //Seed base folders
            foreach (var folder in  Directory.GetDirectories(root))
                directories.Push(folder);

            do
            {
                var folderToDoMagic = directories.Pop();

                // Do magic to folder

                foreach (var folder in Directory.GetDirectories(folderToDoMagic))
                    directories.Push(folder);

            } while (directories.Count > 0);
        }
    }
}