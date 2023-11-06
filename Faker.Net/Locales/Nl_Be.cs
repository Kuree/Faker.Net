namespace Faker.Locales
{
    [Locale(LocaleType.nl_BE)]
    internal class Nl_Be : En
    {
        public override string Title { get { return "Dutch"; } }

        #region Geography
        public override string[] CityPrefix
        {
            get
            {
                return new[] {
                                    "Noord",
                                    "Oost",
                                    "West",
                                    "Zuid",
                                    "Nieuw",
                                    "Oud",
                                    "Bad"
                };
            }
        }

        public override string[] CitySuffix
        {
            get
            {
                return new[] {
                                "stad",
                                "dorp",
                                "land",
                                "burg"
                };
            }
        }

        public override string[] Country
        {
            get
            {
                return new[] {
                                "Egypte",
                                "Equatoriaal-Guinea",
                                "Ethiopië",
                                "Oostenrijk",
                                "Afghanistan",
                                "Albanië",
                                "Algerije",
                                "Amerikaans-Samoa",
                                "Amerikaanse Maagdeneilanden",
                                "Andorra",
                                "Angola",
                                "Anguilla",
                                "Antarctica",
                                "Antigua en Barbuda",
                                "Argentinië",
                                "Armenië",
                                "Aruba",
                                "Azerbeidzjan",
                                "Australië",
                                "Bahama's",
                                "Bahrein",
                                "Bangladesh",
                                "Barbados",
                                "Wit-Rusland",
                                "België",
                                "Belize",
                                "Benin",
                                "Bermuda",
                                "Bhutan",
                                "Bolivia",
                                "Bosnië en Herzegovina",
                                "Botswana",
                                "Bouveteiland",
                                "Brazilië",
                                "Britse Maagdeneilanden",
                                "Brits Indische Oceaanterritorium",
                                "Brunei",
                                "Bulgarije",
                                "Burkina Faso",
                                "Burundi",
                                "Chili",
                                "China",
                                "Cookeilanden",
                                "Costa Rica",
                                "Denemarken",
                                "Democratische Republiek Congo",
                                "Noord-Korea",
                                "Duitsland",
                                "Dominica",
                                "Dominicaanse Republiek",
                                "Djibouti",
                                "Ecuador",
                                "El Salvador",
                                "Eritrea",
                                "Estland",
                                "Faeröer",
                                "Falklandeilanden",
                                "Fiji",
                                "Finland",
                                "Frankrijk",
                                "Frans-Guyana",
                                "Frans-Polynesië",
                                "Franse Zuidelijke en Antarctische Gebieden",
                                "Gabon",
                                "Gambia",
                                "Georgië",
                                "Ghana",
                                "Gibraltar",
                                "Groenland",
                                "Grenada",
                                "Griekenland",
                                "Guadeloupe",
                                "Guam",
                                "Guatemala",
                                "Guinee",
                                "Guinee-Bissau",
                                "Guyana",
                                "Haïti",
                                "Heard en McDonaldeilanden",
                                "Honduras",
                                "Hongkong",
                                "India",
                                "Indonesië",
                                "Irak",
                                "Iran",
                                "Ierland",
                                "IJsland",
                                "Israël",
                                "Italië",
                                "Jamaica",
                                "Japan",
                                "Jemen",
                                "Jordanië",
                                "Joegoslavië",
                                "Kaaimaneilanden",
                                "Cambodja",
                                "Kameroen",
                                "Canada",
                                "Kaapverdië",
                                "Kazachstan",
                                "Qatar",
                                "Kenia",
                                "Kirgizië",
                                "Kiribati",
                                "Amerikaanse kleinere afgelegen eilanden",
                                "Cocoseilanden",
                                "Colombia",
                                "Comoren",
                                "Congo",
                                "Kroatië",
                                "Cuba",
                                "Koeweit",
                                "Laos",
                                "Lesotho",
                                "Letland",
                                "Libanon",
                                "Liberia",
                                "Libië",
                                "Liechtenstein",
                                "Litouwen",
                                "Luxemburg",
                                "Macau",
                                "Madagaskar",
                                "Malawi",
                                "Maleisië",
                                "Maldiven",
                                "Mali",
                                "Malta",
                                "Noord-Macedonië",
                                "Marokko",
                                "Marshalleilanden",
                                "Martinique",
                                "Mauritanië",
                                "Mauritius",
                                "Mayotte",
                                "Mexico",
                                "Micronesië",
                                "Monaco",
                                "Mongolië",
                                "Montserrat",
                                "Mozambique",
                                "Myanmar",
                                "Noordelijke Marianen",
                                "Namibië",
                                "Nauru",
                                "Nepal",
                                "Nieuw-Caledonië",
                                "Nieuw-Zeeland",
                                "Nicaragua",
                                "Nederlandse Antillen",
                                "Nederland",
                                "Niger",
                                "Nigeria",
                                "Niue",
                                "Norfolkeiland",
                                "Noorwegen",
                                "Oman",
                                "Oost-Timor",
                                "Pakistan",
                                "Palau",
                                "Panama",
                                "Papoea-Nieuw-Guinea",
                                "Paraguay",
                                "Peru",
                                "Filipijnen",
                                "Pitcairneilanden",
                                "Polen",
                                "Portugal",
                                "Puerto Rico",
                                "Réunion",
                                "Zuid-Korea",
                                "Moldavië",
                                "Rwanda",
                                "Roemenië",
                                "Rusland",
                                "Sao Tomé en Principe",
                                "Zuid-Afrika",
                                "Zuid-Georgia en Zuidelijke Sandwicheilanden",
                                "Salomonseilanden",
                                "Zambia",
                                "Samoa",
                                "San Marino",
                                "Saoedi-Arabië",
                                "Zweden",
                                "Zwitserland",
                                "Senegal",
                                "Seychellen",
                                "Sierra Leone",
                                "Zimbabwe",
                                "Singapore",
                                "Slowakije",
                                "Slovenië","Spanje",
                                "Sri Lanka",
                                "Saint Helena",
                                "Saint Kitts en Nevis",
                                "Saint Lucia",
                                "Saint Pierre en Miquelon",
                                "Saint Vincent en de Grenadines",
                                "Soedan",
                                "Suriname",
                                "Svalbard en Jan Mayen",
                                "Swaziland",
                                "Syrië",
                                "Turkije",
                                "Tadzjikistan",
                                "Taiwan",
                                "Tanzania",
                                "Thailand",
                                "Togo",
                                "Tokelau",
                                "Tonga",
                                "Trinidad en Tobago",
                                "Tsjaad",
                                "Tsjechië",
                                "Tunesië",
                                "Turkmenistan",
                                "Turks- en Caicoseilanden",
                                "Tuvalu",
                                "Oeganda",
                                "Oekraïne",
                                "Hongarije",
                                "Uruguay",
                                "Oezbekistan",
                                "Vanuatu",
                                "Vaticaanstad",
                                "Venezuela",
                                "Verenigde Arabische Emiraten",
                                "Verenigde Staten",
                                "Verenigd Koninkrijk",
                                "Vietnam",
                                "Wallis en Futuna",
                                "Kersteiland",
                                "Westelijke Sahara",
                                "Centraal-Afrikaanse Republiek",
                                "Cyprus",
                };
            }
        }

        public string[] StreetRoot
        {
            get
            {
                return new[] {
                                    "Stationsstraat",
                                    "Kerkstraat",
                                    "Schoolstraat",
                                    "Molenstraat",
                                    "Beekstraat",
                                    "Meerstraat",
                                    "Parkstraat",
                                    "Kasteelstraat",
                                    "Bosstraat",
                                    "Tuinstraat",
                                    "Oude Markt",
                                    "Nieuwe Weg",
                                    "Zuidstraat",
                                    "Noordstraat",
                                    "Weststraat",
                                    "Ooststraat",
                                    "Langestraat",
                                    "Kortestraat",
                                    "Hoogstraat",
                                    "Laagstraat",
                                    "Groenstraat",
                                    "Kanaalstraat",
                                    "Fabriekstraat",
                                    "Industriestraat",
                                    "Havenstraat",
                                    "Zavelstraat",
                                    "Steenweg",
                                    "Brugstraat",
                                    "Rivierstraat",
                                    "Veldstraat",
                                    "Duinenstraat",
                                    "Akkerstraat",
                                    "Veemarkt",
                                    "Kapelstraat",
                                    "Elisabethlaan",
                                    "Leopoldlaan",
                                    "Astridlaan",
                                    "Albertlaan",
                                    "Koninginlaan",
                                    "Prinsenlaan",
                                    "Graafstraat",
                                    "Burgstraat",
                                    "Markt",
                                    "Vrijheidstraat",
                                    "Gelijkheidstraat",
                                    "Broederschapstraat",
                                    "Bloemstraat",
                                    "Vijverstraat",
                                    "Fonteinstraat",
                                    "Kloosterstraat",
                                    "Begijnhof",
                                    "Zusterstraat",
                                    "Priorijstraat",
                                    "Abdijstraat",
                                    "Monnikenstraat",
                                    "Eikenlaan",
                                    "Berkelaan",
                                    "Beukenlaan",
                                    "Dennenlaan",
                                    "Sparrenlaan",
                                    "Lindenlaan",
                                    "Esdoornlaan",
                                    "Acacialaan",
                                    "Populierenlaan",
                                    "Wilgenlaan",
                                    "Olmenlaan",
                                    "Hazelaarlaan",
                                    "Meidoornlaan",
                                    "Lijsterbeslaan",
                                    "Kastanjelaan",
                                    "Platanenlaan",
                                    "Iepenlaan",
                                    "Tulpenstraat",
                                    "Rozenstraat",
                                    "Violierenstraat",
                                    "Dahliastraat",
                                    "Anjelierenstraat",
                                    "Orchideeënstraat",
                                    "Magnolialaan",
                                    "Azaleastraat",
                                    "Begonialaan",
                                    "Lavendelstraat",
                                    "Tijmstraat",
                                    "Muntstraat",
                                    "Basilicumstraat",
                                    "Korianderstraat",
                                    "Dillestraat",
                                    "Kervellaan",
                                    "Rozemarijnstraat",
                                    "Salieplaats",
                                    "Kamilleweg",
                                    "Valeriaanstraat",
                                    "Laurierlaan",
                                    "Jeneverbeslaan",
                                    "Kruizemuntstraat",
                                    "Pepermuntstraat",
                                    "Tijmlaan",
                                    "Gentiaanstraat",
                                    "Kalmoesstraat",
                                    "Vlierstraat",
                                    "Nachtegaalpad",
                                    "Merellaan",
                                    "Zwaluwweg",
                                    "Sperwerlaan",
                                    "Valkenstraat",
                                    "Havikstraat",
                                    "Adelaarsweg",
                                    "Uilenburg",
                                    "Papegaaienlaan",
                                    "Koekoekstraat",
                                    "Leeuweriklaan",
                                    "Kwikstaartplein",
                                    "Spechtstraat",
                                    "Roodborstlaan",
                                    "Zwanenstraat",
                                    "Ganzenweg",
                                    "Eendenlaan",
                                    "Reigerstraat",
                                    "Ooievaarstraat",
                                    "Meerkoetstraat",
                                    "Waterhoenstraat",
                                    "Fuutstraat",
                                    "Dodaarsweg",
                                    "Lepelaarstraat",
                                    "Stormvogelstraat",
                                    "Jan-van-Gentstraat",
                                    "Albatrosstraat",
                                    "Pelikaanstraat",
                                    "Zeemeeuwlaan",
                                    "Strandloperstraat",
                                    "Scholeksterstraat",
                                    "Kluutstraat",
                                    "Steltloperstraat",
                                    "Regenwulplaan",
                                    "Wulpstraat",
                                    "Tureluurstraat",
                                    "Gruttostraat",
                                    "Kievitstraat",
                                    "Patrijslaan",
                                    "Fazantenweg",
                                    "Korhoenstraat",
                                    "Sneeuwgorsstraat",
                                    "Vinkenstraat",
                                    "Musstraat",
                                    "Spreeuwenlaan",
                                    "Merelstraat",
                                    "Nachtegaallaan",
                                    "Zanglijsterstraat",
                                    "Goudvinkstraat",
                                    "Boomkleverlaan",
                                    "Koolmeesstraat",
                                    "Pimpelmeesstraat",
                                    "Staartmeesstraat",
                                    "Matkopstraat",
                                    "Glanskopstraat",
                                    "Kuifmeesstraat",
                                    "Baardmanstraat",
                };
            }
        }

        public override string[] BuildingNumberFormat
        {
            get
            {
                return new[] {
                                "###",
                                "##",
                                "#",
                                "##a",
                                "##b",
                                "##c"
                };
            }
        }

        public override string[] SecondaryStreetNameFormat
        {
            get
            {
                return new[] {
                                "Bus. ###",
                                "Kamer ###",
                };
            }

        }

        public override string[] PostCode
        {
            get
            {
                return new[] {
                                "####"
                };
            }
        }

        public override string[] State
        {
            get
            {
                return new[] {
                                "West-Vlaanderen",
                                "Oost-Vlaanderen",
                                "Antwerpen",
                                "Limburg",
                                "Brussel",
                                "Vlaams-Braband",
                                "Waals-Braband",
                                "Luxemburg",
                                "Namen",
                                "Luik",
                                "Henegouwen",
                };
            }
        }

        public override string[] StateAbbr
        {
            get
            {
                return new[] {
                                "W-Vl",
                                "O-Vl",
                                "Ant",
                                "Bxl",
                                "Vl-Br",
                                "W-Br",
                                "Lux",
                                "Nam",
                                "Lui",
                                "Hen",
                };
            }
        }

        public override string[] CityNameFormat
        {
            get
            {
                return new[] {
                                "#{CityPrefix} #{Name.GetFirstName}#{CitySuffix}",
                                "#{CityPrefix} #{Name.GetFirstName}",
                                "#{Name.GetFirstName}#{CitySuffix}",
                                "#{Name.GetLastName}#{CitySuffix}"
                };
            }
        }

        public override string[] StreetNameFormat
        {
            get
            {
                return new[] {
                               "#{StreetRoot}"
                };
            }
        }

        public override string[] StreetAddressFormat
        {
            get
            {
                return new[] { "@{Address.GetStreetName} #{BuildingNumberFormat}" };
            }
        }

        public override bool HasFullStreetAddress
        {
            get
            {
                return false;
            }
        }
        #endregion

        #region Company
        public override string[] CompanySuffix
        {
            get
            {
                return new[] {
                                "NV",
                                "BVBA",
                                "BV",
                                "CV",
                };
            }
        }

        public override string[] CompanyNameFormat
        {
            get
            {
                return new[] {
                                "#{Name.GetLastName} #{CompanySuffix}",
                                "#{Name.GetLastName}-#{Name.GetLastName}",
                                "#{Name.GetLastName}, #{Name.GetLastName} und #{Name.GetLastName}"
                };
            }
        }
        #endregion

        #region Internet
        public override string[] DomainSuffix
        {
            get
            {
                return new[] {
                                "com",
                                "info",
                                "name",
                                "net",
                                "org",
                                "be",
                };
            }
        }
        #endregion

        #region Lorem
        public override string[] LoremWord
        {
            get
            {
                return new[] {
                                "alias",
                                "consequatur",
                                "aut",
                                "perferendis",
                                "sit",
                                "voluptatem",
                                "accusantium",
                                "doloremque",
                                "aperiam",
                                "eaque",
                                "ipsa",
                                "quae",
                                "ab",
                                "illo",
                                "inventore",
                                "veritatis",
                                "et",
                                "quasi",
                                "architecto",
                                "beatae",
                                "vitae",
                                "dicta",
                                "sunt",
                                "explicabo",
                                "aspernatur",
                                "aut",
                                "odit",
                                "aut",
                                "fugit",
                                "sed",
                                "quia",
                                "consequuntur",
                                "magni",
                                "dolores",
                                "eos",
                                "qui",
                                "ratione",
                                "voluptatem",
                                "sequi",
                                "nesciunt",
                                "neque",
                                "dolorem",
                                "ipsum",
                                "quia",
                                "dolor",
                                "sit",
                                "amet",
                                "consectetur",
                                "adipisci",
                                "velit",
                                "sed",
                                "quia",
                                "non",
                                "numquam",
                                "eius",
                                "modi",
                                "tempora",
                                "incidunt",
                                "ut",
                                "labore",
                                "et",
                                "dolore",
                                "magnam",
                                "aliquam",
                                "quaerat",
                                "voluptatem",
                                "ut",
                                "enim",
                                "ad",
                                "minima",
                                "veniam",
                                "quis",
                                "nostrum",
                                "exercitationem",
                                "ullam",
                                "corporis",
                                "nemo",
                                "enim",
                                "ipsam",
                                "voluptatem",
                                "quia",
                                "voluptas",
                                "sit",
                                "suscipit",
                                "laboriosam",
                                "nisi",
                                "ut",
                                "aliquid",
                                "ex",
                                "ea",
                                "commodi",
                                "consequatur",
                                "quis",
                                "autem",
                                "vel",
                                "eum",
                                "iure",
                                "reprehenderit",
                                "qui",
                                "in",
                                "ea",
                                "voluptate",
                                "velit",
                                "esse",
                                "quam",
                                "nihil",
                                "molestiae",
                                "et",
                                "iusto",
                                "odio",
                                "dignissimos",
                                "ducimus",
                                "qui",
                                "blanditiis",
                                "praesentium",
                                "laudantium",
                                "totam",
                                "rem",
                                "voluptatum",
                                "deleniti",
                                "atque",
                                "corrupti",
                                "quos",
                                "dolores",
                                "et",
                                "quas",
                                "molestias",
                                "excepturi",
                                "sint",
                                "occaecati",
                                "cupiditate",
                                "non",
                                "provident",
                                "sed",
                                "ut",
                                "perspiciatis",
                                "unde",
                                "omnis",
                                "iste",
                                "natus",
                                "error",
                                "similique",
                                "sunt",
                                "in",
                                "culpa",
                                "qui",
                                "officia",
                                "deserunt",
                                "mollitia",
                                "animi",
                                "id",
                                "est",
                                "laborum",
                                "et",
                                "dolorum",
                                "fuga",
                                "et",
                                "harum",
                                "quidem",
                                "rerum",
                                "facilis",
                                "est",
                                "et",
                                "expedita",
                                "distinctio",
                                "nam",
                                "libero",
                                "tempore",
                                "cum",
                                "soluta",
                                "nobis",
                                "est",
                                "eligendi",
                                "optio",
                                "cumque",
                                "nihil",
                                "impedit",
                                "quo",
                                "porro",
                                "quisquam",
                                "est",
                                "qui",
                                "minus",
                                "id",
                                "quod",
                                "maxime",
                                "placeat",
                                "facere",
                                "possimus",
                                "omnis",
                                "voluptas",
                                "assumenda",
                                "est",
                                "omnis",
                                "dolor",
                                "repellendus",
                                "temporibus",
                                "autem",
                                "quibusdam",
                                "et",
                                "aut",
                                "consequatur",
                                "vel",
                                "illum",
                                "qui",
                                "dolorem",
                                "eum",
                                "fugiat",
                                "quo",
                                "voluptas",
                                "nulla",
                                "pariatur",
                                "at",
                                "vero",
                                "eos",
                                "et",
                                "accusamus",
                                "officiis",
                                "debitis",
                                "aut",
                                "rerum",
                                "necessitatibus",
                                "saepe",
                                "eveniet",
                                "ut",
                                "et",
                                "voluptates",
                                "repudiandae",
                                "sint",
                                "et",
                                "molestiae",
                                "non",
                                "recusandae",
                                "itaque",
                                "earum",
                                "rerum",
                                "hic",
                                "tenetur",
                                "a",
                                "sapiente",
                                "delectus",
                                "ut",
                                "aut",
                                "reiciendis",
                                "voluptatibus",
                                "maiores",
                                "doloribus",
                                "asperiores",
                                "repellat"
                };
            }
        }
        #endregion

        #region Name
        public override string[] FirstName
        {
            get
            {
                return new[] {
                    "Jan", "Sanne", "Bram", "Anne", "Pieter", "Emma", "Daan", "Lotte",
                    "Niels", "Sofie", "Jasper", "Lies", "Thomas", "Eva", "Lucas", "Lisa",
                    "Koen", "Fleur", "Ruben", "Julie", "Jelle", "Laura", "Stijn", "Sara",
                    "Sven", "Anouk", "Lars", "Maud", "Thijs", "Nina", "Dennis", "Lynn",
                    "Wouter", "Eline", "Jeroen", "Iris", "Tim", "Britt", "Tom", "Rosa",
                    "Bart", "Silke", "Kevin", "Anke", "Maarten", "Ellen", "Joost", "Marie",
                    "Robin", "Noa", "Milan", "Hanne", "Jens", "Elise", "Timo", "Amber",
                    "Jordy", "Charlotte", "Vincent", "Femke", "Levi", "Merel", "Rik", "Tess",
                    "Michiel", "Naomi", "Frank", "Lara", "Kasper", "Mila", "Mark", "Roos",
                    "Max", "Lise", "Pim", "Fenna", "Willem", "Julia", "Matthijs", "Lieke",
                    "Dirk", "Lena", "Arne", "Nele", "Rick", "Hannah", "Remco", "Yasmine",
                    "Stefan", "Esmee", "Bas", "Loes", "Dylan", "Kim", "Guido", "Faye",
                    "Floris", "Senna", "Gert", "Bo", "Martijn", "Ella", "Wesley", "Nora",
                    "Hans", "Elisa", "Bjorn", "Mia", "Chris", "Sterre", "Job", "Sofia",
                    "Gijs", "Cato", "Ben", "Feline", "Davy", "Caro", "Edwin", "Vera",
                    "Johan", "Lotte", "Brent", "Linde", "Rens", "Rachel", "Piet", "Zoë",
                    "Niek", "Inge", "Ronald", "Selina", "Teun", "Mara", "Karel", "Claire",
                    "Rob", "Renée", "Erwin", "Lize", "Boris", "Veerle", "Ruud", "Britt",
                    "Oliver", "Chloë", "Stan", "Lore", "Dries", "Puck", "Filip", "Mieke",
                    "Laurens", "Yara", "Alexander", "Demi", "Raf", "Noor", "Benny", "Olivia",
                    "Wim", "Annelies", "Xander", "Astrid", "Joeri", "Jolien", "Diederik", "Lieke"
                };
            }
        }

        public override string[] LastName
        {
            get
            {
                return new[] {
                    "Bakker", "Jansen", "Visser", "Smit", "Meijer", "Bos", "Vos", "Peters",
                    "Hendriks", "Dijkstra", "Smits", "Kuipers", "Willems", "Hoekstra", "Maas",
                    "Verhoeven", "Martens", "Post", "Kuiper", "Vink", "Kramer", "Jacobs",
                    "Gerritsen", "Jonker", "Groen", "Beekman", "Willemsen", "Kok", "Claes",
                    "Verbeek", "Stevens", "Peeters", "Hermans", "Thijs", "Wouters", "Maes",
                    "Lemmens", "Michiels", "Wauters", "Smets", "Claeys", "Jans", "Mertens",
                    "Leys", "Benoot", "Segers", "Cornelis", "Benoot", "Verbruggen", "Prins",
                    "Blom", "Luiken", "Roels", "Brinkman", "Brouwer", "Groeneveld", "Hofman",
                    "Koning", "Kroon", "Molenaar", "Sluis", "Veen", "Wal", "Wit",
                    "Boer", "Groot", "Haan", "Hout", "Jong", "Klein", "Laan", "Meer",
                    "Schaap", "Schouten", "Veen", "Veld", "Ven", "Berg", "Eijk",
                    "Graaf", "Heide", "Hoeve", "Horst", "Kamp", "Lang", "Linden", "Meulen",
                    "Ploeg", "Roos", "Zanden", "Zee", "Zijl", "Dam", "Donk", "Doorn",
                    "Heuvel", "Kant", "Kerk", "Klok", "Ridder", "Steen", "Vliet", "Vries",
                    "Zwaan", "Broek", "Rijn", "Willigen", "Winkel", "Rooij", "Velde",
                    "Bijl", "Blok", "Boon", "Dalen", "Dijk", "Elzen", "Haas", "Heij",
                    "Helden", "Kessel", "Koek", "Kool", "Koster", "Leeuw", "Loos", "Meij",
                    "Moor", "Rooi", "Staal", "Toren", "Voort", "Vosse", "Wolf", "Zand",
                    "Zant"
                };
            }
        }

        public override string[] NamePrefix
        {
            get
            {
                return new[] {
                                "Dhr.",
                                "Mevr.",
                                "Dr.",
                                "Prof."
                };
            }
        }

        public string[] NobilityTitlePrefix
        {
            get
            {
                return new[] {
                                    "van",
                                    "van der",
                                    "van den",
                };
            }
        }

        public override string[] NameFormat
        {
            get
            {
                return new[] {
                                    "{0.8}{FirstName} {LastName}",
                                    "#{NamePrefix} @{Name.GetFirstName} @{Name.GetLastName}",
                                    "@{Name.GetFirstName} #{NobilityTitlePrefix} @{Name.GetLastName}"
                };
            }
        }

        public override string[] PhoneNumberFormat
        {
            get
            {
                return new[] {
                                    "0### ######",
                                    "+32-###-######",
                                    "+32-####-#######"
                };
            }
        }

        #endregion
    }
}
