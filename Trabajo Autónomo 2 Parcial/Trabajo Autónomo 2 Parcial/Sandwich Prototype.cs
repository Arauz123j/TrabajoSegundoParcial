using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Autónomo_2_Parcial
/// <summary>
/// The Prototype abstract class
/// </summary>

{
    abstract class SandwichPrototype

    /// Primero, crearemos una clase abstracta(el participante Prototipo) para representar un sandwich, y definiremos 
    // un método por el cual la clase abstracta Sandwich pueda clonarse a sí misma.

    {
        public abstract SandwichPrototype Clone();

    }
}
