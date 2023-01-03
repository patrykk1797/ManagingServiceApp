
namespace Warsztat
{
    partial class Raport
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
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.lblMechanicSelected = new System.Windows.Forms.Label();
            this.dgvRaport = new System.Windows.Forms.DataGridView();
            this.nr_rej = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koszt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSumText = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(12, 39);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(340, 28);
            this.cmbMechanic.TabIndex = 0;
            this.cmbMechanic.SelectionChangeCommitted += new System.EventHandler(this.cmbMechanic_SelectionChangeCommitted);
            // 
            // lblMechanicSelected
            // 
            this.lblMechanicSelected.AutoSize = true;
            this.lblMechanicSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMechanicSelected.Location = new System.Drawing.Point(12, 4);
            this.lblMechanicSelected.Name = "lblMechanicSelected";
            this.lblMechanicSelected.Size = new System.Drawing.Size(128, 32);
            this.lblMechanicSelected.TabIndex = 1;
            this.lblMechanicSelected.Text = "Mechanik:";
            // 
            // dgvRaport
            // 
            this.dgvRaport.AllowUserToAddRows = false;
            this.dgvRaport.AllowUserToDeleteRows = false;
            this.dgvRaport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRaport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr_rej,
            this.data,
            this.mechanik,
            this.koszt,
            this.czas});
            this.dgvRaport.Location = new System.Drawing.Point(12, 87);
            this.dgvRaport.Name = "dgvRaport";
            this.dgvRaport.ReadOnly = true;
            this.dgvRaport.RowHeadersWidth = 51;
            this.dgvRaport.RowTemplate.Height = 24;
            this.dgvRaport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaport.Size = new System.Drawing.Size(1061, 369);
            this.dgvRaport.TabIndex = 2;
            // 
            // nr_rej
            // 
            this.nr_rej.HeaderText = "Nr. rejestracyjny pojazdu";
            this.nr_rej.MinimumWidth = 6;
            this.nr_rej.Name = "nr_rej";
            this.nr_rej.ReadOnly = true;
            this.nr_rej.Width = 186;
            // 
            // data
            // 
            this.data.HeaderText = "Data naprawy";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 121;
            // 
            // mechanik
            // 
            this.mechanik.HeaderText = "Mechanik";
            this.mechanik.MinimumWidth = 6;
            this.mechanik.Name = "mechanik";
            this.mechanik.ReadOnly = true;
            this.mechanik.Width = 102;
            // 
            // koszt
            // 
            this.koszt.HeaderText = "Koszt części";
            this.koszt.MinimumWidth = 6;
            this.koszt.Name = "koszt";
            this.koszt.ReadOnly = true;
            this.koszt.Width = 112;
            // 
            // czas
            // 
            this.czas.HeaderText = "Czas pracy";
            this.czas.MinimumWidth = 6;
            this.czas.Name = "czas";
            this.czas.ReadOnly = true;
            this.czas.Width = 103;
            // 
            // lblSumText
            // 
            this.lblSumText.AutoSize = true;
            this.lblSumText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSumText.Location = new System.Drawing.Point(373, 42);
            this.lblSumText.Name = "lblSumText";
            this.lblSumText.Size = new System.Drawing.Size(71, 19);
            this.lblSumText.TabIndex = 3;
            this.lblSumText.Text = "Wartość:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSum.Location = new System.Drawing.Point(450, 43);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(31, 18);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "0 zł";
            // 
            // Raport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1119, 468);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblSumText);
            this.Controls.Add(this.dgvRaport);
            this.Controls.Add(this.lblMechanicSelected);
            this.Controls.Add(this.cmbMechanic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Raport";
            this.Text = "Raport";
            this.Load += new System.EventHandler(this.Raport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label lblMechanicSelected;
        private System.Windows.Forms.DataGridView dgvRaport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_rej;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn mechanik;
        private System.Windows.Forms.DataGridViewTextBoxColumn koszt;
        private System.Windows.Forms.DataGridViewTextBoxColumn czas;
        private System.Windows.Forms.Label lblSumText;
        private System.Windows.Forms.Label lblSum;
    }
}