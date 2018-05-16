using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas
{
    public class Encuesta
    {
        #region Atributos

        public string equipoFavorito;

        #endregion

        #region Propiedades
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EquipoFavorito
        {
            get
            {
                return equipoFavorito;
            }
            set
            {
                equipoFavorito = value;
                switch (equipoFavorito)
                {
                    case "Colombia":
                        Color = "Yellow";
                        break;

                    case "Peru":
                        Color = "Red";
                        break;

                    case "Brasil":
                        Color = "Green";
                        break;

                    case "Rusia":
                        Color = "Blue";
                        break;

                    case "Alemania":
                        Color = "Black";
                        break;

                    case "Argentina":
                        Color = "Orange";
                        break;

                }
            }
        }

        public string Color { get; set; }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return $"{Nombre}|{FechaNacimiento}|{EquipoFavorito}";
        }

        #endregion

    }
}
