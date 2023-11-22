﻿namespace CodigoFacilito_Imperativa_Declarativa
{
    public class Book
    {
        string Title { get; set; }
        int AuthorId { get; set; }
        int PublicationDate { get; set; } // Year
        int Sales { get; set; } //Millions 

        public Book(string title, int authorId, int publicationDate, int sales)
        {
            this.Title = title;
            this.AuthorId = authorId;
            this.PublicationDate = publicationDate;
            this.Sales = sales;
        }

        public static List<Book> Books()
        {
            return new List<Book>
            {
                new Book("Don Quijote de la Mancha", 1, 1605, 500),
                new Book("Historia de dos ciudades", 2, 1859, 200),
                new Book("El Señor de los Anillos", 3, 1978, 150),
                new Book("El principito", 4, 1951, 140),
                new Book("El hobbit", 3, 1982, 100),
                new Book("Sueño en el pabellón rojo", 5, 1792, 100),
                new Book("Las aventuras de Alicia en el país de las maravillas", 6, 1865, 100),
                new Book("Diez negritos", 7, 1939, 100),
                new Book("El león, la bruja y el armario", 8, 1950, 85),
                new Book("El código Da Vinci", 9, 2003, 80),
                new Book("El guardián entre el centeno", 10, 1951, 65),
                new Book("El alquimista", 11, 1988, 65),
            };
        }
    }
}
