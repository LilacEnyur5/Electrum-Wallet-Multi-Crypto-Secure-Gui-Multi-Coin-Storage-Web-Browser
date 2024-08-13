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
using CryptoExchange.Net.Authentication;
using Binance.API.Csharp.Client;
using System.Collections;
using System.Net;
using System.Reflection;

namespace BinanceWallet
{
    public partial class Form1 : Form
    {
        ApiClient cliente;
        api keys;
        string file = "ApiKey.json";
        BinanceClient binanceClient;
        public Form1()
        {

            InitializeComponent();
            EnterApi form2 = new EnterApi(this);
            if (!File.Exists(file))
            {             
                form2.ShowDialog();
            }
            else
                connectionTry();
        }

      
        public async void connectionTry()
        {
            try
            {
                string strKeys = File.ReadAllText(file);
                keys = JsonConvert.DeserializeObject<api>(strKeys);
                cliente = new ApiClient(keys.api_key, keys.secret_key);
                binanceClient = new BinanceClient(cliente);
                var serverTime = await binanceClient.GetServerTime();
                Console.WriteLine(serverTime.ServerTime);
                while (true)
                {             
                    conexion();
                    await Task.Delay(20000);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        async void conexion()
        {
            var datos = await binanceClient.GetAccountInfo();
            List<Binance.API.Csharp.Client.Models.Market.Balance> listaDatos = datos.Balances.ToList();
            List<Binance.API.Csharp.Client.Models.Market.Balance> listaCartera = new List<Binance.API.Csharp.Client.Models.Market.Balance>();
            foreach (var dato in listaDatos)
            {
                if (dato.Asset.Equals("BTC") || dato.Asset.Equals("FTM") || dato.Asset.Equals("STX") || dato.Asset.Equals("BNB") || dato.Asset.Equals("DOGE") || dato.Asset.Equals("USDT"))
                    listaCartera.Add(dato);
            }
            ListViewItem item = new ListViewItem();
            lvMonedas.Items.Clear();
            foreach (var dato in listaCartera)
            {
                item = new ListViewItem(dato.Asset);
                item.SubItems.Add(dato.Free.ToString());
                lvMonedas.Items.Add(item);
                
                var uri = conseguirPrecio(dato.Asset, dato.Free); 
                Console.WriteLine(uri);
                WebClient client = new WebClient();
                client.UseDefaultCredentials = true;
                var data = client.DownloadString(uri);
                //Hay que sacar el campo "eur"
                dynamic precio = JsonConvert.DeserializeObject(data);
                decimal precioEur = 0;
                switch (dato.Asset)
                {
                    case "BTC":
                        precioEur = precio.bitcoin.eur;
                        break;
                    case "FTM":
                        precioEur = precio.fantom.eur;
                        break;
                    case "STX":
                        precioEur = precio.blockstack.eur;
                        break;
                    case "BNB":
                        precioEur = precio.binancecoin.eur;
                        break;
                    case "DOGE":
                        precioEur = precio.dogecoin.eur;
                        break;
                    case "USDT":
                        precioEur = precio.tether.eur;
                        break;
                }
                precioEur *= dato.Free;
                item.SubItems.Add(precioEur.ToString("N2")+" €");
            }

            string conseguirPrecio(string asset, decimal cantidad)
            {
                string uri = "https://api.coingecko.com/api/v3/simple/price?ids={0}&vs_currencies=eur";
                switch (asset)
                {
                    case "BTC": uri = String.Format(uri, "bitcoin");
                        break;
                    case "FTM":
                        uri = String.Format(uri, "fantom");
                        break;
                    case "STX":
                        uri = String.Format(uri, "blockstack");
                        break;
                    case "BNB":
                        uri = String.Format(uri, "binancecoin");
                        break;
                    case "DOGE":
                        uri = String.Format(uri, "dogecoin");
                        break;
                    case "USDT":
                        uri = String.Format(uri, "tether");
                        break;
                }
                return uri;
            }

            await Task.Delay(1000);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.binance.com/es");
        }
    }
}
