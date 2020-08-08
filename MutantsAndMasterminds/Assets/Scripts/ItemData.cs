
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
            case 42:
                name = "Fast and Tough";
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
            #region Potion 200-299
            case 200:
                name = "minHealth";
                description = "take plenty of drugs";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 1;
                damage = 0;
                armour = 0;
                heal = 10;
                iconName = "Potion/minHealth";
                meshName = "Potion/minHealth";
                type = ItemTypes.Potion;
                use = "drink";
                remove = "";
                break;
            case 201:
                name = "medHealth";
                description = "take plenty of drugs";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 3;
                damage = 0;
                armour = 0;
                heal = 30;
                iconName = "Potion/medHealth";
                meshName = "Potion/medHealth";
                type = ItemTypes.Potion;
                use = "drink";
                remove = "";
                break;
            case 202:
                name = "maxHealth";
                description = "take plenty of drugs";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 100;
                iconName = "Potion/maxHealth";
                meshName = "Potion/maxHealth";
                type = ItemTypes.Potion;
                use = "drink";
                remove = "";
                break;
            #endregion
            #region Food 300-399
            case 300:
                name = "Apple";
                description = "Munchies and Crunchies";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 1;
                damage = 0;
                armour = 0;
                heal = 2;
                iconName = "Food/Apple";
                meshName = "Food/Apple";
                type = ItemTypes.Food;
                use = "eat";
                remove = "";
                break;
            case 301:
                name = "Meat";
                description = "Lisa does not approve";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 5;
                iconName = "Food/Meat";
                meshName = "Food/Meat";
                type = ItemTypes.Food;
                use = "eat";
                remove = "";
                break;
            case 302:
                name = "Pizza";
                description = "Mamma Mia";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 10;
                damage = 0;
                armour = 0;
                heal = 15;
                iconName = "Food/Pizza";
                meshName = "Food/Pizza";
                type = ItemTypes.Food;
                use = "eat";
                remove = "";
                break;
            #endregion
            #region Ingredient 400-499
            case 400:
                name = "wood";
                description = "Got wood";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 5;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/wood";
                meshName = "Ingrediant/wood";
                type = ItemTypes.Ingredient;
                use = "cook";
                remove = "";
                break;
            case 401:
                name = "stone";
                description = "don't get high";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 15;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/stone";
                meshName = "Ingrediant/stone";
                type = ItemTypes.Ingredient;
                use = "cook";
                remove = "";
                break;
            case 402:
                name = "steel";
                description = "It's real";
                //Amount of items of that type...Stackable
                amount = 1;
                //Buy and Sell Price
                value = 50;
                damage = 0;
                armour = 0;
                heal = 0;
                iconName = "Ingrediant/steel";
                meshName = "Ingrediant/steel";
                type = ItemTypes.Ingredient;
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