using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Abstract
{
    internal interface IEntity
    {
        (string data, string name) GetStringCSV();
        void SetValuesCSV(string line);
    }
}
