using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceWallet
{
    public partial class EnterApi : Form
    {
        Form1 form;
        public EnterApi(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            form.connectionTry();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbxSecret.Text != "" && tbxApi.Text != "")
            {
                api key = new api(tbxApi.Text, tbxSecret.Text);
                string json = JsonConvert.SerializeObject(key);
                File.WriteAllText("ApiKey.json", json);
                form.connectionTry();
                this.Close();
            }
            else
                MessageBox.Show("No ha introducido todos los datos", "Error", MessageBoxButtons.OK);
        }
    }
}
