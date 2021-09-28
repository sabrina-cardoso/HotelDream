
namespace HotelDreamDesktop
{
    partial class FrmCadastrarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarReserva));
            this.panel7 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvQuarto = new System.Windows.Forms.DataGridView();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateSaida = new System.Windows.Forms.DateTimePicker();
            this.colReservar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.label20);
            this.panel7.Location = new System.Drawing.Point(-1, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1169, 35);
            this.panel7.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(480, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(178, 30);
            this.label20.TabIndex = 11;
            this.label20.Text = "Cadastrar Reserva";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(823, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(161, 26);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar Quartos";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvQuarto
            // 
            this.dgvQuarto.AllowUserToAddRows = false;
            this.dgvQuarto.AllowUserToDeleteRows = false;
            this.dgvQuarto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuarto.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuarto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReservar});
            this.dgvQuarto.Location = new System.Drawing.Point(8, 135);
            this.dgvQuarto.Name = "dgvQuarto";
            this.dgvQuarto.ReadOnly = true;
            this.dgvQuarto.RowTemplate.Height = 25;
            this.dgvQuarto.Size = new System.Drawing.Size(1147, 464);
            this.dgvQuarto.TabIndex = 23;
            // 
            // dateEntrada
            // 
            this.dateEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEntrada.Location = new System.Drawing.Point(245, 94);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(265, 26);
            this.dateEntrada.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(241, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data de Entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(533, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data de Saida";
            // 
            // dateSaida
            // 
            this.dateSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSaida.Location = new System.Drawing.Point(537, 94);
            this.dateSaida.Name = "dateSaida";
            this.dateSaida.Size = new System.Drawing.Size(265, 26);
            this.dateSaida.TabIndex = 29;
            // 
            // colReservar
            // 
            this.colReservar.HeaderText = "";
            this.colReservar.Image = ((System.Drawing.Image)(resources.GetObject("colReservar.Image")));
            this.colReservar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colReservar.Name = "colReservar";
            this.colReservar.ReadOnly = true;
            this.colReservar.ToolTipText = "Editar";
            // 
            // FrmCadastrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEntrada);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvQuarto);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarReserva";
            this.Text = "FrmCadastrarReserva";
            this.Load += new System.EventHandler(this.FrmCadastrarReserva_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvQuarto;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSaida;
        private System.Windows.Forms.DataGridViewImageColumn colReservar;
    }
}