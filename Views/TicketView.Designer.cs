
namespace Ejercicio3.Views
{
    partial class TicketView
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
            this.btn_GenTicket = new System.Windows.Forms.Button();
            this.lbl_ticket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_GenTicket
            // 
            this.btn_GenTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenTicket.Location = new System.Drawing.Point(151, 144);
            this.btn_GenTicket.Name = "btn_GenTicket";
            this.btn_GenTicket.Size = new System.Drawing.Size(151, 68);
            this.btn_GenTicket.TabIndex = 0;
            this.btn_GenTicket.Text = "Generar Ticket";
            this.btn_GenTicket.UseVisualStyleBackColor = true;
            // 
            // lbl_ticket
            // 
            this.lbl_ticket.AutoSize = true;
            this.lbl_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ticket.Location = new System.Drawing.Point(197, 76);
            this.lbl_ticket.Name = "lbl_ticket";
            this.lbl_ticket.Size = new System.Drawing.Size(0, 24);
            this.lbl_ticket.TabIndex = 1;
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(453, 235);
            this.Controls.Add(this.lbl_ticket);
            this.Controls.Add(this.btn_GenTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_GenTicket;
        public System.Windows.Forms.Label lbl_ticket;
    }
}