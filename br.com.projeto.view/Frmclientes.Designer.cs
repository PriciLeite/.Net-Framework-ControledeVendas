using System;

namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    partial class Frmclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmclientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabclientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.tabelacliente = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.Btnnovo = new System.Windows.Forms.Button();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btnsalvar = new System.Windows.Forms.Button();
            this.Btnexcluir = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabclientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelacliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 126);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(92, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Cliente";
            // 
            // tabclientes
            // 
            this.tabclientes.Controls.Add(this.tabPage1);
            this.tabclientes.Controls.Add(this.tabPage2);
            this.tabclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabclientes.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabclientes.Location = new System.Drawing.Point(22, 132);
            this.tabclientes.Name = "tabclientes";
            this.tabclientes.SelectedIndex = 0;
            this.tabclientes.Size = new System.Drawing.Size(1187, 408);
            this.tabclientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtestado);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1179, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnbuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnbuscar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Location = new System.Drawing.Point(734, 214);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(97, 35);
            this.btnbuscar.TabIndex = 29;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.UseWaitCursor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtestado
            // 
            this.txtestado.ForeColor = System.Drawing.Color.Gray;
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.txtestado.Location = new System.Drawing.Point(581, 278);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(131, 32);
            this.txtestado.TabIndex = 28;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcomplemento.ForeColor = System.Drawing.Color.Gray;
            this.txtcomplemento.Location = new System.Drawing.Point(581, 333);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(351, 32);
            this.txtcomplemento.TabIndex = 25;
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcidade.ForeColor = System.Drawing.Color.Gray;
            this.txtcidade.Location = new System.Drawing.Point(581, 151);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(351, 32);
            this.txtcidade.TabIndex = 23;
            // 
            // txtbairro
            // 
            this.txtbairro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbairro.ForeColor = System.Drawing.Color.Gray;
            this.txtbairro.Location = new System.Drawing.Point(581, 90);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(351, 32);
            this.txtbairro.TabIndex = 21;
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.Menu;
            this.txtnumero.ForeColor = System.Drawing.Color.Gray;
            this.txtnumero.Location = new System.Drawing.Point(754, 278);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(44, 32);
            this.txtnumero.TabIndex = 19;
            // 
            // txtendereco
            // 
            this.txtendereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtendereco.ForeColor = System.Drawing.Color.Gray;
            this.txtendereco.Location = new System.Drawing.Point(581, 29);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(351, 32);
            this.txtendereco.TabIndex = 17;
            // 
            // txtcep
            // 
            this.txtcep.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcep.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtcep.Location = new System.Drawing.Point(581, 216);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(135, 32);
            this.txtcep.TabIndex = 15;
            // 
            // txtcelular
            // 
            this.txtcelular.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcelular.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtcelular.Location = new System.Drawing.Point(216, 306);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(164, 32);
            this.txtcelular.TabIndex = 13;
            // 
            // txttelefone
            // 
            this.txttelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.txttelefone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txttelefone.Location = new System.Drawing.Point(216, 235);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(164, 32);
            this.txttelefone.TabIndex = 11;
            // 
            // txtcpf
            // 
            this.txtcpf.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcpf.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtcpf.Location = new System.Drawing.Point(37, 306);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(158, 32);
            this.txtcpf.TabIndex = 9;
            // 
            // txtrg
            // 
            this.txtrg.BackColor = System.Drawing.SystemColors.Menu;
            this.txtrg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtrg.Location = new System.Drawing.Point(37, 235);
            this.txtrg.Mask = "##.###.###-#";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(158, 32);
            this.txtrg.TabIndex = 7;
            this.txtrg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtemail.ForeColor = System.Drawing.Color.Gray;
            this.txtemail.Location = new System.Drawing.Point(29, 142);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(351, 32);
            this.txtemail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtnome.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.Gray;
            this.txtnome.Location = new System.Drawing.Point(29, 90);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(351, 30);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcodigo.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.Gray;
            this.txtcodigo.Location = new System.Drawing.Point(29, 30);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(71, 30);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(29, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.txtpesquisa);
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.tabelacliente);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabPage2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.DimGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1179, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseWaitCursor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtpesquisa.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.ForeColor = System.Drawing.Color.Gray;
            this.txtpesquisa.Location = new System.Drawing.Point(84, 39);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(378, 30);
            this.txtpesquisa.TabIndex = 9;
            this.txtpesquisa.UseWaitCursor = true;
            this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnpesquisar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnpesquisar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnpesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnpesquisar.Location = new System.Drawing.Point(477, 39);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(113, 33);
            this.btnpesquisar.TabIndex = 8;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.UseWaitCursor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // tabelacliente
            // 
            this.tabelacliente.AllowUserToAddRows = false;
            this.tabelacliente.AllowUserToDeleteRows = false;
            this.tabelacliente.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.tabelacliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelacliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelacliente.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelacliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabelacliente.Location = new System.Drawing.Point(14, 88);
            this.tabelacliente.Name = "tabelacliente";
            this.tabelacliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelacliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabelacliente.Size = new System.Drawing.Size(1139, 259);
            this.tabelacliente.TabIndex = 7;
            this.tabelacliente.UseWaitCursor = true;
            this.tabelacliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelacliente_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RosyBrown;
            this.label14.Location = new System.Drawing.Point(14, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 24);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nome:";
            this.label14.UseWaitCursor = true;
            // 
            // Btnnovo
            // 
            this.Btnnovo.BackColor = System.Drawing.Color.Teal;
            this.Btnnovo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnnovo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnnovo.ForeColor = System.Drawing.Color.Black;
            this.Btnnovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btnnovo.Location = new System.Drawing.Point(112, 553);
            this.Btnnovo.Name = "Btnnovo";
            this.Btnnovo.Size = new System.Drawing.Size(109, 37);
            this.Btnnovo.TabIndex = 13;
            this.Btnnovo.Text = "Novo";
            this.Btnnovo.UseVisualStyleBackColor = false;
            this.Btnnovo.UseWaitCursor = true;
            this.Btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // Btneditar
            // 
            this.Btneditar.BackColor = System.Drawing.Color.Teal;
            this.Btneditar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btneditar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneditar.ForeColor = System.Drawing.Color.Black;
            this.Btneditar.Location = new System.Drawing.Point(731, 553);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(109, 37);
            this.Btneditar.TabIndex = 14;
            this.Btneditar.Text = "Editar";
            this.Btneditar.UseVisualStyleBackColor = false;
            this.Btneditar.UseWaitCursor = true;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // Btnsalvar
            // 
            this.Btnsalvar.BackColor = System.Drawing.Color.Teal;
            this.Btnsalvar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnsalvar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalvar.ForeColor = System.Drawing.Color.Black;
            this.Btnsalvar.Location = new System.Drawing.Point(311, 553);
            this.Btnsalvar.Name = "Btnsalvar";
            this.Btnsalvar.Size = new System.Drawing.Size(109, 37);
            this.Btnsalvar.TabIndex = 15;
            this.Btnsalvar.Text = "Salvar";
            this.Btnsalvar.UseVisualStyleBackColor = false;
            this.Btnsalvar.UseWaitCursor = true;
            this.Btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // Btnexcluir
            // 
            this.Btnexcluir.BackColor = System.Drawing.Color.Teal;
            this.Btnexcluir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnexcluir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexcluir.ForeColor = System.Drawing.Color.Black;
            this.Btnexcluir.Location = new System.Drawing.Point(538, 553);
            this.Btnexcluir.Name = "Btnexcluir";
            this.Btnexcluir.Size = new System.Drawing.Size(109, 37);
            this.Btnexcluir.TabIndex = 16;
            this.Btnexcluir.Text = "Excluir";
            this.Btnexcluir.UseVisualStyleBackColor = false;
            this.Btnexcluir.UseWaitCursor = true;
            this.Btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(213, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Telefone Resd.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(213, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cel-01:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(578, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(34, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(34, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(578, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(578, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Cidade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(598, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(578, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Complemento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(580, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "UF:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(751, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Núm:";
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 602);
            this.Controls.Add(this.Btnexcluir);
            this.Controls.Add(this.Btnsalvar);
            this.Controls.Add(this.Btneditar);
            this.Controls.Add(this.Btnnovo);
            this.Controls.Add(this.tabclientes);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Frmclientes";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabclientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelacliente)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabclientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView tabelacliente;
        private System.Windows.Forms.Button Btnnovo;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Button Btnsalvar;
        private System.Windows.Forms.Button Btnexcluir;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
    }    
}