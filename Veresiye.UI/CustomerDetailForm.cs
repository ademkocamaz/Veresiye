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
    public partial class CustomerDetailForm : Form
    {
        public Customer Customer { get; set; }
        public ICustomerService CustomerService { get; set; }
        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                button_Add.Enabled = false;

                textBox_ID.Text = Customer.Id.ToString();
                textBox_Calling.Text = Customer.Calling;
                textBox_Contact.Text = Customer.Contact;
                textBox_Gsm.Text = Customer.Gsm;
                textBox_Phone.Text = Customer.Phone;
                textBox_Fax.Text = Customer.Fax;
                textBox_Address.Text = Customer.Address;
                textBox_City.Text = Customer.City;
                textBox_County.Text = Customer.County;
                textBox_TaxOffice.Text = Customer.TaxOffice;
                textBox_TaxID.Text = Customer.TaxId;
                textBox_EMail.Text = Customer.EMail;
                textBox_Web.Text = Customer.Web;
            }
            else
            {
                button_Update.Enabled = false;
                button_Delete.Enabled = false;
                label_ID.Visible = false;
                textBox_ID.Visible = false;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Calling=textBox_Calling.Text,
                Contact=textBox_Contact.Text,
                Gsm=textBox_Gsm.Text,
                Phone=textBox_Phone.Text,
                Fax=textBox_Fax.Text,
                Address=textBox_Address.Text,
                City=textBox_City.Text,
                County=textBox_County.Text,
                TaxOffice=textBox_TaxOffice.Text,
                TaxId=textBox_TaxID.Text,
                EMail=textBox_EMail.Text,
                Web=textBox_Web.Text
            };
            CustomerService.Add(customer);
            this.Close();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Id=Customer.Id,
                Calling = textBox_Calling.Text,
                Contact = textBox_Contact.Text,
                Gsm = textBox_Gsm.Text,
                Phone = textBox_Phone.Text,
                Fax = textBox_Fax.Text,
                Address = textBox_Address.Text,
                City = textBox_City.Text,
                County = textBox_County.Text,
                TaxOffice = textBox_TaxOffice.Text,
                TaxId = textBox_TaxID.Text,
                EMail = textBox_EMail.Text,
                Web = textBox_Web.Text
            };
            CustomerService.Update(customer);
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            CustomerService.Delete(Customer);
            this.Close();
        }
    }
}
