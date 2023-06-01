namespace ExerciciCalcurradora
{
    partial class FormCalcurradora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcurradora));
            this.btnConfiguracio = new System.Windows.Forms.Button();
            this.gbCalculadora = new System.Windows.Forms.GroupBox();
            this.btnNumeroIgual = new System.Windows.Forms.Button();
            this.btnNumero0 = new System.Windows.Forms.Button();
            this.btnNumeroBorrar = new System.Windows.Forms.Button();
            this.btnNumero9 = new System.Windows.Forms.Button();
            this.btnNumero8 = new System.Windows.Forms.Button();
            this.btnNumero7 = new System.Windows.Forms.Button();
            this.btnNumero6 = new System.Windows.Forms.Button();
            this.btnNumero5 = new System.Windows.Forms.Button();
            this.btnNumero4 = new System.Windows.Forms.Button();
            this.btnNumero3 = new System.Windows.Forms.Button();
            this.btnNumero2 = new System.Windows.Forms.Button();
            this.btnNumero1 = new System.Windows.Forms.Button();
            this.tbCalculadora = new System.Windows.Forms.TextBox();
            this.gbOpcions = new System.Windows.Forms.GroupBox();
            this.btnAcceptarConfiguracio = new System.Windows.Forms.Button();
            this.nudDiesVacancesAnyAdicionals = new System.Windows.Forms.NumericUpDown();
            this.nudDiesVacancesAny = new System.Windows.Forms.NumericUpDown();
            this.nudHoresSetmanals = new System.Windows.Forms.NumericUpDown();
            this.nudNumeroPagues = new System.Windows.Forms.NumericUpDown();
            this.nudImportCadaPaga = new System.Windows.Forms.NumericUpDown();
            this.lbDiesFestaAdicionalsPerAny = new System.Windows.Forms.Label();
            this.lbDiesVacancesPerAny = new System.Windows.Forms.Label();
            this.lbHoresSetmanals = new System.Windows.Forms.Label();
            this.lbNumeroPaguesAny = new System.Windows.Forms.Label();
            this.lbImportCadaPaga = new System.Windows.Forms.Label();
            this.gbSolucioFinal = new System.Windows.Forms.GroupBox();
            this.lbHores = new System.Windows.Forms.Label();
            this.lbTotalHoresATreballar = new System.Windows.Forms.Label();
            this.lbMinuts = new System.Windows.Forms.Label();
            this.lbTotalMinutsATreballar = new System.Windows.Forms.Label();
            this.gbCalculadora.SuspendLayout();
            this.gbOpcions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiesVacancesAnyAdicionals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiesVacancesAny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoresSetmanals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroPagues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImportCadaPaga)).BeginInit();
            this.gbSolucioFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfiguracio
            // 
            this.btnConfiguracio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracio.Image = global::ExerciciCalcurradora.Properties.Resources.icons8_job_50;
            this.btnConfiguracio.Location = new System.Drawing.Point(309, 509);
            this.btnConfiguracio.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracio.Name = "btnConfiguracio";
            this.btnConfiguracio.Size = new System.Drawing.Size(49, 55);
            this.btnConfiguracio.TabIndex = 0;
            this.btnConfiguracio.UseVisualStyleBackColor = true;
            this.btnConfiguracio.Click += new System.EventHandler(this.btnConfiguracio_Click);
            // 
            // gbCalculadora
            // 
            this.gbCalculadora.Controls.Add(this.btnNumeroIgual);
            this.gbCalculadora.Controls.Add(this.btnNumero0);
            this.gbCalculadora.Controls.Add(this.btnNumeroBorrar);
            this.gbCalculadora.Controls.Add(this.btnNumero9);
            this.gbCalculadora.Controls.Add(this.btnNumero8);
            this.gbCalculadora.Controls.Add(this.btnNumero7);
            this.gbCalculadora.Controls.Add(this.btnNumero6);
            this.gbCalculadora.Controls.Add(this.btnNumero5);
            this.gbCalculadora.Controls.Add(this.btnNumero4);
            this.gbCalculadora.Controls.Add(this.btnNumero3);
            this.gbCalculadora.Controls.Add(this.btnNumero2);
            this.gbCalculadora.Controls.Add(this.btnNumero1);
            this.gbCalculadora.Controls.Add(this.tbCalculadora);
            this.gbCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalculadora.Location = new System.Drawing.Point(16, 26);
            this.gbCalculadora.Margin = new System.Windows.Forms.Padding(2);
            this.gbCalculadora.Name = "gbCalculadora";
            this.gbCalculadora.Padding = new System.Windows.Forms.Padding(2);
            this.gbCalculadora.Size = new System.Drawing.Size(262, 416);
            this.gbCalculadora.TabIndex = 1;
            this.gbCalculadora.TabStop = false;
            this.gbCalculadora.Text = "Introduiex un import";
            // 
            // btnNumeroIgual
            // 
            this.btnNumeroIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNumeroIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumeroIgual.Location = new System.Drawing.Point(179, 319);
            this.btnNumeroIgual.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumeroIgual.Name = "btnNumeroIgual";
            this.btnNumeroIgual.Size = new System.Drawing.Size(69, 64);
            this.btnNumeroIgual.TabIndex = 12;
            this.btnNumeroIgual.Text = "=";
            this.btnNumeroIgual.UseVisualStyleBackColor = false;
            this.btnNumeroIgual.Click += new System.EventHandler(this.btnNumeroIgual_Click);
            // 
            // btnNumero0
            // 
            this.btnNumero0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero0.Location = new System.Drawing.Point(99, 319);
            this.btnNumero0.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero0.Name = "btnNumero0";
            this.btnNumero0.Size = new System.Drawing.Size(69, 64);
            this.btnNumero0.TabIndex = 11;
            this.btnNumero0.Text = "0";
            this.btnNumero0.UseVisualStyleBackColor = true;
            this.btnNumero0.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumeroBorrar
            // 
            this.btnNumeroBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNumeroBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumeroBorrar.Location = new System.Drawing.Point(17, 319);
            this.btnNumeroBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumeroBorrar.Name = "btnNumeroBorrar";
            this.btnNumeroBorrar.Size = new System.Drawing.Size(69, 64);
            this.btnNumeroBorrar.TabIndex = 10;
            this.btnNumeroBorrar.Text = "C";
            this.btnNumeroBorrar.UseVisualStyleBackColor = false;
            this.btnNumeroBorrar.Click += new System.EventHandler(this.btnNumeroBorrar_Click);
            // 
            // btnNumero9
            // 
            this.btnNumero9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero9.Location = new System.Drawing.Point(179, 241);
            this.btnNumero9.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero9.Name = "btnNumero9";
            this.btnNumero9.Size = new System.Drawing.Size(69, 64);
            this.btnNumero9.TabIndex = 9;
            this.btnNumero9.Text = "9";
            this.btnNumero9.UseVisualStyleBackColor = true;
            this.btnNumero9.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero8
            // 
            this.btnNumero8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero8.Location = new System.Drawing.Point(99, 241);
            this.btnNumero8.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero8.Name = "btnNumero8";
            this.btnNumero8.Size = new System.Drawing.Size(69, 64);
            this.btnNumero8.TabIndex = 8;
            this.btnNumero8.Text = "8";
            this.btnNumero8.UseVisualStyleBackColor = true;
            this.btnNumero8.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero7
            // 
            this.btnNumero7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero7.Location = new System.Drawing.Point(17, 241);
            this.btnNumero7.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero7.Name = "btnNumero7";
            this.btnNumero7.Size = new System.Drawing.Size(69, 64);
            this.btnNumero7.TabIndex = 7;
            this.btnNumero7.Text = "7";
            this.btnNumero7.UseVisualStyleBackColor = true;
            this.btnNumero7.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero6
            // 
            this.btnNumero6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero6.Location = new System.Drawing.Point(179, 165);
            this.btnNumero6.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero6.Name = "btnNumero6";
            this.btnNumero6.Size = new System.Drawing.Size(69, 64);
            this.btnNumero6.TabIndex = 6;
            this.btnNumero6.Text = "6";
            this.btnNumero6.UseVisualStyleBackColor = true;
            this.btnNumero6.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero5
            // 
            this.btnNumero5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero5.Location = new System.Drawing.Point(99, 165);
            this.btnNumero5.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero5.Name = "btnNumero5";
            this.btnNumero5.Size = new System.Drawing.Size(69, 64);
            this.btnNumero5.TabIndex = 5;
            this.btnNumero5.Text = "5";
            this.btnNumero5.UseVisualStyleBackColor = true;
            this.btnNumero5.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero4
            // 
            this.btnNumero4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero4.Location = new System.Drawing.Point(17, 165);
            this.btnNumero4.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero4.Name = "btnNumero4";
            this.btnNumero4.Size = new System.Drawing.Size(69, 64);
            this.btnNumero4.TabIndex = 4;
            this.btnNumero4.Text = "4";
            this.btnNumero4.UseVisualStyleBackColor = true;
            this.btnNumero4.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero3
            // 
            this.btnNumero3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero3.Location = new System.Drawing.Point(179, 89);
            this.btnNumero3.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero3.Name = "btnNumero3";
            this.btnNumero3.Size = new System.Drawing.Size(69, 64);
            this.btnNumero3.TabIndex = 3;
            this.btnNumero3.Text = "3";
            this.btnNumero3.UseVisualStyleBackColor = true;
            this.btnNumero3.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero2
            // 
            this.btnNumero2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero2.Location = new System.Drawing.Point(99, 89);
            this.btnNumero2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero2.Name = "btnNumero2";
            this.btnNumero2.Size = new System.Drawing.Size(69, 64);
            this.btnNumero2.TabIndex = 2;
            this.btnNumero2.Text = "2";
            this.btnNumero2.UseVisualStyleBackColor = true;
            this.btnNumero2.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero1
            // 
            this.btnNumero1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumero1.Location = new System.Drawing.Point(17, 89);
            this.btnNumero1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNumero1.Name = "btnNumero1";
            this.btnNumero1.Size = new System.Drawing.Size(69, 64);
            this.btnNumero1.TabIndex = 1;
            this.btnNumero1.Text = "1";
            this.btnNumero1.UseVisualStyleBackColor = true;
            this.btnNumero1.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // tbCalculadora
            // 
            this.tbCalculadora.Enabled = false;
            this.tbCalculadora.Location = new System.Drawing.Point(4, 37);
            this.tbCalculadora.Margin = new System.Windows.Forms.Padding(2);
            this.tbCalculadora.Name = "tbCalculadora";
            this.tbCalculadora.Size = new System.Drawing.Size(254, 30);
            this.tbCalculadora.TabIndex = 0;
            this.tbCalculadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbOpcions
            // 
            this.gbOpcions.Controls.Add(this.btnAcceptarConfiguracio);
            this.gbOpcions.Controls.Add(this.nudDiesVacancesAnyAdicionals);
            this.gbOpcions.Controls.Add(this.nudDiesVacancesAny);
            this.gbOpcions.Controls.Add(this.nudHoresSetmanals);
            this.gbOpcions.Controls.Add(this.nudNumeroPagues);
            this.gbOpcions.Controls.Add(this.nudImportCadaPaga);
            this.gbOpcions.Controls.Add(this.lbDiesFestaAdicionalsPerAny);
            this.gbOpcions.Controls.Add(this.lbDiesVacancesPerAny);
            this.gbOpcions.Controls.Add(this.lbHoresSetmanals);
            this.gbOpcions.Controls.Add(this.lbNumeroPaguesAny);
            this.gbOpcions.Controls.Add(this.lbImportCadaPaga);
            this.gbOpcions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcions.Location = new System.Drawing.Point(396, 26);
            this.gbOpcions.Margin = new System.Windows.Forms.Padding(2);
            this.gbOpcions.Name = "gbOpcions";
            this.gbOpcions.Padding = new System.Windows.Forms.Padding(2);
            this.gbOpcions.Size = new System.Drawing.Size(401, 416);
            this.gbOpcions.TabIndex = 2;
            this.gbOpcions.TabStop = false;
            this.gbOpcions.Text = "Dades del sou i hores de treball";
            // 
            // btnAcceptarConfiguracio
            // 
            this.btnAcceptarConfiguracio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptarConfiguracio.Image = global::ExerciciCalcurradora.Properties.Resources.icons8_ok_50;
            this.btnAcceptarConfiguracio.Location = new System.Drawing.Point(332, 352);
            this.btnAcceptarConfiguracio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptarConfiguracio.Name = "btnAcceptarConfiguracio";
            this.btnAcceptarConfiguracio.Size = new System.Drawing.Size(56, 51);
            this.btnAcceptarConfiguracio.TabIndex = 10;
            this.btnAcceptarConfiguracio.UseVisualStyleBackColor = true;
            this.btnAcceptarConfiguracio.Click += new System.EventHandler(this.btnAcceptarConfiguracio_Click);
            // 
            // nudDiesVacancesAnyAdicionals
            // 
            this.nudDiesVacancesAnyAdicionals.Location = new System.Drawing.Point(257, 249);
            this.nudDiesVacancesAnyAdicionals.Margin = new System.Windows.Forms.Padding(2);
            this.nudDiesVacancesAnyAdicionals.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudDiesVacancesAnyAdicionals.Name = "nudDiesVacancesAnyAdicionals";
            this.nudDiesVacancesAnyAdicionals.Size = new System.Drawing.Size(120, 30);
            this.nudDiesVacancesAnyAdicionals.TabIndex = 9;
            // 
            // nudDiesVacancesAny
            // 
            this.nudDiesVacancesAny.Location = new System.Drawing.Point(257, 213);
            this.nudDiesVacancesAny.Margin = new System.Windows.Forms.Padding(2);
            this.nudDiesVacancesAny.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudDiesVacancesAny.Name = "nudDiesVacancesAny";
            this.nudDiesVacancesAny.Size = new System.Drawing.Size(120, 30);
            this.nudDiesVacancesAny.TabIndex = 8;
            // 
            // nudHoresSetmanals
            // 
            this.nudHoresSetmanals.Location = new System.Drawing.Point(257, 174);
            this.nudHoresSetmanals.Margin = new System.Windows.Forms.Padding(2);
            this.nudHoresSetmanals.Name = "nudHoresSetmanals";
            this.nudHoresSetmanals.Size = new System.Drawing.Size(120, 30);
            this.nudHoresSetmanals.TabIndex = 7;
            // 
            // nudNumeroPagues
            // 
            this.nudNumeroPagues.Location = new System.Drawing.Point(257, 84);
            this.nudNumeroPagues.Margin = new System.Windows.Forms.Padding(2);
            this.nudNumeroPagues.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudNumeroPagues.Name = "nudNumeroPagues";
            this.nudNumeroPagues.Size = new System.Drawing.Size(120, 30);
            this.nudNumeroPagues.TabIndex = 6;
            // 
            // nudImportCadaPaga
            // 
            this.nudImportCadaPaga.Location = new System.Drawing.Point(257, 45);
            this.nudImportCadaPaga.Margin = new System.Windows.Forms.Padding(2);
            this.nudImportCadaPaga.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudImportCadaPaga.Name = "nudImportCadaPaga";
            this.nudImportCadaPaga.Size = new System.Drawing.Size(120, 30);
            this.nudImportCadaPaga.TabIndex = 5;
            // 
            // lbDiesFestaAdicionalsPerAny
            // 
            this.lbDiesFestaAdicionalsPerAny.BackColor = System.Drawing.Color.Green;
            this.lbDiesFestaAdicionalsPerAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiesFestaAdicionalsPerAny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDiesFestaAdicionalsPerAny.Location = new System.Drawing.Point(16, 254);
            this.lbDiesFestaAdicionalsPerAny.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiesFestaAdicionalsPerAny.Name = "lbDiesFestaAdicionalsPerAny";
            this.lbDiesFestaAdicionalsPerAny.Size = new System.Drawing.Size(225, 24);
            this.lbDiesFestaAdicionalsPerAny.TabIndex = 4;
            this.lbDiesFestaAdicionalsPerAny.Text = "Dies de festa adicionals / any";
            this.lbDiesFestaAdicionalsPerAny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDiesVacancesPerAny
            // 
            this.lbDiesVacancesPerAny.BackColor = System.Drawing.Color.Green;
            this.lbDiesVacancesPerAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiesVacancesPerAny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDiesVacancesPerAny.Location = new System.Drawing.Point(16, 218);
            this.lbDiesVacancesPerAny.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiesVacancesPerAny.Name = "lbDiesVacancesPerAny";
            this.lbDiesVacancesPerAny.Size = new System.Drawing.Size(225, 24);
            this.lbDiesVacancesPerAny.TabIndex = 3;
            this.lbDiesVacancesPerAny.Text = "Dies de vacances / any";
            this.lbDiesVacancesPerAny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHoresSetmanals
            // 
            this.lbHoresSetmanals.BackColor = System.Drawing.Color.Green;
            this.lbHoresSetmanals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoresSetmanals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHoresSetmanals.Location = new System.Drawing.Point(16, 179);
            this.lbHoresSetmanals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoresSetmanals.Name = "lbHoresSetmanals";
            this.lbHoresSetmanals.Size = new System.Drawing.Size(225, 24);
            this.lbHoresSetmanals.TabIndex = 2;
            this.lbHoresSetmanals.Text = "Hores setmanals";
            this.lbHoresSetmanals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNumeroPaguesAny
            // 
            this.lbNumeroPaguesAny.BackColor = System.Drawing.Color.Green;
            this.lbNumeroPaguesAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroPaguesAny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumeroPaguesAny.Location = new System.Drawing.Point(16, 89);
            this.lbNumeroPaguesAny.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumeroPaguesAny.Name = "lbNumeroPaguesAny";
            this.lbNumeroPaguesAny.Size = new System.Drawing.Size(225, 24);
            this.lbNumeroPaguesAny.TabIndex = 1;
            this.lbNumeroPaguesAny.Text = "nº de pagues / any";
            this.lbNumeroPaguesAny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbImportCadaPaga
            // 
            this.lbImportCadaPaga.BackColor = System.Drawing.Color.Green;
            this.lbImportCadaPaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImportCadaPaga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbImportCadaPaga.Location = new System.Drawing.Point(16, 50);
            this.lbImportCadaPaga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbImportCadaPaga.Name = "lbImportCadaPaga";
            this.lbImportCadaPaga.Size = new System.Drawing.Size(225, 24);
            this.lbImportCadaPaga.TabIndex = 0;
            this.lbImportCadaPaga.Text = "Import de cada paga";
            this.lbImportCadaPaga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbSolucioFinal
            // 
            this.gbSolucioFinal.Controls.Add(this.lbHores);
            this.gbSolucioFinal.Controls.Add(this.lbTotalHoresATreballar);
            this.gbSolucioFinal.Controls.Add(this.lbMinuts);
            this.gbSolucioFinal.Controls.Add(this.lbTotalMinutsATreballar);
            this.gbSolucioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSolucioFinal.Location = new System.Drawing.Point(21, 461);
            this.gbSolucioFinal.Margin = new System.Windows.Forms.Padding(2);
            this.gbSolucioFinal.Name = "gbSolucioFinal";
            this.gbSolucioFinal.Padding = new System.Windows.Forms.Padding(2);
            this.gbSolucioFinal.Size = new System.Drawing.Size(258, 106);
            this.gbSolucioFinal.TabIndex = 3;
            this.gbSolucioFinal.TabStop = false;
            this.gbSolucioFinal.Text = "Hauràs de treballar";
            // 
            // lbHores
            // 
            this.lbHores.AutoSize = true;
            this.lbHores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHores.Location = new System.Drawing.Point(178, 67);
            this.lbHores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHores.Name = "lbHores";
            this.lbHores.Size = new System.Drawing.Size(45, 15);
            this.lbHores.TabIndex = 3;
            this.lbHores.Text = "Hores";
            // 
            // lbTotalHoresATreballar
            // 
            this.lbTotalHoresATreballar.AutoSize = true;
            this.lbTotalHoresATreballar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalHoresATreballar.Location = new System.Drawing.Point(98, 67);
            this.lbTotalHoresATreballar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalHoresATreballar.Name = "lbTotalHoresATreballar";
            this.lbTotalHoresATreballar.Size = new System.Drawing.Size(0, 15);
            this.lbTotalHoresATreballar.TabIndex = 2;
            // 
            // lbMinuts
            // 
            this.lbMinuts.AutoSize = true;
            this.lbMinuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinuts.Location = new System.Drawing.Point(178, 40);
            this.lbMinuts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMinuts.Name = "lbMinuts";
            this.lbMinuts.Size = new System.Drawing.Size(50, 15);
            this.lbMinuts.TabIndex = 1;
            this.lbMinuts.Text = "Minuts";
            // 
            // lbTotalMinutsATreballar
            // 
            this.lbTotalMinutsATreballar.AutoSize = true;
            this.lbTotalMinutsATreballar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMinutsATreballar.Location = new System.Drawing.Point(98, 40);
            this.lbTotalMinutsATreballar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalMinutsATreballar.Name = "lbTotalMinutsATreballar";
            this.lbTotalMinutsATreballar.Size = new System.Drawing.Size(0, 15);
            this.lbTotalMinutsATreballar.TabIndex = 0;
            // 
            // FormCalcurradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(805, 576);
            this.Controls.Add(this.gbSolucioFinal);
            this.Controls.Add(this.gbOpcions);
            this.Controls.Add(this.gbCalculadora);
            this.Controls.Add(this.btnConfiguracio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalcurradora";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calcurradora";
            this.Load += new System.EventHandler(this.FormCalcurradora_Load);
            this.gbCalculadora.ResumeLayout(false);
            this.gbCalculadora.PerformLayout();
            this.gbOpcions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiesVacancesAnyAdicionals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiesVacancesAny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoresSetmanals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroPagues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImportCadaPaga)).EndInit();
            this.gbSolucioFinal.ResumeLayout(false);
            this.gbSolucioFinal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfiguracio;
        private System.Windows.Forms.GroupBox gbCalculadora;
        private System.Windows.Forms.Button btnNumeroIgual;
        private System.Windows.Forms.Button btnNumero0;
        private System.Windows.Forms.Button btnNumeroBorrar;
        private System.Windows.Forms.Button btnNumero9;
        private System.Windows.Forms.Button btnNumero8;
        private System.Windows.Forms.Button btnNumero7;
        private System.Windows.Forms.Button btnNumero6;
        private System.Windows.Forms.Button btnNumero5;
        private System.Windows.Forms.Button btnNumero4;
        private System.Windows.Forms.Button btnNumero3;
        private System.Windows.Forms.Button btnNumero2;
        private System.Windows.Forms.Button btnNumero1;
        private System.Windows.Forms.TextBox tbCalculadora;
        private System.Windows.Forms.GroupBox gbOpcions;
        private System.Windows.Forms.NumericUpDown nudDiesVacancesAnyAdicionals;
        private System.Windows.Forms.NumericUpDown nudDiesVacancesAny;
        private System.Windows.Forms.NumericUpDown nudHoresSetmanals;
        private System.Windows.Forms.NumericUpDown nudNumeroPagues;
        private System.Windows.Forms.NumericUpDown nudImportCadaPaga;
        private System.Windows.Forms.Label lbDiesFestaAdicionalsPerAny;
        private System.Windows.Forms.Label lbDiesVacancesPerAny;
        private System.Windows.Forms.Label lbHoresSetmanals;
        private System.Windows.Forms.Label lbNumeroPaguesAny;
        private System.Windows.Forms.Label lbImportCadaPaga;
        private System.Windows.Forms.Button btnAcceptarConfiguracio;
        private System.Windows.Forms.GroupBox gbSolucioFinal;
        private System.Windows.Forms.Label lbHores;
        private System.Windows.Forms.Label lbTotalHoresATreballar;
        private System.Windows.Forms.Label lbMinuts;
        private System.Windows.Forms.Label lbTotalMinutsATreballar;
    }
}

