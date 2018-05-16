using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Encuestas
{
    public class Datos : Notificable
    {
        #region Constructor

        public Datos()
        {

        }

        #endregion

        #region Atributos

        private ObservableCollection<Encuesta> encuestas;

        #endregion

        #region Propiedades

        public ObservableCollection<Encuesta> Encuestas
        {
            get
            {
                return Encuestas;
            }
            set
            {
                if (encuestas == value)
                {
                    return;
                }
                encuestas = value;
                OnPropertyChanged();
            }
        }

        #endregion

    }
}
