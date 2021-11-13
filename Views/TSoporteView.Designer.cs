
namespace Ejercicio3.Views
{
    partial class TSoporteView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.rb_celulares = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_Computo = new System.Windows.Forms.RadioButton();
            this.pl_celulares = new System.Windows.Forms.Panel();
            this.rb_Desbloquear = new System.Windows.Forms.RadioButton();
            this.rb_LibRed = new System.Windows.Forms.RadioButton();
            this.rb_CambPantalla = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Telefonos = new System.Windows.Forms.ComboBox();
            this.pl_computo = new System.Windows.Forms.Panel();
            this.rb_Reparacion = new System.Windows.Forms.RadioButton();
            this.rb_PromSoftware = new System.Windows.Forms.RadioButton();
            this.rb_Mantenimiento = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Computadoras = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pl_celulares.SuspendLayout();
            this.pl_computo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(261, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos de Soporte";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(34, 123);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(0, 13);
            this.lbl_usuario.TabIndex = 1;
            // 
            // rb_celulares
            // 
            this.rb_celulares.AutoSize = true;
            this.rb_celulares.Location = new System.Drawing.Point(37, 228);
            this.rb_celulares.Name = "rb_celulares";
            this.rb_celulares.Size = new System.Drawing.Size(141, 17);
            this.rb_celulares.TabIndex = 2;
            this.rb_celulares.Text = "Reparación de Celulares";
            this.rb_celulares.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Por favor seleccione el soporte que necesita";
            // 
            // rb_Computo
            // 
            this.rb_Computo.AutoSize = true;
            this.rb_Computo.Location = new System.Drawing.Point(37, 271);
            this.rb_Computo.Name = "rb_Computo";
            this.rb_Computo.Size = new System.Drawing.Size(118, 17);
            this.rb_Computo.TabIndex = 4;
            this.rb_Computo.Text = "Equipo de Cómputo";
            this.rb_Computo.UseVisualStyleBackColor = true;
            // 
            // pl_celulares
            // 
            this.pl_celulares.Controls.Add(this.pictureBox1);
            this.pl_celulares.Controls.Add(this.rb_Desbloquear);
            this.pl_celulares.Controls.Add(this.rb_LibRed);
            this.pl_celulares.Controls.Add(this.rb_CambPantalla);
            this.pl_celulares.Controls.Add(this.label3);
            this.pl_celulares.Controls.Add(this.cb_Telefonos);
            this.pl_celulares.Location = new System.Drawing.Point(336, 123);
            this.pl_celulares.Name = "pl_celulares";
            this.pl_celulares.Size = new System.Drawing.Size(414, 315);
            this.pl_celulares.TabIndex = 5;
            // 
            // rb_Desbloquear
            // 
            this.rb_Desbloquear.AutoSize = true;
            this.rb_Desbloquear.Location = new System.Drawing.Point(33, 197);
            this.rb_Desbloquear.Name = "rb_Desbloquear";
            this.rb_Desbloquear.Size = new System.Drawing.Size(85, 17);
            this.rb_Desbloquear.TabIndex = 8;
            this.rb_Desbloquear.TabStop = true;
            this.rb_Desbloquear.Text = "Desbloquear";
            this.rb_Desbloquear.UseVisualStyleBackColor = true;
            // 
            // rb_LibRed
            // 
            this.rb_LibRed.AutoSize = true;
            this.rb_LibRed.Location = new System.Drawing.Point(33, 160);
            this.rb_LibRed.Name = "rb_LibRed";
            this.rb_LibRed.Size = new System.Drawing.Size(90, 17);
            this.rb_LibRed.TabIndex = 7;
            this.rb_LibRed.TabStop = true;
            this.rb_LibRed.Text = "Liberar de red";
            this.rb_LibRed.UseVisualStyleBackColor = true;
            // 
            // rb_CambPantalla
            // 
            this.rb_CambPantalla.AutoSize = true;
            this.rb_CambPantalla.Location = new System.Drawing.Point(33, 118);
            this.rb_CambPantalla.Name = "rb_CambPantalla";
            this.rb_CambPantalla.Size = new System.Drawing.Size(115, 17);
            this.rb_CambPantalla.TabIndex = 6;
            this.rb_CambPantalla.TabStop = true;
            this.rb_CambPantalla.Text = "Cambio de pantalla";
            this.rb_CambPantalla.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione su marca de teléfono";
            // 
            // cb_Telefonos
            // 
            this.cb_Telefonos.FormattingEnabled = true;
            this.cb_Telefonos.Items.AddRange(new object[] {
            "Samsumg",
            "Iphone"});
            this.cb_Telefonos.Location = new System.Drawing.Point(33, 52);
            this.cb_Telefonos.Name = "cb_Telefonos";
            this.cb_Telefonos.Size = new System.Drawing.Size(223, 21);
            this.cb_Telefonos.TabIndex = 0;
            this.cb_Telefonos.SelectedIndexChanged += new System.EventHandler(this.cb_Telefonos_SelectedIndexChanged);
            // 
            // pl_computo
            // 
            this.pl_computo.Controls.Add(this.pictureBox2);
            this.pl_computo.Controls.Add(this.rb_Reparacion);
            this.pl_computo.Controls.Add(this.rb_PromSoftware);
            this.pl_computo.Controls.Add(this.rb_Mantenimiento);
            this.pl_computo.Controls.Add(this.label4);
            this.pl_computo.Controls.Add(this.cb_Computadoras);
            this.pl_computo.Location = new System.Drawing.Point(333, 123);
            this.pl_computo.Name = "pl_computo";
            this.pl_computo.Size = new System.Drawing.Size(414, 315);
            this.pl_computo.TabIndex = 10;
            // 
            // rb_Reparacion
            // 
            this.rb_Reparacion.AutoSize = true;
            this.rb_Reparacion.Location = new System.Drawing.Point(33, 197);
            this.rb_Reparacion.Name = "rb_Reparacion";
            this.rb_Reparacion.Size = new System.Drawing.Size(80, 17);
            this.rb_Reparacion.TabIndex = 8;
            this.rb_Reparacion.TabStop = true;
            this.rb_Reparacion.Text = "Reparación";
            this.rb_Reparacion.UseVisualStyleBackColor = true;
            // 
            // rb_PromSoftware
            // 
            this.rb_PromSoftware.AutoSize = true;
            this.rb_PromSoftware.Location = new System.Drawing.Point(33, 160);
            this.rb_PromSoftware.Name = "rb_PromSoftware";
            this.rb_PromSoftware.Size = new System.Drawing.Size(127, 17);
            this.rb_PromSoftware.TabIndex = 7;
            this.rb_PromSoftware.TabStop = true;
            this.rb_PromSoftware.Text = "Problema de software";
            this.rb_PromSoftware.UseVisualStyleBackColor = true;
            // 
            // rb_Mantenimiento
            // 
            this.rb_Mantenimiento.AutoSize = true;
            this.rb_Mantenimiento.Location = new System.Drawing.Point(33, 118);
            this.rb_Mantenimiento.Name = "rb_Mantenimiento";
            this.rb_Mantenimiento.Size = new System.Drawing.Size(94, 17);
            this.rb_Mantenimiento.TabIndex = 6;
            this.rb_Mantenimiento.TabStop = true;
            this.rb_Mantenimiento.Text = "Mantenimiento";
            this.rb_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seleccione su marca de computadora";
            // 
            // cb_Computadoras
            // 
            this.cb_Computadoras.FormattingEnabled = true;
            this.cb_Computadoras.Items.AddRange(new object[] {
            "DELL",
            "HP",
            "Lenovo"});
            this.cb_Computadoras.Location = new System.Drawing.Point(33, 52);
            this.cb_Computadoras.Name = "cb_Computadoras";
            this.cb_Computadoras.Size = new System.Drawing.Size(223, 21);
            this.cb_Computadoras.TabIndex = 0;
            this.cb_Computadoras.SelectedIndexChanged += new System.EventHandler(this.cb_Computadoras_SelectedIndexChanged);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(71, 370);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(151, 68);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ejercicio3.Properties.Resources.Lenovo;
            this.pictureBox2.Location = new System.Drawing.Point(196, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio3.Properties.Resources.Iphone;
            this.pictureBox1.Location = new System.Drawing.Point(196, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TSoporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.pl_computo);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.pl_celulares);
            this.Controls.Add(this.rb_Computo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_celulares);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TSoporteView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSoporteView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pl_celulares.ResumeLayout(false);
            this.pl_celulares.PerformLayout();
            this.pl_computo.ResumeLayout(false);
            this.pl_computo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_usuario;
        public System.Windows.Forms.RadioButton rb_celulares;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rb_Computo;
        public System.Windows.Forms.Panel pl_celulares;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton rb_Desbloquear;
        public System.Windows.Forms.RadioButton rb_LibRed;
        public System.Windows.Forms.RadioButton rb_CambPantalla;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_Telefonos;
        public System.Windows.Forms.Panel pl_computo;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.RadioButton rb_Reparacion;
        public System.Windows.Forms.RadioButton rb_PromSoftware;
        public System.Windows.Forms.RadioButton rb_Mantenimiento;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cb_Computadoras;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}