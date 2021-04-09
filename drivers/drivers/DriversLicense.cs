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
    public partial class DriversLicense : Form
    {
        public DriversLicense()
        {
            InitializeComponent();
        }

        private void driversLicenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversLicenseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void DriversLicense_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.DriversLicense". При необходимости она может быть перемещена или удалена.
            this.driversLicenseTableAdapter.Fill(this.database1DataSet.DriversLicense);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization f = new Authorization();
            f.Show();
        }
    }
}
