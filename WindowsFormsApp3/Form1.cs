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
using Calcul;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        byte[] IPServeur = { 127, 0, 0, 1 };
        const int PortCommande = 12345;
        Socket soc;
        NetworkStream news;
        IPEndPoint ep;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connecter_Click(object sender, EventArgs e)
        {
            //Tentatives de connection
            soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ep = new IPEndPoint(new IPAddress(IPServeur), PortCommande);

            try
            {
                soc.Connect(ep);
                etatconnection.Text = "Connexion établie :)";
                news = new NetworkStream(soc);
                Choisir.Enabled = true;
                Num1.Enabled = true;
                Num2.Enabled = true;
                Résultat.Enabled = true;
                Deconnection.Enabled = true;
            }
            catch
            {
                etatconnection.Text = "Connection impossible :(";
            }
        }


        private void Deconnection_Click(object sender, EventArgs e)
        {
            //Fermer le socket si on se déconnecte
            soc.Close();
        }


        #region Différentes opérations

        //Gérer les différentes opérations
        private void Add_Click(object sender, EventArgs e)
        {
            Envoyer("add");

        }
        
        private void Sous_Click(object sender, EventArgs e)
        {
            Envoyer("sous");
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Envoyer("multi");
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Envoyer("div");
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            Envoyer("mod");
        }

        private void Pluspetit_Click(object sender, EventArgs e)
        {
            Envoyer("petit");
        }

        private void Plusgrand_Click(object sender, EventArgs e)
        {
            Envoyer("grand");
        }

        private void Egal_Click(object sender, EventArgs e)
        {
            Envoyer("egal");
        }
#endregion
        private void Envoyer(String operation)
        {
            //Envoyer l'objet  calcul contenant les nombres et le type d'opération
            Calcul.CalculGN cl =
              new Calcul.CalculGN(Nomb1.Text, Nomb2.Text, operation);

            //Sérializer
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(news, cl);
            etatconnection.Text = "Opération envoyée! :)";
            timer1.Enabled = true;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Vérifier si on reçoit le résultat
            if (soc.Poll(1000, SelectMode.SelectRead))
            {
                etatconnection.Text = "Réception du résultat!";
                Resultat();
            }
        }
        void Resultat()
        {
            //Déserializer le résultat
            BinaryFormatter bf = new BinaryFormatter();
            Calcul.CalculGN res = (Calcul.CalculGN)bf.Deserialize(news);

            //Écrire le résultat dans la section résultat
            Res.Text = res.resultat;
            timer1.Enabled = false;
            Choisir.Enabled = false;
            Num1.Enabled = false;
            Num2.Enabled = false;

            Deconnection.Enabled = false;
            etatconnection.Text = "Connection fermée";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choisir.Enabled = false;
            Num1.Enabled = false;
            Num2.Enabled = false;
            Résultat.Enabled = false;
            Deconnection.Enabled = false;
        }
    }
}
