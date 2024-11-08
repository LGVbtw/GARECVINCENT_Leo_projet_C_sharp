// Sup2Ciné , nouvel acteur dans la diffusion de film au cinéma vous contacte pour des besoins IT surces 3 premiers cinemas (Paris, Bordeaux, Nice)
// Connaitre les prochaines seances d’un film sur les differents cinema. Certains séances seront réservés aux membres VIP

// Importation de la bibliothèque Newtonsoft.Json.Linq pour manipuler des objets JSON
using Newtonsoft.Json.Linq;

// Création des objets JSON contenant les horaires des films pour les cinémas de Paris, Bordeaux et Nice
JObject horairesfilmsParis = new JObject(
    new JProperty("Joker : Folie à Deux", "11h30", "16h30", "21h30"),
    new JProperty("MotherLand", "17h45"),
    new JProperty("Speak No Evil", "11h30", "16h30", "22h30"),
    new JProperty("Beetlejuice  Beetlejuice", "10h40", "13h00", "15h30"),
    new JProperty("Deadpool & Wolverine", "13h50"),
    new JProperty("Moi, Moche et Méchant 4", "13h40", "16h20"),
    new JProperty("Vice-Versa 2", "10h45", "13h40"),
    new JProperty("Conjuring : Les dossiers Warren", "17h45", "21h40"));

JObject horairesfilmsBordeaux = new JObject(
    new JProperty("Joker : Folie à Deux", "11h30", "16h30", "21h30"),
    new JProperty("MotherLand", "17h45"),
    new JProperty("Deadpool & Wolverine", "13h50"),
    new JProperty("Vice-Versa 2", "10h45", "13h40"),
    new JProperty("Conjuring : Les dossiers Warren", "17h45", "21h40"));

JObject horairesfilmsNice = new JObject(
    new JProperty("Joker : Folie à Deux", "11h30", "16h30", "21h30"),
    new JProperty("Beetlejuice  Beetlejuice", "10h40", "13h00", "15h30"),
    new JProperty("Deadpool & Wolverine", "13h50"),
    new JProperty("Moi, Moche et Méchant 4", "13h40", "16h20"),
    new JProperty("Vice-Versa 2", "10h45", "13h40"),
    new JProperty("Conjuring : Les dossiers Warren", "17h45", "21h40"));

// Création des objets JSON contenant les horaires des films pour les cinémas VIP de Paris, Bordeaux et Nice
JObject horairesfilmsParisVIP = new JObject(
    new JProperty("Joker : Folie à Deux", "9h10", "11h30", "14h00", "16h30", "19h00", "21h30"),
    new JProperty("MotherLand", "17h45", "19h15", "21h40"),
    new JProperty("Speak No Evil", "11h30", "14h00", "16h30", "22h30"),
    new JProperty("Beetlejuice  Beetlejuice", "10h40", "13h00", "15h30", "18h00", "20h30"),
    new JProperty("Deadpool & Wolverine", "13h50", "16h30"),
    new JProperty("Moi, Moche et Méchant 4", "10h50", "13h40", "16h20"),
    new JProperty("Vice-Versa 2", "10h45", "13h40", "15h40"),
    new JProperty("Conjuring : Les dossiers Warren", "17h45", "19h15", "21h40"));

JObject horairesfilmsBordeauxVIP = new JObject(
    new JProperty("Joker : Folie à Deux", "9h10", "11h30", "14h00", "16h30", "19h00", "21h30"),
    new JProperty("MotherLand", "17h45", "19h15", "21h40"),
    new JProperty("Deadpool & Wolverine", "13h50", "16h30"),
    new JProperty("Vice-Versa 2", "10h45", "13h40", "15h40"),
    new JProperty("Conjuring : Les dossiers Warren", "17h45", "19h15", "21h40"));

JObject horairesfilmsNiceVIP = new JObject(
    new JProperty("Joker : Folie à Deux", "9h10", "11h30", "14h00", "16h30", "19h00", "21h30"),
    new JProperty("Beetlejuice  Beetlejuice", "10h40", "13h00", "15h30", "18h00", "20h30"),
    new JProperty("Deadpool & Wolverine", "13h50", "16h30"),
    new JProperty("Moi, Moche et Méchant 4", "10h50", "13h40", "16h20"),
    new JProperty("Vice-Versa 2", "10h45", "13h40", "15h40"),
    new JProperty("Conjuring : Les dossiers Warren", "17h45", "19h15", "21h40"));

