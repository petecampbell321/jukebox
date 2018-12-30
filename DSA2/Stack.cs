using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2
{
    class Stack
    {
        // ATTRIBUTES
        private StackNode top;
        private int size;
        private int capacity;

        // BEHAVIOURS
        // constructor
        public Stack()
        {
            top = null;
            size = 0;
            capacity = 10;
        }// constructor

        // isEmpty
        public Boolean isEmpty()
        {
            if(top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }// isEmpty

        // push
        public Boolean push(StackNode newNode)
        {
            if(size >= capacity)
            {
                return false;
            }
            else
            {
                newNode.previous = top;
                top = newNode;
                size++;
                return true;
            }
        }// push

        // pop
        public StackNode pop()
        {
            if (isEmpty())
            {
                return null;
            }
            else
            {
                StackNode removed = top;
                top = removed.previous;
                size--;
                return removed;
            }
        }// pop

        // list
        public String list()
        {
            if (isEmpty())
            {
                return "There are no records on the spindle...";
            }

            String output = "ALBUMS CURRENTLY ON SPINDLE\n";
            output += "===============================\n";

            StackNode current = top;

            while (current != null)
            {
                output += current.album + " by " + current.artist + "\n";
                current = current.previous;
            }

            return output;
        }// list

        // peek
        public StackNode peek()
        {
            return top;
        }// peek


        // contains
        public Boolean contains(String findAlbum)
        {
            if (isEmpty())
            {
                return false;
            }
            else
            {
                StackNode current = top;

                while (current != null)
                {
                    if ((String.Compare(findAlbum, current.album) == 0))
                    {
                        return true;
                    }
                    else
                    {
                        current = current.previous;
                    }
                }

                return false;
            }
        }// contains

        // removeSelected
        public StackNode removeSelected(String removeAlbum)
        {
            if(isEmpty())
            {
                return null;
            }
            else
            {
                StackNode current = top;

                while (current != null)
                {
                    if ((String.Compare(removeAlbum, current.album) == 0))
                    {
                        return current;
                    }
                    else
                    {
                        current = current.previous;
                    }
                }

                return null;
            }
        }// removeSelected

        
        public int count()
        {
            if (isEmpty())
            {
                return 0;
            }

            int countOutput = 0;
            StackNode current = top;

            while (current != null)
            {
                countOutput++;
                current = current.previous;
            }

            return countOutput;
        }
    }
}
