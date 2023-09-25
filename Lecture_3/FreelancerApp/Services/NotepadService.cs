﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3.Services
{
    internal class NotepadService
    {
        public void SaveToNotepad(string text)
        {
            string path = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Database";
            string filePath = $"{path}\\Customers.txt";


            if (!File.Exists(path))
                Directory.CreateDirectory(path);

            File.AppendAllText(filePath, $"{text}\n");
        }

        public string ReadNotepad()
        {
            string path = @$"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Database";
            string filePath = $"{path}\\Customers.txt";

            if (File.Exists(filePath))
                return File.ReadAllText(filePath);

            throw new Exception("File Path Does Not Exist!");
        }
    }
}