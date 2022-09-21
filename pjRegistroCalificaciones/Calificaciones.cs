using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioTresCalificaciones
{
    internal class Calificaciones
    {
        public string nombreEstudiante { get; set; }
        public int[] calificaciones { get; set; }

        public Calificaciones(string nombreEstudiante, int[] calificaciones)
        {
            this.nombreEstudiante = nombreEstudiante;
            this.calificaciones = calificaciones;
        }

        public double ObtenerPromedio()
        {
            double suma = 0;
            for (int i = 0; i < calificaciones.Length; i++)
                suma += calificaciones[i];
            return suma / calificaciones.Length;
            //foreach (double calificacion in calificaciones)
            //    suma += calificacion;
            //return suma / calificaciones.Length;

        }

        // busca la calificación mínima
        public int ObtenerMinima()
        {
            int califBaja = calificaciones[0]; // asume que calificaciones[0] es la más baja

            // itera a través del arreglo calificaciones
            foreach(int calificacion in calificaciones)
            {
                // si calificación es menor que califBaja, la asigna a califBaja
                if(calificacion < califBaja)
                    califBaja = calificacion; // nueva calificación más baja
            }

            return califBaja; // devuelve la calificación más baja
        }

        // busca la calificación máxima
        public int ObtenerMaxima()
        {
            int califAlta = calificaciones[0]; // asume que calificaciones[0] es la más alta

            // itera a través del arreglo calificaciones
            foreach (int calificacion in calificaciones)
            {
                // si calificación es mayor que califAlta, la asigna a califAlta
                if (calificacion > califAlta)
                    califAlta = calificacion; // nueva calificación más alta
            }

            return califAlta; // devuelve la calificación más baja
        }
    }
}
