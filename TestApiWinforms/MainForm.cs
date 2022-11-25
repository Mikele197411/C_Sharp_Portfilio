using ApiViewModel;
using ApiViewModel.Models;
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
        String defaultOfferUid = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            model = new ApiViewModel.ApiViewModel();
            dataGridViewLocation.DataSource = model.GetLocations();
        }

        private void dataGridViewLocation_CurrentCellChanged(object sender, EventArgs e)
        {
            var idLocation = 1;
            if (dataGridViewLocation.SelectedRows.Count > 0)
            {
                var row = dataGridViewLocation.SelectedRows[0];
                idLocation = Convert.ToInt32(row.Cells[0].Value);
            }
            if(idLocation>0)
            {
                var offers = model.GetOffers(idLocation);
                var offersDataSet = new List<OffersDataSet>();
                foreach(var item in offers)
                {
                    var offer = new OffersDataSet();
                    offer.OfferUId = item.OfferUId;
                    offer.Currency = item.Price.Currency;
                    offer.Price = item.Price.Amount;
                    offer.ModelImage = item.Vehicle.ImageLink;
                    offer.ModelName = item.Vehicle.ModelName;
                    offer.VendorImage = item.Vendor.ImageLink;
                    offer.VendorName = item.Vendor.Name;
                    offersDataSet.Add(offer);
                }
                if(offersDataSet.Count>0)
                {
                    dataGridViewOffers.DataSource = offersDataSet;
                }
            }
            
           
        }

        private void dataGridViewOffers_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = null;
            
            if (dataGridViewOffers.SelectedRows.Count > 0)
            {
                currentRow = dataGridViewOffers.SelectedRows[0];
                defaultOfferUid = currentRow.Cells[0].Value.ToString();
            }
            else
            {
                currentRow = dataGridViewOffers.Rows[0];
                defaultOfferUid = currentRow.Cells[0].Value.ToString();
            }

            if(currentRow!=null)
            {
                var modelImage = model.LoadPicture(currentRow.Cells[2].Value.ToString());
                pictureBoxModel.Image = modelImage;
                var vendorImage = model.LoadPicture(currentRow.Cells[6].Value.ToString());
                pictureBoxVendor.Image = vendorImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Please input name or surname");
            }
            if(!string.IsNullOrEmpty(defaultOfferUid))
            {
                var newBooking = new Reservations();
                newBooking.OfferUId = defaultOfferUid;
                newBooking.Customer = new Customer() { Name = textBoxName.Text, Surname = textBoxSurname.Text };
                var result=model.CreateReservation(newBooking);
                MessageBox.Show($"You booking {result}");
            }
        }
    }
}
