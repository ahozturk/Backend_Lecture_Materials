using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Services
{
    internal class NotepadService
    {
        public void SaveToNotepad(string path, string data)
        {
            File.WriteAllText($"{path}\\Deneme.txt", data);
        }
    }
}
