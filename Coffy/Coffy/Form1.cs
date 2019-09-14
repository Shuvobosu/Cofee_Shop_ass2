using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        String name, phone, address, orderSelect;

        int quantity;
       

        private void button1_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            phone = contactTextBox.Text;
            address = Address.Text;
            quantity = Convert.ToInt32(quantityBox.Text);
            orderSelect = orderCombox.SelectedItem.ToString();

            int FinalPrice = 0;

            if (orderSelect.Equals("Cold-100"))
            {
                FinalPrice = quantity * 100;
            }
            else if (orderSelect.Equals("Black-120"))
            {
                FinalPrice = quantity * 120;
            }
            else if (orderSelect.Equals("Hot-90"))
            {
                FinalPrice = quantity * 90;
            }
            else if (orderSelect.Equals("Regular-80"))
            {
                FinalPrice = quantity * 80;
            }

            String info = "Name: " + name + "\n\n" + "" + "Phone: " + phone + " \n\n" + "Address: "
                + address + "\n\n" + "Order: " + orderSelect + "\n\n"+"Quantity: "+quantity+"\n\n\n";
            String infoBreker = "-----------------------------";
            infoBreker = infoBreker + "\n\nTotal Price: " + FinalPrice + " tk.\n";
            richTextBox1.Text = info +infoBreker;
          
            
    
        }
    }
}
