using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITRY
{
    
    public partial class Form1 : Form
    {
        // variables 
        string var;
        int passed;
        int passed_2;
        string cur_2;
        long memory_size;
        string holeStart; // starting address text
        string sizeInput; // hole size text from console
        List <long> start_address = new List<long>();  // starting time of each hole 
        List <long> sizeHole = new List<long>(); // size of each hole 
        int i = 0; // counter
        int j = 0; // counter
        int n = 0; // hole start address length
        bool firstCheck; // to check if it is first fit
        bool bestCheck;
        bool worstCheck;// to check if it is best fit
        bool de_allocate; // to deallocate current process
        bool de_allocate_old; // to check old process
        string process; // user input process
        bool validCount = true;
       

        
            Memory my_memory = new Memory(0); 
        


        // parsing function 
        List<long> parseArray(string parseinput)
        {
            // 
            n = 0;
            var = "";
            List <long> tempArray = new List<long>();
            int len = parseinput.Length;
            for (i = 0; i < len; i++)
            {
                if (parseinput[i] == ' ')
                {
                    // storing the value if starting address into array
                   // tempArray[n] = long.Parse(var);
                    tempArray.Add(long.Parse(var));
                    var = "";
                    n++;

                }
                else
                {
                    var += parseinput[i];
                }

            }
            tempArray.Add(long.Parse(var));  // to store the last element
            n++;
            return tempArray;
        }
        // segment name parse
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            outputtext.Text = "";
            textmemory.Text = "";
            startingAddress.Text = "";
            holeSize.Text = "";
            processInput.Text = "";
        }
        // show button 
        private void showButton_Click(object sender, EventArgs e)
        {
            memory_size = (long)long.Parse(textmemory.Text);

            my_memory.size = (long)long.Parse(textmemory.Text); 
           
             my_memory = new Memory(memory_size);
            
            Console.WriteLine("hello from console");
            
            // store the starting addresses
            start_address =  parseArray(holeStart);
            sizeHole =  parseArray(sizeInput);
            
            // check if there is a mistake
            if (start_address.Count != sizeHole.Count)
            {
                MessageBox.Show("ERROR, Lack Of Holes'information");
                validCount = false;
                
            }
            if (validCount)
            {
                for (int i = 0; i < start_address.Count; i++)
                {
                    my_memory.holes.Add(new Hole(start_address[i], sizeHole[i]));
                }

                // start storing

                String process_input_string = this.processInput.Text;
                List<string> process_text = process_input_string.Split(';').ToList();
                for (int i = 0; i < process_text.Count; i++)
                {
                    String process_str = process_text[i];
                    List<string> single_process = process_str.Split(',').ToList();
                    String process_name = single_process[0].Split(':')[0]; //P1
                    Process current_process = new Process(process_name);


                    //process segment start fro =m 1 P1:3,Code:50,Data:200;P2:3,Code:500,Data:400
                    for (int l = 1; l < single_process.Count; l++)
                    {
                        String segment_name = single_process[l].Split(':')[0];
                        string temp = single_process[l].Split(':')[1];
                        long segment_size = long.Parse(temp);
                        current_process.segments.Add(new Segment(segment_name, segment_size, 0)); //a.i added there a 0 bec. of starting address
                    }
                    my_memory.processes.Add(current_process);
                }
            }
            my_memory.current = outputtext;
            if (!my_memory.check_holesize())
            {
                MessageBox.Show("ERROR, Size of Holes is not suitable");
                //Application.Exit();
            }
            else
            {
                if (firstCheck && (start_address.Count == sizeHole.Count))
                {
                    outputtext.Text = "";
                    my_memory.old_proccesses();
                    my_memory.first_fit();
                    my_memory.arrange_all();
                }

                if (bestCheck && (start_address.Count == sizeHole.Count))
                {
                    outputtext.Text = "";
                    my_memory.old_proccesses();
                    my_memory.best_fit();
                    my_memory.arrange_all();
                }
                if (worstCheck && (start_address.Count == sizeHole.Count))
                {
                    outputtext.Text = "";
                    my_memory.old_proccesses();
                    my_memory.worst_fit();
                    my_memory.arrange_all();
                }
                // deallocate old process
                if (oldprocessform.Text != "" && (start_address.Count == sizeHole.Count)) //change here lolo
                {
                    outputtext.Text = "";
                    passed_2 = (int)Int32.Parse(oldprocessform.Text);
                    my_memory.deallocate_old_process(passed_2 - 1);
                    my_memory.arrange_all();
                }
                // deallocate current process
                if (deallocatenumber.Text != "")
                {
                    outputtext.Text = "";
                    passed = (int)Int32.Parse(deallocatenumber.Text);
                    my_memory.deallocate(passed - 1);
                    my_memory.arrange_all();

                }

            }
        }
        // starting Address of each one 
        private void startingAddress_TextChanged(object sender, EventArgs e)
        {
            this.holeStart = startingAddress.Text;
        }
        // hole size text
        private void holeSize_TextChanged(object sender, EventArgs e)
        {
            this.sizeInput = holeSize.Text; // storing the text value of hole size text
        }
        // set memory_size 
        private void memorySize_ValueChanged(object sender, EventArgs e)
        {
            //this.memory_size =(long) memorySize.Value;

            //this.my_memory.size = (long)memorySize.Value; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.bestCheck = best.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.firstCheck = first.Checked;
        }

        private void processInput_TextChanged(object sender, EventArgs e)
        {
            this.process = processInput.Text;
        }

        // check deallocate
        private void deAllocate_CheckedChanged(object sender, EventArgs e)
        {
           // this.de_allocte = deAllocate.Checked;
        }

        // check worst
        private void worst_CheckedChanged(object sender, EventArgs e)
        {
            this.worstCheck = worst.Checked; 
        }

       // get the memory size value
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.memory_size = (long)long.Parse(textmemory.Text);

            //this.my_memory.size = (long)long.Parse(textmemory.Text); 
        }
 
        private void outputtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //outputtext.Text = "alaa" + Environment.NewLine + "1000ALaa";
            Font myfont = new Font("Times New Roman", 10.0f);
            outputtext.Font = myfont;
        }

        private void deallocatenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldprocessform_TextChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}

