namespace GUITRY
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.holeSize = new System.Windows.Forms.TextBox();
            this.startingAddress = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.RadioButton();
            this.best = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.processInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.worst = new System.Windows.Forms.RadioButton();
            this.textmemory = new System.Windows.Forms.TextBox();
            this.outputtext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deallocatenumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.oldprocessform = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Address of Each Hole";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size Of Hole";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(342, 500);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(713, 500);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // holeSize
            // 
            this.holeSize.Location = new System.Drawing.Point(313, 159);
            this.holeSize.Name = "holeSize";
            this.holeSize.Size = new System.Drawing.Size(566, 22);
            this.holeSize.TabIndex = 8;
            this.holeSize.TextChanged += new System.EventHandler(this.holeSize_TextChanged);
            // 
            // startingAddress
            // 
            this.startingAddress.Location = new System.Drawing.Point(313, 85);
            this.startingAddress.Name = "startingAddress";
            this.startingAddress.Size = new System.Drawing.Size(566, 22);
            this.startingAddress.TabIndex = 10;
            this.startingAddress.TextChanged += new System.EventHandler(this.startingAddress_TextChanged);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(420, 288);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(75, 21);
            this.first.TabIndex = 12;
            this.first.TabStop = true;
            this.first.Text = "First Fit";
            this.first.UseVisualStyleBackColor = true;
            this.first.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // best
            // 
            this.best.AutoSize = true;
            this.best.Location = new System.Drawing.Point(520, 288);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(76, 21);
            this.best.TabIndex = 13;
            this.best.TabStop = true;
            this.best.Text = "Best Fit";
            this.best.UseVisualStyleBackColor = true;
            this.best.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Proccesses";
            // 
            // processInput
            // 
            this.processInput.Location = new System.Drawing.Point(313, 233);
            this.processInput.Name = "processInput";
            this.processInput.Size = new System.Drawing.Size(566, 22);
            this.processInput.TabIndex = 16;
            this.processInput.TextChanged += new System.EventHandler(this.processInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Please enter the size of each hole ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Please enter the start address of each hole ";
            // 
            // worst
            // 
            this.worst.AutoSize = true;
            this.worst.Location = new System.Drawing.Point(636, 288);
            this.worst.Name = "worst";
            this.worst.Size = new System.Drawing.Size(85, 21);
            this.worst.TabIndex = 25;
            this.worst.TabStop = true;
            this.worst.Text = "Worst Fit";
            this.worst.UseVisualStyleBackColor = true;
            this.worst.CheckedChanged += new System.EventHandler(this.worst_CheckedChanged);
            // 
            // textmemory
            // 
            this.textmemory.Location = new System.Drawing.Point(313, 12);
            this.textmemory.Name = "textmemory";
            this.textmemory.Size = new System.Drawing.Size(566, 22);
            this.textmemory.TabIndex = 27;
            this.textmemory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputtext
            // 
            this.outputtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.outputtext.Location = new System.Drawing.Point(985, -3);
            this.outputtext.Multiline = true;
            this.outputtext.Name = "outputtext";
            this.outputtext.Size = new System.Drawing.Size(433, 701);
            this.outputtext.TabIndex = 29;
            this.outputtext.TextChanged += new System.EventHandler(this.outputtext_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "de-allocate process";
            // 
            // deallocatenumber
            // 
            this.deallocatenumber.Location = new System.Drawing.Point(313, 348);
            this.deallocatenumber.Name = "deallocatenumber";
            this.deallocatenumber.Size = new System.Drawing.Size(566, 22);
            this.deallocatenumber.TabIndex = 31;
            this.deallocatenumber.TextChanged += new System.EventHandler(this.deallocatenumber_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "de-allocate Old Process";
            // 
            // oldprocessform
            // 
            this.oldprocessform.Location = new System.Drawing.Point(313, 402);
            this.oldprocessform.Name = "oldprocessform";
            this.oldprocessform.Size = new System.Drawing.Size(566, 22);
            this.oldprocessform.TabIndex = 34;
            this.oldprocessform.TextChanged += new System.EventHandler(this.oldprocessform_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Example: 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Example: 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(364, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "P1:2,data:20,stack:30;P2:3,Data:10,stack:30,memory:55";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 603);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.oldprocessform);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.deallocatenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputtext);
            this.Controls.Add(this.textmemory);
            this.Controls.Add(this.worst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.processInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.best);
            this.Controls.Add(this.first);
            this.Controls.Add(this.startingAddress);
            this.Controls.Add(this.holeSize);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox holeSize;
        private System.Windows.Forms.TextBox startingAddress;
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton best;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox processInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton worst;
        private System.Windows.Forms.TextBox textmemory;
        private System.Windows.Forms.TextBox outputtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deallocatenumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox oldprocessform;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

