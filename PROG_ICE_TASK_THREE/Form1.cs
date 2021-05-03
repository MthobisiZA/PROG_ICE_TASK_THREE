using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // StreamWriter method
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_ICE_TASK_THREE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txbName.Text;
            String date = dtpDateCreation.Text;
            String priorities = txbPriorities.Text;

            TODO contacts = new TODO(name,date,priorities);

            lbName.Items.Add(name); // adds Name inputed, To the listbox
            
            txbName.Clear(); // clears inputed data in the name textbox
           
            txbPriorities.Clear(); // clears inputed data in the priorities textbox



            // Stream writer for the creation of Textfile:
            using (StreamWriter streamWriter = new StreamWriter("TODO.txt"))
            {
                // writes or output details on the TODO.txt(Textfile):
                streamWriter.WriteLine("Name: "+txbName.Text+", Date: "+dtpDateCreation.Text+", Priorities"+ txbPriorities.Text);
            }

                // adds saved Information to the listView:
                listViewName.Items.Add("Details\n" +
                                       "************************\n" +
                                       "Date:\t" + date + "\n" +
                                       "Priorities:\t" + priorities);
            

        }
    }
}
