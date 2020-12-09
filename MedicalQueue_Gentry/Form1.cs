using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalQueue_Gentry
{
    public partial class MedicalQueue : Form
    {
        DoubleLinkedList ERQueue = new DoubleLinkedList();
        public MedicalQueue()
        {
            InitializeComponent();
        }

        private void AddToQueue_Click(object sender, EventArgs e)
        {
            if(NameToAdd.Text ==  "" || PriorityToAdd.Text == "" )
            {
                totalCount.Text = "-1";
                return;
            }
            else
            {
                totalCount.Text = ERQueue.AddPatient(NameToAdd.Text, int.Parse(PriorityToAdd.Text)).ToString();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Node ToProcces = ERQueue.ProcessCurrentPatient();
            totalCount.Text = ERQueue.CurrentCount().ToString();
            CurrentPatient.Text = ToProcces.GetName() + "    " + ToProcces.GetPriority().ToString();
        }

        private void listPatients_Click(object sender, EventArgs e)
        {
            ListPoint.Text = ERQueue.PrintList();
        }
    }
}
