
namespace Ejercicio3
{
    partial class LoginView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_inicioSesion = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_CrearCuenta = new System.Windows.Forms.Button();
            this.Pl_Registrer = new System.Windows.Forms.Panel();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.btn_ocultar = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ConfirmarCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Registrarse = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tmr_Abrir = new System.Windows.Forms.Timer(this.components);
            this.tmr_Cerrar = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Pl_Registrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbl_Titulo);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 38);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(0, 19);
            this.lbl_Titulo.TabIndex = 12;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.ForeColor = System.Drawing.Color.Black;
            this.btn_minimizar.Image = global::Ejercicio3.Properties.Resources.menos;
            this.btn_minimizar.Location = new System.Drawing.Point(244, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(41, 32);
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Image = global::Ejercicio3.Properties.Resources.cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(300, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(41, 32);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // lbl_inicioSesion
            // 
            this.lbl_inicioSesion.AutoSize = true;
            this.lbl_inicioSesion.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicioSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_inicioSesion.Location = new System.Drawing.Point(76, 93);
            this.lbl_inicioSesion.Name = "lbl_inicioSesion";
            this.lbl_inicioSesion.Size = new System.Drawing.Size(215, 32);
            this.lbl_inicioSesion.TabIndex = 1;
            this.lbl_inicioSesion.Text = "Inicio de Sesión";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.Location = new System.Drawing.Point(84, 190);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(201, 15);
            this.txt_usuario.TabIndex = 2;
            this.txt_usuario.Text = "CORREO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(81, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(80, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_pass.Location = new System.Drawing.Point(84, 263);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(201, 15);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.Text = "CONTRASEÑA";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Aceptar.Location = new System.Drawing.Point(81, 321);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(204, 27);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_CrearCuenta
            // 
            this.btn_CrearCuenta.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btn_CrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearCuenta.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_CrearCuenta.Location = new System.Drawing.Point(81, 370);
            this.btn_CrearCuenta.Name = "btn_CrearCuenta";
            this.btn_CrearCuenta.Size = new System.Drawing.Size(204, 28);
            this.btn_CrearCuenta.TabIndex = 8;
            this.btn_CrearCuenta.Text = "Crear Cuenta";
            this.btn_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // Pl_Registrer
            // 
            this.Pl_Registrer.Controls.Add(this.btn_Registrarse);
            this.Pl_Registrer.Controls.Add(this.btn_ocultar);
            this.Pl_Registrer.Controls.Add(this.btn_ver);
            this.Pl_Registrer.Controls.Add(this.lbl_correo);
            this.Pl_Registrer.Controls.Add(this.label8);
            this.Pl_Registrer.Controls.Add(this.txt_Nombre);
            this.Pl_Registrer.Controls.Add(this.label7);
            this.Pl_Registrer.Controls.Add(this.txt_ConfirmarContrasena);
            this.Pl_Registrer.Controls.Add(this.label6);
            this.Pl_Registrer.Controls.Add(this.txt_Contrasena);
            this.Pl_Registrer.Controls.Add(this.label5);
            this.Pl_Registrer.Controls.Add(this.txt_ConfirmarCorreo);
            this.Pl_Registrer.Controls.Add(this.label4);
            this.Pl_Registrer.Controls.Add(this.txt_correo);
            this.Pl_Registrer.Controls.Add(this.label1);
            this.Pl_Registrer.Controls.Add(this.txt_Apellido);
            this.Pl_Registrer.Controls.Add(this.lbl_Registrarse);
            this.Pl_Registrer.Controls.Add(this.btn_cancelar);
            this.Pl_Registrer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pl_Registrer.Location = new System.Drawing.Point(0, 38);
            this.Pl_Registrer.Name = "Pl_Registrer";
            this.Pl_Registrer.Size = new System.Drawing.Size(0, 410);
            this.Pl_Registrer.TabIndex = 11;
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btn_Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrarse.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrarse.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Registrarse.Location = new System.Drawing.Point(83, 332);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(204, 28);
            this.btn_Registrarse.TabIndex = 26;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            // 
            // btn_ocultar
            // 
            this.btn_ocultar.AutoSize = true;
            this.btn_ocultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ocultar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_ocultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ocultar.Image = global::Ejercicio3.Properties.Resources.ocultar1;
            this.btn_ocultar.Location = new System.Drawing.Point(300, 241);
            this.btn_ocultar.Name = "btn_ocultar";
            this.btn_ocultar.Size = new System.Drawing.Size(24, 24);
            this.btn_ocultar.TabIndex = 25;
            this.btn_ocultar.UseVisualStyleBackColor = true;
            this.btn_ocultar.Visible = false;
            // 
            // btn_ver
            // 
            this.btn_ver.AutoSize = true;
            this.btn_ver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ver.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver.Image = global::Ejercicio3.Properties.Resources.ver1;
            this.btn_ver.Location = new System.Drawing.Point(300, 241);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(24, 24);
            this.btn_ver.TabIndex = 24;
            this.btn_ver.UseVisualStyleBackColor = true;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_correo.Location = new System.Drawing.Point(214, 160);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(69, 14);
            this.lbl_correo.TabIndex = 23;
            this.lbl_correo.Text = "@tarea.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(88, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Nombre.Location = new System.Drawing.Point(91, 81);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(201, 15);
            this.txt_Nombre.TabIndex = 21;
            this.txt_Nombre.Text = "Nombres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(87, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txt_ConfirmarContrasena
            // 
            this.txt_ConfirmarContrasena.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_ConfirmarContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmarContrasena.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmarContrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_ConfirmarContrasena.Location = new System.Drawing.Point(90, 283);
            this.txt_ConfirmarContrasena.Name = "txt_ConfirmarContrasena";
            this.txt_ConfirmarContrasena.Size = new System.Drawing.Size(201, 15);
            this.txt_ConfirmarContrasena.TabIndex = 19;
            this.txt_ConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(87, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_Contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contrasena.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Contrasena.Location = new System.Drawing.Point(90, 241);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.Size = new System.Drawing.Size(201, 15);
            this.txt_Contrasena.TabIndex = 17;
            this.txt_Contrasena.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(87, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txt_ConfirmarCorreo
            // 
            this.txt_ConfirmarCorreo.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_ConfirmarCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmarCorreo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmarCorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_ConfirmarCorreo.Location = new System.Drawing.Point(90, 204);
            this.txt_ConfirmarCorreo.Name = "txt_ConfirmarCorreo";
            this.txt_ConfirmarCorreo.Size = new System.Drawing.Size(201, 15);
            this.txt_ConfirmarCorreo.TabIndex = 15;
            this.txt_ConfirmarCorreo.Text = "Confirmar correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(87, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_correo.Location = new System.Drawing.Point(90, 160);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(118, 15);
            this.txt_correo.TabIndex = 13;
            this.txt_correo.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(87, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.Color.DarkBlue;
            this.txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Apellido.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Apellido.Location = new System.Drawing.Point(90, 122);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(201, 15);
            this.txt_Apellido.TabIndex = 11;
            this.txt_Apellido.Text = "Apellidos";
            // 
            // lbl_Registrarse
            // 
            this.lbl_Registrarse.AutoSize = true;
            this.lbl_Registrarse.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registrarse.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Registrarse.Location = new System.Drawing.Point(111, 23);
            this.lbl_Registrarse.Name = "lbl_Registrarse";
            this.lbl_Registrarse.Size = new System.Drawing.Size(160, 32);
            this.lbl_Registrarse.TabIndex = 10;
            this.lbl_Registrarse.Text = "Registrarse";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Location = new System.Drawing.Point(82, 366);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(204, 28);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // tmr_Abrir
            // 
            this.tmr_Abrir.Interval = 10;
            // 
            // tmr_Cerrar
            // 
            this.tmr_Cerrar.Interval = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ejercicio3.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(43, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio3.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(43, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(350, 448);
            this.ControlBox = false;
            this.Controls.Add(this.Pl_Registrer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CrearCuenta);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_inicioSesion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pl_Registrer.ResumeLayout(false);
            this.Pl_Registrer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.Button btn_Aceptar;
        public System.Windows.Forms.Button btn_CrearCuenta;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel Pl_Registrer;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_cerrar;
        public System.Windows.Forms.Button btn_minimizar;
        public System.Windows.Forms.Label lbl_inicioSesion;
        public System.Windows.Forms.TextBox txt_usuario;
        public System.Windows.Forms.Timer tmr_Abrir;
        public System.Windows.Forms.Timer tmr_Cerrar;
        public System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.Label lbl_Titulo;
        public System.Windows.Forms.Label lbl_Registrarse;
        public System.Windows.Forms.Button btn_ocultar;
        public System.Windows.Forms.Button btn_ver;
        public System.Windows.Forms.Label lbl_correo;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_Nombre;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_ConfirmarContrasena;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Contrasena;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_ConfirmarCorreo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_correo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Apellido;
        public System.Windows.Forms.Button btn_Registrarse;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

