using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibGN.GrandsNombres;

namespace Calcul
{
    [Serializable]
    public class CalculGN
    {
        //Attributs du calcul
        public string Num1;
        public string Num2;
        public string operation;
        public string resultat;

        //Constructeur
        public CalculGN(string num1, string num2, string operation)
        {
            this.Num1 = num1; this.Num2 = num2; this.operation = operation; this.resultat = "";
        }
        
        //Faire le calcul
        public string DoCalculs()
        {
            GN a = new GN(Num1); GN b = new GN(Num2);
            string resultat="Opération non effectuée";
            switch(operation)
            {
                //Selon l'opération
                case "add":
                    {
                        resultat = GN.Add(a, b).ToString();
                        break;
                    }
                case "sous":
                    {
                        resultat = GN.Substract(a, b).ToString();
                        break;
                    }
                case "multi":
                    {
                        resultat = GN.Mult(a, b).ToString();
                        break;
                    }
                case "div":
                    {
                        resultat = (a / b).ToString() ;
                        break;
                    }
                case "mod":
                    {
                        resultat = (a % b).ToString() ;
                        break;
                    }
                case "petit":
                    {
                        if (a < b)
                            resultat = "Vrai, le premier nombre est plus petit";
                        else
                            resultat = "Faux, le premier nombre n'est pas plus petit";
                        break;
                    }
                case "grand":
                    {
                        if (a > b)
                            resultat = "Vrai, le premier nombre est plus grand";
                        else
                            resultat = "Faux, le premier nombre n'est pas plus grand";
                        break;
                    }
                case "egal":
                    {
                        if (a == b)
                            resultat = "Vrai, les nombres sont égaux";
                        else
                            resultat = "Faux, les nombres ne sont pas égaux";
                        break;
                    }

            }
            return resultat;
        }
    }

   }
