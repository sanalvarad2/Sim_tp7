namespace App
{
    partial class Horno
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
            this.txtTnic = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTiempoCalculado = new System.Windows.Forms.Label();
            this.dgvHorno = new System.Windows.Forms.DataGridView();
            this.tmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquiv = new System.Windows.Forms.TextBox();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTnic
            // 
            this.txtTnic.Location = new System.Drawing.Point(303, 36);
            this.txtTnic.Name = "txtTnic";
            this.txtTnic.Size = new System.Drawing.Size(100, 20);
            this.txtTnic.TabIndex = 52;
            this.txtTnic.Text = "5";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(713, 33);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 50;
            this.btnCalcular.Text = "Calcular tiempo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTiempoCalculado
            // 
            this.lblTiempoCalculado.AutoSize = true;
            this.lblTiempoCalculado.Location = new System.Drawing.Point(572, 12);
            this.lblTiempoCalculado.Name = "lblTiempoCalculado";
            this.lblTiempoCalculado.Size = new System.Drawing.Size(49, 13);
            this.lblTiempoCalculado.TabIndex = 49;
            this.lblTiempoCalculado.Text = "00:00:00";
            // 
            // dgvHorno
            // 
            this.dgvHorno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tmp,
            this.T,
            this.k1,
            this.k2,
            this.k3,
            this.k4});
            this.dgvHorno.Location = new System.Drawing.Point(16, 62);
            this.dgvHorno.Name = "dgvHorno";
            this.dgvHorno.Size = new System.Drawing.Size(772, 379);
            this.dgvHorno.TabIndex = 47;
            // 
            // tmp
            // 
            this.tmp.HeaderText = "t";
            this.tmp.Name = "tmp";
            // 
            // T
            // 
            this.T.HeaderText = "T";
            this.T.Name = "T";
            // 
            // k1
            // 
            this.k1.HeaderText = "k1";
            this.k1.Name = "k1";
            // 
            // k2
            // 
            this.k2.HeaderText = "k2";
            this.k2.Name = "k2";
            // 
            // k3
            // 
            this.k3.HeaderText = "k3";
            this.k3.Name = "k3";
            // 
            // k4
            // 
            this.k4.HeaderText = "k4";
            this.k4.Name = "k4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "T inicial";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(75, 36);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 46;
            this.txtH.Text = "0,05";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "h";
            // 
            // txtEquiv
            // 
            this.txtEquiv.Location = new System.Drawing.Point(303, 10);
            this.txtEquiv.Name = "txtEquiv";
            this.txtEquiv.Size = new System.Drawing.Size(100, 20);
            this.txtEquiv.TabIndex = 44;
            this.txtEquiv.Text = "1";
            // 
            // txtElementos
            // 
            this.txtElementos.Location = new System.Drawing.Point(75, 13);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(100, 20);
            this.txtElementos.TabIndex = 43;
            this.txtElementos.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Equivalete en t";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Elementos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tiempo calculado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTnic);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTiempoCalculado);
            this.Controls.Add(this.dgvHorno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEquiv);
            this.Controls.Add(this.txtElementos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTnic;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTiempoCalculado;
        private System.Windows.Forms.DataGridView dgvHorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k3;
        private System.Windows.Forms.DataGridViewTextBoxColumn k4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquiv;
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

