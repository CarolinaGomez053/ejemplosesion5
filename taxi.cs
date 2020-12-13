using System;

namespace ejemploDos
{
    class taxi : Vehiculo
    {
      //propiedad
      private string Taximetro{get;set;}

      //metodo
      
      public string verRuta()
      {
          return Ruta.ToString();
      }

      public string valorcarrera(short taximetrorecorrido)
      {
          string totalcarrera = Taximetro;

          totalcarrera += taximetrorecorrido;
              return totalcarrera;
      }
    }
}
