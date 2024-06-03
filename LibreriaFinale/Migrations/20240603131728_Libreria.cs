using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibreriaFinale.Migrations
{
    /// <inheritdoc />
    public partial class Libreria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SetLibri",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetLibri", x => x.ISBN);
                });

            migrationBuilder.InsertData(
                table: "SetLibri",
                columns: new[] { "ISBN", "Anno", "Autore", "Genere", "Titolo" },
                values: new object[,]
                {
                    { "9780060883287", "1967", "Gabriel Garc�a M�rquez", "Romanzo", "Cent'anni di solitudine" },
                    { "9780060935467", "1960", "Harper Lee", "Romanzo", "Il buio oltre la siepe" },
                    { "9780062073563", "1926", "Agatha Christie", "Romanzo giallo", "L'assassinio di Roger Ackroyd" },
                    { "9780066238500", "1950", "C.S. Lewis", "Fantasy", "Le cronache di Narnia" },
                    { "9780099482282", "2002", "Haruki Murakami", "Romanzo", "Kafka sulla spiaggia" },
                    { "9780140120832", "1985", "Patrick S�skind", "Romanzo", "Il profumo" },
                    { "9780140268867", "800 a.C.", "Omero", "Poesia epica", "Odissea" },
                    { "9780140275360", "800 a.C.", "Omero", "Poesia epica", "Iliade" },
                    { "9780140283292", "1957", "Jack Kerouac", "Romanzo", "Sulla strada" },
                    { "9780140283339", "1954", "William Golding", "Romanzo", "Il signore delle mosche" },
                    { "9780140449174", "1877", "Lev Tolstoj", "Romanzo", "Anna Karenina" },
                    { "9780140449266", "1844", "Alexandre Dumas", "Romanzo", "Il conte di Montecristo" },
                    { "9780140449327", "19 a.C.", "Virgilio", "Poesia epica", "Eneide" },
                    { "9780141187872", "1923", "Italo Svevo", "Romanzo", "La coscienza di Zeno" },
                    { "9780141189579", "1904", "Luigi Pirandello", "Romanzo", "Il fu Mattia Pascal" },
                    { "9780141439778", "1759", "Laurence Sterne", "Romanzo comico", "Vita e opinioni di Tristram Shandy, gentiluomo" },
                    { "9780142437183", "1922", "Hermann Hesse", "Romanzo", "Siddhartha" },
                    { "9780142437222", "1320", "Dante Alighieri", "Poesia epica", "Inferno" },
                    { "9780142437230", "1605", "Miguel de Cervantes", "Romanzo", "Don Chisciotte" },
                    { "9780142437233", "1320", "Dante Alighieri", "Poesia epica", "Purgatorio" },
                    { "9780142437244", "1320", "Dante Alighieri", "Poesia epica", "Paradiso" },
                    { "9780142437247", "1851", "Herman Melville", "Romanzo", "Moby Dick" },
                    { "9780142437268", "1850", "Nathaniel Hawthorne", "Romanzo", "La lettera scarlatta" },
                    { "9780143034907", "2001", "Carlos Ruiz Zaf�n", "Romanzo", "L'ombra del vento" },
                    { "9780143108276", "1967", "Michail Bulgakov", "Romanzo", "Il maestro e Margherita" },
                    { "9780143116375", "2008", "Carlos Ruiz Zaf�n", "Romanzo", "Il gioco dell'angelo" },
                    { "9780156012195", "1943", "Antoine de Saint-Exup�ry", "Romanzo", "Il Piccolo Principe" },
                    { "9780156027991", "2002", "Jos� Saramago", "Romanzo", "L'uomo duplicato" },
                    { "9780156028356", "1982", "Alice Walker", "Romanzo", "Il colore viola" },
                    { "9780156037136", "1980", "Umberto Eco", "Romanzo giallo", "Il nome della rosa" },
                    { "9780261103344", "1937", "J.R.R. Tolkien", "Fantasy", "Lo Hobbit" },
                    { "9780307389732", "1985", "Gabriel Garc�a M�rquez", "Romanzo", "L'amore ai tempi del colera" },
                    { "9780307474278", "2003", "Dan Brown", "Romanzo giallo", "Il codice da Vinci" },
                    { "9780312428815", "1993", "Jeffrey Eugenides", "Romanzo", "Le vergini suicide" },
                    { "9780316769174", "1951", "J.D. Salinger", "Romanzo", "Il giovane Holden" },
                    { "9780316769488", "1951", "J.D. Salinger", "Romanzo", "Il giovane Holden" },
                    { "9780345298974", "1977", "Terry Brooks", "Fantasy", "La spada di Shannara" },
                    { "9780345331404", "1992", "Terry Brooks", "Fantasy", "La Canzone di Shannara" },
                    { "9780345375552", "1993", "Terry Brooks", "Fantasy", "I Talismani di Shannara" },
                    { "9780345375569", "1992", "Terry Brooks", "Fantasy", "La regina degli elfi di Shannara" },
                    { "9780375704024", "1987", "Haruki Murakami", "Romanzo", "Norwegian Wood" },
                    { "9780385494243", "2001", "Ian McEwan", "Romanzo", "L'amore ai tempi della ragione" },
                    { "9780385504225", "2009", "Dan Brown", "Romanzo giallo", "Il simbolo perduto" },
                    { "9780385537858", "2013", "Dan Brown", "Romanzo giallo", "Inferno" },
                    { "9780440212560", "1991", "Diana Gabaldon", "Romanzo storico", "La straniera" },
                    { "9780446310789", "1960", "Harper Lee", "Romanzo", "Il buio oltre la siepe" },
                    { "9780451526345", "1945", "George Orwell", "Romanzo", "La fattoria degli animali" },
                    { "9780451526346", "1945", "George Orwell", "Romanzo", "La fattoria degli animali" },
                    { "9780451529704", "1844", "Alexandre Dumas", "Romanzo", "Il conte di Montecristo" },
                    { "9780452282158", "1999", "Tracy Chevalier", "Romanzo", "La ragazza con l'orecchino di perla" },
                    { "9780452290269", "2006", "Ildefonso Falcones", "Romanzo", "La cattedrale del mare" },
                    { "9780486266848", "1898", "Henry James", "Romanzo", "Il giro di vite" },
                    { "9780486266885", "1886", "Robert Louis Stevenson", "Romanzo", "Il dottor Jekyll e Mr. Hyde" },
                    { "9780486272789", "1603", "William Shakespeare", "Teatro", "Amleto" },
                    { "9780486275438", "1865", "Lewis Carroll", "Fantasia", "Alice nel Paese delle Meraviglie" },
                    { "9780486275575", "1604", "William Shakespeare", "Teatro", "Otello" },
                    { "9780486278026", "1606", "William Shakespeare", "Teatro", "Macbeth" },
                    { "9780486278070", "1890", "Oscar Wilde", "Romanzo", "Il ritratto di Dorian Gray" },
                    { "9780486280586", "1606", "William Shakespeare", "Teatro", "Re Lear" },
                    { "9780486280615", "1884", "Mark Twain", "Romanzo", "Le avventure di Huckleberry Finn" },
                    { "9780486282114", "1818", "Mary Shelley", "Romanzo", "Frankenstein" },
                    { "9780486282115", "1883", "Carlo Collodi", "Fantasia", "Pinocchio" },
                    { "9780486290300", "1915", "Franz Kafka", "Romanzo", "La metamorfosi" },
                    { "9780486291162", "1900", "L. Frank Baum", "Fantasia", "Il Mago di Oz" },
                    { "9780486295060", "1898", "H.G. Wells", "Fantascienza", "La guerra dei mondi" },
                    { "9780486298890", "632", "Autori vari", "Religione", "Il Corano" },
                    { "9780486298910", "0", "Autori vari", "Religione", "La Bibbia" },
                    { "9780486298911", "0", "Autori vari", "Religione", "La Bibbia" },
                    { "9780486400778", "1876", "Mark Twain", "Romanzo", "Le avventure di Tom Sawyer" },
                    { "9780486404272", "1719", "Daniel Defoe", "Romanzo", "Robinson Crusoe" },
                    { "9780486406589", "1599", "William Shakespeare", "Teatro", "Enrico V" },
                    { "9780486406590", "1611", "William Shakespeare", "Teatro", "La tempesta" },
                    { "9780486406600", "1607", "William Shakespeare", "Teatro", "Antonio e Cleopatra" },
                    { "9780486406778", "1596", "William Shakespeare", "Teatro", "Il mercante di Venezia" },
                    { "9780486406785", "1595", "William Shakespeare", "Teatro", "Sogno di una notte di mezza estate" },
                    { "9780486406822", "1599", "William Shakespeare", "Teatro", "Molto rumore per nulla" },
                    { "9780486406846", "1664", "Moli�re", "Teatro", "Il Tartufo" },
                    { "9780486411079", "1320", "Dante Alighieri", "Poesia epica", "La Divina Commedia" },
                    { "9780486411095", "1897", "Bram Stoker", "Romanzo", "Dracula" },
                    { "9780486415871", "1866", "F�dor Dostoevskij", "Romanzo", "Delitto e castigo" },
                    { "9780486418309", "1922", "James Joyce", "Romanzo", "Ulisse" },
                    { "9780486421118", "1926", "Franz Kafka", "Romanzo", "Il castello" },
                    { "9780486424492", "1847", "Charlotte Bront�", "Romanzo", "Jane Eyre" },
                    { "9780486424515", "1862", "Victor Hugo", "Romanzo", "I miserabili" },
                    { "9780486426694", "1927", "Marcel Proust", "Romanzo", "Il tempo ritrovato" },
                    { "9780486437911", "1880", "F�dor Dostoevskij", "Romanzo", "I fratelli Karamazov" },
                    { "9780486440872", "1870", "Jules Verne", "Avventura", "Venti mila leghe sotto i mari" },
                    { "9780486440889", "1868", "Jules Verne", "Avventura", "I figli del capitano Grant" },
                    { "9780486440896", "1874", "Jules Verne", "Avventura", "L'isola misteriosa" },
                    { "9780486451473", "1830", "Stendhal", "Romanzo", "Il rosso e il nero" },
                    { "9780486451954", "1831", "Honor� de Balzac", "Romanzo", "La pelle di zigrino" },
                    { "9780486453941", "1839", "Stendhal", "Romanzo", "La Certosa di Parma" },
                    { "9780486456232", "1869", "F�dor Dostoevskij", "Romanzo", "L'idiota" },
                    { "9780553103540", "1996", "George R.R. Martin", "Fantasy", "Il trono di spade" },
                    { "9780553106633", "2000", "George R.R. Martin", "Fantasy", "Tempesta di spade" },
                    { "9780553296983", "1947", "Anna Frank", "Autobiografia", "Il diario di Anna Frank" },
                    { "9780553383805", "1982", "Isabel Allende", "Romanzo", "La casa degli spiriti" },
                    { "9780553386790", "1996", "George R.R. Martin", "Fantasy", "Cronache del ghiaccio e del fuoco" },
                    { "9780553579901", "1998", "George R.R. Martin", "Fantasy", "Il grande inverno" },
                    { "9780553801477", "2011", "George R.R. Martin", "Fantasy", "La danza dei draghi" },
                    { "9780553801507", "2005", "George R.R. Martin", "Fantasy", "Il banchetto dei corvi" },
                    { "9780618260270", "1954", "J.R.R. Tolkien", "Fantasy", "Le due torri" },
                    { "9780618260553", "1955", "J.R.R. Tolkien", "Fantasy", "Il ritorno del re" },
                    { "9780679720201", "1942", "Albert Camus", "Romanzo", "Lo straniero" },
                    { "9780684801223", "1952", "Ernest Hemingway", "Romanzo", "Il vecchio e il mare" },
                    { "9780684830490", "1952", "Ernest Hemingway", "Romanzo", "Il vecchio e il mare" },
                    { "9780743273565", "1925", "F. Scott Fitzgerald", "Romanzo", "Il grande Gatsby" },
                    { "9780743277709", "1972", "Richard Adams", "Romanzo", "La collina dei conigli" },
                    { "9780743493469", "2000", "Dan Brown", "Romanzo giallo", "Angeli e demoni" },
                    { "9780747532699", "1997", "J.K. Rowling", "Fantasy", "Harry Potter e la Pietra Filosofale" },
                    { "9780747538493", "1998", "J.K. Rowling", "Fantasy", "Harry Potter e la Camera dei Segreti" },
                    { "9780747545118", "1999", "J.K. Rowling", "Fantasy", "Harry Potter e il Prigioniero di Azkaban" },
                    { "9780747551003", "2000", "J.K. Rowling", "Fantasy", "Harry Potter e il Calice di Fuoco" },
                    { "9780747551010", "2003", "J.K. Rowling", "Fantasy", "Harry Potter e l'Ordine della Fenice" },
                    { "9780747581086", "2005", "J.K. Rowling", "Fantasy", "Harry Potter e il Principe Mezzosangue" },
                    { "9780747595824", "2007", "J.K. Rowling", "Fantasy", "Harry Potter e i Doni della Morte" },
                    { "9780765365279", "2010", "Brandon Sanderson", "Fantasy", "La via del re" },
                    { "9780765365286", "2014", "Brandon Sanderson", "Fantasy", "Parole di luce" },
                    { "9780765365293", "2017", "Brandon Sanderson", "Fantasy", "Giuramento" },
                    { "9780765377135", "2006", "Brandon Sanderson", "Fantasy", "L'ultimo impero" },
                    { "9780765377142", "2007", "Brandon Sanderson", "Fantasy", "Il pozzo dell'ascensione" },
                    { "9780765377159", "2008", "Brandon Sanderson", "Fantasy", "Il Campione delle Ere" },
                    { "9780805209990", "1925", "Franz Kafka", "Romanzo", "Il processo" },
                    { "9780812979657", "1997", "Arundhati Roy", "Romanzo", "Il dio delle piccole cose" },
                    { "9781400031696", "2002", "Donna Tartt", "Romanzo", "Il piccolo amico" },
                    { "9781400078776", "2005", "Kazuo Ishiguro", "Romanzo", "Non lasciarmi" },
                    { "9781400079988", "1869", "Lev Tolstoj", "Romanzo", "Guerra e Pace" },
                    { "9781451673319", "1953", "Ray Bradbury", "Distopia", "Fahrenheit 451" },
                    { "9781593082089", "1857", "Gustave Flaubert", "Romanzo", "Madame Bovary" },
                    { "9781594480006", "2003", "Khaled Hosseini", "Romanzo", "Il cacciatore di aquiloni" },
                    { "9781594483851", "2007", "Khaled Hosseini", "Romanzo", "Mille splendidi soli" },
                    { "9781594633669", "2015", "Paula Hawkins", "Thriller", "La ragazza del treno" },
                    { "9781841499713", "1990", "Terry Brooks", "Fantasy", "Gli eredi di Shannara" },
                    { "9788804512770", "1954", "J.R.R. Tolkien", "Fantasy", "Il signore degli anelli" },
                    { "9788806170595", "1981", "Gabriel Garc�a M�rquez", "Romanzo", "Cronaca di una morte annunciata" },
                    { "9788806170847", "1967", "Gabriel Garc�a M�rquez", "Romanzo", "Cent'anni di solitudine" },
                    { "9788806171234", "1984", "Milan Kundera", "Romanzo", "L'insostenibile leggerezza dell'essere" },
                    { "9788806171844", "1985", "Gabriel Garc�a M�rquez", "Romanzo", "Amore ai tempi del colera" },
                    { "9788806172179", "1960", "Harper Lee", "Romanzo", "Il buio oltre la siepe" },
                    { "9788806172361", "1949", "George Orwell", "Distopia", "1984" },
                    { "9788806173150", "1847", "Emily Bront�", "Romanzo", "Cime tempestose" },
                    { "9788806173283", "1926", "Luigi Pirandello", "Romanzo", "Uno, nessuno e centomila" },
                    { "9788806173979", "1951", "Marguerite Yourcenar", "Romanzo", "Memorie di Adriano" },
                    { "9788806177908", "1980", "Umberto Eco", "Romanzo giallo", "Il nome della rosa" },
                    { "9788806181530", "1940", "Dino Buzzati", "Romanzo", "Il deserto dei Tartari" },
                    { "9788806188034", "1320", "Dante Alighieri", "Poesia epica", "Divina Commedia" },
                    { "9788806215389", "1947", "Primo Levi", "Autobiografia", "Se questo � un uomo" },
                    { "9788806221168", "1813", "Jane Austen", "Romanzo", "Orgoglio e Pregiudizio" },
                    { "9788899060694", "1904", "Emilio Salgari", "Avventura", "La regina dei Caraibi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetLibri");
        }
    }
}
