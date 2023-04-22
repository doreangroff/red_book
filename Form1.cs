using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examin_typa
{
    public partial class Form1 : Form
    {
        private AnimalsDataBase _data;
        public Form1()
        {
            InitializeComponent();
            _data = new AnimalsDataBase();
            _data.InInitialize();

            animals_datagrid.DataSource = _data.zivotnie.ToList();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            var sort = _data.zivotnie.OrderBy(s => s.Location).ToList();
            animals_datagrid.DataSource = sort;
        }
    }
}
