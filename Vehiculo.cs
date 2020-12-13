
using System;

namespace ejemploDos
{
    class Vehiculo
    {
        //Propiedades
        /**
        modificado de acceso
        public = la propiedad o metodo se puede utilizar en cualquier parte
        private = la propiedad o metodo ssolo puede utilizar en la misma clase
        protected = la propiedad o metodo se puede utilizar en la clase que heredan de la clase padre  donde estan las propiedades
        */
        public string Marca { get; set; }
        public string Serie { get; set; }

        //Ej concatenar propiedades (Marca y Serie)
        public string MarcaSerie
        {
            get
            {
              return $"Vehiculo tipo {Marca} serie {Serie}";  
            }
        }
         

        short modelo;
        public short Modelo { 
            get
            {
                return modelo;
            }
            set
            {
                if (value > 2017 && value < 2022)
                {
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Modelo no valido");
                }                
            }
        }


        string placa;
        public string Placa {
            get
            {
                return placa;
            }
            set
            {
                if (value.Length == 6)
                {
                    placa = value;
                }
                else
                {
                    Console.WriteLine("La placa debe ser de 6 digitos");
                }
            }
        }
         
         protected String Ruta {get;set;}
          
        //Metodos
        public void prender()
        {
            Console.WriteLine("El vehiculo esta prendiendo");        }
    }
}