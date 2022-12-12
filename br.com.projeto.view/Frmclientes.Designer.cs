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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabclientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.tabelacliente = new System.Windows.Forms.DataGridView();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Btnnovo = new System.Windows.Forms.Button();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btnsalvar = new System.Windows.Forms.Button();
            this.Btnexcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabclientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelacliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente";
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
            this.tabclientes.Size = new System.Drawing.Size(953, 408);
            this.tabclientes.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.txtestado);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtestado
            // 
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
            this.txtestado.Location = new System.Drawing.Point(601, 310);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(131, 33);
            this.txtestado.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.RosyBrown;
            this.label16.Location = new System.Drawing.Point(509, 314);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 24);
            this.label16.TabIndex = 26;
            this.label16.Text = "UF:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcomplemento.Location = new System.Drawing.Point(601, 266);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(232, 31);
            this.txtcomplemento.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.RosyBrown;
            this.label15.Location = new System.Drawing.Point(509, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 24);
            this.label15.TabIndex = 24;
            this.label15.Text = "Compl:";
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcidade.Location = new System.Drawing.Point(137, 310);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(351, 31);
            this.txtcidade.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RosyBrown;
            this.label13.Location = new System.Drawing.Point(28, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cidade:";
            // 
            // txtbairro
            // 
            this.txtbairro.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbairro.Location = new System.Drawing.Point(137, 262);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(351, 31);
            this.txtbairro.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RosyBrown;
            this.label12.Location = new System.Drawing.Point(25, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Bairro:";
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.Menu;
            this.txtnumero.Location = new System.Drawing.Point(803, 221);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(44, 31);
            this.txtnumero.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RosyBrown;
            this.label11.Location = new System.Drawing.Point(742, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Núm:";
            // 
            // txtendereco
            // 
            this.txtendereco.BackColor = System.Drawing.SystemColors.Menu;
            this.txtendereco.Location = new System.Drawing.Point(137, 221);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(351, 31);
            this.txtendereco.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RosyBrown;
            this.label10.Location = new System.Drawing.Point(25, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtcep
            // 
            this.txtcep.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcep.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtcep.Location = new System.Drawing.Point(601, 218);
            this.txtcep.Mask = "##.###-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(135, 31);
            this.txtcep.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RosyBrown;
            this.label9.Location = new System.Drawing.Point(509, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cep:";
            // 
            // txtcelular
            // 
            this.txtcelular.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcelular.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtcelular.Location = new System.Drawing.Point(406, 170);
            this.txtcelular.Mask = "(99) 0 0000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(173, 31);
            this.txtcelular.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RosyBrown;
            this.label8.Location = new System.Drawing.Point(324, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.BackColor = System.Drawing.SystemColors.Menu;
            this.txttelefone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txttelefone.Location = new System.Drawing.Point(137, 170);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(158, 31);
            this.txttelefone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RosyBrown;
            this.label7.Location = new System.Drawing.Point(25, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefone:";
            // 
            // txtcpf
            // 
            this.txtcpf.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcpf.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtcpf.Location = new System.Drawing.Point(601, 123);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(158, 31);
            this.txtcpf.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(540, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cpf:";
            // 
            // txtrg
            // 
            this.txtrg.BackColor = System.Drawing.SystemColors.Menu;
            this.txtrg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtrg.Location = new System.Drawing.Point(601, 70);
            this.txtrg.Mask = "##.###.###-#";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(158, 31);
            this.txtrg.TabIndex = 7;
            this.txtrg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(540, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rg:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtemail.Location = new System.Drawing.Point(137, 123);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(351, 31);
            this.txtemail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtnome.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(137, 70);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(351, 29);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcodigo.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(137, 19);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(87, 29);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btnpesquisar);
            this.tabPage2.Controls.Add(this.tabelacliente);
            this.tabPage2.Controls.Add(this.txtpesquisa);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.RosyBrown;
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(945, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseWaitCursor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.DimGray;
            this.btnpesquisar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnpesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnpesquisar.Location = new System.Drawing.Point(469, 27);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(112, 38);
            this.btnpesquisar.TabIndex = 8;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.UseWaitCursor = true;
            // 
            // tabelacliente
            // 
            this.tabelacliente.AllowUserToAddRows = false;
            this.tabelacliente.AllowUserToDeleteRows = false;
            this.tabelacliente.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.tabelacliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelacliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelacliente.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabelacliente.Location = new System.Drawing.Point(14, 88);
            this.tabelacliente.Name = "tabelacliente";
            this.tabelacliente.ReadOnly = true;
            this.tabelacliente.Size = new System.Drawing.Size(906, 259);
            this.tabelacliente.TabIndex = 7;
            this.tabelacliente.UseWaitCursor = true;
            this.tabelacliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelacliente_CellContentClick);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtpesquisa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtpesquisa.Location = new System.Drawing.Point(85, 31);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(351, 31);
            this.txtpesquisa.TabIndex = 4;
            this.txtpesquisa.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bell MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RosyBrown;
            this.label14.Location = new System.Drawing.Point(15, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 24);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nome:";
            this.label14.UseWaitCursor = true;
            // 
            // Btnnovo
            // 
            this.Btnnovo.BackColor = System.Drawing.Color.DimGray;
            this.Btnnovo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnnovo.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnnovo.ForeColor = System.Drawing.Color.Transparent;
            this.Btnnovo.Location = new System.Drawing.Point(244, 546);
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
            this.Btneditar.BackColor = System.Drawing.Color.DimGray;
            this.Btneditar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btneditar.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneditar.ForeColor = System.Drawing.Color.Transparent;
            this.Btneditar.Location = new System.Drawing.Point(649, 546);
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
            this.Btnsalvar.BackColor = System.Drawing.Color.DimGray;
            this.Btnsalvar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnsalvar.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalvar.ForeColor = System.Drawing.Color.Transparent;
            this.Btnsalvar.Location = new System.Drawing.Point(379, 546);
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
            this.Btnexcluir.BackColor = System.Drawing.Color.DimGray;
            this.Btnexcluir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnexcluir.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexcluir.ForeColor = System.Drawing.Color.Transparent;
            this.Btnexcluir.Location = new System.Drawing.Point(518, 546);
            this.Btnexcluir.Name = "Btnexcluir";
            this.Btnexcluir.Size = new System.Drawing.Size(109, 37);
            this.Btnexcluir.TabIndex = 16;
            this.Btnexcluir.Text = "Excluir";
            this.Btnexcluir.UseVisualStyleBackColor = false;
            this.Btnexcluir.UseWaitCursor = true;
            this.Btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 602);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView tabelacliente;
        private System.Windows.Forms.Button Btnnovo;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Button Btnsalvar;
        private System.Windows.Forms.Button Btnexcluir;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtestado;
    }
}