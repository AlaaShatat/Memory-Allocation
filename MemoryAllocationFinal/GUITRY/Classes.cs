using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUITRY
{

    public class Memory
    {

        public long size;
        public List<Process> processes;
        public List<Hole> holes;
        public List<Hole> prim_holes = new List<Hole>();
        public List<Hole> prim_old = new List<Hole>();
        public List<long> starting = new List<long>();  // store the starting address of each process, hole, old process
        public List<long> finishing = new List<long>(); //store the finishing address of each process, hole, old process
        public List<string> naming = new List<string>(); //store the name of each process, hole, old process
        public TableLayoutPanel drawTable = new TableLayoutPanel();
        public TextBox current = new TextBox();
        public string sent;
       // drawTable.Controls.Add(, 3, 0);
        public Memory(long size_)
        {
            size = size_;
            processes = new List<Process>();
            holes = new List<Hole>();
            ///prim_holes= new List<Hole>();
        }

        public bool check_holesize() 
        {
            long sum = 0;
            for (int k = 0; k < holes.Count; k++ )
            {
                if (k < holes.Count - 1 && holes[k + 1].start_address < holes[k].start_address + holes[k].size)
                {
                    return false;
                }
                    
                    sum += holes[k].size;
                    if (sum>size) 
                    {
                        return false;
                    }
            }
            
            return true;
        }



        ///// function of first fit 

        public void first_fit() //n >> no. of segments , p>> process order
        {

            for (int p = 0; p < processes.Count; p++) // move through process by process
            {
                int n = processes[p].segments.Count; //no. of segments in the procees i work on now
                int h = holes.Count; // no. of holes in memory

                for (int u = 0; u < n; u++)
                    processes[p].segments[u].start_address = -1;

                for (int i = 0; i < n; i++) // n no. of segments 
                {


                    for (int j = 0; j < h; j++) //find the sutable hole for the segment
                    {
                        if (holes[j].size > processes[p].segments[i].size)
                        {
                            processes[p].segments[i].start_address = holes[j].start_address;
                            holes[j].start_address += processes[p].segments[i].size;
                            holes[j].size = holes[j].size - processes[p].segments[i].size;
                            break;
                        }
                        if (holes[j].size == processes[p].segments[i].size)
                        {
                            processes[p].segments[i].start_address = holes[j].start_address;
                            holes.RemoveAt(j);
                            h = holes.Count;
                            break;
                        }


                    }
                    if (processes[p].segments[i].start_address == -1)
                    {
                        int x = p + 1;
                        Console.Write("Not Allocated");
                        MessageBox.Show("Process " + x + " is not allocated");
                        for (int ir = i; ir < processes[p].segments.Count; ir++)
                            processes[p].segments.RemoveAt(ir);
                        deallocate(p);
                        p--;

                        break;

                    }
                }


            }



        }

        // print all
        public void arrange_all()
        {
            starting.Clear();
            finishing.Clear();
            naming.Clear();

            // for loop processes to sort three list 
            for (int i = 0; i < processes.Count; i++)
            {
                Process p = processes[i];
                for (int j = 0; j < p.segments.Count; j++)
                {
                   
                        long var = p.segments[j].start_address;
                        starting.Add(var);
                        long var_2 = p.segments[j].start_address + p.segments[j].size;
                        finishing.Add(var_2);
                        string var_3 = p.name + ":" + p.segments[j].name;
                        naming.Add(var_3);
                    
                }
            }

            // for loop holes
            for (int i = 0; i < holes.Count; i++)
            {
                starting.Add(holes[i].start_address);
                finishing.Add(holes[i].start_address + holes[i].size);
                string hole_name = "hole " + (i+1).ToString();
                naming.Add(hole_name);
            }

            // for loop old processes

            for (int i = 0; i < prim_old.Count; i++)
            {
                starting.Add(prim_old[i].start_address);
                finishing.Add(prim_old[i].start_address + prim_old[i].size);
                string hole_name = "Old Process" + (i + 1).ToString();
                naming.Add(hole_name);
            }
            //       
            long temp1;
            long temp2;
            string temp3;
            for (int c = 0; c < starting.Count; c++)
            {
                int first = c;
                for (int y = c + 1; y < starting.Count; y++)
                {
                    if (starting[first] > starting[y])
                    {
                        first = y;
                    }
                }
                temp1 = starting[c];
                starting[c] = starting[first];
                starting[first] = temp1;

                temp2 = finishing[c];
                finishing[c] = finishing[first];
                finishing[first] = temp2;

                temp3 = naming[c];
                naming[c] = naming[first];
                naming[first] = temp3;
            }
            drawTable.ColumnCount = 1;
            for (int i = 0; i < starting.Count; i++ )
            {
                //   if (i < starting.Count - 1 && (starting[i] == starting[i + 1] || starting[i]<0))
                //if  (starting[i] == finishing[i] || starting[i] < 0 || (i < starting.Count - 1 && (starting[i] == starting[i + 1])))
                if (starting[i] < 0)
                {
                    starting.RemoveAt(i);
                    finishing.RemoveAt(i);
                    naming.RemoveAt(i);
                    i--;
                
                }
                else
                {

                    sent = starting[i] + "_________________" + Environment.NewLine + "   " + naming[i] + Environment.NewLine;
                    current.Text += sent;

                    Console.WriteLine("the process is: " + naming[i]);
                    Console.WriteLine("the starting address is: " + starting[i]);
                    Console.WriteLine("the finishing address is: " + finishing[i]);
                    Console.WriteLine("\n");
                }
            }
            current.Text += size + "_________________";
            MessageBox.Show(current.Text + size + "_________________");


            
        }



        public void deallocate(int req)
        {
            int n = processes[req].segments.Count; //no. of segments in the procees i work on now


            for (int i = 0; i < n; i++)
            {
                Hole hole = new Hole(processes[req].segments[i].start_address, processes[req].segments[i].size);
                holes.Add(hole);
            }
            processes.RemoveAt(req);
            int h = holes.Count; // no. of holes in memory

            //function to arrange of holse by address

            bestfirstarrange();

            //////////////////////

            for (int j = 1; j < holes.Count; j++)
            {
                long temp = holes[j - 1].start_address + holes[j - 1].size; //end of the hole

                if (temp == holes[j].start_address)
                {

                    holes[j - 1].size += holes[j].size;
                    holes.RemoveAt(j);
                    j--;

                }

            }


        }

        public void deallocate_old_process(int req)
        {

            int n = prim_old.Count; //no. of segments in the procees i work on now

            Hole hole = new Hole(prim_old[req].start_address, prim_old[req].size);
            holes.Add(hole);
            prim_old.RemoveAt(req);
            //function to arrange of holse by address
            bestfirstarrange();
            int h = holes.Count; // no. of holes in memory

            for (int j = 1; j < h; j++)
            {
                long temp = holes[j - 1].start_address + holes[j - 1].size; //end of the hole

                if (temp == holes[j].start_address)
                {
                    holes[j - 1].size += holes[j].size;
                    holes.RemoveAt(j);
                    h = holes.Count;
                }

            }

        }
    public class Hole
        {
            public long size;
            public long start_address;
            public Hole(long start_address_, long size_)
            {
                size = size_;
                start_address = start_address_;
            }
        }
        public class Process
        {

            public long size;
            public List<Segment> segments;
            public string name;

            public Process(string name_)
            {

                name = name_;
                segments = new List<Segment>();
            }

        }
        public class Segment
        {

            public long size;
            public string name;
            public long start_address;
            public Segment(string name_, long size_, long start_)
            {
                size = size_;
                name = name_;
                start_address = start_;
            }

        }


    
}


