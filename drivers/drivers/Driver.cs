using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drivers
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.database1DataSet.Driver);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization f = new Authorization();
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DriversLicense f = new DriversLicense();
            f.Show();
        }
    }
}
