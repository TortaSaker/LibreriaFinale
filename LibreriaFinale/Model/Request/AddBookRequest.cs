namespace LibreriaFinale.Model.Request
{
    public class AddBookRequest
    {
        public string ISBN { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Genere { get; set; }
        public string Anno { get; set; }
    }
}
