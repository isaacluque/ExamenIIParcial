
namespace Ejercicio3.Views
{
    partial class MenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_maximizar = new System.Windows.Forms.Button();
            this.btn_minimizarVentana = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.tsti_tiposSoporte = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.tsti_estados = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.tsti_tickets = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.tsti_detalles = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.tabbedMDIManager1 = new Syncfusion.Windows.Forms.Tools.TabbedMDIManager(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.btn_maximizar);
            this.panel2.Controls.Add(this.btn_minimizarVentana);
            this.panel2.Controls.Add(this.lbl_Titulo);
            this.panel2.Controls.Add(this.btn_minimizar);
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 38);
            this.panel2.TabIndex = 1;
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximizar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximizar.ForeColor = System.Drawing.Color.Black;
            this.btn_maximizar.Image = global::Ejercicio3.Properties.Resources.Minimizar_tamano;
            this.btn_maximizar.Location = new System.Drawing.Point(1023, 2);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(41, 35);
            this.btn_maximizar.TabIndex = 14;
            this.btn_maximizar.UseVisualStyleBackColor = true;
            this.btn_maximizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_minimizarVentana
            // 
            this.btn_minimizarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizarVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizarVentana.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_minimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizarVentana.ForeColor = System.Drawing.Color.Black;
            this.btn_minimizarVentana.Image = global::Ejercicio3.Properties.Resources.Maximizar;
            this.btn_minimizarVentana.Location = new System.Drawing.Point(1024, 2);
            this.btn_minimizarVentana.Name = "btn_minimizarVentana";
            this.btn_minimizarVentana.Size = new System.Drawing.Size(41, 35);
            this.btn_minimizarVentana.TabIndex = 13;
            this.btn_minimizarVentana.UseVisualStyleBackColor = true;
            this.btn_minimizarVentana.Click += new System.EventHandler(this.btn_minimizarVentana_Click);
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
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.ForeColor = System.Drawing.Color.Black;
            this.btn_minimizar.Image = global::Ejercicio3.Properties.Resources.menos;
            this.btn_minimizar.Location = new System.Drawing.Point(977, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(41, 32);
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Image = global::Ejercicio3.Properties.Resources.cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(1070, 3);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(41, 32);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(tsti_tiposSoporte);
            this.ribbonControlAdv1.Header.AddMainItem(tsti_estados);
            this.ribbonControlAdv1.Header.AddMainItem(tsti_tickets);
            this.ribbonControlAdv1.Header.AddMainItem(tsti_detalles);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(0, 38);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonVisible = false;
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.Blue;
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbonControlAdv1.SelectedTab = this.tsti_tiposSoporte;
            this.ribbonControlAdv1.ShowMinimizeButton = false;
            this.ribbonControlAdv1.ShowQuickItemsDropDownButton = false;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = false;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1114, 60);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 2;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2016";
            this.ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // tsti_tiposSoporte
            // 
            this.tsti_tiposSoporte.Name = "tsti_tiposSoporte";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.tsti_tiposSoporte.Panel.Name = "ribbonPanel1";
            this.tsti_tiposSoporte.Panel.ScrollPosition = 0;
            this.tsti_tiposSoporte.Panel.TabIndex = 3;
            this.tsti_tiposSoporte.Panel.Text = "Tipos de Soporte";
            this.tsti_tiposSoporte.Position = 0;
            this.tsti_tiposSoporte.Size = new System.Drawing.Size(111, 25);
            this.tsti_tiposSoporte.Tag = "1";
            this.tsti_tiposSoporte.Text = "Tipos de Soporte";
            this.tsti_tiposSoporte.Click += new System.EventHandler(this.tsti_tiposSoporte_Click);
            // 
            // tsti_estados
            // 
            this.tsti_estados.Name = "tsti_estados";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.tsti_estados.Panel.Name = "ribbonPanel2";
            this.tsti_estados.Panel.ScrollPosition = 0;
            this.tsti_estados.Panel.TabIndex = 4;
            this.tsti_estados.Panel.Text = "Estados";
            this.tsti_estados.Position = 1;
            this.tsti_estados.Size = new System.Drawing.Size(63, 25);
            this.tsti_estados.Tag = "2";
            this.tsti_estados.Text = "Estados";
            this.tsti_estados.Click += new System.EventHandler(this.tsti_estados_Click);
            // 
            // tsti_tickets
            // 
            this.tsti_tickets.Name = "tsti_tickets";
            // 
            // ribbonControlAdv1.ribbonPanel3
            // 
            this.tsti_tickets.Panel.Name = "ribbonPanel3";
            this.tsti_tickets.Panel.ScrollPosition = 0;
            this.tsti_tickets.Panel.TabIndex = 5;
            this.tsti_tickets.Panel.Text = "Tickets";
            this.tsti_tickets.Position = 2;
            this.tsti_tickets.Size = new System.Drawing.Size(58, 25);
            this.tsti_tickets.Tag = "3";
            this.tsti_tickets.Text = "Tickets";
            this.tsti_tickets.Click += new System.EventHandler(this.tsti_tickets_Click);
            // 
            // tsti_detalles
            // 
            this.tsti_detalles.Name = "tsti_detalles";
            // 
            // ribbonControlAdv1.ribbonPanel4
            // 
            this.tsti_detalles.Panel.Name = "ribbonPanel4";
            this.tsti_detalles.Panel.ScrollPosition = 0;
            this.tsti_detalles.Panel.TabIndex = 6;
            this.tsti_detalles.Panel.Text = "Detalles";
            this.tsti_detalles.Position = 3;
            this.tsti_detalles.Size = new System.Drawing.Size(64, 25);
            this.tsti_detalles.Tag = "4";
            this.tsti_detalles.Text = "Detalles";
            this.tsti_detalles.Click += new System.EventHandler(this.tsti_detalles_Click);
            // 
            // tabbedMDIManager1
            // 
            this.tabbedMDIManager1.AttachedTo = this;
            this.tabbedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedMDIManager1.CloseButtonToolTip = "";
            this.tabbedMDIManager1.DropDownButtonToolTip = "";
            this.tabbedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedMDIManager1.NeedUpdateHostedForm = false;
            this.tabbedMDIManager1.ShowCloseButton = true;
            this.tabbedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2010);
            this.tabbedMDIManager1.ThemeName = "TabRendererOffice2010";
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 631);
            this.Controls.Add(this.ribbonControlAdv1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BienvenidoView";
            this.Load += new System.EventHandler(this.MenuView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn_cerrar;
        public System.Windows.Forms.Button btn_minimizar;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_maximizar;
        public System.Windows.Forms.Button btn_minimizarVentana;
        public System.Windows.Forms.Label lbl_Titulo;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem tsti_tiposSoporte;
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem tsti_detalles;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem tsti_estados;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem tsti_tickets;
        private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager1;
    }
}