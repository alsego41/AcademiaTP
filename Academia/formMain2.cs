using Academia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formMain
{
    public partial class formMain2 : Form
    {
        public formMain2()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            if (altaUsuario.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPersona altaPersona = new AltaPersona();
            if (altaPersona.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPlan altaPlan = new AltaPlan();
            if (altaPlan.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void comisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaComision altaComision = new AltaComision();
            if (altaComision.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMateria altaMateria = new AltaMateria();
            if (altaMateria.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
