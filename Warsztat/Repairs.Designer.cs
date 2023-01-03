
using System.Windows.Forms;

namespace Warsztat
{
    partial class Repairs
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
            this.dgvRepairList = new System.Windows.Forms.DataGridView();
            this.nr_rej = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koszt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRepairList = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepairList
            // 
            this.dgvRepairList.AllowUserToAddRows = false;
            this.dgvRepairList.AllowUserToDeleteRows = false;
            this.dgvRepairList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRepairList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepairList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr_rej,
            this.data,
            this.mechanik,
            this.koszt,
            this.czas});
            this.dgvRepairList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRepairList.Location = new System.Drawing.Point(12, 41);
            this.dgvRepairList.Name = "dgvRepairList";
            this.dgvRepairList.RowHeadersWidth = 51;
            this.dgvRepairList.RowTemplate.Height = 24;
            this.dgvRepairList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepairList.Size = new System.Drawing.Size(1154, 405);
            this.dgvRepairList.TabIndex = 1;
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
            // lblRepairList
            // 
            this.lblRepairList.AutoSize = true;
            this.lblRepairList.BackColor = System.Drawing.Color.LightGray;
            this.lblRepairList.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRepairList.ForeColor = System.Drawing.Color.Black;
            this.lblRepairList.Location = new System.Drawing.Point(12, 9);
            this.lblRepairList.Name = "lblRepairList";
            this.lblRepairList.Size = new System.Drawing.Size(142, 25);
            this.lblRepairList.TabIndex = 2;
            this.lblRepairList.Text = "Wykaz napraw:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(290, 462);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Repairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1220, 514);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRepairList);
            this.Controls.Add(this.dgvRepairList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Repairs";
            this.Text = "Wykaz napraw";
            this.Load += new System.EventHandler(this.PokażNaprawy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepairList;
        private DataGridViewTextBoxColumn nr_rej;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn mechanik;
        private DataGridViewTextBoxColumn koszt;
        private DataGridViewTextBoxColumn czas;
        private Label lblRepairList;
        private Button button1;
        private NumericUpDown numericUpDown1;
    }
}