﻿using Ejercicio3.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.Views
{
    public partial class DetalleView : Form
    {
        public DetalleView()
        {
            InitializeComponent();
            TicketController controlador = new TicketController(this);
        }
    }
}
