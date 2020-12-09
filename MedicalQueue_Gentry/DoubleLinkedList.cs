using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Gentry
{
    class DoubleLinkedList
    {
        //the head tail and current nodes will help make the movement of nodes happen and to keep things organized in the list.
        private Node HeadNode;
        private Node TailNode;
        private Node CurrentNode;
        private int totalCount;

        public DoubleLinkedList()
        {
            HeadNode = null;
            TailNode = null;
        }

        //add a node or enqueue
        //a sorted add funtion where the new node is added to the end of the priorty level it was given
        // we were asked to give back an int of the size of the queue or -1 if the add failed.
        private int enqueueu(Patients input)
        {
            //first node in or only node in
            if(HeadNode == null)
            {
                Node temp = new Node(input);
                HeadNode = temp;
                TailNode = temp;
                totalCount++;
                return totalCount;
            }
            //if the priority is a 5 it becomes the new tailnode
            else if(input.GetPriority() == 5)
            {
                Node temp = new Node(input);
                TailNode.Next = temp;
                temp.Prev = TailNode;
                TailNode = temp;
                totalCount++;
                return totalCount;
            }
            //add to the middle of the list
            else
            {
                CurrentNode = HeadNode;
                while (CurrentNode.GetPriority() <= input.GetPriority())
                {
                    if (CurrentNode == TailNode)
                    {
                        Node temp = new Node(input);
                        TailNode.Next = temp;
                        temp.Prev = TailNode;
                        TailNode = temp;
                        totalCount++;
                        return totalCount;
                    }
                    CurrentNode = CurrentNode.Next;
                }
                //in a case where the new input is of highest priorty and needed to be added to the frount of the list
                if(CurrentNode == HeadNode)
                {
                    Node temp = new Node(input);
                    HeadNode.Prev = temp;
                    temp.Next = HeadNode;
                    HeadNode = temp;
                    totalCount++;
                    return totalCount;
                }
                else if(CurrentNode == TailNode)
                {
                    Node temp = new Node(input);
                    TailNode.Next = temp;
                    temp.Prev = TailNode;
                    TailNode = temp;
                    totalCount++;
                    return totalCount;
                }
                else
                {
                    Node temp = new Node(input);
                    temp.Next = CurrentNode;
                    temp.Prev = CurrentNode.Prev;
                    CurrentNode.Prev = temp;
                    CurrentNode.Prev.Prev.Next = temp;
                    totalCount++;
                    return totalCount;
                }
            }
        }

        //the show and remove method of the queue or the dequeue
        //i hold the node that is to be returned in curent node but set the new head node to 
        //the node previos so that as sone as curent moves the node is droped
        private Node dequeue()
        {
            CurrentNode = HeadNode;
            HeadNode = HeadNode.Next;
            HeadNode.Prev = null;
            totalCount--;
            return CurrentNode;
        }

        //a print of the list
        public  string PrintList()
        {
            string fullList = "";
            CurrentNode = HeadNode;
            while(CurrentNode != null)
            {
                fullList = fullList + CurrentNode.GetName() + "    " + CurrentNode.GetPriority().ToString() + "\n";
                CurrentNode = CurrentNode.Next;
            }
            return fullList;
        }

        //the public face of the class for enqueue and dequeue
        public int AddPatient(string name, int Priority)
        {
            Patients temp = new Patients(name, Priority);
            return enqueueu(temp);
        }
        public Node ProcessCurrentPatient()
        {
            return dequeue();
        }
        public int CurrentCount()
        {
            return totalCount;
        }
    }
}
