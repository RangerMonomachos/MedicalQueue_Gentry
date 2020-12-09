using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Gentry
{
    class Node
    {
        private Patients Data;
        public Node Prev;
        public Node Next;

        public Node(Patients data)
        {
            Data = data;
        }

        public String GetName()
        {
            return Data.GetName();
        }
        public int GetPriority()
        {
            return Data.GetPriority();
        }
    }
}
