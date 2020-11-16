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
            this.txtPizzaH = new System.Windows.Forms.TextBox();
            this.btnGenerarSimulacionDiaria = new System.Windows.Forms.Button();
            this.txtPrecioVentaHambur = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCantMaxEmp = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCantEmpanadas = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecioVentaLomito = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTiempoCoccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProbHambLom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecioVentaEmpanada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioVentaPizza = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProbabilidadPizza = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVentaSandwich = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProbabilidadSandwich = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLambdaEmpanada = new System.Windows.Forms.TextBox();
            this.txtProbabilidadEmpanada = new System.Windows.Forms.Label();
            this.txtProbabilidadEmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAPizza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPizzaB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMediaSandwich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVarianzaSandwich = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSimulacion = new System.Windows.Forms.DataGridView();
            this.NroEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraLlegadaProximoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaDePedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaIncompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero1Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero1TipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero1Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero1TiempoPreparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero1HoraFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero1TiempoOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero2Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero2TipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero2Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero2TiempoPreparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero2HoraFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero2TiempoOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero3Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero3TipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero3Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero3TiempoPreparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero3HoraFinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cocinero3TiempoOcio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryPedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryTiempoRegreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(210, 84);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(13, 13);
            this.label45.TabIndex = 95;
            this.label45.Text = "h";
            // 
            // txtPizzaH
            // 
            this.txtPizzaH.Location = new System.Drawing.Point(303, 81);
            this.txtPizzaH.Name = "txtPizzaH";
            this.txtPizzaH.Size = new System.Drawing.Size(100, 20);
            this.txtPizzaH.TabIndex = 94;
            this.txtPizzaH.Text = "0,05";
            // 
            // btnGenerarSimulacionDiaria
            // 
            this.btnGenerarSimulacionDiaria.Location = new System.Drawing.Point(1144, 62);
            this.btnGenerarSimulacionDiaria.Name = "btnGenerarSimulacionDiaria";
            this.btnGenerarSimulacionDiaria.Size = new System.Drawing.Size(191, 46);
            this.btnGenerarSimulacionDiaria.TabIndex = 93;
            this.btnGenerarSimulacionDiaria.Text = "Generar simulación diaria";
            this.btnGenerarSimulacionDiaria.UseVisualStyleBackColor = true;
            // 
            // txtPrecioVentaHambur
            // 
            this.txtPrecioVentaHambur.Location = new System.Drawing.Point(855, 107);
            this.txtPrecioVentaHambur.Name = "txtPrecioVentaHambur";
            this.txtPrecioVentaHambur.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaHambur.TabIndex = 92;
            this.txtPrecioVentaHambur.Text = "450";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(683, 107);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(164, 13);
            this.label22.TabIndex = 91;
            this.label22.Text = "Precio de venta de hamburguesa";
            // 
            // txtCantMaxEmp
            // 
            this.txtCantMaxEmp.Location = new System.Drawing.Point(577, 126);
            this.txtCantMaxEmp.Name = "txtCantMaxEmp";
            this.txtCantMaxEmp.Size = new System.Drawing.Size(100, 20);
            this.txtCantMaxEmp.TabIndex = 90;
            this.txtCantMaxEmp.Text = "3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(409, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 13);
            this.label21.TabIndex = 89;
            this.label21.Text = "Cantidad de empanadas/Olla";
            // 
            // txtCantEmpanadas
            // 
            this.txtCantEmpanadas.Location = new System.Drawing.Point(577, 103);
            this.txtCantEmpanadas.Name = "txtCantEmpanadas";
            this.txtCantEmpanadas.Size = new System.Drawing.Size(100, 20);
            this.txtCantEmpanadas.TabIndex = 88;
            this.txtCantEmpanadas.Text = "3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(409, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "Cantidad de empanadas";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(1144, 116);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(191, 46);
            this.btnGenerar.TabIndex = 86;
            this.btnGenerar.Text = "Generar turno";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(850, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 13);
            this.label19.TabIndex = 85;
            this.label19.Text = "Lomito/Hamburguesa";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(584, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "Empanada";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(345, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 83;
            this.label17.Text = "Pizza";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(135, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 82;
            this.label16.Text = "Sandwich";
            // 
            // txtPrecioVentaLomito
            // 
            this.txtPrecioVentaLomito.Location = new System.Drawing.Point(855, 81);
            this.txtPrecioVentaLomito.Name = "txtPrecioVentaLomito";
            this.txtPrecioVentaLomito.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaLomito.TabIndex = 81;
            this.txtPrecioVentaLomito.Text = "400";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(683, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Precio de venta de lomito";
            // 
            // txtTiempoCoccion
            // 
            this.txtTiempoCoccion.Location = new System.Drawing.Point(855, 29);
            this.txtTiempoCoccion.Name = "txtTiempoCoccion";
            this.txtTiempoCoccion.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoCoccion.TabIndex = 79;
            this.txtTiempoCoccion.Text = "8";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(683, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "Probabilidad";
            // 
            // txtProbHambLom
            // 
            this.txtProbHambLom.Location = new System.Drawing.Point(855, 55);
            this.txtProbHambLom.Name = "txtProbHambLom";
            this.txtProbHambLom.Size = new System.Drawing.Size(100, 20);
            this.txtProbHambLom.TabIndex = 77;
            this.txtProbHambLom.Text = "0,1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(683, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 76;
            this.label15.Text = "Tiempo de cocción";
            // 
            // txtPrecioVentaEmpanada
            // 
            this.txtPrecioVentaEmpanada.Location = new System.Drawing.Point(577, 81);
            this.txtPrecioVentaEmpanada.Name = "txtPrecioVentaEmpanada";
            this.txtPrecioVentaEmpanada.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaEmpanada.TabIndex = 75;
            this.txtPrecioVentaEmpanada.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Precio de venta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 73;
            // 
            // txtPrecioVentaPizza
            // 
            this.txtPrecioVentaPizza.Location = new System.Drawing.Point(303, 126);
            this.txtPrecioVentaPizza.Name = "txtPrecioVentaPizza";
            this.txtPrecioVentaPizza.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaPizza.TabIndex = 72;
            this.txtPrecioVentaPizza.Text = "250";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Precio de venta";
            // 
            // txtProbabilidadPizza
            // 
            this.txtProbabilidadPizza.Location = new System.Drawing.Point(303, 103);
            this.txtProbabilidadPizza.Name = "txtProbabilidadPizza";
            this.txtProbabilidadPizza.Size = new System.Drawing.Size(100, 20);
            this.txtProbabilidadPizza.TabIndex = 70;
            this.txtProbabilidadPizza.Text = "0,4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Probabilidad";
            // 
            // txtPrecioVentaSandwich
            // 
            this.txtPrecioVentaSandwich.Location = new System.Drawing.Point(104, 107);
            this.txtPrecioVentaSandwich.Name = "txtPrecioVentaSandwich";
            this.txtPrecioVentaSandwich.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVentaSandwich.TabIndex = 68;
            this.txtPrecioVentaSandwich.Text = "500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Precio de venta";
            // 
            // txtProbabilidadSandwich
            // 
            this.txtProbabilidadSandwich.Location = new System.Drawing.Point(104, 81);
            this.txtProbabilidadSandwich.Name = "txtProbabilidadSandwich";
            this.txtProbabilidadSandwich.Size = new System.Drawing.Size(100, 20);
            this.txtProbabilidadSandwich.TabIndex = 66;
            this.txtProbabilidadSandwich.Text = "0,20";
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
            this.label8.Location = new System.Drawing.Point(11, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Probabilidad";
            // 
            // txtLambdaEmpanada
            // 
            this.txtLambdaEmpanada.Location = new System.Drawing.Point(577, 29);
            this.txtLambdaEmpanada.Name = "txtLambdaEmpanada";
            this.txtLambdaEmpanada.Size = new System.Drawing.Size(100, 20);
            this.txtLambdaEmpanada.TabIndex = 63;
            this.txtLambdaEmpanada.Text = "3";
            // 
            // txtProbabilidadEmpanada
            // 
            this.txtProbabilidadEmpanada.AutoSize = true;
            this.txtProbabilidadEmpanada.Location = new System.Drawing.Point(409, 58);
            this.txtProbabilidadEmpanada.Name = "txtProbabilidadEmpanada";
            this.txtProbabilidadEmpanada.Size = new System.Drawing.Size(65, 13);
            this.txtProbabilidadEmpanada.TabIndex = 62;
            this.txtProbabilidadEmpanada.Text = "Probabilidad";
            // 
            // txtProbabilidadEmp
            // 
            this.txtProbabilidadEmp.Location = new System.Drawing.Point(577, 54);
            this.txtProbabilidadEmp.Name = "txtProbabilidadEmp";
            this.txtProbabilidadEmp.Size = new System.Drawing.Size(100, 20);
            this.txtProbabilidadEmp.TabIndex = 61;
            this.txtProbabilidadEmp.Text = "0,3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Lambda";
            // 
            // txtAPizza
            // 
            this.txtAPizza.Location = new System.Drawing.Point(303, 28);
            this.txtAPizza.Name = "txtAPizza";
            this.txtAPizza.Size = new System.Drawing.Size(100, 20);
            this.txtAPizza.TabIndex = 59;
            this.txtAPizza.Text = "0,3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "b";
            // 
            // txtPizzaB
            // 
            this.txtPizzaB.Location = new System.Drawing.Point(303, 55);
            this.txtPizzaB.Name = "txtPizzaB";
            this.txtPizzaB.Size = new System.Drawing.Size(100, 20);
            this.txtPizzaB.TabIndex = 57;
            this.txtPizzaB.Text = "0,8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "a";
            // 
            // txtMediaSandwich
            // 
            this.txtMediaSandwich.Location = new System.Drawing.Point(104, 29);
            this.txtMediaSandwich.Name = "txtMediaSandwich";
            this.txtMediaSandwich.Size = new System.Drawing.Size(100, 20);
            this.txtMediaSandwich.TabIndex = 55;
            this.txtMediaSandwich.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Desviación";
            // 
            // txtVarianzaSandwich
            // 
            this.txtVarianzaSandwich.Location = new System.Drawing.Point(104, 55);
            this.txtVarianzaSandwich.Name = "txtVarianzaSandwich";
            this.txtVarianzaSandwich.Size = new System.Drawing.Size(100, 20);
            this.txtVarianzaSandwich.TabIndex = 53;
            this.txtVarianzaSandwich.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Media";
            // 
            // dgvSimulacion
            // 
            this.dgvSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEvento,
            this.TipoEvento,
            this.Reloj,
            this.HoraLlegadaProximoPedido,
            this.ColaDePedidos,
            this.ColaIncompleto,
            this.Cocinero1Estado,
            this.Cocinero1TipoPedido,
            this.Cocinero1Cantidad,
            this.Cocinero1TiempoPreparacion,
            this.Cocinero1HoraFinalizacion,
            this.Cocinero1TiempoOcio,
            this.Cocinero2Estado,
            this.Cocinero2TipoPedido,
            this.Cocinero2Cantidad,
            this.Cocinero2TiempoPreparacion,
            this.Cocinero2HoraFinalizacion,
            this.Cocinero2TiempoOcio,
            this.Cocinero3Estado,
            this.Cocinero3TipoPedido,
            this.Cocinero3Cantidad,
            this.Cocinero3TiempoPreparacion,
            this.Cocinero3HoraFinalizacion,
            this.Cocinero3TiempoOcio,
            this.ColaDelivery,
            this.DeliveryEstado,
            this.DeliveryPedidos,
            this.DeliveryTiempoRegreso});
            this.dgvSimulacion.Location = new System.Drawing.Point(5, 171);
            this.dgvSimulacion.Name = "dgvSimulacion";
            this.dgvSimulacion.Size = new System.Drawing.Size(1330, 443);
            this.dgvSimulacion.TabIndex = 51;
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
            // ColaDePedidos
            // 
            this.ColaDePedidos.HeaderText = "Cola de pedidos";
            this.ColaDePedidos.Name = "ColaDePedidos";
            // 
            // ColaIncompleto
            // 
            this.ColaIncompleto.HeaderText = "Stock pedidos incompletos";
            this.ColaIncompleto.Name = "ColaIncompleto";
            // 
            // Cocinero1Estado
            // 
            this.Cocinero1Estado.HeaderText = "Cocinero 1: Estado";
            this.Cocinero1Estado.Name = "Cocinero1Estado";
            // 
            // Cocinero1TipoPedido
            // 
            this.Cocinero1TipoPedido.HeaderText = "Cocinero 1: Tipo de pedido";
            this.Cocinero1TipoPedido.Name = "Cocinero1TipoPedido";
            // 
            // Cocinero1Cantidad
            // 
            this.Cocinero1Cantidad.HeaderText = "Cocinero 1: Cantidad";
            this.Cocinero1Cantidad.Name = "Cocinero1Cantidad";
            // 
            // Cocinero1TiempoPreparacion
            // 
            this.Cocinero1TiempoPreparacion.HeaderText = "Cocinero 1: Tiempo de preparación";
            this.Cocinero1TiempoPreparacion.Name = "Cocinero1TiempoPreparacion";
            // 
            // Cocinero1HoraFinalizacion
            // 
            this.Cocinero1HoraFinalizacion.HeaderText = "Cocinero 1: Hora de finalización";
            this.Cocinero1HoraFinalizacion.Name = "Cocinero1HoraFinalizacion";
            // 
            // Cocinero1TiempoOcio
            // 
            this.Cocinero1TiempoOcio.HeaderText = "Cocinero 1: Tiempo de ocio";
            this.Cocinero1TiempoOcio.Name = "Cocinero1TiempoOcio";
            // 
            // Cocinero2Estado
            // 
            this.Cocinero2Estado.HeaderText = "Cocinero 2: Estado";
            this.Cocinero2Estado.Name = "Cocinero2Estado";
            // 
            // Cocinero2TipoPedido
            // 
            this.Cocinero2TipoPedido.HeaderText = "Cocinero 2: Tipo de pedido";
            this.Cocinero2TipoPedido.Name = "Cocinero2TipoPedido";
            // 
            // Cocinero2Cantidad
            // 
            this.Cocinero2Cantidad.HeaderText = "Cocinero 2: Cantidad";
            this.Cocinero2Cantidad.Name = "Cocinero2Cantidad";
            // 
            // Cocinero2TiempoPreparacion
            // 
            this.Cocinero2TiempoPreparacion.HeaderText = "Cocinero 2: Tiempo de preparación";
            this.Cocinero2TiempoPreparacion.Name = "Cocinero2TiempoPreparacion";
            // 
            // Cocinero2HoraFinalizacion
            // 
            this.Cocinero2HoraFinalizacion.HeaderText = "Cocinero 2: Hora de finalización";
            this.Cocinero2HoraFinalizacion.Name = "Cocinero2HoraFinalizacion";
            // 
            // Cocinero2TiempoOcio
            // 
            this.Cocinero2TiempoOcio.HeaderText = "Cocinero 2: Tiempo de ocio";
            this.Cocinero2TiempoOcio.Name = "Cocinero2TiempoOcio";
            // 
            // Cocinero3Estado
            // 
            this.Cocinero3Estado.HeaderText = "Cocinero 3: Estado";
            this.Cocinero3Estado.Name = "Cocinero3Estado";
            // 
            // Cocinero3TipoPedido
            // 
            this.Cocinero3TipoPedido.HeaderText = "Cocinero 3: Tipo de pedido";
            this.Cocinero3TipoPedido.Name = "Cocinero3TipoPedido";
            // 
            // Cocinero3Cantidad
            // 
            this.Cocinero3Cantidad.HeaderText = "Cocinero 3: Cantidad";
            this.Cocinero3Cantidad.Name = "Cocinero3Cantidad";
            // 
            // Cocinero3TiempoPreparacion
            // 
            this.Cocinero3TiempoPreparacion.HeaderText = "Cocinero 3: Tiempo de preparación";
            this.Cocinero3TiempoPreparacion.Name = "Cocinero3TiempoPreparacion";
            // 
            // Cocinero3HoraFinalizacion
            // 
            this.Cocinero3HoraFinalizacion.HeaderText = "Cocinero 3: Hora de finalización";
            this.Cocinero3HoraFinalizacion.Name = "Cocinero3HoraFinalizacion";
            // 
            // Cocinero3TiempoOcio
            // 
            this.Cocinero3TiempoOcio.HeaderText = "Cocinero 3: Tiempo de ocio";
            this.Cocinero3TiempoOcio.Name = "Cocinero3TiempoOcio";
            // 
            // ColaDelivery
            // 
            this.ColaDelivery.HeaderText = "Cola de Delivery";
            this.ColaDelivery.Name = "ColaDelivery";
            // 
            // DeliveryEstado
            // 
            this.DeliveryEstado.HeaderText = "Delivery: Estado";
            this.DeliveryEstado.Name = "DeliveryEstado";
            // 
            // DeliveryPedidos
            // 
            this.DeliveryPedidos.HeaderText = "Delivery: Pedidos en viaje";
            this.DeliveryPedidos.Name = "DeliveryPedidos";
            // 
            // DeliveryTiempoRegreso
            // 
            this.DeliveryTiempoRegreso.HeaderText = "Delivery: Tiempo de Regreso";
            this.DeliveryTiempoRegreso.Name = "DeliveryTiempoRegreso";
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 624);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.txtPizzaH);
            this.Controls.Add(this.btnGenerarSimulacionDiaria);
            this.Controls.Add(this.txtPrecioVentaHambur);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtCantMaxEmp);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtCantEmpanadas);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPrecioVentaLomito);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTiempoCoccion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProbHambLom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPrecioVentaEmpanada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPrecioVentaPizza);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProbabilidadPizza);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecioVentaSandwich);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProbabilidadSandwich);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLambdaEmpanada);
            this.Controls.Add(this.txtProbabilidadEmpanada);
            this.Controls.Add(this.txtProbabilidadEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAPizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPizzaB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediaSandwich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVarianzaSandwich);
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
        private System.Windows.Forms.TextBox txtPizzaH;
        private System.Windows.Forms.Button btnGenerarSimulacionDiaria;
        private System.Windows.Forms.TextBox txtPrecioVentaHambur;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCantMaxEmp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCantEmpanadas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrecioVentaLomito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTiempoCoccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProbHambLom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecioVentaEmpanada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioVentaPizza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProbabilidadPizza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecioVentaSandwich;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProbabilidadSandwich;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLambdaEmpanada;
        private System.Windows.Forms.Label txtProbabilidadEmpanada;
        private System.Windows.Forms.TextBox txtProbabilidadEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPizzaB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMediaSandwich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVarianzaSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraLlegadaProximoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaDePedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaIncompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero1Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero1TipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero1Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero1TiempoPreparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero1HoraFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero1TiempoOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero2Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero2TipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero2Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero2TiempoPreparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero2HoraFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero2TiempoOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero3Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero3TipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero3Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero3TiempoPreparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero3HoraFinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cocinero3TiempoOcio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryTiempoRegreso;
    }
}