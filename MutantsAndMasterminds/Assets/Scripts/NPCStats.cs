using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCStats : MonoBehaviour
{
    public RandomNumber random;
    public int Strength, Agility, Fighting, Awareness, Stamina, Dexterity, Intellect, Presence;
    public GameObject strength, agility, fighting, awareness, stamina, dexterity, intellect, presence;
    public Text Name, displayname;
    public string[] Archetype, displayArchetype;
    public string[] SubArchetype, displaySubArchetype;
    //public Text Advantage2, displayadvantage2;
    public GameObject StatDisplay;
    
    public Button Drink, Bribe, Promote, Rumour, Share, Execute;
    public GameObject self;
    private string[] names = new string[] { "Albert", "Bogdan", "Dmitry", "Eduard", "Fedir", "German", "Igor", "Julij", "Konstantin", "Lavrentii", "Maxim", "Naum", "Osip", "Peter", "Roman", "Tit", "Vlad", "Yuri", "Vyacheslav", "Goga", "Alexei", "Viktor", "Misha", "Innokentiy", "Stefan", "Stanislav", "Foma", "Ruslan", "Taras", "Mitrofan", "Erik", "Spartak", "Modest", "Garry", "Nikita", "Boris", "Dobrushin", "Trofim", "Anton", "Mikhail", "Abram", "Gedeon", "Dorofey", "Savin", "Isodor", "Leonid", "Gleb", "Valentin", "David", "Daniil", "Ippolit", "Kirill", "Lazar", "Filipp", "Marlen", "Nestor", "Robert", "Arkady", "Pasha", "Valeriy", "Rolan", "Makariy", "Yulian", "Gennady", "Sergei", "Fanasiy", "Khan", "Semyon", "Yakov", "Rurik", "Faddei", "Yefim", "Nikolay", "Sasha", "Vladimir", "Alexander", "Stas", "Ipatiy", "Kolmogorov", "Vitaliy", "Vladislav", "Artyom", "Yana", "Olga", "Fedor", "Vasily", "Ivanovich", "Leo", "Pierre", "Anna", "Natasha", "Andrei" };
    private string[] archetypes = new string[] { "Battlesuit", "Construct", "Crime Fighter", "Elemental", "Energy Controller", "Gadgeteer", "Martial Artist", "Mimic", "Mystic", "Paragon", "Powerhouse", "Psychic", "Shapeshifter", "Speedster", "Summoner", "Supernatural", "Totem", "Warrior", "Weapon Master", "Weather Controller" };
    private string[] subArchetypes = new string[] { };
    private string[] lastNames = new string[] { "Isayev", "Tikhonov", "Chapayev", "Petka", "Anka", "Furmanov", "Budyonny", "Caesar", "Rzhevsky", "Tolstoy", "Bezukhov", "Blonsky", "Romanov", "Pavlovna", "Rostova", "Bolkonsky", "Kuragin", "Vidor", "Bondarchuk", "Levi", "Livinov", "Solomin", "Aksyonov", "Kalashnikov", "Gorbachev", "Smirnov", "Chernov", "Putin", "Brezhnev", "Pushkin", "Lipatov", "Khruschev", "Yeltsin", "Medvedev", "Anatolievych", "Vladimirovich" };
    public string GetRandomName()
    {
        return names[Random.Range(0, names.Length)];
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateNPC();
        Debug.Log(GetRandomName());
        
    }
    
    public void CreateNPC()
    {
       
        Name.text = names[Random.Range(0, names.Length)] + " "  + lastNames[Random.Range(0, lastNames.Length)];
        strength = GameObject.FindGameObjectWithTag("strength");
        agility = GameObject.FindGameObjectWithTag("agility");
        fighting = GameObject.FindGameObjectWithTag("fighting");
        awareness = GameObject.FindGameObjectWithTag("awareness");
        stamina = GameObject.FindGameObjectWithTag("stamina");
        dexterity = GameObject.FindGameObjectWithTag("dexterity");
        intellect = GameObject.FindGameObjectWithTag("intellect");
        presence = GameObject.FindGameObjectWithTag("presence");

        for (int i = 0; i < 1; i++)
        {
            Archetype[i] = archetypes[Random.Range(0, archetypes.Length)];
            Debug.Log(archetypes[i]);
            if (Archetype[i] == "Battlesuit")
            {
               subArchetypes = new string[] {"Genius", "Military", "Accidental" };
               SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Genius")
                {
                    Strength = 0;
                    Agility = 1;
                    Fighting = 2;
                    Awareness = 2;
                    Stamina = 1;
                    Dexterity = 2;
                    Intellect = 8;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Military")
                {
                    Strength = 3;
                    Agility = 1;
                    Fighting = 3;
                    Awareness = 2;
                    Stamina = 3;
                    Dexterity = 2;
                    Intellect = 2;
                    Presence = 2;
                }
                else
                {
                    Strength = 2;
                    Agility = 3;
                    Fighting = 2;
                    Awareness = 3;
                    Stamina = 1;
                    Dexterity = 2;
                    Intellect = 3;
                    Presence = 2;
                }
            }
            else if (Archetype[i] == "Construct")
            {
                subArchetypes = new string[] { "Golem", "Technological", "Undead" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Golem")
                {
                    Strength = 8;
                    Agility = 0;
                    Fighting = 6;
                    Awareness = 4;
                    Stamina = 0;
                    Dexterity = 0;
                    Intellect = 0;
                    Presence = 4;
                }
                else if (SubArchetype[i] == "Technological")
                {
                    Strength = 8;
                    Agility = 0;
                    Fighting = 6;
                    Awareness = 1;
                    Stamina = 0;
                    Dexterity = 2;
                    Intellect = 4;
                    Presence = 1;
                }
                else
                {
                    Strength = 6;
                    Agility = 2;
                    Fighting = 6;
                    Awareness = 2;
                    Stamina = 0;
                    Dexterity = 3;
                    Intellect = 1;
                    Presence = 2;
                }
            }
            else if (Archetype[i] == "Crime Fighter")
            {
                subArchetypes = new string[] { "Dark Avenger", "Detective", "Inventor" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Dark Avenger")
                {
                    Strength = 3;
                    Agility = 5;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 4;
                    Dexterity = 5;
                    Intellect = 4;
                    Presence = 3;
                }
                else if (SubArchetype[i] == "Detective")
                {
                    Strength = 3;
                    Agility = 4;
                    Fighting = 8;
                    Awareness = 4;
                    Stamina = 4;
                    Dexterity = 4;
                    Intellect = 5;
                    Presence = 2;
                }
                else
                {
                    Strength = 3;
                    Agility = 5;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 3;
                    Dexterity = 5;
                    Intellect = 7;
                    Presence = 1;
                }
            }
            else if (Archetype[i] == "Elemental")
            {
                subArchetypes = new string[] { "Embodiment", "Transformed" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Embodiment")
                {
                    Strength = 1;
                    Agility = 1;
                    Fighting = 4;
                    Awareness = 3;
                    Stamina = 2;
                    Dexterity = 2;
                    Intellect = 0;
                    Presence = 1;
                }
                else
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 4;
                    Awareness = 2;
                    Stamina = 2;
                    Dexterity = 1;
                    Intellect = 1;
                    Presence = 0;
                }
            }
            else if (Archetype[i] == "EnergyController")
            {
                subArchetypes = new string[] { "Charismatic", "Hotheaded", "Reserved" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Charismatic")
                {
                    Strength = 0;
                    Agility = 3;
                    Fighting = 3;
                    Awareness = 2;
                    Stamina = 3;
                    Dexterity = 3;
                    Intellect = 0;
                    Presence = 3;
                }
                else if (SubArchetype[i] == "Hotheaded")
                {
                    Strength = 1;
                    Agility = 4;
                    Fighting = 3;
                    Awareness = 2;
                    Stamina = 2;
                    Dexterity = 3;
                    Intellect = 0;
                    Presence = 2;
                }
                else
                {
                    Strength = 0;
                    Agility = 4;
                    Fighting = 3;
                    Awareness = 3;
                    Stamina = 2;
                    Dexterity = 3;
                    Intellect = 2;
                    Presence = 2;
                }
            }
            else if (Archetype[i] == "Gadgeteer")
            {
                subArchetypes = new string[] { "Adventurer", "Gimmick", "Scientist" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Adventurer")
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 4;
                    Awareness = 3;
                    Stamina = 2;
                    Dexterity = 2;
                    Intellect = 8;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Gimmick")
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 4;
                    Awareness = 4;
                    Stamina = 1;
                    Dexterity = 2;
                    Intellect = 9;
                    Presence = 1;
                }
                else
                {
                    Strength = 1;
                    Agility = 2;
                    Fighting = 4;
                    Awareness = 4;
                    Stamina = 2;
                    Dexterity = 2;
                    Intellect = 10;
                    Presence = 0;
                }
            }
            else if (Archetype[i] == "Martial Artist")
            {
                subArchetypes = new string[] { "Finesse and Control", "Mystic Endowment", "Strength and Power" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Finesse and Control")
                {
                    Strength = 3;
                    Agility = 7;
                    Fighting = 13;
                    Awareness = 5;
                    Stamina = 3;
                    Dexterity = 5;
                    Intellect = 0;
                    Presence = 0;
                }
                else if (SubArchetype[i] == "Mystic Endowment")
                {
                    Strength = 3;
                    Agility = 5;
                    Fighting = 12;
                    Awareness = 6;
                    Stamina = 3;
                    Dexterity = 5;
                    Intellect = 1;
                    Presence = 1;
                }
                else
                {
                    Strength = 4;
                    Agility = 6;
                    Fighting = 12;
                    Awareness = 4;
                    Stamina = 4;
                    Dexterity = 4;
                    Intellect = 1;
                    Presence = 1;
                }
            }
            else if (Archetype[i] == "Mimic")
            {
                subArchetypes = new string[] { "Blank Slate", "Metamind", "Perfect Weapon" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Blank Slate")
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 2;
                    Awareness = 2;
                    Stamina = 2;
                    Dexterity = 2;
                    Intellect = 2;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Metamind")
                {
                    Strength = 1;
                    Agility = 1;
                    Fighting = 2;
                    Awareness = 1;
                    Stamina = 1;
                    Dexterity = 1;
                    Intellect = 8;
                    Presence = 1;
                }
                else
                {
                    Strength = 1;
                    Agility = 1;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 1;
                    Dexterity = 1;
                    Intellect = 1;
                    Presence = 1;
                }
            }
            else if (Archetype[i] == "Mystic")
            {
                subArchetypes = new string[] { "Host", "Magical Heritage", "Mystic Master" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Host")
                {
                    Strength = 1;
                    Agility = 1;
                    Fighting = 4;
                    Awareness = 5;
                    Stamina = 0;
                    Dexterity = 3;
                    Intellect = 2;
                    Presence = 5;
                }
                else if (SubArchetype[i] == "Magical Heritage")
                {
                    Strength = 0;
                    Agility = 1;
                    Fighting = 4;
                    Awareness = 7;
                    Stamina = 0;
                    Dexterity = 3;
                    Intellect = 2;
                    Presence = 4;
                }
                else
                {
                    Strength = 0;
                    Agility = 1;
                    Fighting = 4;
                    Awareness = 6;
                    Stamina = 0;
                    Dexterity = 3;
                    Intellect = 3;
                    Presence = 4;
                }
            }
            else if (Archetype[i] == "Paragon")
            {
                subArchetypes = new string[] { "Man Of Action", "Superhuman", "Vessel" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Man Of Action")
                {
                    Strength = 6;
                    Agility = 6;
                    Fighting = 6;
                    Awareness = 4;
                    Stamina = 6;
                    Dexterity = 4;
                    Intellect = 3;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Superhuman")
                {
                    Strength = 8;
                    Agility = 4;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 8;
                    Dexterity = 4;
                    Intellect = 1;
                    Presence = 2;
                }
                else
                {
                    Strength = 8;
                    Agility = 4;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 8;
                    Dexterity = 4;
                    Intellect = 0;
                    Presence = 2;
                }
            }
            else if (Archetype[i] == "Powerhouse")
            {
                subArchetypes = new string[] { "Alternate Form", "Innate Power", "Mutate/Mutant" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Alternate Form")
                {
                    Strength = 4;
                    Agility = 1;
                    Fighting = 6;
                    Awareness = 1;
                    Stamina = 4;
                    Dexterity = 0;
                    Intellect = 0;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Innate Power")
                {
                    Strength = 4;
                    Agility = 1;
                    Fighting = 6;
                    Awareness = 1;
                    Stamina = 4;
                    Dexterity = 0;
                    Intellect = 1;
                    Presence = 1;
                }
                else
                {
                    Strength = 4;
                    Agility = 0;
                    Fighting = 6;
                    Awareness = 0;
                    Stamina = 4;
                    Dexterity = 0;
                    Intellect = 2;
                    Presence = 2;
                }
            }
            else if (Archetype[i] == "Psychic")
            {
                subArchetypes = new string[] { "In-Born", "Psychic Warrior", "Wild Talent" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "In-Born")
                {
                    Strength = 0;
                    Agility = 1;
                    Fighting = 0;
                    Awareness = 6;
                    Stamina = 1;
                    Dexterity = 2;
                    Intellect = 4;
                    Presence = 4;
                }
                else if (SubArchetype[i] == "Psychic Warrior")
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 4;
                    Awareness = 4;
                    Stamina = 2;
                    Dexterity = 2;
                    Intellect = 2;
                    Presence = 0;
                }
                else
                {
                    Strength = 1;
                    Agility = 2;
                    Fighting = 1;
                    Awareness = 6;
                    Stamina = 1;
                    Dexterity = 2;
                    Intellect = 3;
                    Presence = 2;
                }
            }
            else if (Archetype[i] == "Shapeshifter")
            {
                subArchetypes = new string[] { "Everyman", "Whiz"};
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Everyman")
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 2;
                    Awareness = 2;
                    Stamina = 2;
                    Dexterity = 2;
                    Intellect = 2;
                    Presence = 2;
                }
              
                else
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 2;
                    Awareness = 1;
                    Stamina = 2;
                    Dexterity = 0;
                    Intellect = 7;
                    Presence = 0;
                }
            }
            else if (Archetype[i] == "Speedster")
            {
                subArchetypes = new string[] { "Vetern", "Yough", "Old-Timer" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Vetern")
                {
                    Strength = 2;
                    Agility = 4;
                    Fighting = 4;
                    Awareness = 2;
                    Stamina = 2;
                    Dexterity = 3;
                    Intellect = 1;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Youth")
                {
                    Strength = 1;
                    Agility = 5;
                    Fighting = 4;
                    Awareness = 2;
                    Stamina = 1;
                    Dexterity = 5;
                    Intellect = 0;
                    Presence = 2;
                }
                else
                {
                    Strength = 1;
                    Agility = 3;
                    Fighting = 5;
                    Awareness = 3;
                    Stamina = 1;
                    Dexterity = 2;
                    Intellect = 2;
                    Presence = 3;
                }
            }
            else if (Archetype[i] == "Summoner")
            {
                subArchetypes = new string[] { "Duplicator", "Summoner" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Duplicator")
                {
                    Strength = 0;
                    Agility = 1;
                    Fighting = 2;
                    Awareness = 2;
                    Stamina = 1;
                    Dexterity = 2;
                    Intellect = 8;
                    Presence = 2;
                }
                
                else
                {
                    Strength = 2;
                    Agility = 2;
                    Fighting = 2;
                    Awareness = 4;
                    Stamina = 4;
                    Dexterity = 2;
                    Intellect = 4;
                    Presence = 4;
                }
            }
            else if (Archetype[i] == "Supernatural Creature")
            {
                subArchetypes = new string[] { "Demon", "Vampire", "Werewolf" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Demon")
                {
                    Strength = 8;
                    Agility = 3;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 7;
                    Dexterity = 1;
                    Intellect = 0;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Vampire")
                {
                    Strength = 6;
                    Agility = 5;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 0;
                    Dexterity = 2;
                    Intellect = 2;
                    Presence = 2;
                }
                else
                {
                    Strength = 7;
                    Agility = 4;
                    Fighting = 9;
                    Awareness = 3;
                    Stamina = 6;
                    Dexterity = 1;
                    Intellect = 0;
                    Presence = 1;
                }
            }
            else if (Archetype[i] == "Totem")
            {
                subArchetypes = new string[] { "Arthopod", "Avian", "Carnivoran", "Pachyderm", "Reptile" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Arthopod")
                {
                    Strength = 8;
                    Agility = 7;
                    Fighting = 6;
                    Awareness = 2;
                    Stamina = 7;
                    Dexterity = 3;
                    Intellect = 1;
                    Presence = 0;
                }
                else if (SubArchetype[i] == "Avian")
                {
                    Strength = 4;
                    Agility = 8;
                    Fighting = 8;
                    Awareness = 4;
                    Stamina = 6;
                    Dexterity = 4;
                    Intellect = 0;
                    Presence = 0;
                }
                else if (SubArchetype[i] == "Carnivoran")
                {
                    Strength = 7;
                    Agility = 5;
                    Fighting = 10;
                    Awareness = 3;
                    Stamina = 6;
                    Dexterity = 2;
                    Intellect = 0;
                    Presence = 1;
                }
                else if (SubArchetype[i] == "Pachyderm")
                {
                    Strength = 12;
                    Agility = 2;
                    Fighting = 5;
                    Awareness = 3;
                    Stamina = 7;
                    Dexterity = 2;
                    Intellect = 0;
                    Presence = 3;
                }
                else
                {
                    Strength = 10;
                    Agility = 4;
                    Fighting = 6;
                    Awareness = 2;
                    Stamina = 8;
                    Dexterity = 3;
                    Intellect = 1;
                    Presence = 0;
                }
            }
            else if (Archetype[i] == "Warrior")
            {
                subArchetypes = new string[] { "Altered Human", "Otherworldly" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Altered Human")
                {
                    Strength = 5;
                    Agility = 6;
                    Fighting = 10;
                    Awareness = 2;
                    Stamina = 6;
                    Dexterity = 6;
                    Intellect = 1;
                    Presence = 1;
                }
                
                else
                {
                    Strength = 7;
                    Agility = 6;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 8;
                    Dexterity = 4;
                    Intellect = 1;
                    Presence = 3;
                }
            }
            else if (Archetype[i] == "Weapon Master")
            {
                subArchetypes = new string[] { "Enhanced", "Natural", "Self-Made" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Enhanced")
                {
                    Strength = 8;
                    Agility = 3;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 7;
                    Dexterity = 1;
                    Intellect = 0;
                    Presence = 2;
                }
                else if (SubArchetype[i] == "Natural")
                {
                    Strength = 6;
                    Agility = 5;
                    Fighting = 8;
                    Awareness = 2;
                    Stamina = 0;
                    Dexterity = 2;
                    Intellect = 2;
                    Presence = 2;
                }
                else
                {
                    Strength = 7;
                    Agility = 4;
                    Fighting = 9;
                    Awareness = 3;
                    Stamina = 6;
                    Dexterity = 1;
                    Intellect = 0;
                    Presence = 1;
                }
            }
            else if (Archetype[i] == "Weather Controller")
            {
                Hostility -= 20;
            }
            else
            {

            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayStats(bool Display)
    {
        if (Display == true)
        {
            StatDisplay.SetActive(true);
            
            charisma.GetComponent<Slider>().value = Charisma;
            tenacity.GetComponent<Slider>().value = Tenacity;
            greed.GetComponent<Slider>().value = Greed;
            cunning.GetComponent<Slider>().value = Cunning;
            intuition.GetComponent<Slider>().value = Intuition;
            hostility.GetComponent<Slider>().value = Hostility;
            displayname.text = Name.text;
            //displayadvantage.text = Advantage.text;
            //displayadvantage1.text = Advantage1.text;
            //displayadvantage2.text = Advantage2.text;
        }
        if (Display == false)
        {
            StatDisplay.SetActive(false);
            
            
        }
    }
    
}
