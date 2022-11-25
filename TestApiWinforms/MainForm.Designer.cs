
namespace TestApiWinforms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.dataGridViewOffers = new System.Windows.Forms.DataGridView();
            this.labelOffers = new System.Windows.Forms.Label();
            this.pictureBoxModel = new System.Windows.Forms.PictureBox();
            this.pictureBoxVendor = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Locations:";
            // 
            // dataGridViewLocation
            // 
            this.dataGridViewLocation.AllowUserToAddRows = false;
            this.dataGridViewLocation.AllowUserToDeleteRows = false;
            this.dataGridViewLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLocation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocation.Location = new System.Drawing.Point(15, 55);
            this.dataGridViewLocation.MultiSelect = false;
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.ReadOnly = true;
            this.dataGridViewLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocation.Size = new System.Drawing.Size(716, 112);
            this.dataGridViewLocation.TabIndex = 2;
            this.dataGridViewLocation.CurrentCellChanged += new System.EventHandler(this.dataGridViewLocation_CurrentCellChanged);
            // 
            // dataGridViewOffers
            // 
            this.dataGridViewOffers.AllowUserToAddRows = false;
            this.dataGridViewOffers.AllowUserToDeleteRows = false;
            this.dataGridViewOffers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffers.Location = new System.Drawing.Point(15, 189);
            this.dataGridViewOffers.Name = "dataGridViewOffers";
            this.dataGridViewOffers.ReadOnly = true;
            this.dataGridViewOffers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOffers.Size = new System.Drawing.Size(716, 150);
            this.dataGridViewOffers.TabIndex = 3;
            this.dataGridViewOffers.CurrentCellChanged += new System.EventHandler(this.dataGridViewOffers_CurrentCellChanged);
            // 
            // labelOffers
            // 
            this.labelOffers.AutoSize = true;
            this.labelOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOffers.Location = new System.Drawing.Point(15, 173);
            this.labelOffers.Name = "labelOffers";
            this.labelOffers.Size = new System.Drawing.Size(41, 13);
            this.labelOffers.TabIndex = 4;
            this.labelOffers.Text = "Offers";
            // 
            // pictureBoxModel
            // 
            this.pictureBoxModel.Location = new System.Drawing.Point(15, 374);
            this.pictureBoxModel.Name = "pictureBoxModel";
            this.pictureBoxModel.Size = new System.Drawing.Size(358, 208);
            this.pictureBoxModel.TabIndex = 5;
            this.pictureBoxModel.TabStop = false;
            // 
            // pictureBoxVendor
            // 
            this.pictureBoxVendor.Location = new System.Drawing.Point(394, 374);
            this.pictureBoxVendor.Name = "pictureBoxVendor";
            this.pictureBoxVendor.Size = new System.Drawing.Size(334, 208);
            this.pictureBoxVendor.TabIndex = 6;
            this.pictureBoxVendor.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(64, 596);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(307, 597);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(227, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(241, 599);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(60, 13);
            this.labelSurname.TabIndex = 10;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(15, 599);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 647);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxVendor);
            this.Controls.Add(this.pictureBoxModel);
            this.Controls.Add(this.labelOffers);
            this.Controls.Add(this.dataGridViewOffers);
            this.Controls.Add(this.dataGridViewLocation);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.DataGridView dataGridViewOffers;
        private System.Windows.Forms.Label labelOffers;
        private System.Windows.Forms.PictureBox pictureBoxModel;
        private System.Windows.Forms.PictureBox pictureBoxVendor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
    }
}