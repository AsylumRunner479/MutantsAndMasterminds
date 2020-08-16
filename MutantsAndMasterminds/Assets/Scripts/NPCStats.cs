using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCStats : MonoBehaviour
{
    public RandomNumber random;
    public int Strength, Agility, Fighting, Awareness, Stamina, Dexterity, Intellect, Presence;
    public int Dodge, Fortitude, Parry, Toughness, Will, Initiative;
    public GameObject strength, agility, fighting, awareness, stamina, dexterity, intellect, presence;
    public GameObject dodge, fortitude, parry, toughness, will, initiative;
    public Text Name, displayname, background0, background1;
    public string[] Archetype, displayArchetype;
    public string[] SubArchetype, displaySubArchetype;
    public Text Background, displayBackground, displayBackground2;
    public GameObject StatDisplay, NameList;
    public Text advantage0, advantage1, advantage2, advantage3;
    private string string1, string0, string2, string3, string4, string5;
    private string[] adv0, adv1, adv2, adv3;
    private string Adv0, Adv1, Adv2, Adv3;
    public static List<Item> inv = new List<Item>();
    public LinearInventory powers;
    public GameObject self;
    private string[] names = new string[] { "Albert", "Bogdan", "Dmitry", "Eduard", "Fedir", "German", "Igor", "Julij", "Konstantin", "Lavrentii", "Maxim", "Naum", "Osip", "Peter", "Roman", "Tit", "Vlad", "Yuri", "Vyacheslav", "Goga", "Alexei", "Viktor", "Misha", "Innokentiy", "Stefan", "Stanislav", "Foma", "Ruslan", "Taras", "Mitrofan", "Erik", "Spartak", "Modest", "Garry", "Nikita", "Boris", "Dobrushin", "Trofim", "Anton", "Mikhail", "Abram", "Gedeon", "Dorofey", "Savin", "Isodor", "Leonid", "Gleb", "Valentin", "David", "Daniil", "Ippolit", "Kirill", "Lazar", "Filipp", "Marlen", "Nestor", "Robert", "Arkady", "Pasha", "Valeriy", "Rolan", "Makariy", "Yulian", "Gennady", "Sergei", "Fanasiy", "Khan", "Semyon", "Yakov", "Rurik", "Faddei", "Yefim", "Nikolay", "Sasha", "Vladimir", "Alexander", "Stas", "Ipatiy", "Kolmogorov", "Vitaliy", "Vladislav", "Artyom", "Yana", "Olga", "Fedor", "Vasily", "Ivanovich", "Leo", "Pierre", "Anna", "Natasha", "Andrei" };
    private string[] archetypes = new string[] { "Battlesuit", "Construct", "Crime Fighter", "Elemental", "Energy Controller", "Gadgeteer", "Martial Artist", "Mimic", "Mystic", "Paragon", "Powerhouse", "Psychic", "Shapeshifter", "Speedster", "Summoner", "Supernatural Creature", "Totem", "Warrior", "Weapon Master", "Weather Controller" };
    private string[] subArchetypes = new string[] { };
    private string[] lastNames = new string[] { "Isayev", "Tikhonov", "Chapayev", "Petka", "Anka", "Furmanov", "Budyonny", "Caesar", "Rzhevsky", "Tolstoy", "Bezukhov", "Blonsky", "Romanov", "Pavlovna", "Rostova", "Bolkonsky", "Kuragin", "Vidor", "Bondarchuk", "Levi", "Livinov", "Solomin", "Aksyonov", "Kalashnikov", "Gorbachev", "Smirnov", "Chernov", "Putin", "Brezhnev", "Pushkin", "Lipatov", "Khruschev", "Yeltsin", "Medvedev", "Anatolievych", "Vladimirovich" };
    private int skillCount;
    private GameObject[] skilltags;
    private int acrobatics = 0,
        athletics = 0,
        closeCombatGadgets = 0,
        closeCombatUnarmed = 0,
        closeCombatWeapon = 0,
        deception = 0,
        expertiseBusiness = 0,
        expertiseBiology = 0,
        expertiseCurrentEvents = 0,
        expertiseElements = 0,
        expertiseHistory = 0,
        expertiseScience = 0,
        expertiseMagic = 0,
        expertiseMilitary = 0,
        expertiseMythology = 0,
        expertiseRepair = 0,
        expertiseStreetwise = 0,
        expertisePopCulture = 0,
        expertisePhilosophy = 0,
        expertiseTactics = 0,
        expertiseWeapons = 0,
        insight = 0,
        intimidation = 0,
        investigation = 0,
        perception = 0,
        persuasion = 0,
        rangedCombatElement = 0,
        rangedCombatEnergyControl = 0,
        rangedCombatGadgets = 0,
        rangedCombatThrowing = 0,
        rangedCombatWeapon = 0,
        sleightOfHand = 0,
        stealth = 0,
        technology = 0,
        treatment = 0,
        vehicles = 0;
    public GameObject Acrobatics,
        Athletics,
        CloseCombatGadgets,
        CloseCombatUnarmed,
        CloseCombatWeapon,
        Deception,
        ExpertiseBusiness,
        ExpertiseBiology,
        ExpertiseCurrentEvents,
        ExpertiseElements,
        ExpertiseHistory,
        ExpertiseScience,
        ExpertiseMagic,
        ExpertiseMilitary,
        ExpertiseMythology,
        ExpertiseRepair,
        ExpertiseStreetwise,
        ExpertisePopCulture,
        ExpertisePhilosophy ,
        ExpertiseTactics ,
        ExpertiseWeapons,
        Insight,
        Intimidation,
        Investigation,
        Perception ,
        Persuasion ,
        RangedCombatElement ,
        RangedCombatEnergyControl ,
        RangedCombatGadgets,
        RangedCombatThrowing ,
        RangedCombatWeapon,
        SleightOfHand,
        Stealth,
        Technology,
        Treatment,
        Vehicles;
    public GameObject skillName, skillNum, skillList;
    
    private string[] advantages = new string[] { "default" };
    public string GetRandomName()
    {
        return names[Random.Range(0, names.Length)];
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateNPC();
        //Debug.Log(GetRandomName());
       
    }
    public void ExpertiseChoose(int boost)
    {
        random.Random15();
        if (random.number0 == 0)
        {
            expertiseBiology += boost;
        }
        else if (random.number0 == 1)
        {
            expertiseBusiness += boost;
        }
        else if (random.number0 == 2)
        {
            expertiseCurrentEvents += boost;
        }
        else if (random.number0 == 3)
        {
            expertiseElements += boost;
        }
        else if (random.number0 == 4)
        {
            expertiseHistory += boost;
        }
        else if (random.number0 == 5)
        {
            expertiseScience += boost;
        }
        else if (random.number0 == 6)
        {
            expertiseMagic += boost;
        }
        else if (random.number0 == 7)
        {
            expertiseMilitary += boost;
        }
        else if (random.number0 == 8)
        {
            expertiseMythology += boost;
        }
        else if (random.number0 == 9)
        {
            expertisePhilosophy += boost;
        }
        else if (random.number0 == 10)
        {
            expertisePopCulture += boost;
        }
        else if (random.number0 == 11)
        {
            expertiseRepair += boost;
        }
        else if (random.number0 == 12)
        {
            expertiseStreetwise += boost;
        }
        else if (random.number0 == 13)
        {
            expertiseTactics += boost;
        }
        else
        {
            expertiseWeapons += boost;
        }
    }
    public void CloseCombatChoose(int boost)
    {
        random.Random3();
        if (random.number0 == 0)
        {
           closeCombatGadgets += boost;
        }
        else if (random.number0 == 1)
        {
            closeCombatUnarmed += boost;
        }
        
        else
        {
            closeCombatWeapon += boost;
        }
    }
    public void RangedCombatChoose(int boost)
    {
        random.Random5();
        if (random.number0 == 0)
        {
            rangedCombatElement += boost;
        }
        else if (random.number0 == 1)
        {
            rangedCombatEnergyControl += boost;
        }
        else if (random.number0 == 2)
        {
            rangedCombatGadgets += boost;
        }
        else if (random.number0 == 3)
        {
            rangedCombatWeapon += boost;
        }
        else
        {
            rangedCombatThrowing += boost;
        }
    }
    public void CreateNPC()
    {
       
        
       

        for (int i = 0; i < 1; i++)
        {
            Archetype[i] = archetypes[Random.Range(0, archetypes.Length)];
            Debug.Log(archetypes[i]);
            if (Archetype[i] == "Battlesuit")
            {
                
                subArchetypes = new string[] { "Genius", "Military", "Accidental" };
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
                random.DoubleRandom5();
                if (random.number0 == 0)
                {
                    string0 = "Combatant";
                    adv0 = new string[] { "Accurate Attack", "All-out Attack", "Improved Initative", "Interpose", "Move-by Action" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Inventor";
                    adv0 = new string[] { "Eidetic Memory", "Improvised Tools", "Inventor", "Ultimate Effort(Technology)", "Well-informed" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Lucky";
                    adv0 = new string[] { "Beginner's Luck", "Luck 2", "Redirect", "Teamwork" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Scientist";
                    adv0 = new string[] { "Equipment 3(Headquarters)", "Skill Mastery(Expertise: Science)", "Skill Mastery(Technology)" };
                }
                else
                {
                    string0 = "Wealthy";
                    adv0 = new string[] { "Attractive", "Benefit 4(Multi-millionaire)" };
                }
                if (random.number1 == 0)
                {
                    string1 = "Combatant";
                    adv1 = new string[] { "Accurate Attack", "All-out Attack", "Improved Initative", "Interpose", "Move-by Action" };
                }
                else if (random.number1 == 1)
                {
                    string1 = "Inventor";
                    adv1 = new string[] { "Eidetic Memory", "Improvised Tools", "Inventor", "Ultimate Effort(Technology)", "Well-informed" };
                }
                else if (random.number1 == 2)
                {
                    string1 = "Lucky";
                    adv1 = new string[] { "Beginner's Luck", "Luck 2", "Redirect", "Teamwork" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Scientist";
                    adv1 = new string[] { "Equipment 3(Headquarters)", "Skill Mastery(Expertise: Science)", "Skill Mastery(Technology)" };
                }
                else
                {
                    string1 = "Wealthy";
                    adv1 = new string[] { "Attractive", "Benefit 4(Multi-millionaire)" };
                }
                random.Random3();
                if (random.number0 == 0)
                {
                    string2 = "People Person";
                    expertiseBusiness += 4;
                    insight += 4;
                    perception += 4;
                    persuasion += 4;
                }
                else if (random.number0 == 1)
                {
                    string2 = "Sciences";
                    expertiseScience += 6;
                    perception += 4;
                    technology += 6;
                }
                else
                {
                    string2 = "Student";
                    expertiseScience += 4;
                    perception += 4;
                    persuasion += 4;
                    technology += 4;
                }
                random.Random3();
                if (random.number0 == 0)
                {
                    string3 = "People Person";
                    expertiseBusiness += 4;
                    insight += 4;
                    perception += 4;
                    persuasion += 4;
                }
                else if (random.number0 == 1)
                {
                    string3 = "Sciences";
                    expertiseScience += 6;
                    perception += 4;
                    technology += 6;
                }
                else
                {
                    string3 = "Student";
                    expertiseScience += 4;
                    perception += 4;
                    persuasion += 4;
                    technology += 4;
                }
                #region powers
                string4 = "Weapon Array";
                inv.Add(ItemData.CreateItem(100));
                random.QuadRandomX(8);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(101));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(102));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(103));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(104));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(105));
                }
                else if (random.number0 == 6)
                {
                    inv.Add(ItemData.CreateItem(106));
                }
                else if (random.number0 == 7)
                {
                    inv.Add(ItemData.CreateItem(107));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(108));
                }
                if (random.number1 == 0)
                {
                    inv.Add(ItemData.CreateItem(101));
                }
                else if (random.number1 == 1)
                {
                    inv.Add(ItemData.CreateItem(102));
                }
                else if (random.number1 == 2)
                {
                    inv.Add(ItemData.CreateItem(103));
                }
                else if (random.number1 == 4)
                {
                    inv.Add(ItemData.CreateItem(104));
                }
                else if (random.number1 == 5)
                {
                    inv.Add(ItemData.CreateItem(105));
                }
                else if (random.number1 == 6)
                {
                    inv.Add(ItemData.CreateItem(106));
                }
                else if (random.number1 == 7)
                {
                    inv.Add(ItemData.CreateItem(107));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(108));
                }
                if (random.number2 == 0)
                {
                    inv.Add(ItemData.CreateItem(101));
                }
                else if (random.number2 == 1)
                {
                    inv.Add(ItemData.CreateItem(102));
                }
                else if (random.number2 == 2)
                {
                    inv.Add(ItemData.CreateItem(103));
                }
                else if (random.number2 == 4)
                {
                    inv.Add(ItemData.CreateItem(104));
                }
                else if (random.number2 == 5)
                {
                    inv.Add(ItemData.CreateItem(105));
                }
                else if (random.number2 == 6)
                {
                    inv.Add(ItemData.CreateItem(106));
                }
                else if (random.number2 == 7)
                {
                    inv.Add(ItemData.CreateItem(107));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(108));
                }
                if (random.number3 == 0)
                {
                    inv.Add(ItemData.CreateItem(101));
                }
                else if (random.number3 == 1)
                {
                    inv.Add(ItemData.CreateItem(102));
                }
                else if (random.number3 == 2)
                {
                    inv.Add(ItemData.CreateItem(103));
                }
                else if (random.number3 == 4)
                {
                    inv.Add(ItemData.CreateItem(104));
                }
                else if (random.number3 == 5)
                {
                    inv.Add(ItemData.CreateItem(105));
                }
                else if (random.number3 == 6)
                {
                    inv.Add(ItemData.CreateItem(106));
                }
                else if (random.number3 == 7)
                {
                    inv.Add(ItemData.CreateItem(107));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(108));
                }
                inv.Add(ItemData.CreateItem(110));
                inv.Add(ItemData.CreateItem(111));
                inv.Add(ItemData.CreateItem(112));
                random.RandomX(4);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(120));
                    inv.Add(ItemData.CreateItem(121));
                }
                
                else if (random.number0 == 1)
                {
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(120));
                        
                    }

                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(121));

                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(122));
                        
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(123));
                    }

                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(126));
                    inv.Add(ItemData.CreateItem(127));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(128));
                }
                inv.Add(ItemData.CreateItem(130));
                inv.Add(ItemData.CreateItem(131));
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 4;
                Parry += Fighting + 2;
                Fortitude += Stamina + 2;
                Toughness += Stamina + 0;
                Will += Awareness + 4;
                Initiative += Agility; 
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
                    #region powers
                   
                    random.RandomX(3);

                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(0));
                    }
                    else if (random.number0 == 1)
                    {
                        random.RandomX(4);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(1));
                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(2));
                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(3));
                        }
                        else
                        {

                            inv.Add(ItemData.CreateItem(4));

                        }
                    }
                    else
                    {

                        inv.Add(ItemData.CreateItem(5));

                    }

                    #endregion
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
                    #region powers

                    random.RandomX(5);

                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(10));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(11));
                        inv.Add(ItemData.CreateItem(12));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(13));
                        inv.Add(ItemData.CreateItem(14));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(15));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(16));
                    }
                    #endregion
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
                    #region powers

                    random.RandomX(3);

                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(20));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(21));
                        
                    }
                  
                    else
                    {
                        inv.Add(ItemData.CreateItem(22));
                    }
                    #endregion
                }
                random.Random5();
                if (random.number0 == 0)
                {
                    string0 = "Brawler";
                    adv0 = new string[] { "Improved Grab", "Power Attack" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Brawler";
                    adv0 = new string[] { "Improved Grab", "Accurate Attack" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Dabbler";
                    adv0 = new string[] { "Artificer", "Skill Mastery(Expertise: Magic)" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Dabbler";
                    adv0 = new string[] { "Inventory", "Skill Mastery(Technology)" };
                }
                else 
                {
                    string0 = "Perfect Recall";
                    adv0 = new string[] { "Eidetic Memory", "Well-informed" };
                }

                random.Random4();
                if (random.number0 == 0)
                {
                    string1 = "Brute";
                    athletics += 6;
                    intimidation += 6;
                    
                    
                }
                else if (random.number0 == 1)
                {
                    string1 = "Expert";
                    perception += 4;
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        technology += 8;
                    }
                    else
                    {
                        expertiseMagic += 8;
                    }
                }
                else if (random.number0 == 2)
                {
                    string1 = "Seeker";
                    investigation += 5;
                    perception += 3;
                    persuasion += 4;
                }
                else
                {
                    string1 = "Sneak";
                    deception += 6;
                    stealth += 6;
                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string2 = "Brute";
                    athletics += 6;
                    intimidation += 6;


                }
                else if (random.number0 == 1)
                {
                    string2 = "Expert";
                    perception += 4;
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        technology += 8;
                    }
                    else
                    {
                        expertiseMagic += 8;
                    }
                }
                else if (random.number0 == 2)
                {
                    string2 = "Seeker";
                    investigation += 5;
                    perception += 3;
                    persuasion += 4;
                }
                else
                {
                    string1 = "Sneak";
                    deception += 6;
                    stealth += 6;
                }
                #region powers

                random.RandomX(3);
                inv.Add(ItemData.CreateItem(30));
                inv.Add(ItemData.CreateItem(31));
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(40));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(41));

                }

                else
                {
                    inv.Add(ItemData.CreateItem(42));
                }
                random.RandomX(2);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(50));
                }
              

                else
                {
                    inv.Add(ItemData.CreateItem(51));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 0;
                Parry += Fighting + 0;
                Fortitude += Stamina + 0;
                Toughness += Stamina + 0;
                Will += Awareness + 0;
                Initiative += Agility;
            }
            else if (Archetype[i] == "Crime Fighter")
            {
                subArchetypes = new string[] { "Dark Avenger", "Detective", "Inventor" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                closeCombatUnarmed += 6;
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
                    random.DoubleRandom3();
                    if (random.number0 == 0)
                    {
                        string0 = "Criminologist";
                        adv0 = new string[] { "Assessment", "Skill Mastery(Expertise: Streetwise)"};
                    }
                    else if (random.number0 == 1)
                    {
                        string0 = "Scientist";
                        adv0 = new string[] { "Inventor", "Skill Mastery(Technology)" };
                    }
                   
                    else
                    {
                        string0 = "Sleuth";
                        adv0 = new string[] { "Skill Mastery(Investigation)", "Tracking" };
                    }
                    if (random.number1 == 0)
                    {
                        string1 = "Criminologist";
                        adv1 = new string[] { "Assessment", "Skill Mastery(Expertise: Streetwise)" };
                    }
                    else if (random.number1 == 1)
                    {
                        string1 = "Scientist";
                        adv1 = new string[] { "Inventor", "Skill Mastery(Technology)" };
                    }
                    
                    else
                    {
                        string1 = "Sleuth";
                        adv1 = new string[] { "Skill Mastery(Investigation)", "Tracking" };
                    }
                    string4 = "Avenger";
                    expertiseStreetwise += 6;
                    intimidation += 8;
                    vehicles += 6;
                    random.Random4();
                    if (random.number0 == 0)
                    {
                        string5 = "Athlete";
                        acrobatics += 6;
                        athletics += 8;
                        intimidation += 6;


                    }
                    else if (random.number0 == 1)
                    {
                        string5 = "Expert";
                        perception += 6;
                        technology += 8;
                        treatment += 6;
                    }
                    else if (random.number0 == 2)
                    {
                        string5 = "Investigator";
                        expertiseStreetwise += 4;
                        insight += 5;
                        investigation += 6;
                        perception += 5;
                    }
                    else
                    {
                        string5 = "Sneak";
                        deception += 6;
                        stealth += 8;
                        sleightOfHand += 6;
                    }

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
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        string0 = "Criminologist";
                        adv0 = new string[] { "Assessment", "Skill Mastery(Expertise: Streetwise)" };
                    }
                    else 
                    {
                        string0 = "Scientist";
                        adv0 = new string[] { "Inventor", "Skill Mastery(Technology)" };
                    }
                    string1 = "Sleuth";
                    adv1 = new string[] { "Skill Mastery(Investigation)", "Tracking" };
                    string4 = "Investigator";
                    expertiseStreetwise += 4;
                    insight += 5;
                    investigation += 6;
                    perception += 5;
                   
                    random.Random4();
                    if (random.number0 == 0)
                    {
                        string5 = "Athlete";
                        acrobatics += 6;
                        athletics += 8;
                        intimidation += 6;


                    }
                    else if (random.number0 == 1)
                    {
                        string5 = "Expert";
                        perception += 6;
                        technology += 8;
                        treatment += 6;
                    }
                    else if (random.number0 == 2)
                    {
                        string5 = "Avenger";
                        expertiseStreetwise += 6;
                        intimidation += 8;
                        vehicles += 6;
                    }
                    else
                    {
                        string5 = "Sneak";
                        deception += 6;
                        stealth += 8;
                        sleightOfHand += 6;
                    }
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
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        string0 = "Criminologist";
                        adv0 = new string[] { "Assessment", "Skill Mastery(Expertise: Streetwise)" };
                    }
                    else
                    {
                        string0 = "Sleuth";
                        adv0 = new string[] { "Skill Mastery(Investigation)", "Tracking" };
                    }
                    string1 = "Scientist";
                    adv1 = new string[] { "Inventor", "Skill Mastery(Technology)" };
                    string4 = "Expert";
                    perception += 6;
                    technology += 8;
                    treatment += 6;
                   

                    random.Random4();
                    if (random.number0 == 0)
                    {
                        string5 = "Athlete";
                        acrobatics += 6;
                        athletics += 8;
                        intimidation += 6;


                    }
                    else if (random.number0 == 1)
                    {
                        string5 = "Investigator";
                        expertiseStreetwise += 4;
                        insight += 5;
                        investigation += 6;
                        perception += 5;
                    }
                    else if (random.number0 == 2)
                    {
                        string5 = "Avenger";
                        expertiseStreetwise += 6;
                        intimidation += 8;
                        vehicles += 6;
                    }
                    else
                    {
                        string5 = "Sneak";
                        deception += 6;
                        stealth += 8;
                        sleightOfHand += 6;
                    }
                }
                random.Random3();
                
                if (random.number0 == 0 || SubArchetype[i] == "Dark Avenger")
                {
                    string2 = "Incredible Presence";
                    adv2 = new string[] { "Daze(Intimidation)", "Skill Mastery(Intimidation)", "Startle", "Leadership" };
                }
                else if (random.number0 == 1)
                {
                    string2 = "Wealthy Socialite";
                    adv2 = new string[] { "Benfit 3 (Millionaire)", "Connected" };
                }
               
                else
                {
                    string2 = "World Traveler";
                    adv2 = new string[] { "Languages 3(choose 4)", "Contacts" };
                }
                random.Random3();
                if (random.number0 == 0)
                {
                    string3 = "Acrobat";
                    adv3 = new string[] { "Evasion", "Instant Up" };
                }
                else if (random.number0 == 1)
                {
                    string3 = "Martial Artist";
                    adv3 = new string[] { "Defensive Attack", "Uncanny Dodge" };
                }

                else
                {
                    string3 = "Thief";
                    adv3 = new string[] { "Hide in Plain Sight", "Skill Mastery(Stealth)" };
                }
                #region powers
                
                random.RandomX(3);
                
                if (random.number0 == 0 || SubArchetype[i] == "Inventor")
                {
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(210));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(211));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(212));
                        inv.Add(ItemData.CreateItem(213));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(220));
                        inv.Add(ItemData.CreateItem(221));
                        inv.Add(ItemData.CreateItem(222));
                    }

                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(200));
                    inv.Add(ItemData.CreateItem(201));
                    inv.Add(ItemData.CreateItem(202));
                    inv.Add(ItemData.CreateItem(203));
                    inv.Add(ItemData.CreateItem(204));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(201));
                    inv.Add(ItemData.CreateItem(230));
                    inv.Add(ItemData.CreateItem(240));
                    inv.Add(ItemData.CreateItem(241));
                    inv.Add(ItemData.CreateItem(242));
                    inv.Add(ItemData.CreateItem(243));
                    inv.Add(ItemData.CreateItem(244));
                    inv.Add(ItemData.CreateItem(245));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                background1.text = string3 + ", " + string4 + ", " + string5;
                Dodge += Agility + 7;
                Parry += Fighting + 5;
                Fortitude += Stamina + 4;
                Toughness += Stamina + 0;
                Will += Awareness + 8;
                Initiative += Agility;
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

                random.Random3();

                if (random.number0 == 0)
                {
                    string0 = "Imposing";
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv0 = new string[] { "Daze(Deception)" };
                    }
                    else
                    {
                        adv0 = new string[] { "Daze(Intimidation)" };
                    }
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv1 = new string[] { "Startle" };
                    }
                    else
                    {
                        adv1 = new string[] { "Taunt" };
                    }
                }
                else if (random.number0 == 1)
                {
                    string0 = "Overseer";
                    adv0 = new string[] { "Contacts", "Leadership" };
                }

                else
                {
                    string0 = "Unobstrusive";
                    adv0 = new string[] { "Favoured Environment(choose 1)" };
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv1 = new string[] { "Evasion" };
                    }
                    else
                    {
                        adv1 = new string[] { "Improved Initative" };
                    }
                }
                random.Random2();
                if(random.number0 == 0)
                {
                    adv2 = new string[] { "Power Attack" };
                }
                else
                {
                    adv2 = new string[] { "Accurate Attack" };
                }
                random.Random4();
                if (random.number0 == 0 || SubArchetype[i] == "Embodiment")
                {
                    string1 = "Native";
                    expertiseElements += 8;
                    
                    perception += 4;


                }
                else if (random.number0 == 1)
                {
                    string1 = "Pilot/Driver";
                    expertiseRepair += 4;
                    vehicles += 8;
                    
                }
                else if (random.number0 == 2)
                {
                    string1 = "Scientist";
                    expertiseScience += 8;
                    technology += 4;
                    
                }
                else
                {
                    string1 = "Soldier";
                    athletics += 4;
                    expertiseMilitary += 8;
                   
                }
                random.Random3();
                if (random.number0 == 0)
                {
                    acrobatics += 4;
                }
                else if (random.number0 == 1)
                {
                    athletics += 4;
                }
                else
                {
                    closeCombatUnarmed += 4;
                }
                random.Random2();
                if (random.number0 == 0)
                {
                    deception += 6;
                }
       
                else
                {
                    intimidation += 6;
                }
                #region powers
                
                inv.Add(ItemData.CreateItem(300));
                
                random.RandomX(4);
                if (random.number0 == 0)
                {
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(320));
                    }
                    
                    else
                    {
                        inv.Add(ItemData.CreateItem(321));
                    }
                    inv.Add(ItemData.CreateItem(330));
                    random.RandomX(6);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(331));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(332));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(333));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(334));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(335));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(336));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(331));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(332));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(333));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(334));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(335));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(336));
                    }
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(340));
                    inv.Add(ItemData.CreateItem(341));
                    random.RandomX(6);
                    if (random.number0 == 0)
                    {
                        //clay
                        inv.Add(ItemData.CreateItem(350));
                    }
                    else if (random.number0 == 1)
                    {
                        //earth
                        inv.Add(ItemData.CreateItem(351));
                        inv.Add(ItemData.CreateItem(352));
                        inv.Add(ItemData.CreateItem(353));
                        inv.Add(ItemData.CreateItem(354));
                    }
                    else if (random.number0 == 2)
                    {
                        //partic
                        inv.Add(ItemData.CreateItem(355));
                        inv.Add(ItemData.CreateItem(356));
                        
                    }
                    else if (random.number0 == 3)
                    {
                        //rock
                        inv.Add(ItemData.CreateItem(357));
                        inv.Add(ItemData.CreateItem(358));
                        inv.Add(ItemData.CreateItem(359));
                        
                    }
                    else 
                    {
                        inv.Add(ItemData.CreateItem(360));
                        inv.Add(ItemData.CreateItem(361));
                        random.QuadRandomX(5);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(362));
                           
                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(363));
                           
                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(364));

                        }
                        else if (random.number0 == 3)
                        {
                            inv.Add(ItemData.CreateItem(365));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(366));

                        }
                        if (random.number1 == 0)
                        {
                            inv.Add(ItemData.CreateItem(362));

                        }
                        else if (random.number1 == 1)
                        {
                            inv.Add(ItemData.CreateItem(363));

                        }
                        else if (random.number1 == 2)
                        {
                            inv.Add(ItemData.CreateItem(364));

                        }
                        else if (random.number1 == 3)
                        {
                            inv.Add(ItemData.CreateItem(365));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(366));

                        }
                        if (random.number2 == 0)
                        {
                            inv.Add(ItemData.CreateItem(362));

                        }
                        else if (random.number2 == 1)
                        {
                            inv.Add(ItemData.CreateItem(363));

                        }
                        else if (random.number2 == 2)
                        {
                            inv.Add(ItemData.CreateItem(364));

                        }
                        else if (random.number2 == 3)
                        {
                            inv.Add(ItemData.CreateItem(365));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(366));

                        }
                        if (random.number3 == 0)
                        {
                            inv.Add(ItemData.CreateItem(362));

                        }
                        else if (random.number3 == 1)
                        {
                            inv.Add(ItemData.CreateItem(363));

                        }
                        else if (random.number3 == 2)
                        {
                            inv.Add(ItemData.CreateItem(364));

                        }
                        else if (random.number3 == 3)
                        {
                            inv.Add(ItemData.CreateItem(365));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(366));

                        }
                    }
                    
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(301));
                    inv.Add(ItemData.CreateItem(302));
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(303));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(304));
                    }
                    inv.Add(ItemData.CreateItem(310));
                    random.DoubleRandomX(6);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(311));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(312));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(313));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(314));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(315));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(316));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(311));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(312));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(313));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(314));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(315));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(316));
                    }
                }
                
                else
                {
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        //liquid
                        inv.Add(ItemData.CreateItem(370));
                        inv.Add(ItemData.CreateItem(371));
                        inv.Add(ItemData.CreateItem(372));
                        
                        random.QuadRandomX(5);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(373));

                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(374));

                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(375));

                        }
                        else if (random.number0 == 3)
                        {
                            inv.Add(ItemData.CreateItem(376));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(377));

                        }
                        if (random.number1 == 0)
                        {
                            inv.Add(ItemData.CreateItem(373));

                        }
                        else if (random.number1 == 1)
                        {
                            inv.Add(ItemData.CreateItem(374));

                        }
                        else if (random.number1 == 2)
                        {
                            inv.Add(ItemData.CreateItem(375));

                        }
                        else if (random.number1 == 3)
                        {
                            inv.Add(ItemData.CreateItem(376));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(377));

                        }
                        if (random.number2 == 0)
                        {
                            inv.Add(ItemData.CreateItem(373));

                        }
                        else if (random.number2 == 1)
                        {
                            inv.Add(ItemData.CreateItem(374));

                        }
                        else if (random.number2 == 2)
                        {
                            inv.Add(ItemData.CreateItem(375));

                        }
                        else if (random.number2 == 3)
                        {
                            inv.Add(ItemData.CreateItem(376));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(377));

                        }
                        if (random.number3 == 0)
                        {
                            inv.Add(ItemData.CreateItem(373));

                        }
                        else if (random.number3 == 1)
                        {
                            inv.Add(ItemData.CreateItem(374));

                        }
                        else if (random.number3 == 2)
                        {
                            inv.Add(ItemData.CreateItem(375));

                        }
                        else if (random.number3 == 3)
                        {
                            inv.Add(ItemData.CreateItem(376));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(377));

                        }
                    }
                    
                    else
                    {
                        //ice
                        inv.Add(ItemData.CreateItem(380));
                        inv.Add(ItemData.CreateItem(381));
                        inv.Add(ItemData.CreateItem(390));
                        random.QuadRandomX(5);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(391));

                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(392));

                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(393));

                        }
                        else if (random.number0 == 3)
                        {
                            inv.Add(ItemData.CreateItem(394));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(395));

                        }
                        if (random.number1 == 0)
                        {
                            inv.Add(ItemData.CreateItem(391));

                        }
                        else if (random.number1 == 1)
                        {
                            inv.Add(ItemData.CreateItem(392));

                        }
                        else if (random.number1 == 2)
                        {
                            inv.Add(ItemData.CreateItem(393));

                        }
                        else if (random.number1 == 3)
                        {
                            inv.Add(ItemData.CreateItem(394));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(395));

                        }
                        if (random.number2 == 0)
                        {
                            inv.Add(ItemData.CreateItem(391));

                        }
                        else if (random.number2 == 1)
                        {
                            inv.Add(ItemData.CreateItem(392));

                        }
                        else if (random.number2 == 2)
                        {
                            inv.Add(ItemData.CreateItem(393));

                        }
                        else if (random.number2 == 3)
                        {
                            inv.Add(ItemData.CreateItem(394));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(395));

                        }
                        if (random.number3 == 0)
                        {
                            inv.Add(ItemData.CreateItem(391));

                        }
                        else if (random.number3 == 1)
                        {
                            inv.Add(ItemData.CreateItem(392));

                        }
                        else if (random.number3 == 2)
                        {
                            inv.Add(ItemData.CreateItem(393));

                        }
                        else if (random.number3 == 3)
                        {
                            inv.Add(ItemData.CreateItem(394));

                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(395));

                        }
                    }
                    
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 4;
                Parry += Fighting + 2;
                Fortitude += Stamina + 7;
                Toughness += Stamina + 0;
                Will += Awareness + 6;
                Initiative += Agility;
            }
            else if (Archetype[i] == "Energy Controller")
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
                random.DoubleRandom6();
                if (random.number0 == 0)
                {
                    string0 = "Aggresive";
                    adv0 = new string[] { "All-out Attack", "Power Attack" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Disciplined";
                    adv0 = new string[] { "Assessment", "Teamwork" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Intimidating";
                    adv0 = new string[] { "Daze(Intimidation)", "Startle" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Hidden Reserves";
                    adv0 = new string[] { "Extraordinary Effort", "Great Endurance" };
                }
                else if (random.number0 == 4)
                {
                    string0 = "Precise";
                    adv0 = new string[] { "Accurate Attack", "Precise Attack(Ranged, Cover)" };
                }
                else
                {
                    string0 = "Wisecracker";
                    adv0 = new string[] { "Fearless", "Taunt" };
                }
                if (random.number1 == 0)
                {
                    string1 = "Aggresive";
                    adv1 = new string[] { "All-out Attack", "Power Attack" };
                }
                else if (random.number1 == 1)
                {
                    string1 = "Disciplined";
                    adv1 = new string[] { "Assessment", "Teamwork" };
                }
                else if (random.number1 == 2)
                {
                    string1 = "Intimidating";
                    adv1 = new string[] { "Daze(Intimidation)", "Startle" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Hidden Reserves";
                    adv1 = new string[] { "Extraordinary Effort", "Great Endurance" };
                }
                else if (random.number1 == 4)
                {
                    string1 = "Precise";
                    adv1 = new string[] { "Accurate Attack", "Precise Attack(Ranged, Cover)" };
                }
                else
                {
                    string1 = "Wisecracker";
                    adv1 = new string[] { "Fearless", "Taunt" };
                }
                random.DoubleRandom6();
                if (random.number0 == 0)
                {
                    string2 = "Athlete";
                    acrobatics += 4;

                    athletics += 4;


                }
                else if (random.number0 == 1)
                {
                    string2 = "Cool";
                    acrobatics += 4;

                    perception += 4;
                }
                else if (random.number0 == 2)
                {
                    string2 = "Observant";
                    investigation += 4;

                    perception += 4;

                }
                else if (random.number0 == 3)
                {
                    string2 = "Popular";
                    insight += 4;

                    persuasion += 4;

                }
                else if (random.number0 == 4)
                {
                    string2 = "Pilot/Driver";
                    technology += 4;

                    vehicles += 4;
                }
                else
                {
                    string2 = "Sly";
                    sleightOfHand += 4;

                    stealth += 4;

                }
                if (random.number1 == 0)
                {
                    string3 = "Athlete";
                    acrobatics += 4;

                    athletics += 4;


                }
                else if (random.number1 == 1)
                {
                    string3 = "Cool";
                    acrobatics += 4;

                    perception += 4;
                }
                else if (random.number1 == 2)
                {
                    string3 = "Observant";
                    investigation += 4;

                    perception += 4;

                }
                else if (random.number1 == 3)
                {
                    string3 = "Popular";
                    insight += 4;

                    persuasion += 4;

                }
                else if (random.number1 == 4)
                {
                    string3 = "Pilot/Driver";
                    technology += 4;

                    vehicles += 4;
                }
                else
                {
                    string3 = "Sly";
                    sleightOfHand += 4;

                    stealth += 4;

                }
                rangedCombatEnergyControl += 5;
                random.Random2();
                if (random.number0 == 0)
                {
                    deception += 7;
                }
                else
                {
                    intimidation += 7;
                }
                #region powers
                string4 = "Weapon Array";
                inv.Add(ItemData.CreateItem(100));
                random.RandomX(3);
               
                if (random.number0 == 0)
                {
                    //quickchange
                    inv.Add(ItemData.CreateItem(401));
                    inv.Add(ItemData.CreateItem(400));
                    random.TripleRandomX(10);
                    if (random.number0 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }
                        

                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number0 == 2)
                    {
                        random.RandomX(2);
                         if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else 
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number0 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number0 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                    if (random.number1 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number1 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number1 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number1 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number1 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                    if (random.number2 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number2 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number2 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number2 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number2 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(400));
                    random.QuadRandomX(10);
                    if (random.number0 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number0 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number0 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number0 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                    if (random.number1 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number1 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number1 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number1 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number1 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                    if (random.number2 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number2 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number2 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number2 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number2 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                    if (random.number3 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number3 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number3 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number3 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number3 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number3 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number3 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number3 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number3 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                }
                
                else
                {
                   
                    random.RandomX(8);
                    if (random.number0 == 0)
                    {
                        
                            inv.Add(ItemData.CreateItem(410));



                        
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(411));
                    }
                    else if (random.number0 == 2)
                    {
                        
                            inv.Add(ItemData.CreateItem(412));
                       
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(413));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(414));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(415));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(416));
                    }
                    
                    else
                    {
                        inv.Add(ItemData.CreateItem(417));
                    }
                    random.TripleRandomX(10);
                    if (random.number0 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number0 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number0 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number0 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                    if (random.number1 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number1 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number1 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number1 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number1 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                    if (random.number2 == 0)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(420));

                        }


                        else
                        {
                            inv.Add(ItemData.CreateItem(421));
                        }
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(422));
                    }
                    else if (random.number2 == 2)
                    {
                        random.RandomX(2);
                        if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(423));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(424));
                        }
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(425));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(426));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(427));
                    }
                    else if (random.number2 == 6)
                    {
                        inv.Add(ItemData.CreateItem(428));
                    }
                    else if (random.number2 == 7)
                    {
                        random.RandomX(2);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(429));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(430));
                        }
                    }
                    else if (random.number2 == 8)
                    {
                        inv.Add(ItemData.CreateItem(431));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(432));
                    }
                }
                inv.Add(ItemData.CreateItem(440));
                random.RandomX(3);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(441));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(442));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(443));
                }
                inv.Add(ItemData.CreateItem(450));
                random.DoubleRandomX(5);
                if (random.number0 == 0)
                {

                    inv.Add(ItemData.CreateItem(451));




                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(452));
                }
                else if (random.number0 == 2)
                {

                    inv.Add(ItemData.CreateItem(453));

                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(454));
                }
                

                else
                {
                    inv.Add(ItemData.CreateItem(455));
                }
                if (random.number1 == 0)
                {

                    inv.Add(ItemData.CreateItem(451));




                }
                else if (random.number1 == 1)
                {
                    inv.Add(ItemData.CreateItem(452));
                }
                else if (random.number1 == 2)
                {

                    inv.Add(ItemData.CreateItem(453));

                }
                else if (random.number1 == 3)
                {
                    inv.Add(ItemData.CreateItem(454));
                }


                else
                {
                    inv.Add(ItemData.CreateItem(455));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                background1.text = string3 + ", " + string4 + ", " + string5;
                Dodge += Agility + 4;
                Parry += Fighting + 1;
                Fortitude += Stamina + 5;
                Toughness += Stamina + 0;
                Will += Awareness + 6;
                Initiative += Agility;
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
                random.Random4();
                if (random.number0 == 0)
                {
                    string0 = "Athletic";
                    adv0 = new string[] { "Evasion", "Uncanny Dodge", "Improved Initiative" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Natural Leader";
                    adv0 = new string[] { "Inspire 2", "Leadership" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Tinkerer";
                    adv0 = new string[] { "Accurate Attack", "Luck", "Power Attack" };
                }
              
                else
                {
                    string0 = "Well-To-Do-Inventor";
                    adv0 = new string[] { "Benefit 3 (Millionaire)" };
                }
                random.Random2();
                if (random.number0 == 0)
                {
                    closeCombatUnarmed += 6;
                }
                else
                {
                    closeCombatGadgets += 6;
                }
                expertiseScience += 10;
                rangedCombatGadgets += 6;
                technology += 10;
                vehicles += 4;
                random.Random4();
                if (random.number0 == 0)
                {
                    string1 = "Businessman/Woman";
                    expertiseBusiness += 5;
                    insight += 6;
                    persuasion += 5;
                }
                else if (random.number0 == 1)
                {
                    string1 = "Explorer";
                    athletics += 7;
                    perception += 5;
                    stealth += 4;
                }
                else if (random.number0 == 2)
                {
                    string1 = "Investigator";
                    insight += 4;
                    investigation += 7;
                    perception += 5;
                }

                else
                {
                    string1 = "Infiltrator";
                    deception += 6;
                    sleightOfHand += 4;
                    stealth += 6;
                }
                adv1 = new string[] { "Beginner's Luck", "Eidetic Memory", "Equipment 3(Headquarters)", "Improvised Tool", "Inventor", "Skill Mastery(Technology)" };
                #region powers
                
                random.RandomX(6);
                
                if (random.number0 == 0)
                {
                    //energy projector
                    inv.Add(ItemData.CreateItem(500));
                    inv.Add(ItemData.CreateItem(501));
                    inv.Add(ItemData.CreateItem(502));
                    inv.Add(ItemData.CreateItem(503));
                }
                else if (random.number0 == 1)
                {
                    //force armour
                    inv.Add(ItemData.CreateItem(510));
                    inv.Add(ItemData.CreateItem(511));
                    inv.Add(ItemData.CreateItem(512));
                    inv.Add(ItemData.CreateItem(513));
                    inv.Add(ItemData.CreateItem(514));
                    inv.Add(ItemData.CreateItem(515));
                    inv.Add(ItemData.CreateItem(516));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(520));
                    random.TripleRandomX(7);
                    if (random.number0 == 0)
                    {

                        inv.Add(ItemData.CreateItem(521));
               
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(522));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(523));

                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(524));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(525));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(526));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(527));
                    }
                    if (random.number1 == 0)
                    {

                        inv.Add(ItemData.CreateItem(521));

                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(522));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(523));

                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(524));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(525));
                    }
                    else if (random.number1 == 6)
                    {
                        inv.Add(ItemData.CreateItem(526));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(527));
                    }
                    if (random.number2 == 0)
                    {

                        inv.Add(ItemData.CreateItem(521));

                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(522));
                    }
                    else if (random.number2 == 2)
                    {
                        inv.Add(ItemData.CreateItem(523));

                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(524));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(525));
                    }
                    else if (random.number2 == 6)
                    {
                        inv.Add(ItemData.CreateItem(526));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(527));
                    }
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(530));
                    inv.Add(ItemData.CreateItem(531));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(532));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(540));
                    inv.Add(ItemData.CreateItem(541));
                    inv.Add(ItemData.CreateItem(542));
                    inv.Add(ItemData.CreateItem(543));
                    
                }
                random.RandomX(4);
                if (random.number0 == 0)
                {
                   
                    inv.Add(ItemData.CreateItem(550));
                    inv.Add(ItemData.CreateItem(551));
                   
                }
                else if (random.number0 == 1)
                {

                    inv.Add(ItemData.CreateItem(552));
                    

                }
                else if (random.number0 == 2)
                {

                    inv.Add(ItemData.CreateItem(553));


                }
                else
                {

                    inv.Add(ItemData.CreateItem(554));


                }
                random.RandomX(4);
                if (random.number0 == 0)
                {
                     inv.Add(ItemData.CreateItem(560));
                 }
                else if (random.number0 == 1)
                {

                    inv.Add(ItemData.CreateItem(561));


                }
                else if (random.number0 == 2)
                {

                    inv.Add(ItemData.CreateItem(562));


                }
                else
                {

                    inv.Add(ItemData.CreateItem(563));


                }
                random.RandomX(5);
                if (random.number0 == 0)
                {

                    inv.Add(ItemData.CreateItem(570));
                  

                }
                else if (random.number0 == 1)
                {

                    inv.Add(ItemData.CreateItem(571));


                }
                else if (random.number0 == 2)
                {

                    inv.Add(ItemData.CreateItem(572));


                }
                else if (random.number0 == 3)
                {

                    inv.Add(ItemData.CreateItem(573));


                }
                else
                {

                    inv.Add(ItemData.CreateItem(574));


                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 6;
                Parry += Fighting + 4;
                Fortitude += Stamina + 7;
                Toughness += Stamina + 0;
                Will += Awareness + 6;
                Initiative += Agility;
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
                random.Random3();
                
                if (random.number0 == 0)
                {
                    string0 = "Armed Fighter";
                    adv0 = new string[] { "Equipment 2(choose 1)", "Improvised Weapon", "Quick Draw" };
                }
               
                else if (random.number0 == 1)
                {
                    string0 = "Wealthy";
                    adv0 = new string[] { "Benefit 3(Millionaire)", "Connected" };
                }
                else
                {
                    string0 = "Well Travelled";
                    adv0 = new string[] { "Language 1(choose 1)", "Tracking", "Well-informed" };
                }
                if (SubArchetype[i] == "Mystic Endowment")
                {
                    random.Random5();
                    if (random.number0 == 0)
                    {
                        string2 = "Earth";
                        adv2 = new string[] { "Daze(Intimidation)", "Diehard", "Fearless", "Great Endurance" };
                    }

                    else if (random.number0 == 1)
                    {
                        string2 = "Fire";
                        adv2 = new string[] { "Extraordinary Effort", "Inspire", "Interpose", "Leadership" };
                    }
                    else if (random.number0 == 2)
                    {
                        string2 = "Metal";
                        adv2 = new string[] { "Beginner's Luck", "Eidetic Memory", "Luck", "Taunt" };
                    }
                    else if (random.number0 == 3)
                    {
                        string2 = "Water";
                        adv2 = new string[] { "Assessment", "Evasion", "Trance", "Uncanny Dodge" };
                    }
                    else
                    {
                        string2 = "Wood";
                        adv2 = new string[] { "Favoured Environment(Choose 1)", "Hide in Plain Sight", "Precise Attack (Close, Concealment)", "Teamwork" };
                    }
                    random.Random5();
                    if (random.number0 == 0)
                    {
                        string3 = "Agent";
                        acrobatics += 4;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        insight += 4;
                        investigation += 4;
                        perception += 4;
                        stealth += 6;
                        technology += 4;
                    }

                    else if (random.number0 == 1)
                    {
                        string3 = "Mercenary";
                        acrobatics += 4;
                        athletics += 6;
                        closeCombatUnarmed += 2;
                        expertiseStreetwise += 6;
                        insight += 4;
                        intimidation += 6;
                        perception += 4;
                        
                    }
                    else if (random.number0 == 2)
                    {
                        string3 = "Monastic";
                        acrobatics += 4;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        expertisePhilosophy += 6;
                        insight += 6;
                        perception += 6;
                        
                        treatment += 4;
                    }
                    else if (random.number0 == 3)
                    {
                        string3 = "Ninja";
                        acrobatics += 6;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        deception    += 4;
                        
                        perception += 4;
                        stealth += 6;
                        sleightOfHand += 6;
                    }
                    else
                    {
                        string3 = "Soldier";
                        acrobatics += 4;
                        athletics += 6;
                        closeCombatUnarmed += 2;
                        expertiseTactics += 4;
                        intimidation += 4;
                        perception += 4;
                        stealth += 4;
                        vehicles += 4;
                    }
                    #region powers

                    inv.Add(ItemData.CreateItem(100));
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(101));
                        random.QuadRandomX(6);
                       
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(600));
                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(601));
                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(602));
                        }
                        else if (random.number0 == 3)
                        {
                            inv.Add(ItemData.CreateItem(603));
                        }
                        else if (random.number0 == 4)
                        {
                            inv.Add(ItemData.CreateItem(604));
                        }
                        
                        else
                        {
                            inv.Add(ItemData.CreateItem(605));
                        }
                        if (random.number1 == 0)
                        {
                            inv.Add(ItemData.CreateItem(600));
                        }
                        else if (random.number1 == 1)
                        {
                            inv.Add(ItemData.CreateItem(601));
                        }
                        else if (random.number1 == 2)
                        {
                            inv.Add(ItemData.CreateItem(602));
                        }
                        else if (random.number1 == 3)
                        {
                            inv.Add(ItemData.CreateItem(603));
                        }
                        else if (random.number1 == 4)
                        {
                            inv.Add(ItemData.CreateItem(604));
                        }

                        else
                        {
                            inv.Add(ItemData.CreateItem(605));
                        }
                        if (random.number2 == 0)
                        {
                            inv.Add(ItemData.CreateItem(600));
                        }
                        else if (random.number2 == 1)
                        {
                            inv.Add(ItemData.CreateItem(601));
                        }
                        else if (random.number2 == 2)
                        {
                            inv.Add(ItemData.CreateItem(602));
                        }
                        else if (random.number2 == 3)
                        {
                            inv.Add(ItemData.CreateItem(603));
                        }
                        else if (random.number2 == 4)
                        {
                            inv.Add(ItemData.CreateItem(604));
                        }

                        else
                        {
                            inv.Add(ItemData.CreateItem(605));
                        }
                        if (random.number3 == 0)
                        {
                            inv.Add(ItemData.CreateItem(600));
                        }
                        else if (random.number3 == 1)
                        {
                            inv.Add(ItemData.CreateItem(601));
                        }
                        else if (random.number3 == 2)
                        {
                            inv.Add(ItemData.CreateItem(602));
                        }
                        else if (random.number3 == 3)
                        {
                            inv.Add(ItemData.CreateItem(603));
                        }
                        else if (random.number3 == 4)
                        {
                            inv.Add(ItemData.CreateItem(604));
                        }

                        else
                        {
                            inv.Add(ItemData.CreateItem(605));
                        }

                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(610));
                    }
                    
                    else
                    {
                        inv.Add(ItemData.CreateItem(611));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(620));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(621));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(622));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(623));
                    }
                    #endregion
                }
                else
                {
                    random.DoubleRandom5();
                    if (random.number0 == 0)
                    {
                        string2 = "Earth";
                        adv2 = new string[] { "Daze(Intimidation)", "Diehard", "Fearless", "Great Endurance" };
                    }

                    else if (random.number0 == 1)
                    {
                        string2 = "Fire";
                        adv2 = new string[] { "Extraordinary Effort", "Inspire", "Interpose", "Leadership" };
                    }
                    else if (random.number0 == 2)
                    {
                        string2 = "Metal";
                        adv2 = new string[] { "Beginner's Luck", "Eidetic Memory", "Luck", "Taunt" };
                    }
                    else if (random.number0 == 3)
                    {
                        string2 = "Water";
                        adv2 = new string[] { "Assessment", "Evasion", "Trance", "Uncanny Dodge" };
                    }
                    else
                    {
                        string2 = "Wood";
                        adv2 = new string[] { "Favoured Environment(Choose 1)", "Hide in Plain Sight", "Precise Attack (Close, Concealment)", "Teamwork" };
                    }
                    if (random.number1 == 0)
                    {
                        string3 = "Earth";
                        adv3 = new string[] { "Daze(Intimidation)", "Diehard", "Fearless", "Great Endurance" };
                    }

                    else if (random.number1 == 1)
                    {
                        string3 = "Fire";
                        adv3 = new string[] { "Extraordinary Effort", "Inspire", "Interpose", "Leadership" };
                    }
                    else if (random.number1 == 2)
                    {
                        string3 = "Metal";
                        adv3 = new string[] { "Beginner's Luck", "Eidetic Memory", "Luck", "Taunt" };
                    }
                    else if (random.number1 == 3)
                    {
                        string3 = "Water";
                        adv3 = new string[] { "Assessment", "Evasion", "Trance", "Uncanny Dodge" };
                    }
                    else
                    {
                        string3 = "Wood";
                        adv3 = new string[] { "Favoured Environment(Choose 1)", "Hide in Plain Sight", "Precise Attack (Close, Concealment)", "Teamwork" };
                    }
                    random.Random5();
                    if (random.number0 == 0)
                    {
                        string4 = "Agent";
                        acrobatics += 4;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        insight += 4;
                        investigation += 4;
                        perception += 4;
                        stealth += 6;
                        technology += 4;
                    }

                    else if (random.number0 == 1)
                    {
                        string4 = "Mercenary";
                        acrobatics += 4;
                        athletics += 6;
                        closeCombatUnarmed += 2;
                        expertiseStreetwise += 6;
                        insight += 4;
                        intimidation += 6;
                        perception += 4;

                    }
                    else if (random.number0 == 2)
                    {
                        string4 = "Monastic";
                        acrobatics += 4;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        expertisePhilosophy += 6;
                        insight += 6;
                        perception += 6;

                        treatment += 4;
                    }
                    else if (random.number0 == 3)
                    {
                        string4 = "Ninja";
                        acrobatics += 6;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        deception += 4;

                        perception += 4;
                        stealth += 6;
                        sleightOfHand += 6;
                    }
                    else
                    {
                        string4 = "Soldier";
                        acrobatics += 4;
                        athletics += 6;
                        closeCombatUnarmed += 2;
                        expertiseTactics += 4;
                        intimidation += 4;
                        perception += 4;
                        stealth += 4;
                        vehicles += 4;
                    }
                    random.Random5();
                    if (random.number0 == 0)
                    {
                        string5 = "Agent";
                        acrobatics += 4;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        insight += 4;
                        investigation += 4;
                        perception += 4;
                        stealth += 6;
                        technology += 4;
                    }

                    else if (random.number0 == 1)
                    {
                        string5 = "Mercenary";
                        acrobatics += 4;
                        athletics += 6;
                        closeCombatUnarmed += 2;
                        expertiseStreetwise += 6;
                        insight += 4;
                        intimidation += 6;
                        perception += 4;

                    }
                    else if (random.number0 == 2)
                    {
                        string5 = "Monastic";
                        acrobatics += 4;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        expertisePhilosophy += 6;
                        insight += 6;
                        perception += 6;

                        treatment += 4;
                    }
                    else if (random.number0 == 3)
                    {
                        string5 = "Ninja";
                        acrobatics += 6;
                        athletics += 4;
                        closeCombatUnarmed += 2;
                        deception += 4;

                        perception += 4;
                        stealth += 6;
                        sleightOfHand += 6;
                    }
                    else
                    {
                        string5 = "Soldier";
                        acrobatics += 4;
                        athletics += 6;
                        closeCombatUnarmed += 2;
                        expertiseTactics += 4;
                        intimidation += 4;
                        perception += 4;
                        stealth += 4;
                        vehicles += 4;
                    }
                }
               
                random.Random5();
                if (random.number0 == 0)
                {
                    string1 = "Crane";
                    adv1 = new string[] { "Defensive Attack", "Evasion", "Grabbing Finesse", "Improved Defence", "Improved Disarm", "Instant Up", "Move-by Action", "Redirect", "Set-up" };
                }

                else if (random.number0 == 1)
                {
                    string1 = "Dragon";
                    adv1 = new string[] { "Accurate Attack", "All-out Attack", "Defensive Attack", "Evasion", "Fast Grab", "Grabbing Finesse", "Improved Disarm", "Improved Trip", "Move-by Action" };
                }
                else if (random.number0 == 2)
                {
                    string1 = "Leopard";
                    adv1 = new string[] { "All-out Attack", "Improved Critical(Unarmed)", "Improved Initiative", "Improved Trip", "Move-by Action", "Seize Initative", "Skill Mastery(Acrobatics)", "Startle", "Takedown" };
                }
                else if (random.number0 == 3)
                {
                    string1 = "Snake";
                    adv1 = new string[] { "Chokehold", "Defensive Attack", "Fast Grab", "Grabbing Finesse", "Improved Disarm", "Improved Grab", "Improved Hold", "Prone Fighting", "Weapon Bind" };
                }
                else
                {
                    string1 = "Tiger";
                    adv1 = new string[] { "All-out Attack", "Defensive Attack", "Improved Critical (Unarmed)", "Improved Smash", "Move-by Action", "Skill Mastery(Athletics)", "Startle", "Takedown", "Weapon Break" };
                }
                
                background0.text = string0 + ", " + string1 + ", " + string2;
                background1.text = string3 + ", " + string4 + ", " + string5;
                Dodge += Agility + 6;
                Parry += Fighting + 0;
                Fortitude += Stamina + 6;
                Toughness += Stamina + 0;
                Will += Awareness + 5;
                Initiative += Agility;
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
                random.TripleRandom7();
                if (random.number0 == 0)
                {
                    string0 = "Complementary";
                    adv0 = new string[] { "Setup", "Teamwork" };
                }

                else if (random.number0 == 1)
                {
                    string0 = "Discerning";
                    adv0 = new string[] { "Assessment", "Skill Mastery(Insight)" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Engramatic";
                    adv0 = new string[] { "Eidetic Memory", "Jack-of-all-trades" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Innocent";
                    adv0 = new string[] { "Animal Empathy", "Luck" };
                }
                else if (random.number0 == 4)
                {
                    string0 = "Incisive";
                    adv0 = new string[] { "Daze(Deception)", "Taunt" };
                }
                else if (random.number0 == 5)
                {
                    string0 = "Spontaneous";
                    adv0 = new string[] { "Improved Initiative", "Uncanny Dodge" };
                }
                else
                {
                    string0 = "Subtle";
                    adv0 = new string[] { "Evasion", "Hide in Plain Sight" };
                }
                if (random.number1 == 0)
                {
                    string1 = "Complementary";
                    adv1 = new string[] { "Setup", "Teamwork" };
                }

                else if (random.number1 == 1)
                {
                    string1 = "Discerning";
                    adv1 = new string[] { "Assessment", "Skill Mastery(Insight)" };
                }
                else if (random.number1 == 2)
                {
                    string1 = "Engramatic";
                    adv1 = new string[] { "Eidetic Memory", "Jack-of-all-trades" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Innocent";
                    adv1 = new string[] { "Animal Empathy", "Luck" };
                }
                else if (random.number1 == 4)
                {
                    string1 = "Incisive";
                    adv1 = new string[] { "Daze(Deception)", "Taunt" };
                }
                else if (random.number1 == 5)
                {
                    string1 = "Spontaneous";
                    adv1 = new string[] { "Improved Initiative", "Uncanny Dodge" };
                }
                else
                {
                    string1 = "Subtle";
                    adv1 = new string[] { "Evasion", "Hide in Plain Sight" };
                }
                if (random.number2 == 0)
                {
                    string2 = "Complementary";
                    adv2 = new string[] { "Setup", "Teamwork" };
                }

                else if (random.number2 == 1)
                {
                    string2 = "Discerning";
                    adv2 = new string[] { "Assessment", "Skill Mastery(Insight)" };
                }
                else if (random.number2 == 2)
                {
                    string2 = "Engramatic";
                    adv2 = new string[] { "Eidetic Memory", "Jack-of-all-trades" };
                }
                else if (random.number2 == 3)
                {
                    string2 = "Innocent";
                    adv2 = new string[] { "Animal Empathy", "Luck" };
                }
                else if (random.number2 == 4)
                {
                    string2 = "Incisive";
                    adv2 = new string[] { "Daze(Deception)", "Taunt" };
                }
                else if (random.number2 == 5)
                {
                    string2 = "Spontaneous";
                    adv2 = new string[] { "Improved Initiative", "Uncanny Dodge" };
                }
                else
                {
                    string2 = "Subtle";
                    adv2 = new string[] { "Evasion", "Hide in Plain Sight" };
                }
                random.Random6();
                if (random.number0 == 0)
                {
                    string3 = "Dynamic";
                    athletics += 6;
                    acrobatics += 6;
                }

                else if (random.number0 == 1)
                {
                    string3 = "Empathic";
                    insight += 8;
                    persuasion += 4;
                }
                else if (random.number0 == 2)
                {
                    string3 = "Furtive";
                    deception += 6;
                    stealth += 6;
                }
                else if (random.number0 == 3)
                {
                    string3 = "Inscrutable";
                    deception += 8;
                    perception += 4;
                }
                else if (random.number0 == 4)
                {
                    string3 = "Observant";
                    insight += 6;
                    perception += 6;
                }
                
                else
                {
                    string3 = "Sponge";
                    expertiseCurrentEvents += 4;
                    expertisePopCulture += 4;
                    investigation += 4;
                }
                random.Random6();
                if (random.number0 == 0)
                {
                    string4 = "Dynamic";
                    athletics += 6;
                    acrobatics += 6;
                }

                else if (random.number0 == 1)
                {
                    string4 = "Empathic";
                    insight += 8;
                    persuasion += 4;
                }
                else if (random.number0 == 2)
                {
                    string4 = "Furtive";
                    deception += 6;
                    stealth += 6;
                }
                else if (random.number0 == 3)
                {
                    string4 = "Inscrutable";
                    deception += 8;
                    perception += 4;
                }
                else if (random.number0 == 4)
                {
                    string4 = "Observant";
                    insight += 6;
                    perception += 6;
                }

                else
                {
                    string4 = "Sponge";
                    expertiseCurrentEvents += 4;
                    expertisePopCulture += 4;
                    investigation += 4;
                }
                #region powers
                
                random.RandomX(10);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(700));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(701));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(702));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(703));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(704));
                }
                else if (random.number0 == 6)
                {
                    inv.Add(ItemData.CreateItem(705));
                }
                else if (random.number0 == 7)
                {
                    inv.Add(ItemData.CreateItem(706));
                }
                else if (random.number0 == 8)
                {
                    inv.Add(ItemData.CreateItem(707));
                }
                else if (random.number0 == 9)
                {
                    inv.Add(ItemData.CreateItem(708));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(708));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                background1.text = string3 + ", " + string4 + ", " + string5;
                Dodge += Agility + 5;
                Parry += Fighting + 5;
                Fortitude += Stamina + 5;
                Toughness += Stamina + 0;
                Will += Awareness + 5;
                Initiative += Agility;
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
                
                random.Random4();
                if (random.number0 == 0)
                {
                    string0 = "Centered";
                    adv0 = new string[] { "Fearless", "Ultimate Effort(Will checks)" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Enchanter";
                    adv0 = new string[] { "Artificer", "Skill Mastery(Expertise: Magic)" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Powerful Connection";
                    adv0 = new string[] { "Accurate Attack", "Power Attack" };
                }
                
                else
                {
                    string0 = "Student Of The Arts";
                    adv0 = new string[] { "Ritualist", "Well-informed" };
                }
                adv1 = new string[] { "Equipment 3 (Headquarters)", "Ranged Attack 5", "Trance" };
                expertiseMagic += 10;
                insight += 6;
                perception += 4;
                random.Random3();
                if (random.number0 == 0)
                {
                    string1 = "Affecting Presence";
                    intimidation += 4;
                    persuasion += 4;
                }
                else if (random.number0 == 1)
                {
                    string1 = "Occult Investigator";
                    investigation += 4;
                    sleightOfHand += 4;
                }
                
                else
                {
                    string1 = "Prestidigitator";
                    deception += 4;
                    sleightOfHand += 4;
                }
                #region powers
                inv.Add(ItemData.CreateItem(800));
                inv.Add(ItemData.CreateItem(811));
                inv.Add(ItemData.CreateItem(812));
                random.QuinRandomX(10);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(801));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(802));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(803));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(804));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(805));
                }
                else if (random.number0 == 6)
                {
                    inv.Add(ItemData.CreateItem(806));
                }
                else if (random.number0 == 7)
                {
                    inv.Add(ItemData.CreateItem(807));
                }
                else if (random.number0 == 8)
                {
                    inv.Add(ItemData.CreateItem(808));
                }
                else if (random.number0 == 9)
                {
                    inv.Add(ItemData.CreateItem(809));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(810));
                }
                if (random.number1 == 0)
                {
                    inv.Add(ItemData.CreateItem(801));
                }
                else if (random.number1 == 1)
                {
                    inv.Add(ItemData.CreateItem(802));
                }
                else if (random.number1 == 2)
                {
                    inv.Add(ItemData.CreateItem(803));
                }
                else if (random.number1 == 4)
                {
                    inv.Add(ItemData.CreateItem(804));
                }
                else if (random.number1 == 5)
                {
                    inv.Add(ItemData.CreateItem(805));
                }
                else if (random.number1 == 6)
                {
                    inv.Add(ItemData.CreateItem(806));
                }
                else if (random.number1 == 7)
                {
                    inv.Add(ItemData.CreateItem(807));
                }
                else if (random.number1 == 8)
                {
                    inv.Add(ItemData.CreateItem(808));
                }
                else if (random.number1 == 9)
                {
                    inv.Add(ItemData.CreateItem(809));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(810));
                }
                if (random.number2 == 0)
                {
                    inv.Add(ItemData.CreateItem(801));
                }
                else if (random.number2 == 1)
                {
                    inv.Add(ItemData.CreateItem(802));
                }
                else if (random.number2 == 2)
                {
                    inv.Add(ItemData.CreateItem(803));
                }
                else if (random.number2 == 4)
                {
                    inv.Add(ItemData.CreateItem(804));
                }
                else if (random.number2 == 5)
                {
                    inv.Add(ItemData.CreateItem(805));
                }
                else if (random.number2 == 6)
                {
                    inv.Add(ItemData.CreateItem(806));
                }
                else if (random.number2 == 7)
                {
                    inv.Add(ItemData.CreateItem(807));
                }
                else if (random.number2 == 8)
                {
                    inv.Add(ItemData.CreateItem(808));
                }
                else if (random.number2 == 9)
                {
                    inv.Add(ItemData.CreateItem(809));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(810));
                }
                if (random.number3 == 0)
                {
                    inv.Add(ItemData.CreateItem(801));
                }
                else if (random.number3 == 1)
                {
                    inv.Add(ItemData.CreateItem(802));
                }
                else if (random.number3 == 2)
                {
                    inv.Add(ItemData.CreateItem(803));
                }
                else if (random.number3 == 4)
                {
                    inv.Add(ItemData.CreateItem(804));
                }
                else if (random.number3 == 5)
                {
                    inv.Add(ItemData.CreateItem(805));
                }
                else if (random.number3 == 6)
                {
                    inv.Add(ItemData.CreateItem(806));
                }
                else if (random.number3 == 7)
                {
                    inv.Add(ItemData.CreateItem(807));
                }
                else if (random.number3 == 8)
                {
                    inv.Add(ItemData.CreateItem(808));
                }
                else if (random.number3 == 9)
                {
                    inv.Add(ItemData.CreateItem(809));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(810));
                }
                if (random.number4 == 0)
                {
                    inv.Add(ItemData.CreateItem(801));
                }
                else if (random.number4 == 1)
                {
                    inv.Add(ItemData.CreateItem(802));
                }
                else if (random.number4 == 2)
                {
                    inv.Add(ItemData.CreateItem(803));
                }
                else if (random.number4 == 4)
                {
                    inv.Add(ItemData.CreateItem(804));
                }
                else if (random.number4 == 5)
                {
                    inv.Add(ItemData.CreateItem(805));
                }
                else if (random.number4 == 6)
                {
                    inv.Add(ItemData.CreateItem(806));
                }
                else if (random.number4 == 7)
                {
                    inv.Add(ItemData.CreateItem(807));
                }
                else if (random.number4 == 8)
                {
                    inv.Add(ItemData.CreateItem(808));
                }
                else if (random.number4 == 9)
                {
                    inv.Add(ItemData.CreateItem(809));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(810));
                }
                random.RandomX(3);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(801));
                    random.TripleRandomX(8);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(820));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(821));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(822));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(823));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(824));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(825));
                    }
                    else if (random.number0 == 7)
                    {
                        inv.Add(ItemData.CreateItem(826));
                    }
                   
                    else
                    {
                        inv.Add(ItemData.CreateItem(827));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(820));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(821));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(822));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(823));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(824));
                    }
                    else if (random.number1 == 6)
                    {
                        inv.Add(ItemData.CreateItem(825));
                    }
                    else if (random.number1 == 7)
                    {
                        inv.Add(ItemData.CreateItem(826));
                    }

                    else
                    {
                        inv.Add(ItemData.CreateItem(827));
                    }
                    if (random.number2 == 0)
                    {
                        inv.Add(ItemData.CreateItem(820));
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(821));
                    }
                    else if (random.number2 == 2)
                    {
                        inv.Add(ItemData.CreateItem(822));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(823));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(824));
                    }
                    else if (random.number2 == 6)
                    {
                        inv.Add(ItemData.CreateItem(825));
                    }
                    else if (random.number2 == 7)
                    {
                        inv.Add(ItemData.CreateItem(826));
                    }

                    else
                    {
                        inv.Add(ItemData.CreateItem(827));
                    }
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(830));
                }
                
                else
                {
                    inv.Add(ItemData.CreateItem(831));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 7;
                Parry += Fighting + 4;
                Fortitude += Stamina + 6;
                Toughness += Stamina + 0;
                Will += Awareness + 7;
                Initiative += Agility;
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
                    Dodge += Agility + 4;
                    Parry += Fighting + 4;
                    Fortitude += Stamina + 4;
                    Toughness += Stamina + 0;
                    Will += Awareness + 6;
                    Initiative += Agility;
                    inv.Add(ItemData.CreateItem(900));
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
                    Dodge += Agility + 4;
                    Parry += Fighting + 0;
                    Fortitude += Stamina + 2;
                    Toughness += Stamina + 0;
                    Will += Awareness + 6;
                    Initiative += Agility;
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(901));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(902));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(903));
                    }
                    random.RandomX(6);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(930));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(931));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(932));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(933));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(934));
                    }
                   
                    else
                    {
                        inv.Add(ItemData.CreateItem(935));
                    }
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
                    Dodge += Agility + 4;
                    Parry += Fighting + 0;
                    Fortitude += Stamina + 2;
                    Toughness += Stamina + 0;
                    Will += Awareness + 6;
                    Initiative += Agility;
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(901));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(902));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(903));
                    }
                    random.RandomX(6);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(930));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(931));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(932));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(933));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(934));
                    }

                    else
                    {
                        inv.Add(ItemData.CreateItem(935));
                    }
                }
                random.Random6();
                if (random.number0 == 0)
                {
                    string0 = "Athlete";
                    adv0 = new string[] { "Extraordinary Effort", "Improved Initiative", "Power Attack", "Uncanny Dodge" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Leader";
                    adv0 = new string[] { "Inspire 2", "Leadership", "Teamwork" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Lucky";
                    adv0 = new string[] { "Beginner's Luck", "Luck 2", "Redirect" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Resources";
                    adv0 = new string[] { "Equipment 4(Headquarters)" };
                }
                else if (random.number0 == 4)
                {
                    string0 = "Warrior";
                    adv0 = new string[] { "All-out Attack", "Improved Initiative", "Interpose", "Move-by Action" };
                }
                else
                {
                    string0 = "Wealthy";
                    adv0 = new string[] { "Benefit 4 (Multi-millionaire)" };
                }
                random.DoubleRandom4();
                if (random.number0 == 0)
                {
                    string1 = "Athlete";
                    acrobatics += 6;
                    athletics += 6;
                    perception += 4;
                }
                else if (random.number0 == 1)
                {
                    string1 = "Broad Training";
                    ExpertiseChoose(4);
                    
                    insight += 2;
                    perception += 2;
                    persuasion += 4;
                    rangedCombatThrowing += 4;
                }
                else if (random.number0 == 2)
                {
                    string1 = "Charismatic";
                    ExpertiseChoose(4);
                    insight += 4;
                    persuasion += 4;
                    perception += 4;
                }
              
                else
                {
                    string1 = "Learned";
                    ExpertiseChoose(6);

                    technology += 4;
                    perception += 4;
                }
                if (random.number1 == 0)
                {
                    string2 = "Athlete";
                    acrobatics += 6;
                    athletics += 6;
                    perception += 4;
                }
                else if (random.number1 == 1)
                {
                    string2 = "Broad Training";
                    ExpertiseChoose(4);
                    insight += 2;
                    perception += 2;
                    persuasion += 4;
                    rangedCombatThrowing += 4;
                }
                else if (random.number1 == 2)
                {
                    string2 = "Charismatic";
                    ExpertiseChoose(4);
                    insight += 4;
                    persuasion += 4;
                    perception += 4;
                }

                else
                {
                    string2 = "Learned";
                    ExpertiseChoose(6);

                    technology += 4;
                    perception += 4;
                }
                #region powers
                
                inv.Add(ItemData.CreateItem(910));
                inv.Add(ItemData.CreateItem(911));
                random.RandomX(2);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(920));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(921));
                }

                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
               
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
                random.DoubleRandom7();
                if (random.number0 == 0)
                {
                    string0 = "Driven";
                    adv0 = new string[] { "Extraordinary Effort" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Fighter";
                    random.AltRandom2();
                    if (random.number5 == 0)
                    {
                        adv0 = new string[] { "All-out Attack" };
                    }
                    else
                    {


                        adv0 = new string[] { "Accurate Attack" };
                    }
                }
                else if (random.number0 == 2)
                {
                    string0 = "Good With Crowds";
                    adv0 = new string[] { "Takedown" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Popular";
                    adv0 = new string[] { "Connected" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Team Player";
                    adv0 = new string[] { "Interpose" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Tough";
                    adv0 = new string[] { "Ultimate Effort(Toughness checks)" };
                }
                else
                {
                    string0 = "Quick";
                    adv0 = new string[] { "Improved Initiative" };
                }
                if (random.number1 == 0)
                {
                    string1 = "Driven";
                    adv1 = new string[] { "Extraordinary Effort" };
                }
                else if (random.number1 == 1)
                {
                    string1 = "Fighter";
                    random.AltRandom2();
                    if (random.number5 == 0)
                    {
                        adv1 = new string[] { "All-out Attack" };
                    }
                    else
                    {


                        adv1 = new string[] { "Accurate Attack" };
                    }
                }
                else if (random.number1 == 2)
                {
                    string1 = "Good With Crowds";
                    adv1 = new string[] { "Takedown" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Popular";
                    adv1 = new string[] { "Connected" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Team Player";
                    adv1 = new string[] { "Interpose" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Tough";
                    adv1 = new string[] { "Ultimate Effort(Toughness checks)" };
                }
                else
                {
                    string1 = "Quick";
                    adv1 = new string[] { "Improved Initiative" };
                }
                closeCombatUnarmed += 2;
                random.DoubleRandom5();
                if (random.number0 == 0)
                {
                    string2 = "Athlete";
                    rangedCombatThrowing += 4;
                    athletics += 4;
                    perception += 4;
                }
                else if (random.number0 == 1)
                {
                    string2 = "Ex-Military";
                    rangedCombatThrowing += 4;
                    expertiseMilitary += 4;
                    perception += 4;
                }
                else if (random.number0 == 2)
                {
                    string2 = "Charmer";
                    deception += 4;
                    insight += 4;
                    persuasion += 4;
                }
                else if (random.number0 == 3)
                {
                    string2 = "Rough Upbringing";
                    expertiseStreetwise += 4;
                    intimidation += 6;
                    perception += 2;
                }
                else
                {
                    string2 = "Sharp Mind";
                    ExpertiseChoose(4);
                    insight += 4;
                    perception += 4;
                }
                if (random.number1 == 0)
                {
                    string3 = "Athlete";
                    rangedCombatThrowing += 4;
                    athletics += 4;
                    perception += 4;
                }
                else if (random.number1 == 1)
                {
                    string3 = "Ex-Military";
                    rangedCombatThrowing += 4;
                    expertiseMilitary += 4;
                    perception += 4;
                }
                else if (random.number1 == 2)
                {
                    string3 = "Charmer";
                    deception += 4;
                    insight += 4;
                    persuasion += 4;
                }
                else if (random.number1 == 3)
                {
                    string3 = "Rough Upbringing";
                    expertiseStreetwise += 4;
                    intimidation += 6;
                    perception += 2;
                }
                else
                {
                    string3 = "Sharp Mind";
                    ExpertiseChoose(4);
                    insight += 4;
                    perception += 4;
                }
                #region powers
                
                random.RandomX(4);
                if (random.number0 == 0)
                {
                    //density
                    inv.Add(ItemData.CreateItem(1000));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                       inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                }
                else if (random.number0 == 1)
                {
                    //growth
                    inv.Add(ItemData.CreateItem(1001));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                }
                else if (random.number0 == 2)
                {
                    //solid form
                    inv.Add(ItemData.CreateItem(1002));
                    inv.Add(ItemData.CreateItem(1020));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                }
                
                else
                {
                    //super strength
                    inv.Add(ItemData.CreateItem(1003));
                    inv.Add(ItemData.CreateItem(1020));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1021));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1022));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1023));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1024));
                    }
                }
                random.RandomX(4);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1000));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1001));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1002));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1003));
                }
                random.DoubleRandomX(7);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1010));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1011));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1012));
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1013));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(1014));
                    inv.Add(ItemData.CreateItem(1015));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(1016));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1017));
                }
                if (random.number1 == 0)
                {
                    inv.Add(ItemData.CreateItem(1010));
                }
                else if (random.number1 == 1)
                {
                    inv.Add(ItemData.CreateItem(1011));
                }
                else if (random.number1 == 2)
                {
                    inv.Add(ItemData.CreateItem(1012));
                }
                else if (random.number1 == 3)
                {
                    inv.Add(ItemData.CreateItem(1013));
                }
                else if (random.number1 == 4)
                {
                    inv.Add(ItemData.CreateItem(1014));
                    inv.Add(ItemData.CreateItem(1015));
                }
                else if (random.number1 == 5)
                {
                    inv.Add(ItemData.CreateItem(1016));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1017));
                }
                random.RandomX(6);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1044));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1030));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1031));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1032));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1034));
                    }
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1045));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1030));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1031));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1032));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1034));
                    }
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1044));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1040));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1041));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1042));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1043));
                    }
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1046));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1030));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1031));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1032));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1034));
                    }
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(1047));
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1030));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1031));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1032));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1034));
                    }
                }
                else
                {
                   
                    
                        inv.Add(ItemData.CreateItem(1048));
                        random.RandomX(4);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(1030));
                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(1031));
                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(1032));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(1034));
                        }
                    
                }
                
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                background1.text = string3 + ", " + string4 + ", " + string5;
                Dodge += Agility + 5;
                Parry += Fighting + 0;
                Fortitude += Stamina + 0;
                Toughness += Stamina + 0;
                Will += Awareness + 5;
                Initiative += Agility;
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
                random.Random5();
                if (random.number0 == 0)
                {
                    string0 = "Charmed Life";
                    adv0 = new string[] { "Attractive", "Fascinate(Persuasion)", "Luck" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Contemplative";
                    adv0 = new string[] { "Fearless", "Trance", "Ultimate Effort(Will checks)" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Perfect Mind";
                    adv0 = new string[] { "Eidetic Memory", "Jack-of-all-trades", "Ultimate Effort(Will checks)" };
                }
                else if (random.number0 == 3)
                {
                    random.Random3();
                    string0 = "Thought Leader";
                    if (random.number0 == 0)
                    {
                       
                        adv0 = new string[] { "Inspire", "Leadership", "Teamwork" };
                    }
                    else if (random.number0 == 1)
                    {
                        
                        adv0 = new string[] { "Inspire 2", "Leadership" };
                    }
                    else
                    {
                        
                        adv0 = new string[] { "Inspire 2", "Teamwork" };
                    }
                    
                }
                else
                {
                    string0 = "Trained Fighter";
                    adv0 = new string[] { "Improved Initiative", "Power Attack", "Uncanny Dodge" };
                }
                random.DoubleRandom5();
                if (random.number0 == 0)
                {
                    string1 = "Charmer";
                    deception += 4;
                    insight += 4;
                    persuasion += 4;
                }
                else if (random.number0 == 1)
                {
                    string1 = "Dabbler";
                    ExpertiseChoose(4);
                    insight += 4;
                    perception += 4;
                }
                else if (random.number0 == 2)
                {
                    string1 = "Ninja";
                    acrobatics += 4;
                    perception += 4;
                    stealth += 4;
                }
                else if (random.number0 == 3)
                {
                    string1 = "Sneak";
                    deception += 4;
                    perception += 4;
                    stealth += 4;
                }
                else
                {
                    string1 = "Student";
                    ExpertiseChoose(6);
                    insight += 2;
                    perception += 4;
                }
                if (random.number1 == 0)
                {
                    string2 = "Charmer";
                    deception += 4;
                    insight += 4;
                    persuasion += 4;
                }
                else if (random.number1 == 1)
                {
                    string2 = "Dabbler";
                    ExpertiseChoose(4);
                    insight += 4;
                    perception += 4;
                }
                else if (random.number1 == 2)
                {
                    string2 = "Ninja";
                    acrobatics += 4;
                    perception += 4;
                    stealth += 4;
                }
                else if (random.number1 == 3)
                {
                    string2 = "Sneak";
                    deception += 4;
                    perception += 4;
                    stealth += 4;
                }
                else
                {
                    string2 = "Student";
                    ExpertiseChoose(6);
                    insight += 2;
                    perception += 4;
                }
                #region powers
                
                random.RandomX(3);
                
                if (random.number0 == 0)
                {
                    //psionic
                    inv.Add(ItemData.CreateItem(1100));
                    random.TripleRandomX(6);

                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1101));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1102));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1103));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1104));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1105));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1106));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1101));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1102));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1103));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1104));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1105));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1106));
                    }
                    if (random.number2 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1101));
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1102));
                    }
                    else if (random.number2 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1103));
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1104));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1105));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1106));
                    }
                }
                else if (random.number0 == 1)
                {
                    //mentalist
                    inv.Add(ItemData.CreateItem(1110));
                    random.TripleRandomX(7);

                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1111));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1112));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1113));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1114));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1115));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1116));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1117));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1111));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1112));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1113));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1114));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1115));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1116));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1117));
                    }
                    if (random.number2 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1111));
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1112));
                    }
                    else if (random.number2 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1113));
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1114));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1115));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1116));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1117));
                    }
                }
               
                else
                {
                    //Telekinetic
                    inv.Add(ItemData.CreateItem(1120));
                    random.TripleRandomX(7);

                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1121));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1122));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1123));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1124));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1125));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1126));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1127));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1121));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1122));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1123));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1124));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1125));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1126));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1127));
                    }
                    if (random.number2 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1121));
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1122));
                    }
                    else if (random.number2 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1123));
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1124));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1125));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1126));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1127));
                    }
                }
                random.RandomX(4);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1130));
                    inv.Add(ItemData.CreateItem(1131));
                    inv.Add(ItemData.CreateItem(1132));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1133));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1134));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1135));
                }
                random.RandomX(9);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1140));
                    
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1141));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1142));
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1143));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(1144));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(1145));
                }
                else if (random.number0 == 6)
                {
                    inv.Add(ItemData.CreateItem(1146));
                }
                else if (random.number0 == 7)
                {
                    inv.Add(ItemData.CreateItem(1147));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1148));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 6;
                Parry += Fighting + 4;
                Fortitude += Stamina + 5;
                Toughness += Stamina + 0;
                Will += Awareness + 8;
                Initiative += Agility;
            }
            else if (Archetype[i] == "Shapeshifter")
            {
                subArchetypes = new string[] { "Everyman", "Whiz" };
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
                random.Random5();
                if (random.number0 == 0)
                {
                    string0 = "Fact Reaction Speed";
                    adv0 = new string[] { "Evasion", "Improved Initiative" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Inventor";
                    adv0 = new string[] { "Inventor", "Skill Mastery (Choose 1)" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Smart Alec";
                    adv0 = new string[] { "Daze(Deception)", "Taunt" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Spontaneous";
                    adv0 = new string[] { "Improved Initiative", "Uncanny Dodge" };
                }
                else
                {
                    string0 = "Wealthy";
                    adv0 = new string[] { "Benefit 2(Independently Wealthy)" };
                }
                adv1 = new string[] { "Defensive Roll 3", "Move-by Action" };
                closeCombatUnarmed += 8;
                random.Random5();
                if (random.number0 == 0)
                {
                    string1 = "Adventurer";
                    athletics += 4;
                    ExpertiseChoose(4);
                    perception += 4;
                }
                else if (random.number0 == 1)
                {
                    string1 = "Explorer";
                    athletics += 4;
                    stealth += 2;
                    perception += 6;
                }
                else if (random.number0 == 2)
                {
                    string1 = "Infiltrator";
                    deception += 5;
                    stealth += 3;
                    technology += 4;
                }
                else if (random.number0 == 3)
                {
                    string1 = "Investigator";
                    insight += 4;
                    investigation += 4;
                    perception += 4;
                }
                else
                {
                    string1 = "Researcher";
                    ExpertiseChoose(6);

                    technology += 6;
                }
                random.Random5();
                if (random.number0 == 0)
                {
                    string2 = "Adventurer";
                    athletics += 4;
                    ExpertiseChoose(4);
                    perception += 4;
                }
                else if (random.number0 == 1)
                {
                    string2 = "Explorer";
                    athletics += 4;
                    stealth += 2;
                    perception += 6;
                }
                else if (random.number0 == 2)
                {
                    string2 = "Infiltrator";
                    deception += 5;
                    stealth += 3;
                    technology += 4;
                }
                else if (random.number0 == 3)
                {
                    string2 = "Investigator";
                    insight += 4;
                    investigation += 4;
                    perception += 4;
                }
                else
                {
                    string2 = "Researcher";
                    ExpertiseChoose(6);

                    technology += 6;
                }
                #region powers
                random.RandomX(5);
                if (random.number0 == 0)
                {
                    //shapeshifter
                    inv.Add(ItemData.CreateItem(1200));
                }
                else if (random.number0 == 1)
                {
                    //size-changer
                    
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        //giant
                        inv.Add(ItemData.CreateItem(1211));
                        inv.Add(ItemData.CreateItem(1212));
                        inv.Add(ItemData.CreateItem(1213));
                        inv.Add(ItemData.CreateItem(1214));
                    }
                    
                    else
                    {
                        //shrinking
                        inv.Add(ItemData.CreateItem(1220));
                        inv.Add(ItemData.CreateItem(1221));
                        inv.Add(ItemData.CreateItem(1222));
                        inv.Add(ItemData.CreateItem(1223));
                    }
                }
                else if (random.number0 == 2)
                {
                    //density changer
                    
                    random.RandomX(5);
                    if (random.number0 == 0)
                    {
                        //increase
                        inv.Add(ItemData.CreateItem(1230));
                        inv.Add(ItemData.CreateItem(1231));
                        inv.Add(ItemData.CreateItem(1232));
                        inv.Add(ItemData.CreateItem(1233));
                        inv.Add(ItemData.CreateItem(1234));
                        inv.Add(ItemData.CreateItem(1235));
                        inv.Add(ItemData.CreateItem(1236));
                    }
                  
                    else
                    {
                        //decrease
                        inv.Add(ItemData.CreateItem(1240));
                        inv.Add(ItemData.CreateItem(1241));
                        inv.Add(ItemData.CreateItem(1242));
                        inv.Add(ItemData.CreateItem(1243));
                        inv.Add(ItemData.CreateItem(1244));
                        inv.Add(ItemData.CreateItem(1245));
                        inv.Add(ItemData.CreateItem(1246));
                    }
                }
                else if (random.number0 == 4)
                {
                    //specific shapeshifter
                    inv.Add(ItemData.CreateItem(1201));
                }
               
                else
                {
                    //stretcher
                    inv.Add(ItemData.CreateItem(1250));
                    inv.Add(ItemData.CreateItem(1251));
                    inv.Add(ItemData.CreateItem(1252));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 6;
                Parry += Fighting + 6;
                Fortitude += Stamina + 6;
                Toughness += Stamina + 0;
                Will += Awareness + 6;
                Initiative += Agility;
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
                random.Random4();
                if (random.number0 == 0)
                {
                    string0 = "Fighter";
                    adv0 = new string[] { "Close Attack 2", "Equipment (Sword or other melee weapon)" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Nimble";
                    adv0 = new string[] { "Evasion", "Instant Up", "Move-by Action" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Prodigy";
                    adv0 = new string[] { "Beginners' Luck", "Eidetic Memory", "Well-informed" };
                }
               
                else
                {
                    string0 = "Team Player";
                    adv0 = new string[] { "Interpose", "Set-up", "Teamwork" };
                }
                random.Random5();
                if (random.number0 == 0)
                {
                    string1 = "Athlete";
                    acrobatics += 4;
                    athletics += 8;
                    perception += 4;
                }
                else if (random.number0 == 1)
                {
                    string1 = "Charmer";
                    deception += 6;
                    insight += 4;
                    persuasion += 6;
                }
                else if (random.number0 == 2)
                {
                    string1 = "Police";
                    insight += 4;
                    investigation += 6;
                    perception += 6;
                }
                else if (random.number0 == 3)
                {
                    string1 = "Scientist";
                    ExpertiseChoose(6);
                    technology += 6;
                    vehicles += 4;
                }
                else
                {
                    string1 = "Thief";
                    deception += 4;
                    stealth += 6;
                    technology += 6;
                }
                random.Random5();
                if (random.number0 == 0)
                {
                    string2 = "Athlete";
                    acrobatics += 4;
                    athletics += 8;
                    perception += 4;
                }
                else if (random.number0 == 1)
                {
                    string2 = "Charmer";
                    deception += 6;
                    insight += 4;
                    persuasion += 6;
                }
                else if (random.number0 == 2)
                {
                    string2 = "Police";
                    insight += 4;
                    investigation += 6;
                    perception += 6;
                }
                else if (random.number0 == 3)
                {
                    string2 = "Scientist";
                    ExpertiseChoose(6);
                    technology += 6;
                    vehicles += 4;
                }
                else
                {
                    string2 = "Thief";
                    deception += 4;
                    stealth += 6;
                    technology += 6;
                }
                #region powers


                random.RandomX(3);
                
                if (random.number0 == 0)
                {
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1300));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1301));
                    }
                    
                    else
                    {
                        inv.Add(ItemData.CreateItem(1302));
                    }
                }
                else if (random.number0 == 1)
                {
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1303));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1304));
                    }

                    else
                    {
                        inv.Add(ItemData.CreateItem(1305));
                    }
                }
                
                else
                {
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1306));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1307));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1308));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1309));
                    }
                }
                random.DoubleRandomX(6);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1310));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1311));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1312));
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1313));
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1314));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1315));
                }
                if (random.number1 == 0)
                {
                    inv.Add(ItemData.CreateItem(1310));
                }
                else if (random.number1 == 1)
                {
                    inv.Add(ItemData.CreateItem(1311));
                }
                else if (random.number1 == 2)
                {
                    inv.Add(ItemData.CreateItem(1312));
                }
                else if (random.number1 == 3)
                {
                    inv.Add(ItemData.CreateItem(1313));
                }
                else if (random.number1 == 3)
                {
                    inv.Add(ItemData.CreateItem(1314));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1315));
                }
                random.RandomX(4);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1316));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1317));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1318));
                }
               
                else
                {
                    inv.Add(ItemData.CreateItem(1319));
                }
                random.RandomX(4);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1320));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1321));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1322));
                }

                else
                {
                    inv.Add(ItemData.CreateItem(1323));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 0;
                Parry += Fighting + 0;
                Fortitude += Stamina + 7;
                Toughness += Stamina + 0;
                Will += Awareness + 7;
                Initiative += Agility;
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
                    random.Random3();
                    if (random.number0 == 0)
                    {
                       
                        adv0 = new string[] { "Defensive Roll 4", "Artificer" };
                    }
                    else if (random.number0 == 1)
                    {

                        adv0 = new string[] { "Defensive Roll 4", "Ritualist" };
                    }
                   

                    else
                    {

                        adv0 = new string[] { "Defensive Roll 4", "Inventor" };
                    }
                    perception += 4;
                    stealth += 4;
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        expertiseMagic += 6;
                    }
                    else
                    {
                        technology += 6;
                    }
                    #region powers
                    
                    random.RandomX(8);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(101));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(102));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(103));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(104));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(105));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(106));
                    }
                    else if (random.number0 == 7)
                    {
                        inv.Add(ItemData.CreateItem(107));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(108));
                    }
                    #endregion
                    Dodge += Agility + 10;
                    Parry += Fighting + 8;
                    Fortitude += Stamina + 4;
                    Toughness += Stamina + 0;
                    Will += Awareness + 7;
                    Initiative += Agility;
                }

                
                background0.text = string0 + ", " + string1 + ", " + string2;
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
                    Dodge += Agility + 7;
                    Parry += Fighting + 2;
                    Fortitude += Stamina + 5;
                    Toughness += Stamina + 0;
                    Will += Awareness + 6;
                    Initiative += Agility;
                    #region powers

                    random.DoubleRandomX(6);
                    inv.Add(ItemData.CreateItem(1503));
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1510));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1511));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1512));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1513));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1514));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1515));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1510));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1511));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1512));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1513));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1514));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1515));
                    }
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1516));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1517));
                    }
                    
                    else
                    {
                        random.TripleRandomX(8);
                        
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(1520));
                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(1521));
                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(1522));
                        }
                        else if (random.number0 == 3)
                        {
                            inv.Add(ItemData.CreateItem(1523));
                        }
                        else if (random.number0 == 4)
                        {
                            inv.Add(ItemData.CreateItem(1524));
                        }
                        else if (random.number0 == 5)
                        {
                            inv.Add(ItemData.CreateItem(1525));
                        }
                        else if (random.number0 == 6)
                        {
                            inv.Add(ItemData.CreateItem(1526));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(1527));
                        }
                        if (random.number1 == 0)
                        {
                            inv.Add(ItemData.CreateItem(1520));
                        }
                        else if (random.number1 == 1)
                        {
                            inv.Add(ItemData.CreateItem(1521));
                        }
                        else if (random.number1 == 2)
                        {
                            inv.Add(ItemData.CreateItem(1522));
                        }
                        else if (random.number1 == 3)
                        {
                            inv.Add(ItemData.CreateItem(1523));
                        }
                        else if (random.number1 == 4)
                        {
                            inv.Add(ItemData.CreateItem(1524));
                        }
                        else if (random.number1 == 5)
                        {
                            inv.Add(ItemData.CreateItem(1525));
                        }
                        else if (random.number1 == 6)
                        {
                            inv.Add(ItemData.CreateItem(1526));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(1527));
                        }
                        if (random.number2 == 0)
                        {
                            inv.Add(ItemData.CreateItem(1520));
                        }
                        else if (random.number2 == 1)
                        {
                            inv.Add(ItemData.CreateItem(1521));
                        }
                        else if (random.number2 == 2)
                        {
                            inv.Add(ItemData.CreateItem(1522));
                        }
                        else if (random.number2 == 3)
                        {
                            inv.Add(ItemData.CreateItem(1523));
                        }
                        else if (random.number2 == 4)
                        {
                            inv.Add(ItemData.CreateItem(1524));
                        }
                        else if (random.number2 == 5)
                        {
                            inv.Add(ItemData.CreateItem(1525));
                        }
                        else if (random.number2 == 6)
                        {
                            inv.Add(ItemData.CreateItem(1526));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(1527));
                        }
                    }
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1530));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1531));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1532));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1533));
                    }
                    #endregion
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
                    Dodge += Agility + 7;
                    Parry += Fighting + 2;
                    Fortitude += Stamina + 5;
                    Toughness += Stamina + 0;
                    Will += Awareness + 6;
                    Initiative += Agility;
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1540));
                    }
                     else
                    {
                        inv.Add(ItemData.CreateItem(1541));
                    }
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1542));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1543));
                    }
                    
                    else
                    {
                        inv.Add(ItemData.CreateItem(1544));
                    }
                    inv.Add(ItemData.CreateItem(1504));
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1545));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1546));
                    }

                    else
                    {
                        inv.Add(ItemData.CreateItem(1547));
                    }
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
                    Dodge += Agility + 7;
                    Parry += Fighting + 2;
                    Fortitude += Stamina + 0;
                    Toughness += Stamina + 0;
                    Will += Awareness + 8;
                    Initiative += Agility;
                    inv.Add(ItemData.CreateItem(1505));
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1550));
                    }
                    

                    else
                    {
                        inv.Add(ItemData.CreateItem(1551));
                    }
                    random.TripleRandomX(5);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1552));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1553));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1554));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1555));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1556));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1552));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1553));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1554));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1555));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1556));
                    }
                    if (random.number2 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1552));
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1553));
                    }
                    else if (random.number2 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1554));
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1555));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1556));
                    }
                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string0 = "Aristocrat";
                    adv0 = new string[] { "Benefit 2(Wealthy)", "Equipment 2(Lair Headquarters)" };
                }
                else if (random.number0 == 1)
                {
                    random.Random2();
                    string0 = "Heartthrob";
                    if (random.number0 == 0)
                    {
                        adv0 = new string[] { "Attractive", "Daze(Deception)", "Fascinate(Deception)", "Inspire" };
                    }
                    else
                    {
                        adv0 = new string[] { "Attractive", "Daze(Deception)", "Fascinate(Persuasion)", "Inspire" };
                    }
                }
                else if (random.number0 == 2)
                {
                    string0 = "Savage";
                    adv0 = new string[] { "Agile Feint", "Evasion", "Great Endurance", "Power Attack" };
                }
                
                else
                {
                    string0 = "Wilder";
                    adv0 = new string[] { "Animal Empathy", "Great Endurance", "Favoured Environment(choose 1)", "Track" };
                }
                random.Random5();
                if (random.number0 == 0)
                {
                    string1 = "Bestial";
                    intimidation += 12;
                    athletics += 6;
                    perception += 6;
                }
                else if (random.number0 == 1)
                {
                    string1 = "Mysterious";
                    deception += 8;
                    stealth += 8;
                    perception += 8;
                }
                else if (random.number0 == 2)
                {
                    string1 = "Refined";
                    ExpertiseChoose(4);
                    insight += 4;
                    persuasion += 10;
                    perception += 6;
                }
                else if (random.number0 == 3)
                {
                    string1 = "Teen";
                    deception += 8;
                    expertisePopCulture += 4;
                    expertiseStreetwise += 4;
                    perception += 4;
                    technology += 4;
                }
                else
                {
                    string1 = "Temptor";
                    deception += 12;
                    insight += 6;
                    perception += 6;
                }
                #region powers
                
                random.RandomX(3);
            
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1500));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1501));
                }
                
                else
                {
                    inv.Add(ItemData.CreateItem(1502));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
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
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        //scorpion
                        inv.Add(ItemData.CreateItem(1600));
                        inv.Add(ItemData.CreateItem(1601));
                    }
                    else if (random.number0 == 1)
                    {
                        //spider
                        inv.Add(ItemData.CreateItem(1602));
                        inv.Add(ItemData.CreateItem(1603));
                  
                        inv.Add(ItemData.CreateItem(1604));
                        inv.Add(ItemData.CreateItem(1605));
                    }
                    else if (random.number0 == 2)
                    {
                        //swarm
                        inv.Add(ItemData.CreateItem(1606));
                        inv.Add(ItemData.CreateItem(1607));

                        inv.Add(ItemData.CreateItem(1608));
                        inv.Add(ItemData.CreateItem(1609));
                    }
                    else
                    {
                        //wasp
                        inv.Add(ItemData.CreateItem(1610));
                        inv.Add(ItemData.CreateItem(1611));

                        inv.Add(ItemData.CreateItem(1612));
                        
                    }
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
                    inv.Add(ItemData.CreateItem(1613));
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        //owl
                        inv.Add(ItemData.CreateItem(1614));
                        inv.Add(ItemData.CreateItem(1615));

                        inv.Add(ItemData.CreateItem(1616));
                    }
                   
                    else
                    {
                        //owl
                        inv.Add(ItemData.CreateItem(1617));
                        inv.Add(ItemData.CreateItem(1618));

                        inv.Add(ItemData.CreateItem(1619));

                    }
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
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        //Canine
                        inv.Add(ItemData.CreateItem(1620));
                        inv.Add(ItemData.CreateItem(1621));
                        inv.Add(ItemData.CreateItem(1622));
                        inv.Add(ItemData.CreateItem(1623));
                    }

                    else
                    {
                        //Feline
                        inv.Add(ItemData.CreateItem(1630));
                        inv.Add(ItemData.CreateItem(1631));
                        inv.Add(ItemData.CreateItem(1632));
                        random.RandomX(4);
                        if (random.number0 == 0)
                        {
                            //owl
                            inv.Add(ItemData.CreateItem(1633));
                           
                        }
                        else if (random.number0 == 1)
                        {
                            //owl
                            inv.Add(ItemData.CreateItem(1634));
                          
                        }
                        else if (random.number0 == 2)
                        {
                            //owl
                            inv.Add(ItemData.CreateItem(1635));
                            
                        }
                        else
                        {
                            //owl
                            inv.Add(ItemData.CreateItem(1636));
                           

                        }

                    }
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
                    inv.Add(ItemData.CreateItem(1640));
                    random.RandomX(2);
                    if (random.number0 == 0)
                    {
                        //elephant
                        inv.Add(ItemData.CreateItem(1641));
                        inv.Add(ItemData.CreateItem(1642));
                        inv.Add(ItemData.CreateItem(1643));
                        inv.Add(ItemData.CreateItem(1644));
                        inv.Add(ItemData.CreateItem(1645));
                    }
                   
                    else
                    {
                        //Rhino
                        inv.Add(ItemData.CreateItem(1646));
                        inv.Add(ItemData.CreateItem(1647));
                        inv.Add(ItemData.CreateItem(1648));
                        

                    }
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
                    inv.Add(ItemData.CreateItem(1650));
                    inv.Add(ItemData.CreateItem(1651));
                    inv.Add(ItemData.CreateItem(1652));
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        //Crocodile
                        inv.Add(ItemData.CreateItem(1653));
                        inv.Add(ItemData.CreateItem(1654));
                        inv.Add(ItemData.CreateItem(1655));
                        inv.Add(ItemData.CreateItem(1656));
                    }
                    else if (random.number0 == 1)
                    {
                        //Lizard
                        inv.Add(ItemData.CreateItem(1660));
                        inv.Add(ItemData.CreateItem(1661));
                        inv.Add(ItemData.CreateItem(1662));
                        inv.Add(ItemData.CreateItem(1663));
                        inv.Add(ItemData.CreateItem(1664));
                    }
                    
                    else
                    {
                        //Snake
                        inv.Add(ItemData.CreateItem(1665));
                        inv.Add(ItemData.CreateItem(1666));
                    }
                }
                random.Random5();
                if (random.number0 == 0)
                {
                    string0 = "Active";
                    adv0 = new string[] { "Agile Feint", "Instant Up", "Move-by Action" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Catch And Hold";
                    adv0 = new string[] { "Chokehold", "Improved Grab", "Improved Hold" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Mystic";
                    adv0 = new string[] { "Assessment", "Ritualist", "Trance" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Playful";
                    adv0 = new string[] { "Daze(Deception)", "Redirect", "Taunt" };
                }
                else
                {
                    string0 = "Sneaky";
                    adv0 = new string[] { "Evasion", "Hide in Plain Sight", "Improved Initiative" };
                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string1 = "Altruistic";
                    adv1 = new string[] { "Inspire", "Interpose", "Leadership" };
                }
                else if (random.number0 == 1)
                {
                    string1 = "Cooperative";
                    adv1 = new string[] { "Animal Empathy", "Set-up", "Teamwork" };
                }
                else if (random.number0 == 2)
                {
                    string1 = "Egoistic";
                    adv1 = new string[] { "Favored Environment(choose 1)", "Great Endurance", "Uncanny Dodge" };
                }
                
                else
                {
                    string1 = "Vengeful";
                    adv1 = new string[] { "Daze(Intimidation)", "Favored Foe(choose 1)", "Startle" };
                }
                random.Random3();
                if (random.number0 == 0)
                {
                    string2 = "Awakened";
                    athletics += 6;
                    stealth += 8;
                    perception += 6;
                }
                else if (random.number0 == 1)
                {
                    string2 = "Invocation";
                    insight += 8;
                    treatment += 6;
                    perception += 6;
                }
              
                else
                {
                    string2 = "Mutation";
                    ExpertiseChoose(8);
                    investigation += 6;
                    technology += 6;
                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string3 = "Dominating";
                    athletics += 4;
                    intimidation += 12;
                    perception += 4;
                }
                else if (random.number0 == 1)
                {
                    string3 = "Predator";
                    acrobatics += 4;
                    athletics += 4;
                    perception += 6;
                    stealth += 6;
                }
                else if (random.number0 == 1)
                {
                    string3 = "Trickster";
                    acrobatics += 6;
                    deception += 6;
                    sleightOfHand += 4;
                    stealth += 4;
                }
                else
                {
                    string3 = "Wise";
                    insight += 8;
                    perception += 8;
                    treatment += 4;
                    
                }
                
                background0.text = string0 + ", " + string1 + ", " + string2;
                background1.text = string3 + ", " + string4 + ", " + string5;
                Dodge += Agility + 6;
                Parry += Fighting + 4;
                Fortitude += Stamina + 4;
                Toughness += Stamina + 0;
                Will += Awareness + 6;
                Initiative += Agility;
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
                    #region powers
                   
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1700));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1701));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1702));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1703));
                    }
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1720));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1721));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1722));
                    }
                    #endregion
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
                    #region powers
                    random.RandomX(4);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1710));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1711));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1712));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1713));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1714));
                    }
                    random.RandomX(3);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1730));
                        inv.Add(ItemData.CreateItem(1731));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1732));
                        inv.Add(ItemData.CreateItem(1733));
                    }
                    else
                    {
                        random.RandomX(4);
                        if (random.number0 == 0)
                        {
                            inv.Add(ItemData.CreateItem(1734));
                        }
                        else if (random.number0 == 1)
                        {
                            inv.Add(ItemData.CreateItem(1735));
                        }
                        else if (random.number0 == 2)
                        {
                            inv.Add(ItemData.CreateItem(1736));
                        }
                        else
                        {
                            inv.Add(ItemData.CreateItem(1737));
                        }
                    }
                    #endregion
                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string0 = "Field General";
                    adv0 = new string[] { "Inspire", "Leadership", "Teamwork" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Hunter";
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv0 = new string[] { "Skill Mastery(Perception)", "Tracking", "Favoured Environment(choose 1)" };
                    }
                    else
                    {
                        adv0 = new string[] { "Skill Mastery(Perception)", "Tracking", "Favoured Foe(choose 1)" };
                    }
                }
                else if (random.number0 == 2)
                {
                    string0 = "Mysterious Past";
                    adv0 = new string[] { "Beginner's Luck", "Benefit(Cipher)", "Language(choose 1)" };
                }
               
                else
                {
                    string0 = "Survivor";
                    adv0 = new string[] { "Diehard", "Great Endurance", "Ultimate Effort(Toughness checks)" };
                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string1 = "Agile";
                    adv2 = new string[] { "Evasion", "Grabbing Finesse", "Improved Defense" };
                }
                else if (random.number0 == 1)
                {
                    string1 = "Daring";
                    
                    
                        adv2 = new string[] { "All-out Attack", "Fearless", "Improved Critical(choose 1)" };
                   
                }
                else if (random.number0 == 2)
                {
                    string1 = "Grappler";
                    adv2 = new string[] { "Chokehold", "Improved Grab", "Improved Hold" };
                }

                else
                {
                    string1 = "Skillful";
                    adv2 = new string[] { "Accurate Attack", "Defensive Attack", "Precise Attack(Close; Concealment)" };
                }
                adv1 = new string[] { "Agile Feint", "Power Attack", "Takedown" };
                acrobatics += 6;
                athletics += 6;
                insight += 4;
                perception += 6;
                random.Random5();
                if (random.number0 == 0)
                {
                    string2 = "Advanced";
                    technology += 6;
                    vehicles += 6;
                    
                }
                else if (random.number0 == 1)
                {
                    string2 = "Charismatic";
                    insight += 6;
                    persuasion += 6;
                    
                }
                else if (random.number0 == 2)
                {
                    string2 = "Cultured";
                    expertiseHistory += 6;
                    
                    persuasion += 6;
                }
                else if (random.number0 == 3)
                {
                    string2 = "Military";
                    expertiseTactics += 6;
                    intimidation += 6;
                    
                }
                else
                {
                    string2 = "Mystical";
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        expertiseMagic += 6;
                    }
                    else
                    {
                        expertiseMythology += 6;
                    }
                    insight += 6;
                    
                }
                
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 4;
                Parry += Fighting + 2;
                Fortitude += Stamina + 2;
                Toughness += Stamina + 0;
                Will += Awareness + 6;
                Initiative += Agility;
            }
            else if (Archetype[i] == "Weapon Master")
            {
                subArchetypes = new string[] { "Enhanced", "Natural", "Self-Made" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Enhanced")
                {
                    Strength = 3;
                    Agility = 6;
                    Fighting = 7;
                    Awareness = 1;
                    Stamina = 4;
                    Dexterity = 6;
                    Intellect = 1;
                    Presence = 0;
                }
                else if (SubArchetype[i] == "Natural")
                {
                    Strength = 3;
                    Agility = 7;
                    Fighting = 8;
                    Awareness = 0;
                    Stamina = 3;
                    Dexterity = 7;
                    Intellect = 0;
                    Presence = 0;
                }
                else
                {
                    Strength = 3;
                    Agility = 6;
                    Fighting = 7;
                    Awareness = 2;
                    Stamina = 3;
                    Dexterity = 6;
                    Intellect = 0;
                    Presence = 1;
                }
                random.DoubleRandom4();
                if (random.number0 == 0)
                {
                    
                    adv0 = new string[] { "Defensive Roll 3", "Accurate Attack" };
                }
                else if (random.number0 == 1)
                {

                    adv0 = new string[] { "Defensive Roll 3", "All-out Attack" };
                }
                else if (random.number0 == 2)
                {

                    adv0 = new string[] { "Defensive Roll 3", "Defensive Attack" };
                }
               
                else
                {

                    adv0 = new string[] { "Defensive Roll 3", "Power Attack" };
                }
                if (random.number1 == 0)
                {

                    adv1 = new string[] {  "Accurate Attack" };
                }
                else if (random.number1 == 1)
                {

                    adv1 = new string[] { "All-out Attack" };
                }
                else if (random.number1 == 2)
                {

                    adv1 = new string[] {  "Defensive Attack" };
                }

                else
                {

                    adv1 = new string[] { "Power Attack" };
                }
                random.DoubleRandom6();
                if (random.number0 == 0)
                {
                    string0 = "Alert";
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv2 = new string[] { "Evasion", "Precise Attack(Close; Concealment)", "Uncanny Dodge" };
                    }
                    else
                    {
                        adv2 = new string[] { "Evasion", "Precise Attack(Ranged; Concealment)", "Uncanny Dodge" };
                    }
                }
                else if (random.number0 == 1)
                {
                    string0 = "Dead Eye";


                    adv2 = new string[] { "Improved Aim", "Ultimate Effort(Aim)", "Improved Critical(weapon)" };

                }
                else if (random.number0 == 2)
                {
                    string0 = "Field Commander";
                    adv2 = new string[] { "Inspire", "Leadership", "Skill Mastery (Persuasion)" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Master Tactician";
                    adv2 = new string[] { "Assessment", "Teamwork", "Skill Mastery (Insight)" };
                }
                else if (random.number0 == 4)
                {
                    string0 = "Peak Conditioning";
                    adv2 = new string[] { "Diehard", "Great Endurance", "Skill Mastery (Athletics)" };
                }
                else
                {
                    string0 = "Reactive Fighter";
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv2 = new string[] { "Benefit(Ambidexterity)", "Quick Draw", "Precise Attack(Close; Cover)" };
                    }
                    else
                    {
                        adv2 = new string[] { "Benefit(Ambidexterity)", "Quick Draw", "Precise Attack(Ranged; Concealment)" };
                    }
                    
                }
                if (random.number1 == 0)
                {
                    string1 = "Alert";
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv3 = new string[] { "Evasion", "Precise Attack(Close; Concealment)", "Uncanny Dodge" };
                    }
                    else
                    {
                        adv3 = new string[] { "Evasion", "Precise Attack(Ranged; Concealment)", "Uncanny Dodge" };
                    }
                }
                else if (random.number1 == 1)
                {
                    string1 = "Dead Eye";


                    adv3 = new string[] { "Improved Aim", "Ultimate Effort(Aim)", "Improved Critical(weapon)" };

                }
                else if (random.number1 == 2)
                {
                    string1 = "Field Commander";
                    adv3 = new string[] { "Inspire", "Leadership", "Skill Mastery (Persuasion)" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Master Tactician";
                    adv3 = new string[] { "Assessment", "Teamwork", "Skill Mastery (Insight)" };
                }
                else if (random.number1 == 4)
                {
                    string1 = "Peak Conditioning";
                    adv3 = new string[] { "Diehard", "Great Endurance", "Skill Mastery (Athletics)" };
                }
                else
                {
                    string1 = "Reactive Fighter";
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        adv3 = new string[] { "Benefit(Ambidexterity)", "Quick Draw", "Precise Attack(Close; Cover)" };
                    }
                    else
                    {
                        adv3 = new string[] { "Benefit(Ambidexterity)", "Quick Draw", "Precise Attack(Ranged; Concealment)" };
                    }

                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string2 = "Fast";
                     adv3 = new string[] { "Improved Initiative", "Takedown" };
                    
                }
                else if (random.number0 == 1)
                {
                    string2 = "Imposing";
                    adv3 = new string[] { "Daze(Intimidation)", "Startle" };
                    

                }
                else if (random.number0 == 2)
                {
                    string2 = "Quick";
                    adv3 = new string[] { "Agile Feint", "Evasion" };
                }
               else
                {
                    string2 = "Tricky";
                    adv3 = new string[] { "Daze(Deception)", "Taunt" };

                }
                acrobatics += 4;
                athletics += 4;
                ExpertiseChoose(6);
                random.Random2();
                if (random.number0 == 0)
                {
                    closeCombatWeapon += 6;
                    closeCombatUnarmed += 4;
                    ExpertiseChoose(4);
                }
                else
                {
                    ExpertiseChoose(6);
                    rangedCombatWeapon += 8;
                }
                random.Random4();
                if (random.number0 == 0)
                {
                    string3 = "Soldier";
                    expertiseMilitary += 6;
                    vehicles += 6;
                    
                }
                else if (random.number0 == 1)
                {
                    string3 = "Time-Displaced";
                    expertiseHistory += 6;
                    random.Random2();
                    if (random.number0 == 0)
                    {
                        expertiseMagic += 6;
                    }
                    else
                    {
                        technology += 6;
                    }
                }
                else if (random.number0 == 2)
                {
                    string3 = "Vigilante";
                    expertiseStreetwise += 6;
                    investigation += 6;
                }
              
                else
                {
                    string3 = "Weaponsmith";
                    expertiseWeapons += 6;
                    technology += 6;
                }
                random.Random3();
                if (random.number0 == 0)
                {
                    string4 = "Flamboyant";
                    acrobatics += 8;
                    athletics += 4;
                    sleightOfHand += 4;
                }
                else if (random.number0 == 1)
                {
                    string4 = "Instinctive";
                    acrobatics += 6;
                    athletics += 6;
                    stealth += 4;
                }
               
                else
                {
                    string4 = "Sneaky";
                    acrobatics += 6;
                    athletics += 4;
                    stealth += 6;
                }
                random.Random5();
                if (random.number0 == 0)
                {
                    string5 = "Assertive";
                    insight += 8;
                    intimidation += 8;
                    persuasion += 8;
                }
                else if (random.number0 == 1)
                {
                    string5 = "Cunning";
                    deception += 10;
                    insight += 8;
                    perception += 6;
                }
                else if (random.number0 == 2)
                {
                    string5 = "Empathic";
                    perception += 6;
                    insight += 10;
                    persuasion += 8;
                }
                else if (random.number0 == 3)
                {
                    string5 = "Forceful Personality";
                    deception += 8;
                    intimidation += 8;
                    persuasion += 8;
                }
                else
                {
                    string5 = "Smooth Talker";
                    deception += 10;
                    insight += 4;
                    persuasion += 10;
                }
                #region powers
                
                random.RandomX(6);
                
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1810));
                    random.QuinRandomX(10);
                    if (random.number0 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1800));
                    }
                    else if (random.number0 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1801));
                    }
                    else if (random.number0 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1802));
                    }
                    else if (random.number0 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1803));
                    }
                    else if (random.number0 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1804));
                    }
                    else if (random.number0 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1805));
                    }
                    else if (random.number0 == 6)
                    {
                        inv.Add(ItemData.CreateItem(1806));
                    }
                    else if (random.number0 == 7)
                    {
                        inv.Add(ItemData.CreateItem(1807));
                    }
                    else if (random.number0 == 8)
                    {
                        inv.Add(ItemData.CreateItem(1808));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1809));
                    }
                    if (random.number1 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1800));
                    }
                    else if (random.number1 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1801));
                    }
                    else if (random.number1 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1802));
                    }
                    else if (random.number1 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1803));
                    }
                    else if (random.number1 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1804));
                    }
                    else if (random.number1 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1805));
                    }
                    else if (random.number1 == 6)
                    {
                        inv.Add(ItemData.CreateItem(1806));
                    }
                    else if (random.number1 == 7)
                    {
                        inv.Add(ItemData.CreateItem(1807));
                    }
                    else if (random.number1 == 8)
                    {
                        inv.Add(ItemData.CreateItem(1808));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1809));
                    }
                    if (random.number2 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1800));
                    }
                    else if (random.number2 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1801));
                    }
                    else if (random.number2 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1802));
                    }
                    else if (random.number2 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1803));
                    }
                    else if (random.number2 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1804));
                    }
                    else if (random.number2 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1805));
                    }
                    else if (random.number2 == 6)
                    {
                        inv.Add(ItemData.CreateItem(1806));
                    }
                    else if (random.number2 == 7)
                    {
                        inv.Add(ItemData.CreateItem(1807));
                    }
                    else if (random.number2 == 8)
                    {
                        inv.Add(ItemData.CreateItem(1808));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1809));
                    }
                    if (random.number3 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1800));
                    }
                    else if (random.number3 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1801));
                    }
                    else if (random.number3 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1802));
                    }
                    else if (random.number3 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1803));
                    }
                    else if (random.number3 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1804));
                    }
                    else if (random.number3 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1805));
                    }
                    else if (random.number3 == 6)
                    {
                        inv.Add(ItemData.CreateItem(1806));
                    }
                    else if (random.number3 == 7)
                    {
                        inv.Add(ItemData.CreateItem(1807));
                    }
                    else if (random.number3 == 8)
                    {
                        inv.Add(ItemData.CreateItem(1808));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1809));
                    }
                    if (random.number4 == 0)
                    {
                        inv.Add(ItemData.CreateItem(1800));
                    }
                    else if (random.number4 == 1)
                    {
                        inv.Add(ItemData.CreateItem(1801));
                    }
                    else if (random.number4 == 2)
                    {
                        inv.Add(ItemData.CreateItem(1802));
                    }
                    else if (random.number4 == 3)
                    {
                        inv.Add(ItemData.CreateItem(1803));
                    }
                    else if (random.number4 == 4)
                    {
                        inv.Add(ItemData.CreateItem(1804));
                    }
                    else if (random.number4 == 5)
                    {
                        inv.Add(ItemData.CreateItem(1805));
                    }
                    else if (random.number4 == 6)
                    {
                        inv.Add(ItemData.CreateItem(1806));
                    }
                    else if (random.number4 == 7)
                    {
                        inv.Add(ItemData.CreateItem(1807));
                    }
                    else if (random.number4 == 8)
                    {
                        inv.Add(ItemData.CreateItem(1808));
                    }
                    else
                    {
                        inv.Add(ItemData.CreateItem(1809));
                    }
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1811));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1812));
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1813));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(1814));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1815));
                    inv.Add(ItemData.CreateItem(1816));
                    inv.Add(ItemData.CreateItem(1817));
                }
                random.RandomX(7);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1820));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1821));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1822));
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1823));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(1824));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(1825));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1826));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                background1.text = string3 + ", " + string4 + ", " + string5;
                Dodge += Agility + 7;
                Parry += Fighting + 6;
                Fortitude += Stamina + 5;
                Toughness += Stamina + 0;
                Will += Awareness + 8;
                Initiative += Agility;
            }
            else if (Archetype[i] == "Weather Controller")
            {
                subArchetypes = new string[] { "Conjurer", "Psionic", "Technological" };
                SubArchetype[i] = subArchetypes[Random.Range(0, subArchetypes.Length)];
                if (SubArchetype[i] == "Conjurer")
                {
                    Strength = 1;
                    Agility = 2;
                    Fighting = 4;
                    Awareness = 3;
                    Stamina = 3;
                    Dexterity = 2;
                    Intellect = 1;
                    Presence = 4;
                }
                else if (SubArchetype[i] == "Psionic")
                {
                    Strength = 1;
                    Agility = 3;
                    Fighting = 4;
                    Awareness = 4;
                    Stamina = 3;
                    Dexterity = 2;
                    Intellect = 1;
                    Presence = 2;
                }
                else
                {
                    Strength = 1;
                    Agility = 3;
                    Fighting = 5;
                    Awareness = 2;
                    Stamina = 2;
                    Dexterity = 2;
                    Intellect = 4;
                    Presence = 1;
                }
                random.DoubleRandom5();
                if (random.number0 == 0)
                {
                    string0 = "Adapted";
                    adv0 = new string[] { "Favoured Environment(choose 1)", "Great Endurance" };
                }
                else if (random.number0 == 1)
                {
                    string0 = "Divine";
                    adv0 = new string[] { "Extraordinary Effort", "Ritualist" };
                }
                else if (random.number0 == 2)
                {
                    string0 = "Facilitator";
                    adv0 = new string[] { "Set-up", "Teamwork" };
                }
                else if (random.number0 == 3)
                {
                    string0 = "Raging";
                    adv0 = new string[] { "Daze(Intimidation)", "Power Attack" };
                }
                else
                {
                    string0 = "Sovereign";
                    adv0 = new string[] { "Benefit(Status)", "Connected" };
                }
                if (random.number1 == 0)
                {
                    string1 = "Adapted";
                    adv1 = new string[] { "Favoured Environment(choose 1)", "Great Endurance" };
                }
                else if (random.number1 == 1)
                {
                    string1 = "Divine";
                    adv1 = new string[] { "Extraordinary Effort", "Ritualist" };
                }
                else if (random.number1 == 2)
                {
                    string1 = "Facilitator";
                    adv1 = new string[] { "Set-up", "Teamwork" };
                }
                else if (random.number1 == 3)
                {
                    string1 = "Raging";
                    adv1 = new string[] { "Daze(Intimidation)", "Power Attack" };
                }
                else
                {
                    string1 = "Sovereign";
                    adv1 = new string[] { "Benefit(Status)", "Connected" };
                }
                adv2 = new string[] { "Defensive Roll 3" };
                //expertise(1) += 8
                random.Random4();
                if (random.number0 == 0)
                {
                    string2 = "Attuned";
                    //expertise(1) += 8;
                    insight += 8;
                    perception += 8;
                }
                else if (random.number0 == 1)
                {
                    string2 = "Organic";
                    expertiseBiology += 8;
                    persuasion += 8;
                    perception += 4;
                    treatment += 4;
                }
                else if (random.number0 == 2)
                {
                    string2 = "Sneak";
                    deception += 4;
                    expertiseStreetwise += 4;
                    sleightOfHand += 8;
                    stealth += 8;
                }
                
                else
                {
                    string2 = "Spirited";
                    acrobatics += 8;
                    athletics += 8;
                    intimidation += 8;
                    
                }
                #region powers
                random.QuinRandomX(10);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1900));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1901));
                }
                else if (random.number0 == 2)
                {
                    inv.Add(ItemData.CreateItem(1902));
                }
                else if (random.number0 == 3)
                {
                    inv.Add(ItemData.CreateItem(1903));
                }
                else if (random.number0 == 4)
                {
                    inv.Add(ItemData.CreateItem(1904));
                }
                else if (random.number0 == 5)
                {
                    inv.Add(ItemData.CreateItem(1905));
                }
                else if (random.number0 == 6)
                {
                    inv.Add(ItemData.CreateItem(1906));
                }
                else if (random.number0 == 7)
                {
                    inv.Add(ItemData.CreateItem(1907));
                }
                else if (random.number0 == 8)
                {
                    inv.Add(ItemData.CreateItem(1908));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1909));
                }
                if (random.number1 == 0)
                {
                    inv.Add(ItemData.CreateItem(1900));
                }
                else if (random.number1 == 1)
                {
                    inv.Add(ItemData.CreateItem(1901));
                }
                else if (random.number1 == 2)
                {
                    inv.Add(ItemData.CreateItem(1902));
                }
                else if (random.number1 == 3)
                {
                    inv.Add(ItemData.CreateItem(1903));
                }
                else if (random.number1 == 4)
                {
                    inv.Add(ItemData.CreateItem(1904));
                }
                else if (random.number1 == 5)
                {
                    inv.Add(ItemData.CreateItem(1905));
                }
                else if (random.number1 == 6)
                {
                    inv.Add(ItemData.CreateItem(1906));
                }
                else if (random.number1 == 7)
                {
                    inv.Add(ItemData.CreateItem(1907));
                }
                else if (random.number1 == 8)
                {
                    inv.Add(ItemData.CreateItem(1908));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1909));
                }
                if (random.number2 == 0)
                {
                    inv.Add(ItemData.CreateItem(1900));
                }
                else if (random.number2 == 1)
                {
                    inv.Add(ItemData.CreateItem(1901));
                }
                else if (random.number2 == 2)
                {
                    inv.Add(ItemData.CreateItem(1902));
                }
                else if (random.number2 == 3)
                {
                    inv.Add(ItemData.CreateItem(1903));
                }
                else if (random.number2 == 4)
                {
                    inv.Add(ItemData.CreateItem(1904));
                }
                else if (random.number2 == 5)
                {
                    inv.Add(ItemData.CreateItem(1905));
                }
                else if (random.number2 == 6)
                {
                    inv.Add(ItemData.CreateItem(1906));
                }
                else if (random.number2 == 7)
                {
                    inv.Add(ItemData.CreateItem(1907));
                }
                else if (random.number2 == 8)
                {
                    inv.Add(ItemData.CreateItem(1908));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1909));
                }
                if (random.number3 == 0)
                {
                    inv.Add(ItemData.CreateItem(1900));
                }
                else if (random.number3 == 1)
                {
                    inv.Add(ItemData.CreateItem(1901));
                }
                else if (random.number3 == 2)
                {
                    inv.Add(ItemData.CreateItem(1902));
                }
                else if (random.number3 == 3)
                {
                    inv.Add(ItemData.CreateItem(1903));
                }
                else if (random.number3 == 4)
                {
                    inv.Add(ItemData.CreateItem(1904));
                }
                else if (random.number3 == 5)
                {
                    inv.Add(ItemData.CreateItem(1905));
                }
                else if (random.number3 == 6)
                {
                    inv.Add(ItemData.CreateItem(1906));
                }
                else if (random.number3 == 7)
                {
                    inv.Add(ItemData.CreateItem(1907));
                }
                else if (random.number3 == 8)
                {
                    inv.Add(ItemData.CreateItem(1908));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1909));
                }
                if (random.number4 == 0)
                {
                    inv.Add(ItemData.CreateItem(1900));
                }
                else if (random.number4 == 1)
                {
                    inv.Add(ItemData.CreateItem(1901));
                }
                else if (random.number4 == 2)
                {
                    inv.Add(ItemData.CreateItem(1902));
                }
                else if (random.number4 == 3)
                {
                    inv.Add(ItemData.CreateItem(1903));
                }
                else if (random.number4 == 4)
                {
                    inv.Add(ItemData.CreateItem(1904));
                }
                else if (random.number4 == 5)
                {
                    inv.Add(ItemData.CreateItem(1905));
                }
                else if (random.number4 == 6)
                {
                    inv.Add(ItemData.CreateItem(1906));
                }
                else if (random.number4 == 7)
                {
                    inv.Add(ItemData.CreateItem(1907));
                }
                else if (random.number4 == 8)
                {
                    inv.Add(ItemData.CreateItem(1908));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1909));
                }
                random.RandomX(3);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1910));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1911));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1912));
                }
                random.RandomX(3);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1920));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1921));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1922));
                }
                random.RandomX(3);
                if (random.number0 == 0)
                {
                    inv.Add(ItemData.CreateItem(1930));
                }
                else if (random.number0 == 1)
                {
                    inv.Add(ItemData.CreateItem(1931));
                }
                else
                {
                    inv.Add(ItemData.CreateItem(1932));
                }
                #endregion
                background0.text = string0 + ", " + string1 + ", " + string2;
                Dodge += Agility + 2;
                Parry += Fighting + 0;
                Fortitude += Stamina + 4;
                Toughness += Stamina + 0;
                Will += Awareness + 6;
                Initiative += Agility;
            }
            else
            {

            }
            Name.text = Archetype[0] + " (" + SubArchetype[0] + ")";
            {

                if (acrobatics > 0)
                {

                    acrobatics += Agility;
                    
                    skillCount += 1;
                   
                }
                if (athletics > 0)
                {
                    athletics += Strength;
                    
                    skillCount += 1;
                    
                }
                if (closeCombatUnarmed > 0)
                {
                    closeCombatUnarmed += Fighting;
                    
                    skillCount += 1;
                   
                }
                if (closeCombatGadgets > 0)
                {
                    closeCombatGadgets += Fighting;
                    
                    skillCount += 1;
                    
                }
                if (closeCombatWeapon > 0)
                {
                    closeCombatWeapon += Fighting;
                    
                    skillCount += 1;
                    
                }
                if (deception > 0)
                {
                    deception += Presence;
                    
                    skillCount += 1;
                    
                }
                if (expertiseBusiness > 0)
                {
                    expertiseBusiness += Intellect;
                    
                    skillCount += 1;
                    
                }
                if (expertiseBiology > 0)
                {
                    expertiseBiology += Intellect;
                   
                    skillCount += 1;
                    
                }
                if (expertiseCurrentEvents > 0)
                {
                    expertiseCurrentEvents += Intellect;
                   
                    skillCount += 1;
                    
                }
                if (expertiseElements > 0)
                {
                    expertiseElements += Intellect;
                    skillCount += 1;
                }
                if (expertiseHistory > 0)
                {
                    expertiseHistory += Intellect;
                    skillCount += 1;
                }
                if (expertiseMythology > 0)
                {
                    expertiseMythology += Intellect;
                    skillCount += 1;
                }
                if (expertiseScience > 0)
                {
                    expertiseScience += Intellect;
                    skillCount += 1;
                }
                if (expertiseMagic > 0)
                {
                    expertiseMagic += Intellect;
                    skillCount += 1;
                }
                if (expertisePhilosophy > 0)
                {
                    expertisePhilosophy += Intellect;
                    skillCount += 1;
                }
                if (expertiseTactics > 0)
                {
                    expertiseTactics += Intellect;
                    skillCount += 1;
                }
                if (expertisePopCulture > 0)
                {
                    expertisePopCulture += Intellect;
                    skillCount += 1;
                }
                if (expertiseRepair > 0)
                {
                    expertiseRepair += Intellect;
                    skillCount += 1;
                }
                if (expertiseMilitary > 0)
                {
                    expertiseMilitary += Intellect;
                    skillCount += 1;
                }
                if (expertiseStreetwise > 0)
                {
                    expertiseStreetwise += Intellect;
                    skillCount += 1;
                }
                if (expertiseWeapons > 0)
                {
                    expertiseWeapons += Intellect;
                    skillCount += 1;
                }
                if (insight > 0)
                {
                    insight += Awareness;
                    skillCount += 1;
                }
                if (intimidation > 0)
                {
                    intimidation += Presence;
                    skillCount += 1;
                }
                if (investigation > 0)
                {
                    investigation += Intellect;
                    skillCount += 1;
                }
                if (persuasion > 0)
                {
                    persuasion += Presence;
                    skillCount += 1;
                }
                if (perception > 0)
                {
                    perception += Awareness;
                    skillCount += 1;
                }
                if (rangedCombatElement > 0)
                {
                    rangedCombatElement += Dexterity;
                    skillCount += 1;
                }
                if (rangedCombatEnergyControl > 0)
                {
                    rangedCombatEnergyControl += Dexterity;
                    skillCount += 1;
                }
                if (rangedCombatGadgets > 0)
                {
                    rangedCombatGadgets += Dexterity;
                    skillCount += 1;
                }
                if (rangedCombatThrowing > 0)
                {
                    rangedCombatThrowing += Dexterity;
                    skillCount += 1;
                }
                if (sleightOfHand > 0)
                {
                    sleightOfHand += Dexterity;
                    skillCount += 1;
                }
                if (stealth > 0)
                {
                    stealth += Agility;
                    skillCount += 1;
                }
                if (technology > 0)
                {
                    technology += Intellect;
                    skillCount += 1;
                }
                if (treatment > 0)
                {
                    treatment += Intellect;
                    skillCount += 1;
                }
                if (vehicles > 0)
                {
                    vehicles += Dexterity;
                    
                    skillCount += 1;
                    
                }
            }
            
        }
        for (int i = 0; i < adv0.Length; i++)
        {
            Adv0 = Adv0 + ", " + adv0[i].ToString();
        }
        for (int i = 0; i < adv1.Length; i++)
        {
            Adv1 = Adv1 + ", " + adv1[i].ToString();
        }
        for (int i = 0; i < adv2.Length; i++)
        {
            Adv2 = Adv2 + ", " + adv2[i].ToString();
        }
        for (int i = 0; i < adv3.Length; i++)
        {
            Adv3 = Adv3 + ", " + adv3[i].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            DisplayStats(false);
        }
        

    }
    public void DisplayStats(bool Display)
    {
        if (Display == true)
        {
            
            StatDisplay.SetActive(true);
            NameList.SetActive(false);
            dodge.GetComponent<Text>().text = Dodge.ToString();
            fortitude.GetComponent<Text>().text = Fortitude.ToString();
            parry.GetComponent<Text>().text = Parry.ToString();
            toughness.GetComponent<Text>().text = Toughness.ToString();
            will.GetComponent<Text>().text = Will.ToString();
            initiative.GetComponent<Text>().text = Initiative.ToString();
            strength.GetComponent<Text>().text = Strength.ToString();
            agility.GetComponent<Text>().text = Agility.ToString();
            fighting.GetComponent<Text>().text = Fighting.ToString();
            awareness.GetComponent<Text>().text = Awareness.ToString();
            stamina.GetComponent<Text>().text = Stamina.ToString();
            dexterity.GetComponent<Text>().text = Dexterity.ToString();
            intellect.GetComponent<Text>().text = Intellect.ToString();
            presence.GetComponent<Text>().text = Presence.ToString();

            if (Adv0 != null)
            {
                advantage0.text = Adv0;
            }
            else
            {
                advantage0.text = " ";
            }
            if (Adv1 != null)
            {
                advantage1.text = Adv1;
            }
            else
            {
                advantage1.text = " ";
            }
            if (Adv2 != null)
            {
                advantage2.text = Adv2;
            }
            else
            {
                advantage2.text = " ";
            }
            if (Adv3 != null)
            {
                advantage3.text = Adv3;
            }
            else
            {
                advantage3.text = " ";
            }
            displayname.text = Name.text;
            displayBackground.text = background0.text;
            displayBackground2.text = background1.text;
            Acrobatics.SetActive(false);
        Athletics.SetActive(false);
            CloseCombatGadgets.SetActive(false);
            CloseCombatUnarmed.SetActive(false);
            CloseCombatWeapon.SetActive(false);
            Deception.SetActive(false);
            ExpertiseBusiness.SetActive(false);
            ExpertiseBiology.SetActive(false);
            ExpertiseCurrentEvents.SetActive(false);
            ExpertiseElements.SetActive(false);
            ExpertiseHistory.SetActive(false);
            ExpertiseScience.SetActive(false);
            ExpertiseMagic.SetActive(false);
            ExpertiseMilitary.SetActive(false);
            ExpertiseMythology.SetActive(false);
            ExpertiseRepair.SetActive(false);
            ExpertiseStreetwise.SetActive(false);
            ExpertisePopCulture.SetActive(false);
            ExpertisePhilosophy.SetActive(false);
            ExpertiseTactics.SetActive(false);
            ExpertiseWeapons.SetActive(false);
            Insight.SetActive(false);
            Intimidation.SetActive(false);
            Investigation.SetActive(false);
            Perception.SetActive(false);
            Persuasion.SetActive(false);
            RangedCombatElement.SetActive(false);
            RangedCombatEnergyControl.SetActive(false);
            RangedCombatGadgets.SetActive(false);
            RangedCombatThrowing.SetActive(false);
            RangedCombatWeapon.SetActive(false);
            SleightOfHand.SetActive(false);
            Stealth.SetActive(false);
            Technology.SetActive(false);
            Treatment.SetActive(false);
            Vehicles.SetActive(false);
            
            skillCount = 0;
            {
                if (acrobatics > 0)
                {

                    Acrobatics.SetActive(true);


                }
                if (athletics > 0)
                {
                    Athletics.SetActive(true);
                }
                if (closeCombatUnarmed > 0)
                {
                    CloseCombatUnarmed.SetActive(true);
                }
                if (closeCombatGadgets > 0)
                {
                    CloseCombatGadgets.SetActive(true);
                }
                if (closeCombatWeapon > 0)
                {
                    CloseCombatWeapon.SetActive(true);
                }
                if (deception > 0)
                {
                    Deception.SetActive(true);
                }
                if (expertiseBusiness > 0)
                {
                    ExpertiseBusiness.SetActive(true);
                }
                if (expertiseBiology > 0)
                {
                    ExpertiseBiology.SetActive(true);
                }
                if (expertiseCurrentEvents > 0)
                {
                    ExpertiseCurrentEvents.SetActive(true);
                }
                if (expertiseElements > 0)
                {

                    ExpertiseElements.SetActive(true);
                }
                if (expertiseHistory > 0)
                {

                    ExpertiseHistory.SetActive(true);
                }
                if (expertiseMythology > 0)
                {
                    ExpertiseMythology.SetActive(true);
                }
                if (expertiseScience > 0)
                {
                    ExpertiseScience.SetActive(true);
                }
                if (expertiseMagic > 0)
                {

                    ExpertiseMagic.SetActive(true);
                }
                if (expertisePhilosophy > 0)
                {

                    ExpertisePhilosophy.SetActive(true);
                }
                if (expertiseTactics > 0)
                {

                    ExpertiseTactics.SetActive(true);
                }
                if (expertisePopCulture > 0)
                {
                    ExpertisePopCulture.SetActive(true);
                }
                if (expertiseRepair > 0)
                {

                    ExpertiseRepair.SetActive(true);
                }
                if (expertiseMilitary > 0)
                {

                    ExpertiseMilitary.SetActive(true);
                }
                if (expertiseStreetwise > 0)
                {

                    ExpertiseStreetwise.SetActive(true);
                }
                if (expertiseWeapons > 0)
                {

                    ExpertiseWeapons.SetActive(true);
                }
                if (insight > 0)
                {

                    Insight.SetActive(true);
                }
                if (intimidation > 0)
                {

                    Intimidation.SetActive(true);
                }
                if (investigation > 0)
                {

                    Investigation.SetActive(true);
                }
                if (persuasion > 0)
                {

                    Persuasion.SetActive(true);
                }
                if (perception > 0)
                {

                    Perception.SetActive(true);
                }
                if (rangedCombatElement > 0)
                {
                    RangedCombatElement.SetActive(true);
                }
                if (rangedCombatEnergyControl > 0)
                {

                    RangedCombatEnergyControl.SetActive(true);
                }
                if (rangedCombatGadgets > 0)
                {

                    RangedCombatGadgets.SetActive(true);
                }
                if (rangedCombatThrowing > 0)
                {

                    ExpertiseScience.SetActive(true);
                }
                if (sleightOfHand > 0)
                {

                    SleightOfHand.SetActive(true);
                }
                if (stealth > 0)
                {

                    Stealth.SetActive(true);
                }
                if (technology > 0)
                {

                    Technology.SetActive(true);
                }
                if (treatment > 0)
                {

                    Treatment.SetActive(true);
                }
                if (vehicles > 0)
                {

                    Vehicles.SetActive(true);
                }
            }
        }
        if (Display == false)
        {
            StatDisplay.SetActive(false);
            NameList.SetActive(true);

        }
    }
    
}
