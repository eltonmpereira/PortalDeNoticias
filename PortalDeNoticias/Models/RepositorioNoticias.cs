using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();
            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Lorem Ipsum dolor sit",
                Autor = "Elton Medeiros",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit"
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Lorem Ipsum dolor sit",
                Autor = "Carlos SIlva",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Today logo hoje Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit"
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Contento du parlare pellentesque",
                Autor = "Renata Portela",
                Data = DateTime.Today.AddDays (-5),
                Conteudo = "Pellentesque luctus Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit"
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Sus pendisse Lorem Ipsum dolor sit",
                Autor = "Elton Medeiros",
                Data = DateTime.Today.AddDays (-4),
                Conteudo = "vivanus consequat Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit, Lorem ipsum dolor sit"
            });
        }
    }
}