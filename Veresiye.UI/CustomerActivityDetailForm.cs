using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veresiye.Business.Abstract;
using Veresiye.Entity.Concrete;

namespace Veresiye.UI
{
    public partial class CustomerActivityDetailForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerActivity CustomerActivity { get; set; }
        public ICustomerActivityService CustomerActivityService { get; set; }
        public CustomerActivityDetailForm()
        {
            InitializeComponent();
        }

        private void CustomerActivityDetailForm_Load(object sender, EventArgs e)
        {
            comboBox_Type.Items.Clear();
            comboBox_Type.Items.Add("Borç");
            comboBox_Type.Items.Add("Tahsilat");
            comboBox_Type.Items.Add("Alacak");
            comboBox_Type.Items.Add("Ödeme");

            if (CustomerActivity != null)
            {
                button_Add.Enabled = false;

                comboBox_Type.Text = CustomerActivity.Type;
                textBox_Description.Text = CustomerActivity.Description;
                numericUpDown_Total.Value = CustomerActivity.Total;
            }
            else
            {
                button_Update.Enabled = false;
                button_Delete.Enabled = false;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            CustomerActivity customerActivity = new CustomerActivity
            {
                CustomerId = Customer.Id,
                Type = comboBox_Type.Text,
                Description = textBox_Description.Text,
                Total = numericUpDown_Total.Value,                
            };
            CustomerActivityService.Add(customerActivity);
            this.Close();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            CustomerActivity customerActivity = new CustomerActivity
            {
                Id=CustomerActivity.Id,
                CustomerId = Customer.Id,
                Type = comboBox_Type.Text,
                Description = textBox_Description.Text,
                Total = numericUpDown_Total.Value,
            };
            CustomerActivityService.Update(customerActivity);
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            CustomerActivityService.Delete(CustomerActivity);
            this.Close();
        }
    }
}
