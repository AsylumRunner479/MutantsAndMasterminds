
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
        ItemTypes type = ItemTypes.Misc;
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
            #region Craftable 500-599
            case 500:
                name = "mushroom";
                description = "get high";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/mushroom";
                meshName = "Craftable/mushroom";
                type = ItemTypes.Craftable;
                use = "craft";
                remove = "";
                break;
            case 501:
                name = "grass";
                description = "get high";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 15;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/grass";
                meshName = "Craftable/grass";
                type = ItemTypes.Craftable;
                use = "craft";
                remove = "";
                break;
            case 502:
                name = "flower";
                description = "very pretty";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 50;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Craftable/flower";
                meshName = "Craftable/flower";
                type = ItemTypes.Craftable;
                use = "craft";
                remove = "";
                break;
            #endregion
            #region Quest 600-699
            case 600:
                name = "purple key";
                description = "opens purple doors";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/purple";
                meshName = "Quest/purple";
                type = ItemTypes.Quest;
                use = "open";
                remove = "";
                break;
            case 601:
                name = "yellow key";
                description = "opens yellow doors";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/yellow";
                meshName = "Quest/yellow";
                type = ItemTypes.Quest;
                use = "open";
                remove = "";
                break;
            case 602:
                name = "green key";
                description = "opens green doors";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Quest/green";
                meshName = "Quest/green";
                type = ItemTypes.Quest;
                use = "open";
                remove = "";
                break;
            #endregion
            #region Misc 700-799
            case 700:
                name = "diamond";
                description = "why do you have this";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 1000;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/trans";
                meshName = "Misc/trans";
                type = ItemTypes.Misc;
                use = "use";
                remove = "";
                break;
            case 701:
                name = "onyx";
                description = "why do you have this";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/black";
                meshName = "Misc/black";
                type = ItemTypes.Misc;
                use = "use";
                remove = "";
                break;
            case 702:
                name = "gold";
                description = "why do you have this";
                //Amount of items of that type...Stackable
                amount = 0;
                //Buy and Sell Price
                value = 100;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Misc/yellow";
                meshName = "Misc/yellow";
                type = ItemTypes.Misc;
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