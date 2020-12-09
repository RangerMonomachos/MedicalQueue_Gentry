using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Gentry
{
    class Patients
    {
        private string Name;
        private int Priority;
        public Patients (string name, int priority)
        {
            Name = name;
            Priority = priority;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetPriority()
        {
            return Priority;
        }
    }
}
