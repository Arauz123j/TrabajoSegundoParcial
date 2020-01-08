using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Autónomo_2_Parcial
{
    class Sandwich : SandwichPrototype
    {
        private string Bread;  
        private string Meat;
        private string Cheese;  /// Para nuestro modelo, diremos que un Sandwich consta de cuatro partes: la carne, el queso, el pan y las verduras.
        private string Veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public override SandwichPrototype Clone() /// Ahora necesitamos la clase de participante ConcretePrototype que puede clonarse para crear más instancias Sandwich. 
        {
            string ingredientList = GetIngredientList();
            Console.WriteLine("Cloning sandwich with ingredients: {0}", ingredientList.Remove(ingredientList.LastIndexOf(",")));

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {

        }
        
    }

    
}