namespace App
{
    partial class Colas
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
            this.label45 = new System.Windows.Forms.Label();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.btnGenerarSimulacionDiaria = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttiempoLimite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProbabilidadEmpanada = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMediaCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.txtHornoCantSStock = new System.Windows.Forms.TextBox();
            this.txtHornoCantStock = new System.Windows.Forms.TextBox();
            this.txtEquivalenciaEnMinutos = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHornoTinic = new System.Windows.Forms.TextBox();
            this.txtHornoTiempoInicio = new System.Windows.Forms.TextBox();
            this.txtCantSim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSimApartir = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMostrarCada = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NroEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaProximoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaDeClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantClientesPerdido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado1Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado1Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado1TiempoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado2Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado2NroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado2TiempoFinCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HornoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HornoHoraFinCoccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HornoCantidadElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(670, 32);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(13, 13);
            this.label45.TabIndex = 95;
            this.label45.Text = "h";
            // 
            // txtPaso
            // 
            this.txtPaso.Location = new System.Drawing.Point(852, 28);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(100, 20);
            this.txtPaso.TabIndex = 94;
            this.txtPaso.Text = "0,05";
            // 
            // btnGenerarSimulacionDiaria
            // 
            this.btnGenerarSimulacionDiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarSimulacionDiaria.Location = new System.Drawing.Point(1146, 25);
            this.btnGenerarSimulacionDiaria.Name = "btnGenerarSimulacionDiaria";
            this.btnGenerarSimulacionDiaria.Size = new System.Drawing.Size(191, 46);
            this.btnGenerarSimulacionDiaria.TabIndex = 93;
            this.btnGenerarSimulacionDiaria.Text = "Ecuacion diferencial";
            this.btnGenerarSimulacionDiaria.UseVisualStyleBackColor = true;
            this.btnGenerarSimulacionDiaria.Click += new System.EventHandler(this.btnGenerarSimulacionDiaria_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(382, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 89;
            this.label21.Text = "Tiempo entre Inicio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(382, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "Temperatura Inicial";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Location = new System.Drawing.Point(1146, 84);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(191, 46);
            this.btnGenerar.TabIndex = 86;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(216, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 83;
            this.label17.Text = "Empleado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Equivalente en minutos";
            // 
            // txttiempoLimite
            // 
            this.txttiempoLimite.Location = new System.Drawing.Point(104, 116);
            this.txttiempoLimite.Name = "txttiempoLimite";
            this.txttiempoLimite.Size = new System.Drawing.Size(100, 20);
            this.txttiempoLimite.TabIndex = 68;
            this.txttiempoLimite.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tiempo Limite";
            // 
            // txtbCliente
            // 
            this.txtbCliente.Location = new System.Drawing.Point(104, 84);
            this.txtbCliente.Name = "txtbCliente";
            this.txtbCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbCliente.TabIndex = 66;
            this.txtbCliente.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "b";
            // 
            // txtProbabilidadEmpanada
            // 
            this.txtProbabilidadEmpanada.AutoSize = true;
            this.txtProbabilidadEmpanada.Location = new System.Drawing.Point(382, 58);
            this.txtProbabilidadEmpanada.Name = "txtProbabilidadEmpanada";
            this.txtProbabilidadEmpanada.Size = new System.Drawing.Size(148, 13);
            this.txtProbabilidadEmpanada.TabIndex = 62;
            this.txtProbabilidadEmpanada.Text = "Cantidad Elementos sin Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Cantidad Elementos con Stock";
            // 
            // txtAEmpleado
            // 
            this.txtAEmpleado.Location = new System.Drawing.Point(265, 29);
            this.txtAEmpleado.Name = "txtAEmpleado";
            this.txtAEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtAEmpleado.TabIndex = 59;
            this.txtAEmpleado.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "b";
            // 
            // txtBEmpleado
            // 
            this.txtBEmpleado.Location = new System.Drawing.Point(265, 58);
            this.txtBEmpleado.Name = "txtBEmpleado";
            this.txtBEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtBEmpleado.TabIndex = 57;
            this.txtBEmpleado.Text = "1,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "a";
            // 
            // txtMediaCliente
            // 
            this.txtMediaCliente.Location = new System.Drawing.Point(104, 29);
            this.txtMediaCliente.Name = "txtMediaCliente";
            this.txtMediaCliente.Size = new System.Drawing.Size(100, 20);
            this.txtMediaCliente.TabIndex = 55;
            this.txtMediaCliente.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "a";
            // 
            // txtaCliente
            // 
            this.txtaCliente.Location = new System.Drawing.Point(104, 58);
            this.txtaCliente.Name = "txtaCliente";
            this.txtaCliente.Size = new System.Drawing.Size(100, 20);
            this.txtaCliente.TabIndex = 53;
            this.txtaCliente.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Media";
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSimulacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEvento,
            this.TipoEvento,
            this.Reloj,
            this.HoraLlegadaProximoPedido,
            this.Stock,
            this.ColaDeClientes,
            this.CantClientesPerdido,
            this.Empleado1Estado,
            this.Empleado1Cliente,
            this.Empleado1TiempoCliente,
            this.Empleado2Estado,
            this.Empleado2NroCliente,
            this.Empleado2TiempoFinCliente,
            this.HornoEstado,
            this.HornoHoraFinCoccion,
            this.HornoCantidadElem});
            this.dgvSimulacion.Location = new System.Drawing.Point(5, 142);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.Size = new System.Drawing.Size(1330, 472);
            this.dgvSimulacion.TabIndex = 51;
            // 
            // txtHornoCantSStock
            // 
            this.txtHornoCantSStock.Location = new System.Drawing.Point(550, 54);
            this.txtHornoCantSStock.Name = "txtHornoCantSStock";
            this.txtHornoCantSStock.Size = new System.Drawing.Size(100, 20);
            this.txtHornoCantSStock.TabIndex = 61;
            this.txtHornoCantSStock.Text = "45";
            // 
            // txtHornoCantStock
            // 
            this.txtHornoCantStock.Location = new System.Drawing.Point(550, 29);
            this.txtHornoCantStock.Name = "txtHornoCantStock";
            this.txtHornoCantStock.Size = new System.Drawing.Size(100, 20);
            this.txtHornoCantStock.TabIndex = 63;
            this.txtHornoCantStock.Text = "30";
            // 
            // txtEquivalenciaEnMinutos
            // 
            this.txtEquivalenciaEnMinutos.Location = new System.Drawing.Point(852, 57);
            this.txtEquivalenciaEnMinutos.Name = "txtEquivalenciaEnMinutos";
            this.txtEquivalenciaEnMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtEquivalenciaEnMinutos.TabIndex = 75;
            this.txtEquivalenciaEnMinutos.Text = "2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(382, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "Horno";
            // 
            // txtHornoTinic
            // 
            this.txtHornoTinic.Location = new System.Drawing.Point(550, 80);
            this.txtHornoTinic.Name = "txtHornoTinic";
            this.txtHornoTinic.Size = new System.Drawing.Size(100, 20);
            this.txtHornoTinic.TabIndex = 88;
            this.txtHornoTinic.Text = "5";
            // 
            // txtHornoTiempoInicio
            // 
            this.txtHornoTiempoInicio.Location = new System.Drawing.Point(550, 103);
            this.txtHornoTiempoInicio.Name = "txtHornoTiempoInicio";
            this.txtHornoTiempoInicio.Size = new System.Drawing.Size(100, 20);
            this.txtHornoTiempoInicio.TabIndex = 90;
            this.txtHornoTiempoInicio.Text = "45";
            // 
            // txtCantSim
            // 
            this.txtCantSim.Location = new System.Drawing.Point(852, 81);
            this.txtCantSim.Name = "txtCantSim";
            this.txtCantSim.Size = new System.Drawing.Size(100, 20);
            this.txtCantSim.TabIndex = 97;
            this.txtCantSim.Text = "10000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Cantidad Simulaciones";
            // 
            // txtSimApartir
            // 
            this.txtSimApartir.Location = new System.Drawing.Point(852, 107);
            this.txtSimApartir.Name = "txtSimApartir";
            this.txtSimApartir.Size = new System.Drawing.Size(100, 20);
            this.txtSimApartir.TabIndex = 99;
            this.txtSimApartir.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(670, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Mostrar 50 simulaciones a partir de: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(670, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Simulacion y Ecuacion Diferencial";
            // 
            // txtMostrarCada
            // 
            this.txtMostrarCada.Location = new System.Drawing.Point(1040, 25);
            this.txtMostrarCada.Name = "txtMostrarCada";
            this.txtMostrarCada.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarCada.TabIndex = 102;
            this.txtMostrarCada.Text = "1000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(958, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 101;
            this.label13.Text = "Mostrar Cada: ";
            // 
            // NroEvento
            // 
            this.NroEvento.HeaderText = "Número de evento";
            this.NroEvento.Name = "NroEvento";
            // 
            // TipoEvento
            // 
            this.TipoEvento.HeaderText = "Tipo de evento";
            this.TipoEvento.Name = "TipoEvento";
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj";
            this.Reloj.Name = "Reloj";
            // 
            // HoraLlegadaProximoPedido
            // 
            this.HoraLlegadaProximoPedido.HeaderText = "Hora de llegada del próximo pedido";
            this.HoraLlegadaProximoPedido.Name = "HoraLlegadaProximoPedido";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // ColaDeClientes
            // 
            this.ColaDeClientes.HeaderText = "Cola de Clientes";
            this.ColaDeClientes.Name = "ColaDeClientes";
            // 
            // CantClientesPerdido
            // 
            this.CantClientesPerdido.HeaderText = "Clientes Perdidos";
            this.CantClientesPerdido.Name = "CantClientesPerdido";
            this.CantClientesPerdido.ReadOnly = true;
            // 
            // Empleado1Estado
            // 
            this.Empleado1Estado.HeaderText = "Empleado 1: Estado";
            this.Empleado1Estado.Name = "Empleado1Estado";
            this.Empleado1Estado.ReadOnly = true;
            // 
            // Empleado1Cliente
            // 
            this.Empleado1Cliente.HeaderText = "Empleado 1: Nro Cliente";
            this.Empleado1Cliente.Name = "Empleado1Cliente";
            this.Empleado1Cliente.ReadOnly = true;
            // 
            // Empleado1TiempoCliente
            // 
            this.Empleado1TiempoCliente.HeaderText = "Empleado 1: Hora finalizacion de Atencion Cliente";
            this.Empleado1TiempoCliente.Name = "Empleado1TiempoCliente";
            this.Empleado1TiempoCliente.ReadOnly = true;
            // 
            // Empleado2Estado
            // 
            this.Empleado2Estado.HeaderText = "Empleado 2: Estado";
            this.Empleado2Estado.Name = "Empleado2Estado";
            this.Empleado2Estado.ReadOnly = true;
            // 
            // Empleado2NroCliente
            // 
            this.Empleado2NroCliente.HeaderText = "Empleado 2: Nro Cliente";
            this.Empleado2NroCliente.Name = "Empleado2NroCliente";
            this.Empleado2NroCliente.ReadOnly = true;
            // 
            // Empleado2TiempoFinCliente
            // 
            this.Empleado2TiempoFinCliente.HeaderText = "Empleado 2: Hora Finalizacion Atencion";
            this.Empleado2TiempoFinCliente.Name = "Empleado2TiempoFinCliente";
            this.Empleado2TiempoFinCliente.ReadOnly = true;
            // 
            // HornoEstado
            // 
            this.HornoEstado.HeaderText = "Horno: Estado";
            this.HornoEstado.Name = "HornoEstado";
            this.HornoEstado.ReadOnly = true;
            // 
            // HornoHoraFinCoccion
            // 
            this.HornoHoraFinCoccion.HeaderText = "Horno: Hora Fin Coccion";
            this.HornoHoraFinCoccion.Name = "HornoHoraFinCoccion";
            this.HornoHoraFinCoccion.ReadOnly = true;
            // 
            // HornoCantidadElem
            // 
            this.HornoCantidadElem.HeaderText = "Horno: Cantidad de Elementos";
            this.HornoCantidadElem.Name = "HornoCantidadElem";
            this.HornoCantidadElem.ReadOnly = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(1146, 84);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(189, 46);
            this.progressBar.TabIndex = 103;
            this.progressBar.Visible = false;
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 624);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtMostrarCada);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSimApartir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantSim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.btnGenerarSimulacionDiaria);
            this.Controls.Add(this.txtHornoTiempoInicio);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtHornoTinic);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtEquivalenciaEnMinutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttiempoLimite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHornoCantStock);
            this.Controls.Add(this.txtProbabilidadEmpanada);
            this.Controls.Add(this.txtHornoCantSStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSimulacion);
            this.Name = "Colas";
            this.Text = "Colas";
            this.Load += new System.EventHandler(this.Colas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.Button btnGenerarSimulacionDiaria;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttiempoLimite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtProbabilidadEmpanada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMediaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.TextBox txtHornoCantSStock;
        private System.Windows.Forms.TextBox txtHornoCantStock;
        private System.Windows.Forms.TextBox txtEquivalenciaEnMinutos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHornoTinic;
        private System.Windows.Forms.TextBox txtHornoTiempoInicio;
        private System.Windows.Forms.TextBox txtCantSim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSimApartir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMostrarCada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaProximoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaDeClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantClientesPerdido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado1Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado1Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado1TiempoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado2Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado2NroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado2TiempoFinCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn HornoEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn HornoHoraFinCoccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HornoCantidadElem;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}