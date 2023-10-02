using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaCalculator.Domain.Abstract;


namespace ShapeAreaCalculator.Infrastructure.Services
{
    public class NotepadService
    {
        public void SaveToNotepad(ISaveableShape saveableShape)
        {
            string path = DirectoryService.GetNotepadDirectory();
            
            DirectoryService.DirectoryCreateIfNotExist(path);

            File.AppendAllText($"{path}/{saveableShape.GetType()}.txt", saveableShape.GetInfos());
        }
    }
}
