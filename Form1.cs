using System;
using System.Drawing;
using System.Windows.Forms;
using Canchalista.Presentacion;

namespace Canchalista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            this.Text = "Menú Principal - Canchalista";
            this.Size = new Size(500, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = Color.WhiteSmoke;

            Label lblTitulo = new Label
            {
                Text = "SISTEMA CANCHALISTA",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Location = new Point(10, 30),
                Size = new Size(465, 40),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button btnCanchas = new Button
            {
                Text = "1. Gestionar Canchas",
                Location = new Point(110, 95),
                Size = new Size(260, 45),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnCanchas.Click += (s, e) => { new FrmCanchas().ShowDialog(); };

            Button btnClientes = new Button
            {
                Text = "2. Gestionar Clientes",
                Location = new Point(110, 155),
                Size = new Size(260, 45),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnClientes.Click += (s, e) => { new FrmClientes().ShowDialog(); };

            Button btnReservas = new Button
            {
                Text = "3. Gestionar Reservas",
                Location = new Point(110, 215),
                Size = new Size(260, 45),
                BackColor = Color.SeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnReservas.Click += (s, e) => { new FrmReservas().ShowDialog(); };

            this.Controls.AddRange(new Control[] { lblTitulo, btnCanchas, btnClientes, btnReservas });
        }
    }
}