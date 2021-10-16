
namespace HotelDreamDesktop
{
    partial class FrmListaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaReserva));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.colCheckIn = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCheckOut = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLista);
            this.tabControl.Location = new System.Drawing.Point(-1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1168, 596);
            this.tabControl.TabIndex = 26;
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.txtBusca);
            this.tabLista.Controls.Add(this.panel7);
            this.tabLista.Controls.Add(this.btnBuscar);
            this.tabLista.Controls.Add(this.dgvReserva);
            this.tabLista.Location = new System.Drawing.Point(4, 22);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabLista.Size = new System.Drawing.Size(1160, 570);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista";
            this.tabLista.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBusca.Location = new System.Drawing.Point(182, 58);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(699, 26);
            this.txtBusca.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.label20);
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1160, 35);
            this.panel7.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(513, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 30);
            this.label20.TabIndex = 11;
            this.label20.Text = "Lista de Reserva";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(887, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 26);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReserva.BackgroundColor = System.Drawing.Color.White;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckIn,
            this.colCheckOut});
            this.dgvReserva.Location = new System.Drawing.Point(12, 112);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.RowTemplate.Height = 25;
            this.dgvReserva.Size = new System.Drawing.Size(1136, 445);
            this.dgvReserva.TabIndex = 0;
            this.dgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserva_CellContentClick);
            // 
            // colCheckIn
            // 
            this.colCheckIn.Description = "CheckIn";
            this.colCheckIn.HeaderText = "";
            this.colCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("colCheckIn.Image")));
            this.colCheckIn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colCheckIn.Name = "colCheckIn";
            this.colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            this.colCheckOut.Description = "CheckOut";
            this.colCheckOut.HeaderText = "";
            this.colCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("colCheckOut.Image")));
            this.colCheckOut.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colCheckOut.Name = "colCheckOut";
            this.colCheckOut.ReadOnly = true;
            this.colCheckOut.ToolTipText = "CheckOut";
            // 
            // FrmListaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 599);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaReserva";
            this.Text = "FrmListaReserva";
            this.tabControl.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            this.tabLista.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewImageColumn colCheckIn;
        private System.Windows.Forms.DataGridViewImageColumn colCheckOut;
    }
}