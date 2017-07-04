using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_Interdisciplinar.Modelo
{
    public class Controles
    {
        public string CapsLock()
        {
            // verificar se a tecla Caps Lock está ativada
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                return "A tecla Caps Lock está ativada";
            }
            else
            {
               return "A tecla Caps Lock NÃO está ativada";
            }
        }

    }
}
