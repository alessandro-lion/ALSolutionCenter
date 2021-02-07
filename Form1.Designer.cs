
namespace ALSolutionCenter
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
            this.button1ToolBox = new System.Windows.Forms.Button();
            this.button2PDF = new System.Windows.Forms.Button();
            this.button3JPG = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxHPPrinter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1ToolBox
            // 
            this.button1ToolBox.Location = new System.Drawing.Point(62, 89);
            this.button1ToolBox.Name = "button1ToolBox";
            this.button1ToolBox.Size = new System.Drawing.Size(124, 76);
            this.button1ToolBox.TabIndex = 0;
            this.button1ToolBox.Text = "ToolBox";
            this.button1ToolBox.UseVisualStyleBackColor = true;
            this.button1ToolBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2PDF
            // 
            this.button2PDF.Location = new System.Drawing.Point(243, 89);
            this.button2PDF.Name = "button2PDF";
            this.button2PDF.Size = new System.Drawing.Size(124, 76);
            this.button2PDF.TabIndex = 1;
            this.button2PDF.Text = "Scan PDF";
            this.button2PDF.UseVisualStyleBackColor = true;
            this.button2PDF.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3JPG
            // 
            this.button3JPG.Location = new System.Drawing.Point(243, 188);
            this.button3JPG.Name = "button3JPG";
            this.button3JPG.Size = new System.Drawing.Size(124, 76);
            this.button3JPG.TabIndex = 2;
            this.button3JPG.Text = "Scan JPG";
            this.button3JPG.UseVisualStyleBackColor = true;
            this.button3JPG.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "HP Guided Solution 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "2021 FOSS ( Free Open Source Software ) from Alex \"Pi\" Lion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 89);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(107, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://alexpilion.wordpress.com/links/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Foss without fuss, just working. If it doesn\'t feel fre to let me know.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 22);
            this.panel2.TabIndex = 7;
            // 
            // comboBoxHPPrinter
            // 
            this.comboBoxHPPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHPPrinter.FormattingEnabled = true;
            this.comboBoxHPPrinter.Location = new System.Drawing.Point(56, 17);
            this.comboBoxHPPrinter.Name = "comboBoxHPPrinter";
            this.comboBoxHPPrinter.Size = new System.Drawing.Size(332, 21);
            this.comboBoxHPPrinter.TabIndex = 8;
            this.comboBoxHPPrinter.SelectedIndexChanged += new System.EventHandler(this.comboBoxHPPrinter_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBoxHPPrinter);
            this.panel3.Location = new System.Drawing.Point(9, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 58);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Printer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(433, 394);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3JPG);
            this.Controls.Add(this.button2PDF);
            this.Controls.Add(this.button1ToolBox);
            this.Name = "Form1";
            this.Text = "Alex Lion Solution Center for HP DeskJet F2280";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1ToolBox;
        private System.Windows.Forms.Button button2PDF;
        private System.Windows.Forms.Button button3JPG;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxHPPrinter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}

