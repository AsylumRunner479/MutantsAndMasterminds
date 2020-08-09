
using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemId)
    {
        #region Variables

        //id of the item for programmers and developers
        string name = "";
        //allows you to desiginate what the names of the item use is
        string remove = "";
        string use = "";
        string description = "";
        //Amount of items of that type...Stackable
        int amount = 0;
        //Buy and Sell Price
        int value = 0;
        int damage = 0;
        int armour = 0;
        int heal = 0;
        string iconName = "";
        string meshName = "";
        //itemId is used in the game as a shorthand for referencing different items and assign value to the stats from Item
        ItemTypes type = ItemTypes.Consturct;
        switch (itemId)
        {
            //an index of all the items you can get in this world and what type they are
            #region Consturct 0-99
            case 0:
                name = "Blast";
                description = "Ranged, accurate 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 8;
                armour = 1;
                heal = 0;
                iconName = "Armour/Light";
                meshName = "Armour/Light";
                type = ItemTypes.Consturct;
                //what the display comes up with
                use = "wear";
                remove = "strip";
                break;
            case 1:
                name = "Damaging aura elemental";
                description = "Reaction, enh closeattack";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 2:
                name = "Gaseous elemental";
                description = "flight 3, insubstantial 2(gaseous), enh closeattack";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 3:
                name = "Liquid elemental";
                description = "Concealment 10(all senses,limited in liquid), insubstantial 1(liquid), swimming 6, enh closeattack";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 4:
                name = "Particulate elemental";
                description = "Elongation 2, insubstantial 2(particulate), enh closeattack";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 5:
                name = "Unstoppable";
                description = "Enh Strength, Enh close attack 2, immortality 5, regeneration 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 10:
                name = "Blast";
                description = "Ranged, accurate 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 9;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 11:
                name = "Retractable Claws and Combat Computer";
                description = "strength based, penetrating 6, enh closeattack 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 2;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 12:
                name = "Combat Computer";
                description = " All-out attack, diehard, evasion, fast grab, imp crit,imp intiative, precise attack(close/concealment), takedown, uncanny dodge";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 2;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 13:
                name = "Jetpack";
                description = "flight 5, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 14:
                name = "Blaster Rifle";
                description = "ranged, accurate 4, easily removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 15:
                name = "Juggernaut";
                description = "enh strength 4, enh close attack 2, Immortality 5, Leaping 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 16:
                name = "Repeater";
                description = "Ranged Multiattack, Accurate 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 20:
                name = "Bestial";
                description = "enh close attack, diehard, evasion, improved critical(unarmed), improved initiative 2, takedown, uncanny dodge, leaping 2, wallcrawling, darkvision";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 21:
                name = "Unholy Strength and Vitality";
                description = "enh strength 3, enh close attack, leaping 3, regeneration 5, speed 3";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 5;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 22:
                name = "Wraith";
                description = "flight 1, insubstantial 4, concentration, strength based damage 2, enhanced close attack";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 22;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 30:
                name = "Damage Resistance";
                description = "imprevious protection 8";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 31:
                name = "Unliving";
                description = "immunity 38(aging, critical hits, fortitude effects, sensory afflictions)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 38;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 40:
                name = "Fast and Tough";
                description = "imprevious protection 2, enh dodge 8, enh parry 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 41:
                name = "Unnatural Speed";
                description = " enh dodge 10, enh parry 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 42:
                name = "Unnatural Toughness";
                description = "imprevious protection 4, enh dodge 6, enh parry 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 50:
                name = "Inhuman Brain";
                description = "Immunity 10(mental effects)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;
            case 51:
                name = "Almost Human";
                description = "Immunity 5(emotion effects), enh will 5";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Armour/Med";
                meshName = "Armour/Med";
                type = ItemTypes.Consturct;
                use = "wear";
                remove = "strip";
                break;

            #endregion
            #region BattleSuit 100-199
            case 100:
                name = "Plasma Blast";
                description = "Ranged, Accurate 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/dagger";
                meshName = "Weapeon/dagger";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 101:
                name = "Electrified Shell";
                description = "Reaction";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/sword";
                meshName = "Weapeon/sword";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 102:
                name = "Electro Stunner";
                description = "Ranged Affliction, accurate 4,resisted by dodge overcome by fort; dazed,stunned,incapicated";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 103:
                name = "Plasma Bolts";
                description = "Ranged Multiattack, accurate 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 104:
                name = "Force Capsule";
                description = "Ranged Affliction, accurate 4, extra condition,resisted by dodge overcome by damage; Hindered and vulnerable,Defensiveless and Immobile";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 105:
                name = "MicroRockets";
                description = "Ranged Burst Area";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 106:
                name = "OmniBlaster";
                description = "Cone Area, Penetrating 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 107:
                name = "Strength/ Accuracy booster";
                description = "Enhanced strength 8, Enhanced close attack 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 108:
                name = "Tractor/Presser Beam";
                description = "Move Object 10, accurate 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 110:
                name = "Ability Amplifier";
                description = "Enh dodge 4, Enh fort 4, Enh parry 4, Enh will 4, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 111:
                name = "Armoured Shell";
                description = "Imprevious protection 8, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 112:
                name = "Sealed Systems";
                description = "Immunity 10(life support), removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 8;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 120:
                name = "Gravity Drivers";
                description = "Flight 7, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 121:
                name = "Space Flight";
                description = "Movement 2(zero-g adaptation, space travel 1), removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 122:
                name = "Locomotion Systems";
                description = "Speed 7, leaping 4, Safe Fall, Swinging, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 123:
                name = "Locomotion Systems";
                description = "Speed 7, leaping 4, Safe Fall, Wallcrawling, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 124:
                name = "Locomotion Systems";
                description = "Speed 7, leaping 4, Swinging, Wallcrawling, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 125:
                name = "Locomotion Systems";
                description = "Speed 7, leaping 4, Wallcrawling 2, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 126:
                name = "Rocket Turbines";
                description = "Flight 7, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 127:
                name = "Aquatic Turbines";
                description = "Swimming 8, Movement 1(aquatic adaption), removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 128:
                name = "Teleport Tech";
                description = "Teleport 3, easy, extended, change direction, change velocity, turnabout, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 130:
                name = "Communication Systems";
                description = "Radio Communication 2, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 6;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            case 131:
                name = "Sensors";
                description = "Senses 2(extended, infrared), removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 2;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Weapeon/axe";
                meshName = "Weapeon/axe";
                type = ItemTypes.BattleSuit;
                use = "equip";
                remove = "unequip";
                break;
            #endregion
            #region CrimeFighter 200-299
            case 200:
                name = "Smartphone";
                description = "ring people";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 2;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 201:
                name = "Motorcycle";
                description = "Medium, str 1, speed 6, defence 10, toughness 8";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 202:
                name = "Knife";
                description = "Strength based, improved crit";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 2;
                damage = 1;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 203:
                name = "Custom Laser Heavy Pistol";
                description = "ranged, accurate 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 204:
                name = "Custom Assault Rifle";
                description = "ranged multiattack, accurate";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 5;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 210:
                name = "Combat Suit";
                description = "Enh str, leap 1, wallcrawling 2, pro 1, infrared senses, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 7;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 211:
                name = "Flight Suit";
                description = "flight 5(wings), ultravision, strength based damage 1, wallcrawling, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 7;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 212:
                name = "Stealth Suit defence";
                description = "concealment 4(all visual), wallcrawling, passive removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 7;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 213:
                name = "Stealth Suit offence";
                description = "ranged afflication: resisted and overcome by fortitude; vulnerable defensiveless, unreliable - 5 shots removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 7;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 220:
                name = "Gimmick Gadgets 0";
                description = "ranged damage, accurate, easily removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 7;
                damage = 5;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 221:
                name = "Gimmick Gadgets 0";
                description = "ranged cloud area afflication, resisted and overcome by fortitude; dazed, stunned, incapacitated, easily removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 7;
                damage = 3;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 222:
                name = "Gimmick Gadgets 1";
                description = "Safe fall, Swinging, easily removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 7;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 230:
                name = "Swingline";
                description = "swinging";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 2;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 240:
                name = "Bolas";
                description = "ranger cumlative afflication, resisted by dodge, overcome by damage, hindered and vulnerable, defensiveless and immobilized";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 241:
                name = "Boomerangs";
                description = "Strength based ranged damage, accurate 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 1;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 242:
                name = "Explosives";
                description = "ranged burst area damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 243:
                name = "Power Knuckles";
                description = "Strength based damage, improved crit, inaccurate";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 3;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 244:
                name = "Taser";
                description = "ranged cumulative afflication, resisted and overcome by fort; dazed, stunned, incapacitated";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            case 245:
                name = "Tear-Gas Pellets";
                description = "ranged cloud area afflication, resisted and overcome by fortitude, dazed and visually impaired, stunned and vis disabled";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.CrimeFighter;
                use = "drink";
                remove = "";
                break;
            
            #endregion
            #region Elemental 300-399
            case 300:
                name = "Elemental constitution";
                description = "Immunity 12(critical hits, life support)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 301:
                name = "Flame Form";
                description = "Immunity 5(fire), insubstantial 3, permenent";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 302:
                name = "Flight";
                description = "flight 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 303:
                name = "Containment Suit";
                description = "Enh str 6, affects coporeal, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 304:
                name = "Flaming Aura";
                description = "Reaction damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 4;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 310:
                name = "Fire Blast";
                description = "Ranged Damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 311:
                name = "Asphyxicate";
                description = "Burst area progressive affliction, resist and overcome fort; dazed, stunned, incapacitated";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 312:
                name = "Fire Ball";
                description = "ranged burst area";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 313:
                name = "Fire Burst";
                description = "Burst area damage, penetrating 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 314:
                name = "Flame Shape";
                description = "sustained shapeable area damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 315:
                name = "Flash";
                description = "Burst area cumulative affliction, resist and overcome fort; vis impaired, vis disabled, vis unaware";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 316:
                name = "Open Flame";
                description = "Environment 6 (Extreme heat, bright light)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 320:
                name = "Andoroid host";
                description = "enh str 6, reduce stamina 7, enh dodge 4, enh parry 4, immunity 20(all fortitude), pro 8";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 34;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 321:
                name = "Gaseous form";
                description = "vis concealment 4, partial, defensive roll 2, enh dodge 9, enh parry 9, insubstantial 2, permenent";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 34;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 330:
                name = "Air blast";
                description = "ranged damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 331:
                name = "Fog";
                description = "environment 12(Visibility -5, 8 mile)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 332:
                name = "Tornado";
                description = "Cyclinder Move object 8, concentration, duration, damaging";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 333:
                name = "Wind Binding";
                description = "ranged afflication, resisted by dodge, overcome by str; hindered and vulnerable, immobile and defensiveless";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 334:
                name = "Wind Control";
                description = "Move object 12";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 335:
                name = "Wind Screen";
                description = "deflect 12, Cylinder area(2), limited to dodge attacks";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 340:
                name = "Earthen Body";
                description = "enh str 8, imp pro 8";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 32;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 341:
                name = "Reconstruction";
                description = "Regeneration 10, Source(Element)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 350:
                name = "Clay form";
                description = "elongation 4, insubstantial 1; morph 4, slithering, wallcrawling, surefooted, speed 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 37;
                damage = 12;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 351:
                name = "Earth form";
                description = "Burrowing 6, permeate(earth), surefooted, Ranged touch, visual concealment 4(earthen limit)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 15;
                damage = 12;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 352:
                name = "Earth Control";
                description = "perception ranged move object 10(earthen limit)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 12;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 353:
                name = "Earth Blast";
                description = "Ranged damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 354:
                name = "Earthen Snare";
                description = "Cumulative afflication, resisted by dodge, overcome by dam; hindered and vulnerable, immobile and defenceless";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 355:
                name = "Particulate form";
                description = "Elongation 7, insubstantial 2, slithering, sure-footed, speed 2, visual concealment 4,partial";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 23;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 356:
                name = "Sandstorm";
                description = "Environment 5(visibility - 5; 500 feet)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 357:
                name = "RockForm";
                description = "Reaction damage, enh str 2, immun 1(own powers), imp pro 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 34;
                damage = 7;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 358:
                name = "GroundStrike";
                description = "Burst area afflication, res fort, over dodge; dazed/vulnerable, stunned/prone, both player and targets have to be grounded";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 359:
                name = "Shockwave";
                description = "Burst area damage, both player and targets have to grounded";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 360:
                name = "Plant Form";
                description = "vis conceal 4(vegetation, immune(plant), teleport 7, medium(plants))";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 361:
                name = "Plant Toxin";
                description = "cumulative afflication, res and over by fort; dazed, stunned, incapacitated";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 362:
                name = "Animate Trees";
                description = "summon 10, controlled, limited to size availiability(tree)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 363:
                name = "Entanglement";
                description = "burst area cumulative afflication, res by dodge, over by dam; hindered and vulnerable, defensiveless and incapacited, limit(ambient plant-life)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 364:
                name = "Plant perception";
                description = "remote sensing 5(all senses), medium(plants)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 365:
                name = "Wood Objects";
                description = "create 7, innate, movable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 366:
                name = "Transmit";
                description = "teleport 10, extended, medium(plants)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 370:
                name = "Liquid form 0";
                description = "visual concealment 4, limit(liquid), elongation 8, immunity 2(water), insubstantial 1,permenent";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 60;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 371:
                name = "Liquid form 1";
                description = "slithering, surefooted, imp pro 8, regen 8, source(water), swimming 7";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 60;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 372:
                name = "Water Blast";
                description = "damage 10";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 373:
                name = "Dehydrate";
                description = "cumulative afflication, res and over fort, fatiqued, exhausted, incapacitated";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 374:
                name = "Drown";
                description = "progr afflication, res and over fort, dazed, stunned, incapicated";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 375:
                name = "Hard Water Objects";
                description = "create 10";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 376:
                name = "Move Water";
                description = "perception ranged move object 10, limit (water)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 377:
                name = "Watery Snare";
                description = "ranged afflication, res by dodge, over by str; hindered and vulnerable, immobile and defensiveless";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 380:
                name = "Ice form";
                description = "Enh Str 8, immunity 7(cold, ice), imp pro 8, tracking, infrared";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 45;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 381:
                name = "Ice Slide";
                description = "flight 5, platform";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;

            case 390:
                name = "Ice Blast";
                description = "ranged damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 391:
                name = "Cold Blast";
                description = "ranged afflication, res and over by fort; fatigued, exhausted, incapacitated";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 392:
                name = "Cold Field";
                description = "environment 10(extreme cold)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 393:
                name = "Icy shapes";
                description = "create 6, continous, innate";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 394:
                name = "Icy Snare";
                description = "cumulative afflication, res dodge, over dam; hindered and vulnerable, immobile and defensiveless";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            case 395:
                name = "Icy surfaces";
                description = "environment 10(impede movement)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Elemental;
                use = "eat";
                remove = "";
                break;
            #endregion
            #region Energy Controller 400-499
            case 400:
                name = "Energy Blast";
                description = "Ranged damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 401:
                name = "Quick change";
                description = "transform costume free action";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 410:
                name = "Enervating Blast";
                description = "ranged damage, incurable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 411:
                name = "Homing Blast";
                description = "ranged damage, homing";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 412:
                name = "Invisible Blast";
                description = "ranged damage, subtle";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 413:
                name = "Phantom Blast";
                description = "ranged damage, affect incorporal";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 414:
                name = "Pinpoint Blast";
                description = "ranged damage, Precise";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 415:
                name = "Proxy Blast";
                description = "ranged damage, indirect";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 416:
                name = "Reflective Blast";
                description = "ranged damage, ricochet";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 417:
                name = "Variable Blast";
                description = "ranged damage, variable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 420:
                name = "Dazzle";
                description = "Cumulative Ranged afflication, res dodge, over fort;impaired, disabled, unaware, vision";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 421:
                name = "Dazzle";
                description = "Cumulative Ranged afflication, res dodge, over fort;impaired, disabled, unaware, audio";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 422:
                name = "Disintegrate";
                description = "Ranged weaken affects objects toughness 8";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 423:
                name = "Energy Burst";
                description = "Burst area damage, penetrating 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 424:
                name = "Energy Burst";
                description = "Ranged Burst area damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 425:
                name = "Energy Constructs";
                description = "Create 12";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 426:
                name = "Energy Manipaulation";
                description = "Deflect 12, reflect, redirect, limit(energy)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 427:
                name = "Energy Weapon";
                description = "penetrating damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 428:
                name = "Enivoronment control";
                description = "environment 12(eight miles, choose two, Cold/Heat/Impede Movement/Light/Visibility)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 429:
                name = "Obscure";
                description = "Ranged Visual concealment 4 attack, burst area";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 430:
                name = "Obscure";
                description = "Ranged Visual concealment 4 attack, cloud area";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 431:
                name = "Snare";
                description = "Cumulative Ranged Affliction, res by dodge, over with dam; hindered and vulnerable, Defensiveless and Immobile";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 432:
                name = "Telekinesis";
                description = "Move object 12";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 440:
                name = "Energy Immunity";
                description = "Immunity 5(energy control)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 441:
                name = "Energy Absorption";
                description = "Enh str 10 (fades), Enh sta 10 (fades)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 442:
                name = "Energy Shield";
                description = "Enh dodge 5, Enh parry 5, Imp pro 5(sustained)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 443:
                name = "Force Field";
                description = "Imp pro 10, sustained";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 450:
                name = "Energy Sense";
                description = "Energy awareness";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 1;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 451:
                name = "Energy Aura";
                description = "Reaction damage, activation(strandard action)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 14;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 452:
                name = "Energy Form";
                description = "Insubstantial 3(energy), activation(move action)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 14;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 453:
                name = "Flight";
                description = "Flight 7";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 14;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 454:
                name = "Scry";
                description = "Visual Remote Sensing 14, medium(energy)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 14;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            case 455:
                name = "Transmit";
                description = "Teleport 14, Medium(energy)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 14;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.EnergyController;
                use = "cook";
                remove = "";
                break;
            #endregion
            #region Gadgeteer 500-599
            case 500:
                name = "Energy Projector Device 0";
                description = "Ranged Damage, Accurate 2, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 501:
                name = "Energy Projector Device 1";
                description = "Burst area afflication, res and over fort, dazed,stunned,incapacitated, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 502:
                name = "Energy Projector Device 2";
                description = "Ranged Multiattack damage, accurate 3, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 5;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 503:
                name = "Energy Projector Device 3";
                description = "Close cone area dazzle, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 9;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 510:
                name = "Force Armour 0";
                description = "Enh str 8, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 511:
                name = "Force Armour 1";
                description = "Burst area afflication, res and over fort, dazed and vulnerable, defenseless and stunned, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 512:
                name = "Force Armour 2";
                description = "Create 8, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 513:
                name = "Force Armour 3";
                description = "Burst Area damage, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 514:
                name = "Force Armour 4";
                description = "Reaction Damage, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 515:
                name = "Force Armour 5";
                description = "Ranged Damage, accurate 2, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 7;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 516:
                name = "Force Armour 6";
                description = "Move Object 8, acttivation(move), Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 520:
                name = "Energy Blast";
                description = "Ranged Damage, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 521:
                name = "Create";
                description = "Create 7, continous, innate, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 522:
                name = "Move";
                description = "Move Object 12, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 523:
                name = "Stun";
                description = "Ranged Afflication, res and over fort; daze4d, stunned, incapacitated, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 524:
                name = "Disable";
                description = "Ranged Afflication, res by dodge, over by dam; vulner, defensiveless, incapicated, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 525:
                name = "Flash";
                description = "Cloud area Ranged Afflication, res and over fort, dazed and vis imp, stun and vis dis, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 526:
                name = "Energy Burst";
                description = "Ranged Burst Damage, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 527:
                name = "Energy Cone";
                description = "Close Cone Damage, penetrate 8, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 530:
                name = "Personal Combat Enhancers 0";
                description = "All-out attack, defensive attack, evasion, extraordinary effort, diehard, fearless, Great endurance, Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 17;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 531:
                name = "Personal Combat Enhancers 1";
                description = "improv crit(unarmed), imp initiative, takedown 2, Enh Str 3, Enh Close attack 5, activation(move), Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 17;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 532:
                name = "Physical Boosters";
                description = "Enh Str 8, leaping 2, quickness 2, speed 2, Activation(move), Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 17;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 540:
                name = "Ray Gun";
                description = "Ranged Damage, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 541:
                name = "Power Truncheon";
                description = "Strengh based Damage, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 542:
                name = "Stunner";
                description = "Ranged Afflication, res and over fort, dazed, stunned, incapicated, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 543:
                name = "Force Capsule Gernade";
                description = "ranged afflication, res by dodge, pver by dam, hinder and vulner, def and immobile, Easily Removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 14;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 550:
                name = "Combat Training";
                description = "Defensive roll 2, Enh dodge 4, Enh parry 4";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 551:
                name = "Armoured Costume";
                description = "pro 4, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 552:
                name = "Displacer field";
                description = "Enh dodge 6, parry 6, pro 4, sustained, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 553:
                name = "Energy-Absorbing Bodysuit";
                description = "pro 10, Imp 6, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 554:
                name = "Force Field";
                description = "Immunity 6(crit, cold, heat, high pressure, radiation), pro 10, sustained, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 13;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 560:
                name = "Biological OverClocking";
                description = "Move-by Action, leaping 2, quickness 2, speed 5, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 561:
                name = "Boot Jets";
                description = "leaping 5, can hover, safe fall, speed 2, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 562:
                name = "Flight Harness";
                description = "Flight 5, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 563:
                name = "Personal Teleporter";
                description = "Teleport 4, increased mass, turnabout, removable";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 570:
                name = "Low-Level Telepath";
                description = "communication 1(mental), concentration, only with loved ones/friends";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 2;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 571:
                name = "Mental Database";
                description = "assessment, Enh insight 2";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 2;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 572:
                name = "Physicially fit";
                description = "speed 2, stacks";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 2;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 573:
                name = "Polymath";
                description = "Quickness 4, limit(mental), stacks";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 2;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            case 574:
                name = "Technopath";
                description = "Comprehend 2, distracting";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 2;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Gadgeteer;
                use = "craft";
                remove = "";
                break;
            #endregion
            #region Martial Artist 600-699
            case 600:
                name = "Death Touch";
                description = "progressive weaken stamina 4, res fort";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 601:
                name = "Flurry of Blows";
                description = "Selective multiattack 5, any attack effect";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 602:
                name = "Iron Fist";
                description = "Strength based damage, penetrating 8, inaccurate";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 12;
                damage = 5;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 603:
                name = "Mental Weapon";
                description = "Damage , alt res(will)";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 12;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 604:
                name = "Nerve Strike";
                description = "Cumulative afflication, res and over fort, dazed, stun, paralyzed";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 12;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 605:
                name = "Restorative Chi";
                description = "Healing 6";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 610:
                name = "Missle Redirection";
                description = "Immunity 5(thrown weapons), concentration duration, reflect, redirect";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 15;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 611:
                name = "Untouchable";
                description = "Immunity(attacks targeting parry), concentration duration";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 15;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 620:
                name = "Chi Sense";
                description = "Danger Sense, detect life-acute,radius,ranged";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 621:
                name = "Mediation";
                description = "Immunity 5(choose 5: aging, cold, disease, heat, need for sleep, poison, starvation and thrist, suffocation(2)), sustained";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 622:
                name = "Perfect Serenitity";
                description = "Immunity 5(interaction effects)";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            case 623:
                name = "Weightless Step";
                description = "Leaping 3, trackless 1";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.MartialArtist;
                use = "open";
                remove = "";
                break;
            #endregion
            #region Mimic 700-799
            case 700:
                name = "Animal Mimicry";
                description = "Variable 10(50, mimic traits of one animal), continous";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 701:
                name = "Mental duplicate";
                description = "Mind reading 10(subject), Variable 10(50, mimic mental traits of one subject), continous, res by will";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 702:
                name = "Nemesis";
                description = "Variable 8(40, mimic traits to fight one subject), continous, free action";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 703:
                name = "Object Mimicry";
                description = "Variable 8(40, mimic object traits by touch), reaction";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 704:
                name = "Power duplicate";
                description = "Variable 10(50, mimic powers of one subject), continous";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 705:
                name = "Power Theft 0";
                description = "cumulative afflication, res and over by will, pow impair, pow dis, transform(powerless)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 706:
                name = "Power theft 1";
                description = "Variable 8(40, mimic powers of one subject), move action, limit(afflicated)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 707:
                name = "Reflex Memory";
                description = "Variable 8(40, mimic observed skills and advantages), continous, free action";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 708:
                name = "Android Body";
                description = "immunity 30(fort), stamina 0, fort 0, pro 5";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            case 709:
                name = "power duplicate";
                description = "Variable 8(50, mimic powers of one subject), continousl";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 80;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mimic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Mystic 800-899
            case 800:
                name = "Magical Blast";
                description = "Ranged Damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 801:
                name = "Billowing Darkness";
                description = "Ranged Burst concealment 4 attack(all vis)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 802:
                name = "Dispel Magic";
                description = "Nullify 8, Broad(magic), simultaneous";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 803:
                name = "Enervation";
                description = "Ranged Weaken 8, broad(physical- one at a time)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 804:
                name = "Enhanced Strength";
                description = "Enh Str 9, Enh Close Attack 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 805:
                name = "Ghost Hands";
                description = "Perception Move Object 7, precise, subtle 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 806:
                name = "Healing Hand";
                description = "Healing 5, energizing, persistent, restorative, stabilize";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 807:
                name = "Maddening Blast";
                description = "Ranged Damage, res will";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 808:
                name = "Mystic Bindings";
                description = "Ranged afflication, res and over by will, hinder/vulner, defensiveless/immobile";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 809:
                name = "Mystic Constructs";
                description = "Create 7,continous, innate, precise, subtle";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 810:
                name = "Phatasm";
                description = "Illusion 4 vs all senses, area, res will, selective";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 811:
                name = "Astral Projection";
                description = "Remote sensing 8(vis, aud, mental), defensiveless, subtle";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 26;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 812:
                name = "Levitation";
                description = "Flight 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 26;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 813:
                name = "Mystic Shield";
                description = "sustained pro, imp 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 26;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 820:
                name = "Apparation";
                description = "Immunity 2(suffocation), insubstantial";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 821:
                name = "Hex";
                description = "Luck control 4(all options), Luck 5";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 822:
                name = "Illusory Appearence";
                description = "Morph 2, attack, burst, selective";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 823:
                name = "Invisibility";
                description = "Conecealment 10(all senses), precise, passive, resistable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 824:
                name = "Message";
                description = "Communication 4(mental)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 825:
                name = "Pierce the Veil";
                description = "Dimension travel 3, affects others";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 826:
                name = "Protective Aura";
                description = "Immunity 7(Cold, heat, pressure, radiation, vacuum, all suffocation), affects others, sustained";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 827:
                name = "Teleportation";
                description = "Teleport 3, accurate, easy, extended, portal";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 830:
                name = "Immortal";
                description = "Immortality 1, immunity 1(aging)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 3;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            case 831:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;


            #endregion
            #region Paragon 900-999
            case 900:
                name = "Find Weakness";
                description = "Strength-based damage, Enh Close Attack 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 8;
                damage = 4;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 901:
                name = "Powerful";
                description = "Enh Str 2, Enh Close Attack 2, powerlift 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 902:
                name = "Super Strength";
                description = "Enh Str 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 903:
                name = "Soldier";
                description = "Enh Close Attack 4, powerlift 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 8;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 910:
                name = "Immunities";
                description = "immunity 10(life support)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 911:
                name = "Invulnerability";
                description = "pro 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 4;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 920:
                name = "Flight";
                description = "Flight 8";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 921:
                name = "Super Movement";
                description = "Speed 3, leaping 7, swinging, wallcrawling 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 16;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 930:
                name = "Improved Invulnerability";
                description = "Impervious toughness 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 6;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 931:
                name = "Inhuman Physiology";
                description = "diehard, immunity 2(crit), Regeneration 3";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 6;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 932:
                name = "Enhanced Senses";
                description = "extended audio 2, extended vis 2, microscopic vision, ultra hearing";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 6;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 933:
                name = "Quickness";
                description = "Quickness 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 6;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 934:
                name = "Telepathy";
                description = "mental communication 1, subtle 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 6;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            case 935:
                name = "Traveller";
                description = "dimension travel 3";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 6;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Paragon;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Powerhouse 1000-1099
            case 1000:
                name = "Density";
                description = "-4 dodge, -4 parry, +8 str, +8 sta, pro 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1001:
                name = "Growth";
                description = "-4 dodge, -4 parry, -8 stealth, +4 intimidation, +1 speed, +8 str, +8 sta, pro 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1002:
                name = "Solid Form";
                description = "Enh str 8, immunity 2(crit), powerlift 3, Activation(move)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1003:
                name = "Super Strength";
                description = "Enh str 8, powerlift 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1010:
                name = "Energy Blast";
                description = "Ranged Damage, accurate 5, distracting, tiring";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1011:
                name = "Foot Stomp";
                description = "Line Damage, player and targets must be on same surface";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1012:
                name = "GroundStrike";
                description = "Burst afflication, res and over for, daze/hinder, stun/prone, incapicated, instant recovery player and targets must be on same surface";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1013:
                name = "Shockwave";
                description = "Burst Damage, player and targets must be on same surface";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1014:
                name = "Super Breath 0";
                description = "Close cone move object 5, limited (towards and away)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1015:
                name = "Super Breath 1";
                description = "cone Damage, Unreliable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 5;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1016:
                name = "Cut Loose";
                description = "Penetrating 10 on strength";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1017:
                name = "ThunderClap";
                description = "Cone afflication, res and over fort, dazed,stun";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1020:
                name = "Super Stamina";
                description = "Enh Sta 10";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1021:
                name = "Invulnerability";
                description = "Immunity 10(common power description)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1022:
                name = "Life Support";
                description = "Immunity 10(Life Support)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1023:
                name = "Resistant";
                description = "Immunity 10(two 5 point immunities)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1024:
                name = "Thick Skin";
                description = "Imprevious Toughness 10";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1030:
                name = "Burrowing";
                description = "burrowing 6, penetrating";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1031:
                name = "Flight";
                description = "Flight 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1032:
                name = "Super Leaping";
                description = "leaping 12";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1033:
                name = "Super Movement";
                description = "Speed 5, leaping 7";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 12;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1040:
                name = "Faster Burrowing";
                description = "burrowing 7, penetrating, infravision, Direction sense, distance sense";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 17;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1041:
                name = "Faster Flight";
                description = "Flight 7, AE Swimming 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 17;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1042:
                name = "Faster Super Leaping";
                description = "leaping 17";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 17;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1043:
                name = "Faster Super Movement";
                description = "Speed 7, leaping 10";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 17;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1044:
                name = "Enhanced Sense";
                description = "Extended audio 2, extended vis 2, low-light vis";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1045:
                name = "Fast Recovery";
                description = "Regen 4, diehard";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1046:
                name = "Immortal";
                description = "Immortality 2, diehard";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1047:
                name = "Like Hitting A Brick Wall";
                description = "Reaction damage, penetrating";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 1;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            case 1048:
                name = "Pliable Form";
                description = "Elongation 1, permeate, safe fall";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.PowerHouse;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Psychic 1100-1199
            case 1100:
                name = "Telepathy";
                description = "Mind reading 5, linked to area mental communication 3";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1101:
                name = "ESP";
                description = "Remote Sensing 6, vis, audio, mental";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1102:
                name = "Mental Blast";
                description = "Perception Range Damage, res will";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1103:
                name = "Psi-Knife";
                description = "Damage, penetrating 4, accurate 4, res will";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1104:
                name = "Psionic Invisibility";
                description = "Concealment 10, affects other, limited(brains), precise, reach";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1105:
                name = "Sleep Touch";
                description = "Cumulative afflication, res dodge, over will, fatiqued, exhaust, asleep, accurate 3, insidious, subtle 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 9;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1106:
                name = "Telekinetic Weapon";
                description = "damage, accurate 4, affects insubstantial, penetrating 8, reach, split";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1110:
                name = "Telepathy";
                description = "Mind reading 5, linked to area mental communication 3";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 25;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1111:
                name = "ESP";
                description = "Remote Sensing 6, vis, audio, mental";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1112:
                name = "Mental Blast";
                description = "Perception Range Damage, res will";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1113:
                name = "Induce Blindness";
                description = "Perception Range cumulative afflication, res/over will, vis impair, vis Disable, vis Unaware";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1114:
                name = "Mental Illusion";
                description = "Illusion 6(all senses), feedback, res will, selective";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1115:
                name = "Mental Paraylsis";
                description = "Perception Range cumulative Affflication, res/over will; dazed, stun, parazlyed";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1116:
                name = "Mind control";
                description = "Perception Range cumulative Affflication, res/over will; dazed, compelled, controlled";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1117:
                name = "Weaken Resolve";
                description = "Perception range weaken will 8";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 6;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1120:
                name = "Telekinesis";
                description = "Move Object 10, accurate 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1121:
                name = "Telekinetic Column";
                description = "Line 2 Damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1122:
                name = "Telekinetic Constructs";
                description = "Create 8, movable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1123:
                name = "Telekinetic Bolt";
                description = "Ranged Damage, accurate 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1124:
                name = "Telekinetic Grab";
                description = "Ranged Concentration afflication, res dodge, over dam, hinder/vulner, defenceless/immobile, accurate 4, instant recovery";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1125:
                name = "Telekinetic Hammer";
                description = "Ranged burst Damage";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1126:
                name = "Telekinetic Snare";
                description = "Ranged Cumalative afflication, res dodge, over dam, hinder/vulner, defenceless/immobile, accurate 4, Limit(nearby objects)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1127:
                name = "Telekinetic Weapon";
                description = "Damage, accurate 4, affects insubstantial 2, penetrating 8, reach, split";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1130:
                name = "Armoured Costume";
                description = "Protection 4, subtle, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1131:
                name = "Combat Training";
                description = "defensive attack, defensive roll 2, evasion, imp defence, imp initiative, instant up, takedown";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1132:
                name = "Combat Training";
                description = "Enh Dodge 4, Enh Parry 4";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1133:
                name = "Precognitive Reactions";
                description = "Defensive roll 4, evasion 2, imp def, imp initiative, Enh dodge 6, Enh Parry 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1134:
                name = "Psychokinetic Shield";
                description = "Pro 10, imp 5, sustained, Immunity(mental), limit(half)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1135:
                name = "Telekinetic Shield";
                description = "Imp pro 10, sustained";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 20;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1140:
                name = "Levitation";
                description = "Flight 2, subtle";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1141:
                name = "Mental Awareness";
                description = "mental awareness, acute, detect, radius, range";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1142:
                name = "Telekinetic Flight";
                description = "Flight 5, distracting";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1143:
                name = "Telekinetic Hands";
                description = "Move object 2, precise";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1144:
                name = "Telepathic Translation";
                description = "Comprehend Languages 3(speak, understand, understood), noticable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1145:
                name = "Healing";
                description = "Empathic Healing 4, stabilize";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1146:
                name = "Inhuman";
                description = "Immunity 5(crit, disease, poison, one environmental)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1147:
                name = "Immortal";
                description = "Immortality 2, immunity(aging)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            case 1148:
                name = "Space Bending";
                description = "Teleport 2, accurate, distracting, subtle";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Psychic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Shapeshifter 1200-1299
            case 1200:
                name = "Shapeshifter";
                description = "Variable 9(45 points, assume different shapes), move action";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1201:
                name = "Specific Shapeshifter";
                description = "Variable 9(45 points, assume different shapes), continous, limit(one entity), move action";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1210:
                name = "Giant Size 0";
                description = "Growth 10, + 10 Str, + 10 Str, -5 dodge, -5 parry, -10 stealth, +5 intimidation +1 speed, continous";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1211:
                name = "Giant Size 1";
                description = "Accurate Att, Great Endur, Imp Grab, Imp Hold, Imp smash, interpose, Pow Att, Ult Effort(tough)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1212:
                name = "Giant Size 2";
                description = "Enh dodge 1, Enh Parry 1, Fort -6, Enh Pre, close combat(unarmed)-2, intimidation 4, immunity 5(bullets)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1213:
                name = "Giant Size 3";
                description = "Imp toughness 12, pro 1, powerlift 2";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1214:
                name = "Flight Harness";
                description = "Flight 6, limited(not grown), removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1220:
                name = "Shrinking 0";
                description = "Shrinking 12, dodge 6, parry 6, stealth 12, -6 intimid, continous, norm strength";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1221:
                name = "Shrinking 1";
                description = "damage, limit (damage linked to shrinking)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 8;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1222:
                name = "Shrinking 2";
                description = "Evasion 2, hide in sight, Imp def, Imp trip, Pow Att, redirect, Set-up, taunt, Ult Effort(dodge), imp pro 1";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1223:
                name = "Flight Harness";
                description = "Flight 5, removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1230:
                name = "Density Increase 0";
                description = "Growth 5, +5 Str, +5 Sta, density, continous";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1231:
                name = "Density Increase 1";
                description = "Enh Sta 5, Enh Str 5, - 3 def roll, - 2 close combat(unarmed), fort - 6";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1232:
                name = "Density Increase 2";
                description = "all att, great endur, Imp grab, Imp hold, Imp smash, interpose, Pow Att, Ult Eff(toughness)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1233:
                name = "Density Increase 3";
                description = "Immunity 17(life support, bullets, crit), Imp tough 12";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1234:
                name = "Like Hitting a Brick Wall";
                description = "Reaction damage, when hit";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 1;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1235:
                name = "Foot Stomp";
                description = "Line Damage, both target and player must share surface";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 10;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1236:
                name = "Flight Harness";
                description = "Flight 6, Limit(growth inactive), removable";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1240:
                name = "Density Decrease 0";
                description = "Insubstantial 4(incorporal, affected by magic), reaction";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1241:
                name = "Density Decrease 1";
                description = "Flight 1, limit(airwalking), immunity 10(life support, suffocation(when holding breath))";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1242:
                name = "Density Decrease 2";
                description = "Concealment 1(hearing), continous";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 72;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1243:
                name = "Incorporal Weapon";
                description = "Affect corporal, damage, res fort, Limit(toughness of weapon)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            case 1244:
                name = "Disrupts Electronics";
                description = "Affect corporal, damage, res fort, Limit(toughness of weapon)";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 12;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Shapeshifter;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Speedster 1300-1399
            case 1300:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Summoner 1400-1499
            case 1400:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Supernatural Creature 1500-1599
            case 1500:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Totem 1600-1699
            case 1600:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Warrior 1700-1799
            case 1700:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Weapon Master 1800-1899
            case 1800:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
            #endregion
            #region Weather Controller 1900-1999
            case 1900:
                name = "Mystic awareness";
                description = "senses 3, mystic awareness, analytical, radius";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 24;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Mystic;
                use = "use";
                remove = "";
                break;
                #endregion
        }
        Item temp = new Item
        {

            ID = itemId,
            Name = name,
            Description = description,
            Value = value,
            Amount = amount,
            Damage = damage,
            Armour = armour,
            Heal = heal,
            //loads the icon and gameobject from the folders when needed
            IconName = Resources.Load("Icons/" + iconName) as Sprite,
            MeshName = Resources.Load("Prefabs/" + meshName) as GameObject,
            ItemType = type,
            RemoveItem = remove,
            UseItem = use

        };
        return temp;
        #endregion
    }
}