
namespace Warsztat
{
    partial class AddRepair
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
            this.lblRegistry = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMechanicChoose = new System.Windows.Forms.Label();
            this.lblCosts = new System.Windows.Forms.Label();
            this.lblWorktime = new System.Windows.Forms.Label();
            this.lblAddRepair = new System.Windows.Forms.Label();
            this.tbxRegistry = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.numCosts = new System.Windows.Forms.NumericUpDown();
            this.numWorktime = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewRepair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWorktime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistry
            // 
            this.lblRegistry.AutoSize = true;
            this.lblRegistry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegistry.Location = new System.Drawing.Point(11, 76);
            this.lblRegistry.Name = "lblRegistry";
            this.lblRegistry.Size = new System.Drawing.Size(120, 18);
            this.lblRegistry.TabIndex = 0;
            this.lblRegistry.Text = "Nr. rejestracyjny:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 119);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Data naprawy:";
            // 
            // lblMechanicChoose
            // 
            this.lblMechanicChoose.AutoSize = true;
            this.lblMechanicChoose.Location = new System.Drawing.Point(10, 162);
            this.lblMechanicChoose.Name = "lblMechanicChoose";
            this.lblMechanicChoose.Size = new System.Drawing.Size(81, 20);
            this.lblMechanicChoose.TabIndex = 2;
            this.lblMechanicChoose.Text = "Mechanik:";
            // 
            // lblCosts
            // 
            this.lblCosts.AutoSize = true;
            this.lblCosts.Location = new System.Drawing.Point(9, 208);
            this.lblCosts.Name = "lblCosts";
            this.lblCosts.Size = new System.Drawing.Size(110, 20);
            this.lblCosts.TabIndex = 3;
            this.lblCosts.Text = "Koszta części:";
            // 
            // lblWorktime
            // 
            this.lblWorktime.AutoSize = true;
            this.lblWorktime.Location = new System.Drawing.Point(10, 251);
            this.lblWorktime.Name = "lblWorktime";
            this.lblWorktime.Size = new System.Drawing.Size(91, 20);
            this.lblWorktime.TabIndex = 4;
            this.lblWorktime.Text = "Czas pracy:";
            // 
            // lblAddRepair
            // 
            this.lblAddRepair.AutoSize = true;
            this.lblAddRepair.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddRepair.Location = new System.Drawing.Point(10, 19);
            this.lblAddRepair.Name = "lblAddRepair";
            this.lblAddRepair.Size = new System.Drawing.Size(163, 30);
            this.lblAddRepair.TabIndex = 5;
            this.lblAddRepair.Text = "Dodaj naprawę:";
            // 
            // tbxRegistry
            // 
            this.tbxRegistry.Location = new System.Drawing.Point(157, 72);
            this.tbxRegistry.Name = "tbxRegistry";
            this.tbxRegistry.Size = new System.Drawing.Size(98, 26);
            this.tbxRegistry.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(157, 113);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(397, 26);
            this.dtpDate.TabIndex = 7;
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(157, 159);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(397, 28);
            this.cmbMechanic.TabIndex = 8;
            // 
            // numCosts
            // 
            this.numCosts.DecimalPlaces = 2;
            this.numCosts.Location = new System.Drawing.Point(157, 206);
            this.numCosts.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCosts.Name = "numCosts";
            this.numCosts.Size = new System.Drawing.Size(118, 26);
            this.numCosts.TabIndex = 9;
            // 
            // numWorktime
            // 
            this.numWorktime.Location = new System.Drawing.Point(157, 249);
            this.numWorktime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWorktime.Name = "numWorktime";
            this.numWorktime.Size = new System.Drawing.Size(66, 26);
            this.numWorktime.TabIndex = 10;
            // 
            // btnAddNewRepair
            // 
            this.btnAddNewRepair.BackColor = System.Drawing.Color.Green;
            this.btnAddNewRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewRepair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewRepair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewRepair.Location = new System.Drawing.Point(14, 304);
            this.btnAddNewRepair.Name = "btnAddNewRepair";
            this.btnAddNewRepair.Size = new System.Drawing.Size(162, 45);
            this.btnAddNewRepair.TabIndex = 11;
            this.btnAddNewRepair.Text = "Dodaj naprawę";
            this.btnAddNewRepair.UseVisualStyleBackColor = false;
            this.btnAddNewRepair.Click += new System.EventHandler(this.btnAddNewRepair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "zł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "h";
            // 
            // AddRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(568, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewRepair);
            this.Controls.Add(this.numWorktime);
            this.Controls.Add(this.numCosts);
            this.Controls.Add(this.cmbMechanic);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbxRegistry);
            this.Controls.Add(this.lblAddRepair);
            this.Controls.Add(this.lblWorktime);
            this.Controls.Add(this.lblCosts);
            this.Controls.Add(this.lblMechanicChoose);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRegistry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddRepair";
            this.Text = "Dodaj naprawę";
            this.Load += new System.EventHandler(this.AddRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWorktime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistry;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMechanicChoose;
        private System.Windows.Forms.Label lblCosts;
        private System.Windows.Forms.Label lblWorktime;
        private System.Windows.Forms.Label lblAddRepair;
        private System.Windows.Forms.TextBox tbxRegistry;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.NumericUpDown numCosts;
        private System.Windows.Forms.NumericUpDown numWorktime;
        private System.Windows.Forms.Button btnAddNewRepair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}