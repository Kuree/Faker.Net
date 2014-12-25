using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Locales
{
    [LocaleAttribute(Faker.LocaleType.fr)]
    internal class Fr : En
    {
        public override string Title { get { return "French"; } }

        #region Address
        public override string[] BuildingNumberFormat
        {
            get
            {
                return new string[] { 
                                    "####",
                                    "###",
                                    "##",
                                    "#"            
                };
            }
        }

        public string[] StreetPrefix
        {
            get
            {
                return new string[] { 
                                    "Allée, Voie",
                                    "Rue",
                                    "Avenue",
                                    "Boulevard",
                                    "Quai",
                                    "Passage",
                                    "Impasse",
                                    "Place"            
                };
            }
        }

        public override string[] SecondaryStreetNameFormat
        {
            get
            {
                return new string[] { 
                                "Apt. ###",
                                "# étage"         
                };
            }
        }

        public override string[] PostCode
        {
            get
            {
                return new string[] { 
                                    "#####"         
                };
            }
        }

        public override string[] State
        {
            get
            {
                return new string[] { 
                                    "Alsace",
                                    "Aquitaine",
                                    "Auvergne",
                                    "Basse-Normandie",
                                    "Bourgogne",
                                    "Bretagne",
                                    "Centre",
                                    "Champagne-Ardenne",
                                    "Corse",
                                    "Franche-Comté",
                                    "Haute-Normandie",
                                    "Île-de-France",
                                    "Languedoc-Roussillon",
                                    "Limousin",
                                    "Lorraine",
                                    "Midi-Pyrénées",
                                    "Nord-Pas-de-Calais",
                                    "Pays de la Loire",
                                    "Picardie",
                                    "Poitou-Charentes",
                                    "Provence-Alpes-Côte d'Azur",
                                    "Rhône-Alpes"         
                };
            }
        }

        public string[] CityName
        {
            get
            {
                return new string[] { 
                                "Paris",
                                "Marseille",
                                "Lyon",
                                "Toulouse",
                                "Nice",
                                "Nantes",
                                "Strasbourg",
                                "Montpellier",
                                "Bordeaux",
                                "Lille13",
                                "Rennes",
                                "Reims",
                                "Le Havre",
                                "Saint-Étienne",
                                "Toulon",
                                "Grenoble",
                                "Dijon",
                                "Angers",
                                "Saint-Denis",
                                "Villeurbanne",
                                "Le Mans",
                                "Aix-en-Provence",
                                "Brest",
                                "Nîmes",
                                "Limoges",
                                "Clermont-Ferrand",
                                "Tours",
                                "Amiens",
                                "Metz",
                                "Perpignan",
                                "Besançon",
                                "Orléans",
                                "Boulogne-Billancourt",
                                "Mulhouse",
                                "Rouen",
                                "Caen",
                                "Nancy",
                                "Saint-Denis",
                                "Saint-Paul",
                                "Montreuil",
                                "Argenteuil",
                                "Roubaix",
                                "Dunkerque14",
                                "Tourcoing",
                                "Nanterre",
                                "Avignon",
                                "Créteil",
                                "Poitiers",
                                "Fort-de-France",
                                "Courbevoie",
                                "Versailles",
                                "Vitry-sur-Seine",
                                "Colombes",
                                "Pau",
                                "Aulnay-sous-Bois",
                                "Asnières-sur-Seine",
                                "Rueil-Malmaison",
                                "Saint-Pierre",
                                "Antibes",
                                "Saint-Maur-des-Fossés",
                                "Champigny-sur-Marne",
                                "La Rochelle",
                                "Aubervilliers",
                                "Calais",
                                "Cannes",
                                "Le Tampon",
                                "Béziers",
                                "Colmar",
                                "Bourges",
                                "Drancy",
                                "Mérignac",
                                "Saint-Nazaire",
                                "Valence",
                                "Ajaccio",
                                "Issy-les-Moulineaux",
                                "Villeneuve-d'Ascq",
                                "Levallois-Perret",
                                "Noisy-le-Grand",
                                "Quimper",
                                "La Seyne-sur-Mer",
                                "Antony",
                                "Troyes",
                                "Neuilly-sur-Seine",
                                "Sarcelles",
                                "Les Abymes",
                                "Vénissieux",
                                "Clichy",
                                "Lorient",
                                "Pessac",
                                "Ivry-sur-Seine",
                                "Cergy",
                                "Cayenne",
                                "Niort",
                                "Chambéry",
                                "Montauban",
                                "Saint-Quentin",
                                "Villejuif",
                                "Hyères",
                                "Beauvais",
                                "Cholet"           
                };
            }
        }

        public override string[] CityNameFormat
        {
            get
            {
                return new string[] { "#{CityName}" };
            }
        }

        public override string[] StreetSuffix
        {
            get
            {
                return new string[] { 
                                    "de l'Abbaye",
                                    "Adolphe Mille",
                                    "d'Alésia",
                                    "d'Argenteuil",
                                    "d'Assas",
                                    "du Bac",
                                    "de Paris",
                                    "La Boétie",
                                    "Bonaparte",
                                    "de la Bûcherie",
                                    "de Caumartin",
                                    "Charlemagne",
                                    "du Chat-qui-Pêche",
                                    "de la Chaussée-d'Antin",
                                    "du Dahomey",
                                    "Dauphine",
                                    "Delesseux",
                                    "du Faubourg Saint-Honoré",
                                    "du Faubourg-Saint-Denis",
                                    "de la Ferronnerie",
                                    "des Francs-Bourgeois",
                                    "des Grands Augustins",
                                    "de la Harpe",
                                    "du Havre",
                                    "de la Huchette",
                                    "Joubert",
                                    "Laffitte",
                                    "Lepic",
                                    "des Lombards",
                                    "Marcadet",
                                    "Molière",
                                    "Monsieur-le-Prince",
                                    "de Montmorency",
                                    "Montorgueil",
                                    "Mouffetard",
                                    "de Nesle",
                                    "Oberkampf",
                                    "de l'Odéon",
                                    "d'Orsel",
                                    "de la Paix",
                                    "des Panoramas",
                                    "Pastourelle",
                                    "Pierre Charron",
                                    "de la Pompe",
                                    "de Presbourg",
                                    "de Provence",
                                    "de Richelieu",
                                    "de Rivoli",
                                    "des Rosiers",
                                    "Royale",
                                    "d'Abbeville",
                                    "Saint-Honoré",
                                    "Saint-Bernard",
                                    "Saint-Denis",
                                    "Saint-Dominique",
                                    "Saint-Jacques",
                                    "Saint-Séverin",
                                    "des Saussaies",
                                    "de Seine",
                                    "de Solférino",
                                    "Du Sommerard",
                                    "de Tilsitt",
                                    "Vaneau",
                                    "de Vaugirard",
                                    "de la Victoire",
                                    "Zadkine" };
            }
        }

        public override string[] StreetNameFormat
        {
            get
            {
                return new string[] { "#{StreetPrefix} #{StreetSuffix}" };
            }
        }

        public override string[] StreetAddressFormat
        {
            get
            {
                return new string[] { "#{BuildingNumberFormat} #{StreetNameFormat}" };
            }
        }
        #endregion

        #region Company
        public override string[] CompanySuffix
        {
            get
            {
                return new string[] { 
                    "SARL",
                    "SA",
                    "EURL",
                    "SAS",
                    "SEM",
                    "SCOP",
                    "GIE",
                    "EI" };
            }
        }

        public override string[] CompanyAdjective
        {
            get
            {
                return new string[] { 
                                   "Adaptive",
                                  "Advanced",
                                  "Ameliorated",
                                  "Assimilated",
                                  "Automated",
                                  "Balanced",
                                  "Business-focused",
                                  "Centralized",
                                  "Cloned",
                                  "Compatible",
                                  "Configurable",
                                  "Cross-group",
                                  "Cross-platform",
                                  "Customer-focused",
                                  "Customizable",
                                  "Decentralized",
                                  "De-engineered",
                                  "Devolved",
                                  "Digitized",
                                  "Distributed",
                                  "Diverse",
                                  "Down-sized",
                                  "Enhanced",
                                  "Enterprise-wide",
                                  "Ergonomic",
                                  "Exclusive",
                                  "Expanded",
                                  "Extended",
                                  "Face to face",
                                  "Focused",
                                  "Front-line",
                                  "Fully-configurable",
                                  "Function-based",
                                  "Fundamental",
                                  "Future-proofed",
                                  "Grass-roots",
                                  "Horizontal",
                                  "Implemented",
                                  "Innovative",
                                  "Integrated",
                                  "Intuitive",
                                  "Inverse",
                                  "Managed",
                                  "Mandatory",
                                  "Monitored",
                                  "Multi-channelled",
                                  "Multi-lateral",
                                  "Multi-layered",
                                  "Multi-tiered",
                                  "Networked",
                                  "Object-based",
                                  "Open-architected",
                                  "Open-source",
                                  "Operative",
                                  "Optimized",
                                  "Optional",
                                  "Organic",
                                  "Organized",
                                  "Persevering",
                                  "Persistent",
                                  "Phased",
                                  "Polarised",
                                  "Pre-emptive",
                                  "Proactive",
                                  "Profit-focused",
                                  "Profound",
                                  "Programmable",
                                  "Progressive",
                                  "Public-key",
                                  "Quality-focused",
                                  "Reactive",
                                  "Realigned",
                                  "Re-contextualized",
                                  "Re-engineered",
                                  "Reduced",
                                  "Reverse-engineered",
                                  "Right-sized",
                                  "Robust",
                                  "Seamless",
                                  "Secured",
                                  "Self-enabling",
                                  "Sharable",
                                  "Stand-alone",
                                  "Streamlined",
                                  "Switchable",
                                  "Synchronised",
                                  "Synergistic",
                                  "Synergized",
                                  "Team-oriented",
                                  "Total",
                                  "Triple-buffered",
                                  "Universal",
                                  "Up-sized",
                                  "Upgradable",
                                  "User-centric",
                                  "User-friendly",
                                  "Versatile",
                                  "Virtual",
                                  "Visionary",
                                  "Vision-oriented"      
                };
            }
        }

        public override string[] CompanyDescriptor
        {
            get
            {
                return new string[] { 
                                   "24 hour",
                                  "24/7",
                                  "3rd generation",
                                  "4th generation",
                                  "5th generation",
                                  "6th generation",
                                  "actuating",
                                  "analyzing",
                                  "asymmetric",
                                  "asynchronous",
                                  "attitude-oriented",
                                  "background",
                                  "bandwidth-monitored",
                                  "bi-directional",
                                  "bifurcated",
                                  "bottom-line",
                                  "clear-thinking",
                                  "client-driven",
                                  "client-server",
                                  "coherent",
                                  "cohesive",
                                  "composite",
                                  "context-sensitive",
                                  "contextually-based",
                                  "content-based",
                                  "dedicated",
                                  "demand-driven",
                                  "didactic",
                                  "directional",
                                  "discrete",
                                  "disintermediate",
                                  "dynamic",
                                  "eco-centric",
                                  "empowering",
                                  "encompassing",
                                  "even-keeled",
                                  "executive",
                                  "explicit",
                                  "exuding",
                                  "fault-tolerant",
                                  "foreground",
                                  "fresh-thinking",
                                  "full-range",
                                  "global",
                                  "grid-enabled",
                                  "heuristic",
                                  "high-level",
                                  "holistic",
                                  "homogeneous",
                                  "human-resource",
                                  "hybrid",
                                  "impactful",
                                  "incremental",
                                  "intangible",
                                  "interactive",
                                  "intermediate",
                                  "leading edge",
                                  "local",
                                  "logistical",
                                  "maximized",
                                  "methodical",
                                  "mission-critical",
                                  "mobile",
                                  "modular",
                                  "motivating",
                                  "multimedia",
                                  "multi-state",
                                  "multi-tasking",
                                  "national",
                                  "needs-based",
                                  "neutral",
                                  "next generation",
                                  "non-volatile",
                                  "object-oriented",
                                  "optimal",
                                  "optimizing",
                                  "radical",
                                  "real-time",
                                  "reciprocal",
                                  "regional",
                                  "responsive",
                                  "scalable",
                                  "secondary",
                                  "solution-oriented",
                                  "stable",
                                  "static",
                                  "systematic",
                                  "systemic",
                                  "system-worthy",
                                  "tangible",
                                  "tertiary",
                                  "transitional",
                                  "uniform",
                                  "upward-trending",
                                  "user-facing",
                                  "value-added",
                                  "web-enabled",
                                  "well-modulated",
                                  "zero administration",
                                  "zero defect",
                                  "zero tolerance"       
                };
            }
        }

        public override string[] CompanyNoun
        {
            get
            {
                return new string[] { 
                                    "ability",
                                  "access",
                                  "adapter",
                                  "algorithm",
                                  "alliance",
                                  "analyzer",
                                  "application",
                                  "approach",
                                  "architecture",
                                  "archive",
                                  "artificial intelligence",
                                  "array",
                                  "attitude",
                                  "benchmark",
                                  "budgetary management",
                                  "capability",
                                  "capacity",
                                  "challenge",
                                  "circuit",
                                  "collaboration",
                                  "complexity",
                                  "concept",
                                  "conglomeration",
                                  "contingency",
                                  "core",
                                  "customer loyalty",
                                  "database",
                                  "data-warehouse",
                                  "definition",
                                  "emulation",
                                  "encoding",
                                  "encryption",
                                  "extranet",
                                  "firmware",
                                  "flexibility",
                                  "focus group",
                                  "forecast",
                                  "frame",
                                  "framework",
                                  "function",
                                  "functionalities",
                                  "Graphic Interface",
                                  "groupware",
                                  "Graphical User Interface",
                                  "hardware",
                                  "help-desk",
                                  "hierarchy",
                                  "hub",
                                  "implementation",
                                  "info-mediaries",
                                  "infrastructure",
                                  "initiative",
                                  "installation",
                                  "instruction set",
                                  "interface",
                                  "internet solution",
                                  "intranet",
                                  "knowledge user",
                                  "knowledge base",
                                  "local area network",
                                  "leverage",
                                  "matrices",
                                  "matrix",
                                  "methodology",
                                  "middleware",
                                  "migration",
                                  "model",
                                  "moderator",
                                  "monitoring",
                                  "moratorium",
                                  "neural-net",
                                  "open architecture",
                                  "open system",
                                  "orchestration",
                                  "paradigm",
                                  "parallelism",
                                  "policy",
                                  "portal",
                                  "pricing structure",
                                  "process improvement",
                                  "product",
                                  "productivity",
                                  "project",
                                  "projection",
                                  "protocol",
                                  "secured line",
                                  "service-desk",
                                  "software",
                                  "solution",
                                  "standardization",
                                  "strategy",
                                  "structure",
                                  "success",
                                  "superstructure",
                                  "support",
                                  "synergy",
                                  "system engine",
                                  "task-force",
                                  "throughput",
                                  "time-frame",
                                  "toolset",
                                  "utilisation",
                                  "website",
                                  "workforce"       
                };
            }
        }

        public override string[] CompanyNameFormat
        {
            get
            {
                return new string[] { 
                                   "@{Name.GetLastName} #{CompanySuffix}",
                                   "@{Name.GetLastName} et @{Name.GetLastName}"      
                };
            }
        }
        #endregion

        #region Internet
        public override string[] FreeEmailDomain
        {
            get
            {
                return new string[] { 
                                   "gmail.com",
                                    "yahoo.fr",
                                    "hotmail.fr"     
                };
            }
        }

        public override string[] DomainSuffix
        {
            get
            {
                return new string[] { 
                                       "com",
                                        "fr",
                                        "eu",
                                        "info",
                                        "name",
                                        "net",
                                        "org"       
                };
            }
        }
        #endregion

        #region Name
        public override string[] FirstName
        {
            get
            {
                return new string[] { 
                                "Enzo",
                                "Lucas",
                                "Mathis",
                                "Nathan",
                                "Thomas",
                                "Hugo",
                                "Théo",
                                "Tom",
                                "Louis",
                                "Raphaël",
                                "Clément",
                                "Léo",
                                "Mathéo",
                                "Maxime",
                                "Alexandre",
                                "Antoine",
                                "Yanis",
                                "Paul",
                                "Baptiste",
                                "Alexis",
                                "Gabriel",
                                "Arthur",
                                "Jules",
                                "Ethan",
                                "Noah",
                                "Quentin",
                                "Axel",
                                "Evan",
                                "Mattéo",
                                "Romain",
                                "Valentin",
                                "Maxence",
                                "Noa",
                                "Adam",
                                "Nicolas",
                                "Julien",
                                "Mael",
                                "Pierre",
                                "Rayan",
                                "Victor",
                                "Mohamed",
                                "Adrien",
                                "Kylian",
                                "Sacha",
                                "Benjamin",
                                "Léa",
                                "Clara",
                                "Manon",
                                "Chloé",
                                "Camille",
                                "Ines",
                                "Sarah",
                                "Jade",
                                "Lola",
                                "Anaïs",
                                "Lucie",
                                "Océane",
                                "Lilou",
                                "Marie",
                                "Eva",
                                "Romane",
                                "Lisa",
                                "Zoe",
                                "Julie",
                                "Mathilde",
                                "Louise",
                                "Juliette",
                                "Clémence",
                                "Célia",
                                "Laura",
                                "Lena",
                                "Maëlys",
                                "Charlotte",
                                "Ambre",
                                "Maeva",
                                "Pauline",
                                "Lina",
                                "Jeanne",
                                "Lou",
                                "Noémie",
                                "Justine",
                                "Louna",
                                "Elisa",
                                "Alice",
                                "Emilie",
                                "Carla",
                                "Maëlle",
                                "Alicia",
                                "Mélissa"
                };
            }
        }

        public override string[] LastName
        {
            get
            {
                return new string[] { 
                                "Martin",
                                "Bernard",
                                "Dubois",
                                "Thomas",
                                "Robert",
                                "Richard",
                                "Petit",
                                "Durand",
                                "Leroy",
                                "Moreau",
                                "Simon",
                                "Laurent",
                                "Lefebvre",
                                "Michel",
                                "Garcia",
                                "David",
                                "Bertrand",
                                "Roux",
                                "Vincent",
                                "Fournier",
                                "Morel",
                                "Girard",
                                "Andre",
                                "Lefevre",
                                "Mercier",
                                "Dupont",
                                "Lambert",
                                "Bonnet",
                                "Francois",
                                "Martinez",
                                "Legrand",
                                "Garnier",
                                "Faure",
                                "Rousseau",
                                "Blanc",
                                "Guerin",
                                "Muller",
                                "Henry",
                                "Roussel",
                                "Nicolas",
                                "Perrin",
                                "Morin",
                                "Mathieu",
                                "Clement",
                                "Gauthier",
                                "Dumont",
                                "Lopez",
                                "Fontaine",
                                "Chevalier",
                                "Robin",
                                "Masson",
                                "Sanchez",
                                "Gerard",
                                "Nguyen",
                                "Boyer",
                                "Denis",
                                "Lemaire",
                                "Duval",
                                "Joly",
                                "Gautier",
                                "Roger",
                                "Roche",
                                "Roy",
                                "Noel",
                                "Meyer",
                                "Lucas",
                                "Meunier",
                                "Jean",
                                "Perez",
                                "Marchand",
                                "Dufour",
                                "Blanchard",
                                "Marie",
                                "Barbier",
                                "Brun",
                                "Dumas",
                                "Brunet",
                                "Schmitt",
                                "Leroux",
                                "Colin",
                                "Fernandez",
                                "Pierre",
                                "Renard",
                                "Arnaud",
                                "Rolland",
                                "Caron",
                                "Aubert",
                                "Giraud",
                                "Leclerc",
                                "Vidal",
                                "Bourgeois",
                                "Renaud",
                                "Lemoine",
                                "Picard",
                                "Gaillard",
                                "Philippe",
                                "Leclercq",
                                "Lacroix",
                                "Fabre",
                                "Dupuis",
                                "Olivier",
                                "Rodriguez",
                                "Da silva",
                                "Hubert",
                                "Louis",
                                "Charles",
                                "Guillot",
                                "Riviere",
                                "Le gall",
                                "Guillaume",
                                "Adam",
                                "Rey",
                                "Moulin",
                                "Gonzalez",
                                "Berger",
                                "Lecomte",
                                "Menard",
                                "Fleury",
                                "Deschamps",
                                "Carpentier",
                                "Julien",
                                "Benoit",
                                "Paris",
                                "Maillard",
                                "Marchal",
                                "Aubry",
                                "Vasseur",
                                "Le roux",
                                "Renault",
                                "Jacquet",
                                "Collet",
                                "Prevost",
                                "Poirier",
                                "Charpentier",
                                "Royer",
                                "Huet",
                                "Baron",
                                "Dupuy",
                                "Pons",
                                "Paul",
                                "Laine",
                                "Carre",
                                "Breton",
                                "Remy",
                                "Schneider",
                                "Perrot",
                                "Guyot",
                                "Barre",
                                "Marty",
                                "Cousin"
                };
            }
        }

        public override string[] NamePrefix
        {
            get
            {
                return new string[] { 
                                    "M",
                                    "Mme",
                                    "Mlle",
                                    "Dr",
                                    "Prof"
                };
            }
        }

        public override string[] NameFormat
        {
            get
            {
                return new string[] { 
                                    "{0.8}{FirstName} {LastName}",
                                    "#{NamePrefix} {FirstName} {LastName}",                                    
                };  
            }
        }
        #endregion

        #region Phone Number
        public override string[] PhoneNumberFormat
        {
            get
            {
                return new string[] { 
                                    "01########",
                                    "02########",
                                    "03########",
                                    "04########",
                                    "05########",
                                    "06########",
                                    "07########",
                                    "+33 1########",
                                    "+33 2########",
                                    "+33 3########",
                                    "+33 4########",
                                    "+33 5########",
                                    "+33 6########",
                                    "+33 7########"
                };
            }
        }
        #endregion

    }
}
