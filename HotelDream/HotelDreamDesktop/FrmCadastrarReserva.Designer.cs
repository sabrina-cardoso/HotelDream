
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
            this.btnBuscarQuartos = new System.Windows.Forms.Button();
            this.dgvQuarto = new System.Windows.Forms.DataGridView();
            this.colReservQuarto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateSaida = new System.Windows.Forms.DateTimePicker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQuarto = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabHospede = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarHospede = new System.Windows.Forms.Button();
            this.dgvHospede = new System.Windows.Forms.DataGridView();
            this.colReservHospede = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnConfReserva = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboPagamento = new System.Windows.Forms.ComboBox();
            this.dateSaidaReserv = new System.Windows.Forms.DateTimePicker();
            this.dateEntradaReserv = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHospede = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoQuarto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabAcompanhante = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAcompanhante = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabQuarto.SuspendLayout();
            this.tabHospede.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospede)).BeginInit();
            this.tabReserva.SuspendLayout();
            this.tabAcompanhante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhante)).BeginInit();
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
            this.label20.Location = new System.Drawing.Point(503, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(178, 30);
            this.label20.TabIndex = 11;
            this.label20.Text = "Cadastrar Reserva";
            // 
            // btnBuscarQuartos
            // 
            this.btnBuscarQuartos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarQuartos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarQuartos.FlatAppearance.BorderSize = 2;
            this.btnBuscarQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarQuartos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBuscarQuartos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarQuartos.Location = new System.Drawing.Point(821, 89);
            this.btnBuscarQuartos.Name = "btnBuscarQuartos";
            this.btnBuscarQuartos.Size = new System.Drawing.Size(127, 26);
            this.btnBuscarQuartos.TabIndex = 25;
            this.btnBuscarQuartos.Text = "Buscar Quartos";
            this.btnBuscarQuartos.UseVisualStyleBackColor = false;
            this.btnBuscarQuartos.Click += new System.EventHandler(this.btnBuscarQuartos_Click);
            // 
            // dgvQuarto
            // 
            this.dgvQuarto.AllowUserToAddRows = false;
            this.dgvQuarto.AllowUserToDeleteRows = false;
            this.dgvQuarto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuarto.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuarto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReservQuarto});
            this.dgvQuarto.Location = new System.Drawing.Point(7, 122);
            this.dgvQuarto.Name = "dgvQuarto";
            this.dgvQuarto.ReadOnly = true;
            this.dgvQuarto.RowTemplate.Height = 25;
            this.dgvQuarto.Size = new System.Drawing.Size(1147, 420);
            this.dgvQuarto.TabIndex = 23;
            this.dgvQuarto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuarto_CellContentClick);
            // 
            // colReservQuarto
            // 
            this.colReservQuarto.HeaderText = "";
            this.colReservQuarto.Image = ((System.Drawing.Image)(resources.GetObject("colReservQuarto.Image")));
            this.colReservQuarto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colReservQuarto.Name = "colReservQuarto";
            this.colReservQuarto.ReadOnly = true;
            this.colReservQuarto.ToolTipText = "Editar";
            // 
            // dateEntrada
            // 
            this.dateEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEntrada.Location = new System.Drawing.Point(243, 90);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(265, 26);
            this.dateEntrada.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(239, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data de Entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(531, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data de Saida";
            // 
            // dateSaida
            // 
            this.dateSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSaida.Location = new System.Drawing.Point(535, 90);
            this.dateSaida.Name = "dateSaida";
            this.dateSaida.Size = new System.Drawing.Size(265, 26);
            this.dateSaida.TabIndex = 29;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQuarto);
            this.tabControl.Controls.Add(this.tabHospede);
            this.tabControl.Controls.Add(this.tabReserva);
            this.tabControl.Controls.Add(this.tabAcompanhante);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl.Location = new System.Drawing.Point(-1, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1169, 575);
            this.tabControl.TabIndex = 31;
            // 
            // tabQuarto
            // 
            this.tabQuarto.Controls.Add(this.label3);
            this.tabQuarto.Controls.Add(this.label2);
            this.tabQuarto.Controls.Add(this.label1);
            this.tabQuarto.Controls.Add(this.dgvQuarto);
            this.tabQuarto.Controls.Add(this.dateSaida);
            this.tabQuarto.Controls.Add(this.btnBuscarQuartos);
            this.tabQuarto.Controls.Add(this.dateEntrada);
            this.tabQuarto.Location = new System.Drawing.Point(4, 22);
            this.tabQuarto.Name = "tabQuarto";
            this.tabQuarto.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuarto.Size = new System.Drawing.Size(1161, 549);
            this.tabQuarto.TabIndex = 0;
            this.tabQuarto.Text = "Quarto";
            this.tabQuarto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(422, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Escolha o Quarto que será reservado";
            // 
            // tabHospede
            // 
            this.tabHospede.Controls.Add(this.label4);
            this.tabHospede.Controls.Add(this.txtBusca);
            this.tabHospede.Controls.Add(this.btnBuscarHospede);
            this.tabHospede.Controls.Add(this.dgvHospede);
            this.tabHospede.Location = new System.Drawing.Point(4, 22);
            this.tabHospede.Name = "tabHospede";
            this.tabHospede.Padding = new System.Windows.Forms.Padding(3);
            this.tabHospede.Size = new System.Drawing.Size(1161, 549);
            this.tabHospede.TabIndex = 1;
            this.tabHospede.Text = "Hóspede";
            this.tabHospede.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(499, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "Escolha o Hóspede";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBusca.Location = new System.Drawing.Point(255, 63);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(572, 26);
            this.txtBusca.TabIndex = 24;
            // 
            // btnBuscarHospede
            // 
            this.btnBuscarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarHospede.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscarHospede.FlatAppearance.BorderSize = 2;
            this.btnBuscarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarHospede.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBuscarHospede.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHospede.Location = new System.Drawing.Point(833, 63);
            this.btnBuscarHospede.Name = "btnBuscarHospede";
            this.btnBuscarHospede.Size = new System.Drawing.Size(117, 26);
            this.btnBuscarHospede.TabIndex = 25;
            this.btnBuscarHospede.Text = "Buscar Hóspede";
            this.btnBuscarHospede.UseVisualStyleBackColor = false;
            this.btnBuscarHospede.Click += new System.EventHandler(this.btnBuscarHospede_Click);
            // 
            // dgvHospede
            // 
            this.dgvHospede.AllowUserToAddRows = false;
            this.dgvHospede.AllowUserToDeleteRows = false;
            this.dgvHospede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHospede.BackgroundColor = System.Drawing.Color.White;
            this.dgvHospede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReservHospede});
            this.dgvHospede.Location = new System.Drawing.Point(12, 95);
            this.dgvHospede.Name = "dgvHospede";
            this.dgvHospede.ReadOnly = true;
            this.dgvHospede.RowTemplate.Height = 25;
            this.dgvHospede.Size = new System.Drawing.Size(1136, 429);
            this.dgvHospede.TabIndex = 23;
            this.dgvHospede.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHospede_CellContentClick);
            // 
            // colReservHospede
            // 
            this.colReservHospede.HeaderText = "";
            this.colReservHospede.Image = ((System.Drawing.Image)(resources.GetObject("colReservHospede.Image")));
            this.colReservHospede.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colReservHospede.Name = "colReservHospede";
            this.colReservHospede.ReadOnly = true;
            this.colReservHospede.ToolTipText = "Editar";
            // 
            // tabReserva
            // 
            this.tabReserva.Controls.Add(this.lblTotal);
            this.tabReserva.Controls.Add(this.label15);
            this.tabReserva.Controls.Add(this.btnConfReserva);
            this.tabReserva.Controls.Add(this.label11);
            this.tabReserva.Controls.Add(this.comboPagamento);
            this.tabReserva.Controls.Add(this.dateSaidaReserv);
            this.tabReserva.Controls.Add(this.dateEntradaReserv);
            this.tabReserva.Controls.Add(this.label9);
            this.tabReserva.Controls.Add(this.label10);
            this.tabReserva.Controls.Add(this.label8);
            this.tabReserva.Controls.Add(this.txtHospede);
            this.tabReserva.Controls.Add(this.label6);
            this.tabReserva.Controls.Add(this.txtTipoQuarto);
            this.tabReserva.Controls.Add(this.label7);
            this.tabReserva.Controls.Add(this.txtQuarto);
            this.tabReserva.Controls.Add(this.label5);
            this.tabReserva.Location = new System.Drawing.Point(4, 22);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabReserva.Size = new System.Drawing.Size(1161, 549);
            this.tabReserva.TabIndex = 2;
            this.tabReserva.Text = "Resumo da Reserva";
            this.tabReserva.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(811, 244);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 25);
            this.lblTotal.TabIndex = 49;
            this.lblTotal.Text = "000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(760, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 25);
            this.label15.TabIndex = 48;
            this.label15.Text = "Total:";
            // 
            // btnConfReserva
            // 
            this.btnConfReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfReserva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConfReserva.FlatAppearance.BorderSize = 2;
            this.btnConfReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfReserva.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConfReserva.ForeColor = System.Drawing.Color.White;
            this.btnConfReserva.Location = new System.Drawing.Point(941, 231);
            this.btnConfReserva.Name = "btnConfReserva";
            this.btnConfReserva.Size = new System.Drawing.Size(200, 38);
            this.btnConfReserva.TabIndex = 46;
            this.btnConfReserva.Text = "Confirmar Reserva";
            this.btnConfReserva.UseVisualStyleBackColor = false;
            this.btnConfReserva.Click += new System.EventHandler(this.btnConfReserva_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label11.Location = new System.Drawing.Point(622, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Tipo de Pagamento";
            // 
            // comboPagamento
            // 
            this.comboPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboPagamento.FormattingEnabled = true;
            this.comboPagamento.Location = new System.Drawing.Point(621, 168);
            this.comboPagamento.Name = "comboPagamento";
            this.comboPagamento.Size = new System.Drawing.Size(520, 28);
            this.comboPagamento.TabIndex = 44;
            // 
            // dateSaidaReserv
            // 
            this.dateSaidaReserv.Enabled = false;
            this.dateSaidaReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateSaidaReserv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSaidaReserv.Location = new System.Drawing.Point(322, 170);
            this.dateSaidaReserv.Name = "dateSaidaReserv";
            this.dateSaidaReserv.Size = new System.Drawing.Size(293, 26);
            this.dateSaidaReserv.TabIndex = 43;
            // 
            // dateEntradaReserv
            // 
            this.dateEntradaReserv.Enabled = false;
            this.dateEntradaReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateEntradaReserv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEntradaReserv.Location = new System.Drawing.Point(23, 170);
            this.dateEntradaReserv.Name = "dateEntradaReserv";
            this.dateEntradaReserv.Size = new System.Drawing.Size(293, 26);
            this.dateEntradaReserv.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label9.Location = new System.Drawing.Point(320, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Data de Saída";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label10.Location = new System.Drawing.Point(21, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Data de Entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(622, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Hóspede";
            // 
            // txtHospede
            // 
            this.txtHospede.Enabled = false;
            this.txtHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHospede.Location = new System.Drawing.Point(621, 95);
            this.txtHospede.Name = "txtHospede";
            this.txtHospede.Size = new System.Drawing.Size(520, 26);
            this.txtHospede.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label6.Location = new System.Drawing.Point(320, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tipo de Quarto";
            // 
            // txtTipoQuarto
            // 
            this.txtTipoQuarto.Enabled = false;
            this.txtTipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTipoQuarto.Location = new System.Drawing.Point(322, 95);
            this.txtTipoQuarto.Name = "txtTipoQuarto";
            this.txtTipoQuarto.Size = new System.Drawing.Size(293, 26);
            this.txtTipoQuarto.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.Location = new System.Drawing.Point(21, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quarto";
            // 
            // txtQuarto
            // 
            this.txtQuarto.Enabled = false;
            this.txtQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuarto.Location = new System.Drawing.Point(23, 95);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(293, 26);
            this.txtQuarto.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(466, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Resumo da Reserva";
            // 
            // tabAcompanhante
            // 
            this.tabAcompanhante.Controls.Add(this.button2);
            this.tabAcompanhante.Controls.Add(this.label14);
            this.tabAcompanhante.Controls.Add(this.textBox2);
            this.tabAcompanhante.Controls.Add(this.label13);
            this.tabAcompanhante.Controls.Add(this.label12);
            this.tabAcompanhante.Controls.Add(this.textBox1);
            this.tabAcompanhante.Controls.Add(this.button1);
            this.tabAcompanhante.Controls.Add(this.dgvAcompanhante);
            this.tabAcompanhante.Location = new System.Drawing.Point(4, 22);
            this.tabAcompanhante.Name = "tabAcompanhante";
            this.tabAcompanhante.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcompanhante.Size = new System.Drawing.Size(1161, 549);
            this.tabAcompanhante.TabIndex = 3;
            this.tabAcompanhante.Text = "Acompanhantes";
            this.tabAcompanhante.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(948, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 38);
            this.button2.TabIndex = 47;
            this.button2.Text = "Finalizar Reserva";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label14.Location = new System.Drawing.Point(516, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "CPF:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(555, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(361, 26);
            this.textBox2.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label13.Location = new System.Drawing.Point(71, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(499, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 30);
            this.label12.TabIndex = 30;
            this.label12.Text = "Acompanhantes";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(124, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 26);
            this.textBox1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(922, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "Adicionar Acompanhante";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvAcompanhante
            // 
            this.dgvAcompanhante.AllowUserToAddRows = false;
            this.dgvAcompanhante.AllowUserToDeleteRows = false;
            this.dgvAcompanhante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcompanhante.BackgroundColor = System.Drawing.Color.White;
            this.dgvAcompanhante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcompanhante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgvAcompanhante.Location = new System.Drawing.Point(12, 157);
            this.dgvAcompanhante.Name = "dgvAcompanhante";
            this.dgvAcompanhante.ReadOnly = true;
            this.dgvAcompanhante.RowTemplate.Height = 25;
            this.dgvAcompanhante.Size = new System.Drawing.Size(1136, 257);
            this.dgvAcompanhante.TabIndex = 27;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Editar";
            // 
            // FrmCadastrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 630);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarReserva";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.FrmCadastrarReserva_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabQuarto.ResumeLayout(false);
            this.tabQuarto.PerformLayout();
            this.tabHospede.ResumeLayout(false);
            this.tabHospede.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospede)).EndInit();
            this.tabReserva.ResumeLayout(false);
            this.tabReserva.PerformLayout();
            this.tabAcompanhante.ResumeLayout(false);
            this.tabAcompanhante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcompanhante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBuscarQuartos;
        private System.Windows.Forms.DataGridView dgvQuarto;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSaida;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabQuarto;
        private System.Windows.Forms.TabPage tabHospede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscarHospede;
        private System.Windows.Forms.DataGridView dgvHospede;
        private System.Windows.Forms.TabPage tabReserva;
        private System.Windows.Forms.DataGridViewImageColumn colReservQuarto;
        private System.Windows.Forms.DataGridViewImageColumn colReservHospede;
        private System.Windows.Forms.TabPage tabAcompanhante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHospede;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoQuarto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.DateTimePicker dateSaidaReserv;
        private System.Windows.Forms.DateTimePicker dateEntradaReserv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboPagamento;
        private System.Windows.Forms.Button btnConfReserva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAcompanhante;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
    }
}