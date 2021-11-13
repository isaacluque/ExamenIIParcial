
namespace Ejercicio3.Views
{
    partial class EstadoView
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
            this.rb_SinResolver = new System.Windows.Forms.RadioButton();
            this.rb_Abierto = new System.Windows.Forms.RadioButton();
            this.rb_EnEspera = new System.Windows.Forms.RadioButton();
            this.rb_Cerrado = new System.Windows.Forms.RadioButton();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado de tickets";
            // 
            // rb_SinResolver
            // 
            this.rb_SinResolver.AutoSize = true;
            this.rb_SinResolver.Location = new System.Drawing.Point(39, 150);
            this.rb_SinResolver.Name = "rb_SinResolver";
            this.rb_SinResolver.Size = new System.Drawing.Size(80, 17);
            this.rb_SinResolver.TabIndex = 1;
            this.rb_SinResolver.Text = "Sin resolver";
            this.rb_SinResolver.UseVisualStyleBackColor = true;
            // 
            // rb_Abierto
            // 
            this.rb_Abierto.AutoSize = true;
            this.rb_Abierto.Location = new System.Drawing.Point(184, 150);
            this.rb_Abierto.Name = "rb_Abierto";
            this.rb_Abierto.Size = new System.Drawing.Size(58, 17);
            this.rb_Abierto.TabIndex = 2;
            this.rb_Abierto.Text = "Abierto";
            this.rb_Abierto.UseVisualStyleBackColor = true;
            // 
            // rb_EnEspera
            // 
            this.rb_EnEspera.AutoSize = true;
            this.rb_EnEspera.Location = new System.Drawing.Point(310, 150);
            this.rb_EnEspera.Name = "rb_EnEspera";
            this.rb_EnEspera.Size = new System.Drawing.Size(73, 17);
            this.rb_EnEspera.TabIndex = 3;
            this.rb_EnEspera.Text = "En espera";
            this.rb_EnEspera.UseVisualStyleBackColor = true;
            // 
            // rb_Cerrado
            // 
            this.rb_Cerrado.AutoSize = true;
            this.rb_Cerrado.Location = new System.Drawing.Point(447, 150);
            this.rb_Cerrado.Name = "rb_Cerrado";
            this.rb_Cerrado.Size = new System.Drawing.Size(62, 17);
            this.rb_Cerrado.TabIndex = 4;
            this.rb_Cerrado.Text = "Cerrado";
            this.rb_Cerrado.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(202, 215);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(151, 68);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // EstadoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 295);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.rb_Cerrado);
            this.Controls.Add(this.rb_EnEspera);
            this.Controls.Add(this.rb_Abierto);
            this.Controls.Add(this.rb_SinResolver);
            this.Controls.Add(this.label1);
            this.Name = "EstadoView";
            this.Text = "EstadoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rb_SinResolver;
        public System.Windows.Forms.RadioButton rb_Abierto;
        public System.Windows.Forms.RadioButton rb_EnEspera;
        public System.Windows.Forms.RadioButton rb_Cerrado;
        public System.Windows.Forms.Button btn_aceptar;
    }
}