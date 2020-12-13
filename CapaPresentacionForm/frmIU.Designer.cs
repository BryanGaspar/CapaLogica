
namespace CapaPresentacionForm
{
    partial class frmIU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldoIni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValidarFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESARROLLO EN CAPAS - CAPA PRESENTACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el saldo inicial";
            // 
            // txtSaldoIni
            // 
            this.txtSaldoIni.Location = new System.Drawing.Point(224, 105);
            this.txtSaldoIni.Name = "txtSaldoIni";
            this.txtSaldoIni.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoIni.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresa tu nombre";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(224, 145);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(172, 20);
            this.txtNom.TabIndex = 4;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(434, 130);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(89, 31);
            this.btnCal.TabIndex = 5;
            this.btnCal.Text = "CALCULAR";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(139, 316);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(331, 20);
            this.txtMensaje.TabIndex = 9;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(139, 274);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(331, 20);
            this.txtRes.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingresa el numero del Mes";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(224, 178);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(172, 20);
            this.txtMes.TabIndex = 11;
            this.txtMes.TextChanged += new System.EventHandler(this.txtMes_TextChanged);
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.Location = new System.Drawing.Point(139, 368);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.ReadOnly = true;
            this.txtNombreMes.Size = new System.Drawing.Size(331, 20);
            this.txtNombreMes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mes";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(224, 216);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(172, 20);
            this.txtFecha.TabIndex = 15;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingrese la fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado de Fecha";
            // 
            // txtValidarFecha
            // 
            this.txtValidarFecha.Location = new System.Drawing.Point(139, 404);
            this.txtValidarFecha.Name = "txtValidarFecha";
            this.txtValidarFecha.ReadOnly = true;
            this.txtValidarFecha.Size = new System.Drawing.Size(331, 20);
            this.txtValidarFecha.TabIndex = 17;
            // 
            // frmIU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.txtValidarFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreMes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldoIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmIU";
            this.Text = "Desarrollo por Capas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldoIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValidarFecha;
    }
}