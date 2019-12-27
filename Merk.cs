using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Kasir
{
    public partial class Merk : Form
    {
        public Merk()
        {
            InitializeComponent();
        }

        private void tb_merkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_merkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_penjualanDataSet);

        }

        private void Merk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_penjualanDataSet.tb_merk' table. You can move, or remove it, as needed.
            //this.tb_merkTableAdapter.Fill(this.db_penjualanDataSet.tb_merk);

        }

    }
}
