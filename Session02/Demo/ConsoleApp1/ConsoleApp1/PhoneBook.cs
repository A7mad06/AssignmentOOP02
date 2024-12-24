using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class PhoneBook
    {
        #region Attributes
        string[] Names;
        long[] Numbers;
        int size;
        #endregion
        public int Size
        {
            get
            {
                return size;
            }
        }
        public PhoneBook(int _size)
        {
            size = _size;
            Names = new string[size];
            Numbers = new long[size];
        }
        public void AddPerson(int pos,string name,long number)
        {
            if (Names is not null && Numbers is not null && pos>-1 && pos <Size)
            {
                Names[pos] = name;
                Numbers[pos] = number;
            }
        }
        #region Encapsulation
        //Get
        
        public long GetNumber(string name)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (Names[i] == name)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;
        }

        //Set
        public void SetNumber(string name,long number)
        {
            if(Numbers is not null && Names is not null)
            {
                for(int i = 0; i < size; i++)
                {
                    if (Names[i] == name)
                    {
                        Numbers[i] = number;
                    }
                }
            }
        }
        //Indexer
        public long this[string name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (Names[i] == name)
                        {
                            return Numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (Numbers is not null && Names is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (Names[i] == name)
                        {
                            Numbers[i] = value;
                        }
                    }
                }
            }
        }
        public string this[long number]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (Numbers[i] == number)
                        {
                            return Names[i];
                        }
                    }
                }
                return "";
            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (Numbers[i] == number)
                        {
                            Names[i]=value;
                        }
                    }
                }
            }
        }
        #endregion
    }
}
