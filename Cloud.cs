using FileMA1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMA1.Classes
{
    public class Cloud
    {
        public string OrdnerName { get; set; }
        public List<FileZ> files { get; set; } 


        public Cloud()
        {
            files = new List<FileZ>();
        }

        public void SaveFileInCloud(FileZ newFile)
        {
            files.Add(newFile);
        }

        public void SaveFileInCloud(string newFileName)
        {
            files.Add(newFileName);
        }

        public WriteStatus WriteToFile (string name, string content)
        {
            var file = files.Find(f => name.Equals(name));
            if(file != null)
            {
                string breaker = "";
                if (file.Content != string.Empty) breaker = "\n";
                file.Content = breaker + content;
            }
        }


         
        public Cloud ReadAllFilesFromCloud(Cloud cloud)
        {
            Console.WriteLine("____________________________");
            foreach (var fileZ in cloud.files)
            {
                Console.WriteLine(fileZ.Name + " " + fileZ.FileExtension + " " + fileZ.WeightKb);
                Console.WriteLine("____________________________");
            }


            return cloud;
        }

        public Cloud ReadOneFilesFromCloud(Cloud cloud, int fileId)
        {
            Console.WriteLine("____________________________");
            foreach (var fileZ in cloud.files)
            {
                if(fileZ.Id == fileId)
                Console.WriteLine(fileZ.Name + " " + fileZ.FileExtension + " " + fileZ.WeightKb);
                Console.WriteLine("____________________________");
            }


            return cloud;
        }
    }

    }

