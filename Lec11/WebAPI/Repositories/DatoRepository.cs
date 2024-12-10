using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class DatoRepository : IDatoRepository
    {
        private static List<Dato> datos = new List<Dato>
        {
            new Dato { Id = 1, Name = " Dato 1", Description = "- La Torre Eiffel puede ser 15 cm más alta durante el verano. Todo tiene una explicación: se debe a la expansión térmica que significa que el hierro se calienta, las partículas ganan energía cinética y ocupan más espacio." },
            new Dato { Id = 2, Name = " Dato 2", Description = "- Australia es más ancha que la Luna. La Luna tiene 3400 km de diámetro, mientras que el diámetro de Australia de este a oeste es de casi 4000 km." },
            new Dato { Id = 3, Name = " Dato 3", Description = "- La gente es más creativa en la ducha. Cuando nos duchamos con agua caliente, experimentamos un mayor flujo de dopamina que nos hace más creativos." },
            new Dato { Id = 4, Name = " Dato 4", Description = "- Las artes solían ser un deporte olímpico. Entre 1912 y 1948, los eventos deportivos internacionales otorgaban medallas a la música, la pintura, la escultura y la arquitectura." },
            new Dato { Id = 5, Name = " Dato 5", Description = "- Los átomos que conforman nuestro cuerpo tienen más de 13.700 millones de años ya que son los mismos que se formaron durante el Big Bang." },
            new Dato { Id = 6, Name = " Dato 6", Description = "- La Reina Isabel II tenía formación en mecánica. Con 16 años se incorporó a la bolsa de trabajo británica y aprendió los fundamentos de la reparación de camiones. Al parecer, sabía reparar neumáticos y motores." },
            new Dato { Id = 7, Name = " Dato 7", Description = "- El polvo que vemos a contraluz por el resplandor que entra por las ventanas está compuesto en un 90% por nuestras células muertas." },
            new Dato { Id = 8, Name = " Dato 8", Description = "- La última letra añadida al alfabeto inglés fue la \"J\". La letra data de 1524, y antes se utilizaba la letra \"i\" para los sonidos \"i\" y \"j\"." },
            new Dato { Id = 9, Name = " Dato 9", Description = "- La Luna tiene terremotos lunares. Se producen debido a las tensiones de las mareas relacionadas con la distancia entre la Luna y la Tierra." }
        };

        public List<Dato> GetDatos() => datos;

        public Dato GetById(int id) => datos.FirstOrDefault(p => p.Id == id);

        public void Add(Dato dato) => datos.Add(dato);

        public void Update(Dato dato)
        {
            var existing = datos.FirstOrDefault(p => p.Id == dato.Id);
            if (existing != null)
            {
                existing.Name = dato.Name;
                existing.Description = dato.Description;
            }
        }

        public void Delete(int id) => datos.RemoveAll(p => p.Id == id);
    }
}