using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticaS2.Entidades;

namespace PracticaS2.Negocio
{
    public class ClsNota{
        public String Verificador(Nota nota)
        {
            if (nota.dat >= 6 && nota.dat < 11){
                return $"Usted aprobó la materia con una nota de {nota.dat}";
            }
            else if (nota.dat <= 6){
                return $"Usted desaprobó la materia con una nota de {nota.dat}";
            }
            else{
                return $"Usted ingresó un rango no permitido solo se permite en un rango de 0 a 10";
            }
        }
    }
}
