using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using Calcul;


namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        byte[] IPServeur = { 127, 0, 0, 1 };
        Socket soc;
        IPEndPoint ep;
        const int PortCommande = 12345;
        public Form2()
        {
            InitializeComponent();
        }

        private void demarrer_Click(object sender, EventArgs e)
        {
            //Démarrer la connection
            ep = new IPEndPoint(new IPAddress(IPServeur), PortCommande);
            soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.Tcp);
            soc.Bind(ep);
            soc.Listen(3);
            etat.Text += "Le port 12345 est prêt!\r\n";
            Timer1.Enabled = true;
        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            //Vérifier si on reçoit quelque chose
                if (soc.Poll(1000, SelectMode.SelectRead))
                {
                //Faire le calcul lorsqu'on reçoit quelque chose
                    DoCalcul();
                }

        }
        void DoCalcul()
        {

            //Déserializer les données
            Socket s = soc.Accept();
            NetworkStream ns = new NetworkStream(s);
            BinaryFormatter bf = new BinaryFormatter();
            Calcul.CalculGN cal = (Calcul.CalculGN)bf.Deserialize(ns);

            //Faire le calcul avec l'objet Calcul reçu
            cal.resultat = cal.DoCalculs();

            //Sérializer et envoyer le résultat
            Calcul.CalculGN res =
            new Calcul.CalculGN(cal.Num1, cal.Num2, cal.operation);
            res.resultat = cal.resultat;
            bf.Serialize(ns, res);

            //Restarter l'application pour pouvoir effectuer une nouvelle connection et une nouvelle opération
            Application.Restart();
        }


    }
}
