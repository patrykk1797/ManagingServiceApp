
namespace Warsztat
{
    partial class Menu
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
            this.btnMechanics = new System.Windows.Forms.Button();
            this.btnAddRepair = new System.Windows.Forms.Button();
            this.btnRepairs = new System.Windows.Forms.Button();
            this.btnRaport = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMechanics
            // 
            this.btnMechanics.BackColor = System.Drawing.Color.White;
            this.btnMechanics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMechanics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMechanics.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMechanics.ForeColor = System.Drawing.Color.Black;
            this.btnMechanics.Location = new System.Drawing.Point(69, 153);
            this.btnMechanics.Name = "btnMechanics";
            this.btnMechanics.Size = new System.Drawing.Size(183, 62);
            this.btnMechanics.TabIndex = 0;
            this.btnMechanics.Text = "Wykaz mechaników";
            this.btnMechanics.UseVisualStyleBackColor = false;
            this.btnMechanics.Click += new System.EventHandler(this.btnMechanics_Click);
            // 
            // btnAddRepair
            // 
            this.btnAddRepair.BackColor = System.Drawing.Color.Green;
            this.btnAddRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRepair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRepair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddRepair.ForeColor = System.Drawing.Color.Black;
            this.btnAddRepair.Location = new System.Drawing.Point(69, 85);
            this.btnAddRepair.Name = "btnAddRepair";
            this.btnAddRepair.Size = new System.Drawing.Size(183, 62);
            this.btnAddRepair.TabIndex = 1;
            this.btnAddRepair.Text = "Dodaj nową naprawe";
            this.btnAddRepair.UseVisualStyleBackColor = false;
            this.btnAddRepair.Click += new System.EventHandler(this.btnAddRepair_Click);
            // 
            // btnRepairs
            // 
            this.btnRepairs.BackColor = System.Drawing.Color.White;
            this.btnRepairs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepairs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRepairs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRepairs.ForeColor = System.Drawing.Color.Black;
            this.btnRepairs.Location = new System.Drawing.Point(69, 289);
            this.btnRepairs.Name = "btnRepairs";
            this.btnRepairs.Size = new System.Drawing.Size(183, 62);
            this.btnRepairs.TabIndex = 2;
            this.btnRepairs.Text = "Wykaz napraw";
            this.btnRepairs.UseVisualStyleBackColor = false;
            this.btnRepairs.Click += new System.EventHandler(this.btnRepairs_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.BackColor = System.Drawing.Color.White;
            this.btnRaport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRaport.ForeColor = System.Drawing.Color.Black;
            this.btnRaport.Location = new System.Drawing.Point(69, 221);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(183, 62);
            this.btnRaport.TabIndex = 3;
            this.btnRaport.Text = "Raport z napraw";
            this.btnRaport.UseVisualStyleBackColor = false;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAppName.ForeColor = System.Drawing.Color.Black;
            this.lblAppName.Location = new System.Drawing.Point(12, 24);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(286, 37);
            this.lblAppName.TabIndex = 4;
            this.lblAppName.Text = "Zarządzanie serwisem";
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Red;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExit.Location = new System.Drawing.Point(69, 357);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(183, 62);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "Wyjdź z programu";
            this.lblExit.UseVisualStyleBackColor = false;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(332, 470);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.btnRepairs);
            this.Controls.Add(this.btnAddRepair);
            this.Controls.Add(this.btnMechanics);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMechanics;
        private System.Windows.Forms.Button btnAddRepair;
        private System.Windows.Forms.Button btnRepairs;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button lblExit;
    }
}