// Écriture des objets JSON dans des fichiers
File.WriteAllText(@"C:\Users\LeoGARECVINCENT\OneDrive - SUP DE VINCI\Cours SDV\B2\C#\ProjetFinal\horairesfilmsParis.json", horairesfilmsParis.ToString());
File.WriteAllText(@"C:\Users\LeoGARECVINCENT\OneDrive - SUP DE VINCI\Cours SDV\B2\C#\ProjetFinal\horairesfilmsBordeaux.json", horairesfilmsBordeaux.ToString());
File.WriteAllText(@"C:\Users\LeoGARECVINCENT\OneDrive - SUP DE VINCI\Cours SDV\B2\C#\ProjetFinal\horairesfilmsNice.json", horairesfilmsNice.ToString());
File.WriteAllText(@"C:\Users\LeoGARECVINCENT\OneDrive - SUP DE VINCI\Cours SDV\B2\C#\ProjetFinal\horairesfilmsParisVIP.json", horairesfilmsParisVIP.ToString());
File.WriteAllText(@"C:\Users\LeoGARECVINCENT\OneDrive - SUP DE VINCI\Cours SDV\B2\C#\ProjetFinal\horairesfilmsBordeauxVIP.json", horairesfilmsBordeauxVIP.ToString());
File.WriteAllText(@"C:\Users\LeoGARECVINCENT\OneDrive - SUP DE VINCI\Cours SDV\B2\C#\ProjetFinal\horairesfilmsNiceVIP.json", horairesfilmsNiceVIP.ToString());

// Récupération de la date actuelle et de la date de demain
DateTime aujourdhui = DateTime.Now;
DateTime demain = aujourdhui.AddDays(1);

string motDePasse = "P@$$w0rd";

// Affichage du menu principal
Console.WriteLine("┏━━━━━━━━━━━━━━━┛ Bienvenue au Sup2Ciné ┗━━━━━━━━━━━━━━━┓");
Console.WriteLine("┃                                                       ┃");
Console.WriteLine("┃            3 cinémas dans toute la France             ┃");
Console.WriteLine("┃                        Paris                          ┃");
Console.WriteLine("┃                       Bordeaux                        ┃");
Console.WriteLine("┃                         Nice                          ┃");
Console.WriteLine("┃     Êtes-vous prets a plonger au coeur du cinéma ?    ┃");
Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
Console.WriteLine("Veuillez choisir le nom de votre cinéma :");
Console.WriteLine("⚠️  Si vous entrez un autre numéro, cela stopera votre session ! ⚠️");
Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━ 1. Paris ━━━━━━━━━━━━━━━━━━━━━━━");
Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━ 2. Bordeaux ━━━━━━━━━━━━━━━━━━━━━");
Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━ 3. Nice ━━━━━━━━━━━━━━━━━━━━━━━━");

// Lecture du choix de l'utilisateur
int choix = int.Parse(Console.ReadLine());

// Exécution de l'action en fonction du choix de l'utilisateur
switch (choix)
{
    case 1:
        AfficherHoraires("Paris", horairesfilmsParis, horairesfilmsParisVIP);
        break;
    case 2:
        AfficherHoraires("Bordeaux", horairesfilmsBordeaux, horairesfilmsBordeauxVIP);
        break;
    case 3:
        AfficherHoraires("Nice", horairesfilmsNice, horairesfilmsNiceVIP);
        break;
    default:
        Console.WriteLine("Vous avez choisi de quitter le programme");
        break;
}

// Fonction pour afficher les horaires des films
void AfficherHoraires(string ville, JObject horairesNormaux, JObject horairesVIP)
{
    // Affiche le cinéma choisi par l'utilisateur
    Console.WriteLine($"Vous avez choisi le cinéma de {ville}");
    Console.WriteLine("        Veuillez choisir le film de votre choix :");     // Demande à l'utilisateur de choisir un film
    var films = horairesNormaux.Properties().Select(p => p.Name).ToList();     // Récupère la liste des films disponibles dans les horaires normaux
    for (int i = 0; i < films.Count; i++)      // Affiche la liste des films avec un numéro
    {
        Console.WriteLine($"━━━━━━━━━━━━━━━ {i + 1}. {films[i]} ");
    }
    int filmChoisi = int.Parse(Console.ReadLine());
    Console.WriteLine("💎 💎 Avez-vous un abonnement VIP ? (Oui/Non) 💎 💎");  
    string vip = Console.ReadLine().ToUpper();
    JObject horaires = horairesNormaux;     // Par défaut, utilise les horaires normaux

    if (vip == "OUI")
    {
        Console.WriteLine("Veuillez entrer le mot de passe VIP :");
        string motDePasseEntree = Console.ReadLine();
        if (motDePasseEntree == motDePasse)         // Si le mot de passe est correct, utilise les horaires VIP
        {
            horaires = horairesVIP;
        }
        else         // Sinon, affiche un message d'erreur et continue avec les horaires normaux
        {
            Console.WriteLine("Mot de passe incorrect. Affichage des horaires normaux.");
        }
    }
    string film = films[filmChoisi - 1];     // Récupère le nom du film choisi
    Console.WriteLine($"人人人人人人 Les horaires pour demain ({demain:dd/MM/yyyy}) sont :");     // Affiche les horaires pour le film choisi pour demain
    Console.WriteLine(horaires.GetValue(film));     // Affiche les horaires du film
}
