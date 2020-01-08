using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Autónomo_2_Parcial
{
    class SandwichMenu
    {
        /// Ahora necesitamos crear un montón de sándwiches. En nuestro método Main () (que cumple la doble función de ser nuestro participante Cliente), 
        /// podemos hacer exactamente eso creando instancias del prototipo y luego clonándolo, para así completar nuestro `` SandwichMenu '':
       
        private Dictionary<string, SandwichPrototype> _sandwiches = new Dictionary<string, SandwichPrototype>();

        public SandwichPrototype this[string name]
        {
            get { return _sandwiches[name]; }
            set { _sandwiches.Add(name, value); }
        }
    }

}

