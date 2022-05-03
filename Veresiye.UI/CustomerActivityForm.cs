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
    public partial class CustomerActivityForm : Form
    {
        public Customer Customer { get; set; }
        private ICustomerActivityService customerActivityService;
        public CustomerActivityForm()
        {
            InitializeComponent();
            customerActivityService = InstanceFactory.GetInstance<ICustomerActivityService>();
        }

        private async void LoadCustomerActivities()
        {
            Task<List<CustomerActivity>> task = customerActivityService.GetAllAsync(a => a.CustomerId == Customer.Id);
            dataGridView_Activity.DataSource = await task;

            label_Balance.Text = "Bakiye : " + customerActivityService.BakiyeHesapla(Customer).ToString() + "₺";
        }

        private void DataGridViewProperties(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns.Add("ID", "Id");
            dataGridView.Columns.Add("TYPE", "Tipi");
            dataGridView.Columns.Add("DESCRIPTION", "Açıklama");
            dataGridView.Columns.Add("TOTAL", "Tutar");


            dataGridView.Columns["ID"].DataPropertyName = "ID";
            dataGridView.Columns["TYPE"].DataPropertyName = "TYPE";
            dataGridView.Columns["DESCRIPTION"].DataPropertyName = "DESCRIPTION";
            dataGridView.Columns["TOTAL"].DataPropertyName = "TOTAL";

            dataGridView.Columns["ID"].Visible = false;

        }

        private void CustomerActivityForm_Load(object sender, EventArgs e)
        {
            DataGridViewProperties(dataGridView_Activity);
            LoadCustomerActivities();
            label_CustomerCalling.Text = Customer.Calling;
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            using (CustomerActivityDetailForm customerActivityDetailForm = new CustomerActivityDetailForm())
            {
                customerActivityDetailForm.Customer = Customer;
                customerActivityDetailForm.CustomerActivityService = customerActivityService;
                customerActivityDetailForm.ShowDialog();
            }
            LoadCustomerActivities();
        }

        private void dataGridView_Activity_DoubleClick(object sender, EventArgs e)
        {
            using (CustomerActivityDetailForm customerActivityDetailForm = new CustomerActivityDetailForm())
            {
                int id = Convert.ToInt32(dataGridView_Activity.CurrentRow.Cells["ID"].Value);
                customerActivityDetailForm.CustomerActivity = customerActivityService.Get(a => a.Id.Equals(id));
                customerActivityDetailForm.Customer = Customer;
                customerActivityDetailForm.CustomerActivityService = customerActivityService;
                customerActivityDetailForm.ShowDialog();
            }
            LoadCustomerActivities();

        }
    }
}
