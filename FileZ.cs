using FileMA1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMA1.Classes
{
    public class FileZ 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int WeightKb { get; set; }
        public Extension FileExtension { get; set; }

        public FileZ(int id, string name,  int weighthtKb, Extension fileExtension) 
        {
            Id = id;
            Name = name;
            WeightKb = weighthtKb;
            FileExtension = fileExtension;
            Content = string.Empty;
        }

        public FileZ() 
        { 
        }

        public void SaveFile(int fileId)
        {
            
            Id = fileId;
            Console.WriteLine("Save");
            Console.WriteLine("Please enter the name of the file");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter the weight");
            WeightKb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter file extension <1> doc , <2> txt , <3> pdf");
            int exten;
            exten = Convert.ToInt32(Console.ReadLine());
            if (exten == 1)
            {
                FileExtension = Extension.doc;
            }else if (exten == 2)
            {
                FileExtension= Extension.txt;
            }
            else
            {
                FileExtension = Extension.pdf;
            }
            FileZ newFile = new FileZ(fileId, Name, WeightKb, FileExtension);

        }

        public FileZ ReadFile(FileZ fileToRead)
        {
            Console.WriteLine("This is the result of the ReadFile");
            Console.WriteLine(fileToRead.Name);
            Console.WriteLine(fileToRead.WeightKb);
            Console.WriteLine(fileToRead.FileExtension);
            return fileToRead;
        }

        public FileZ ReadFileByID(FileZ fileToRead, int id)
        {
            if(fileToRead.Id == id)
            Console.WriteLine("This is the result of the ReadFileById");
            Console.WriteLine(fileToRead.Name);
            Console.WriteLine(fileToRead.WeightKb);
            Console.WriteLine(fileToRead.FileExtension);
            return fileToRead;
        }


    }
}
