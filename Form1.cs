using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ALSolutionCenter
{
    public partial class Form1 : Form
    {
        private string sActionToolBox;
        private string sActionScan;
        private string sActionGuidedSol;
        private string sSelectedPrinter;
        private string sSelectedPrinterCUE;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            App_Starting(label3, comboBoxHPPrinter);
        }

        static void App_Starting(Label reflabel, ComboBox refcomboBox)
        {
            PopulateInstalledHPPrintersCombo(refcomboBox);
        }

        static void PopulateInstalledHPPrintersCombo(ComboBox MyHPPrinterCombo)
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                if (pkInstalledPrinters.IndexOf("HP ") > -1)
                {
                    MyHPPrinterCombo.Items.Add(pkInstalledPrinters);
                }
            }
            if (MyHPPrinterCombo.Items.Count > 0)
            {
                MyHPPrinterCombo.SelectedIndex = 0;
            }
        }

        private void comboBoxHPPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            sSelectedPrinter = comboBoxHPPrinter.SelectedItem.ToString();
            PrepareButtons();
        }

        private void PrepareButtons()
        {
            // "Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Print\Printers\HP Deskjet F2200 series\PrinterDriverData"
            const string printersRoot = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Print\\Printers\\";
            const string printerToolBox = "C:\\Program Files (x86)\\HP\\Digital Imaging\\bin\\hpqtbx01.exe";
            const string printerGuidedSol = "C:\\Program Files (x86)\\HP\\Digital Imaging\\bin\\hpqgplgt02.exe";
            const string printerscanexe = "C:\\Program Files (x86)\\HP\\Digital Imaging\\bin\\hpqkygrp.exe";

            string skeyName = printersRoot + "\\" + sSelectedPrinter + "\\PrinterDriverData";


            /*
             * TODO: New func, check if the driver is installed on the canonical path and eventually fix the path in the sAction variabiles accordingly to the 
            real position

             * 
             * Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Hewlett-Packard\Models
             * Keyname= HP Deskjet F2200 series 
             * Value= C:\Program Files (x86)\HP\Digital Imaging\{60D6AAC5-FDC1-49BA-867B-3135F4726156}\
             *  */

            /*
             * ??? NOT IMPLEMENTED BUTTON
             * "C:\Program Files (x86)\HP\Digital Imaging\bin\hpqkygrp.exe" -n"#Hewlett-Packard#HP Deskjet F2200 series#1602513960" -aSCAN -fSCAN_TMA
            * */

            sSelectedPrinterCUE = Registry.GetValue(skeyName, "SoftwareCUEContextID", "").ToString();

            label3.Text = "Preparing Buttons for " + sSelectedPrinterCUE;

            sActionToolBox = printerToolBox;
            sActionGuidedSol = printerGuidedSol;
            sActionScan = printerscanexe;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start(sActionToolBox, "\"" + sSelectedPrinter + "\"");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(sActionGuidedSol, sSelectedPrinter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(sActionScan, "-aSCAN -fSCAN_DOCUMENT -n\"" + sSelectedPrinterCUE + "\"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(sActionScan, "-aSCAN -fSCAN_PICTURE -n\"" + sSelectedPrinterCUE + "\"");
        }
    }
}
