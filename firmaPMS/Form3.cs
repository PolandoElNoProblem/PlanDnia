using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace firmaPMS
{
    public partial class dChoose : Form
    {
        public string nazwa = "";

        public dChoose()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ChooseDay.SelectedText=nazwa; 

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (ChooseDay.Text == null)
            {
                MessageBox.Show("Wybierz wartosc");
            }
            else { 
            try
            {
                string selectedItem = ChooseDay.Text;
                        nazwa = selectedItem;
                    
            }
            catch (Exception ef)
            {
                Console.WriteLine("{0} Exception caught.", ef);
            }
            }
        }

        private void ChooseDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
           
        }
    }
}
