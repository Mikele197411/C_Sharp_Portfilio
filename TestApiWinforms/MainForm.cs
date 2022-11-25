using ApiViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApiWinforms
{
    public partial class MainForm : Form
    {
        ApiViewModel.ApiViewModel model;
        public MainForm()
        {
            InitializeComponent();
            model = new ApiViewModel.ApiViewModel();
            dataGridViewLocation.DataSource = model.GetLocations();
        }
    }
}
