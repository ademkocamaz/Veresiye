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
using Veresiye.Business.DependencyResolvers.Ninject;
using Veresiye.Entity.Concrete;

namespace Veresiye.UI
{
    public partial class MainForm : Form
    {

        private ICustomerService customerService;
        public MainForm()
        {
            InitializeComponent();
            customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void LoadCustomers()
        {
            dataGridView_Customers.DataSource = customerService.GetAll();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataGridViewProperties(dataGridView_Customers);
            LoadCustomers();
        }

        private void DataGridViewProperties(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns.Add("ID", "Id");
            dataGridView.Columns.Add("CALLING", "Ünvan");
            dataGridView.Columns.Add("CONTACT", "Yetkili");
            dataGridView.Columns.Add("GSM", "Gsm");
            dataGridView.Columns.Add("BALANCE", "Bakiye");

            dataGridView.Columns["ID"].DataPropertyName = "ID";
            dataGridView.Columns["CALLING"].DataPropertyName = "CALLING";
            dataGridView.Columns["CONTACT"].DataPropertyName = "CONTACT";
            dataGridView.Columns["GSM"].DataPropertyName = "GSM";
            dataGridView.Columns["BALANCE"].DataPropertyName = "BALANCE";

            dataGridView.Columns["ID"].Visible = false;


        }

        private void dataGridView_Customers_DoubleClick(object sender, EventArgs e)
        {
            using (CustomerDetailForm customerDetailForm = new CustomerDetailForm())
            {
                int id = Convert.ToInt32(dataGridView_Customers.CurrentRow.Cells["ID"].Value);
                customerDetailForm.Customer = customerService.Get(c => c.Id.Equals(id));
                customerDetailForm.CustomerService = customerService;
                customerDetailForm.ShowDialog();
            }
            LoadCustomers();

        }

        private void button_New_Click(object sender, EventArgs e)
        {
            using (CustomerDetailForm customerDetailForm = new CustomerDetailForm())
            { 
                customerDetailForm.CustomerService = customerService;
                customerDetailForm.ShowDialog();
            }
            LoadCustomers();
        }

        private void button_Activity_Click(object sender, EventArgs e)
        {
            using (CustomerActivityForm customerActivityForm = new CustomerActivityForm())
            {
                int id = Convert.ToInt32(dataGridView_Customers.CurrentRow.Cells["ID"].Value);
                customerActivityForm.Customer = customerService.Get(c => c.Id.Equals(id));
                customerActivityForm.ShowDialog();
            }
        }
    }
}
