using System.ComponentModel.DataAnnotations;

namespace FormService.Models
{
    public class Dane
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}",ErrorMessage = "Nieprawidłowy Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj hasło")]
        [MinLength(8), RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", 
            ErrorMessage =" Hasło musi zawierać co najmniej 8 znaków w tym jedną dużą literę, jedną małą oraz jedną cyfrę ")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }
        [Required(ErrorMessage = "Potwiedz hasło")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
        public string Haslo2 { get; set; }

        [Required(ErrorMessage = "Podaj numer telefonu")]
        [Phone(ErrorMessage = "Nieprawidłowy numer telefonu")]
        public string NrTel { get; set; }

        [Required(ErrorMessage = "Prosze podaj swój wiek")]
        [Range(11, 80, ErrorMessage = "Wiek musi być między 10 a 80 lat")]
        public string Wiek { get; set; }
        [Required(ErrorMessage = "Prosze wybrać miasto")]
        public string Kategoria { get; set; }
        public enum Kategorie { Kraków, Warszawa, Gdańsk, Wrocław, Rzeszów}
    }
}
