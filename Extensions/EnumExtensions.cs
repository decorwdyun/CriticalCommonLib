using System;
using System.Collections.Generic;
using System.Linq;
using CriticalCommonLib.Enums;
using CriticalCommonLib.Models;

namespace CriticalCommonLib.Extensions
{
    public static class EnumExtensions
    {
        public static IEnumerable<TEnum> GetFlags<TEnum>(this TEnum enumValue)
            where TEnum : Enum
        {
            return EnumUtil.GetFlags<TEnum>().Where(ev => enumValue.HasFlag(ev));
        }
        
        public static string FormattedName(this CharacterSex characterSex)
        {
            switch (characterSex)
            {
                case CharacterSex.Both:
                    return "Both";
                case CharacterSex.Either:
                    return "Either"; 
                case CharacterSex.Female:
                    return "Female"; 
                case CharacterSex.Male:
                    return "Male"; 
                case CharacterSex.FemaleOnly:
                    return "Female Only"; 
                case CharacterSex.MaleOnly:
                    return "Male Only"; 
                case CharacterSex.NotApplicable:
                    return "N/A"; 
            }

            return "Unknown";
        }
        public static string FormattedName(this CharacterRace characterRace)
        {
            switch (characterRace)
            {
                case CharacterRace.Any:
                    return "Any";
                case CharacterRace.Hyur:
                    return "Hyur"; 
                case CharacterRace.Elezen:
                    return "Elezen"; 
                case CharacterRace.Lalafell:
                    return "Lalafell"; 
                case CharacterRace.Miqote:
                    return "Miqote"; 
                case CharacterRace.Roegadyn:
                    return "Roegadyn"; 
                case CharacterRace.Viera:
                    return "Viera"; 
                case CharacterRace.AuRa:
                    return "Au Ra"; 
                case CharacterRace.None:
                    return "None"; 
            }

            return "N/A";
        }

        public static List<InventoryType> GetTypes(this InventoryCategory category)
        {
            switch (category)
            {
                case InventoryCategory.CharacterBags:
                    return new List<InventoryType>()
                        {InventoryType.Bag0, InventoryType.Bag1, InventoryType.Bag2, InventoryType.Bag3};
                case InventoryCategory.RetainerBags:
                    return new List<InventoryType>()
                        {InventoryType.RetainerBag0, InventoryType.RetainerBag1, InventoryType.RetainerBag2, InventoryType.RetainerBag3, InventoryType.RetainerBag4, InventoryType.RetainerBag5, InventoryType.RetainerBag6};
                case InventoryCategory.Armoire:
                    return new List<InventoryType>()
                        {InventoryType.Armoire};
                case InventoryCategory.Crystals:
                    return new List<InventoryType>()
                        {InventoryType.Crystal,InventoryType.RetainerCrystal, InventoryType.FreeCompanyCrystal};
                case InventoryCategory.Currency:
                    return new List<InventoryType>()
                        {InventoryType.Currency,InventoryType.FreeCompanyGil, InventoryType.RetainerGil, InventoryType.FreeCompanyCurrency};
                case InventoryCategory.CharacterEquipped:
                    return new List<InventoryType>()
                        {InventoryType.GearSet0};
                case InventoryCategory.CharacterArmoryChest:
                    return new List<InventoryType>()
                        {InventoryType.ArmoryBody, InventoryType.ArmoryEar , InventoryType.ArmoryFeet , InventoryType.ArmoryHand , InventoryType.ArmoryHead , InventoryType.ArmoryLegs , InventoryType.ArmoryLegs , InventoryType.ArmoryMain , InventoryType.ArmoryNeck , InventoryType.ArmoryOff , InventoryType.ArmoryRing , InventoryType.ArmoryWaist , InventoryType.ArmoryWrist};
                case InventoryCategory.GlamourChest:
                    return new List<InventoryType>()
                        {InventoryType.GlamourChest};
                case InventoryCategory.RetainerEquipped:
                    return new List<InventoryType>()
                        {InventoryType.RetainerEquippedGear};
                case InventoryCategory.RetainerMarket:
                    return new List<InventoryType>()
                        {InventoryType.RetainerMarket};
                case InventoryCategory.CharacterSaddleBags:
                    return new List<InventoryType>()
                        {InventoryType.SaddleBag0,InventoryType.SaddleBag1};
                case InventoryCategory.CharacterPremiumSaddleBags:
                    return new List<InventoryType>()
                        {InventoryType.PremiumSaddleBag0,InventoryType.PremiumSaddleBag1};
                case InventoryCategory.FreeCompanyBags:
                    return new List<InventoryType>()
                        {InventoryType.FreeCompanyBag0,InventoryType.FreeCompanyBag1,InventoryType.FreeCompanyBag2,InventoryType.FreeCompanyBag3,InventoryType.FreeCompanyBag4,InventoryType.FreeCompanyBag5,InventoryType.FreeCompanyBag6,InventoryType.FreeCompanyBag7,InventoryType.FreeCompanyBag8,InventoryType.FreeCompanyBag9,InventoryType.FreeCompanyBag10};
                case InventoryCategory.HousingInteriorItems:
                    return new List<InventoryType>()
                        {
                            InventoryType.HousingInteriorPlacedItems1, InventoryType.HousingInteriorPlacedItems2,
                            InventoryType.HousingInteriorPlacedItems3, InventoryType.HousingInteriorPlacedItems4,
                            InventoryType.HousingInteriorPlacedItems5, InventoryType.HousingInteriorPlacedItems6,
                            InventoryType.HousingInteriorPlacedItems7, InventoryType.HousingInteriorPlacedItems8,
                        };
                case InventoryCategory.HousingInteriorStoreroom:
                    return new List<InventoryType>()
                        {
                            InventoryType.HousingInteriorStoreroom1, InventoryType.HousingInteriorStoreroom2,
                            InventoryType.HousingInteriorStoreroom3, InventoryType.HousingInteriorStoreroom4,
                            InventoryType.HousingInteriorStoreroom5, InventoryType.HousingInteriorStoreroom6,
                            InventoryType.HousingInteriorStoreroom7, InventoryType.HousingInteriorStoreroom8,
                        };
                case InventoryCategory.HousingInteriorAppearance:
                    return new List<InventoryType>()
                        {
                            InventoryType.HousingInteriorAppearance
                        };
                case InventoryCategory.HousingExteriorStoreroom:
                    return new List<InventoryType>()
                        {
                            InventoryType.HousingExteriorStoreroom
                        };
                case InventoryCategory.HousingExteriorItems:
                    return new List<InventoryType>()
                        {
                            InventoryType.HousingExteriorPlacedItems
                        };
                case InventoryCategory.HousingExteriorAppearance:
                    return new List<InventoryType>()
                        {
                            InventoryType.HousingExteriorAppearance
                        };
            }

            return new List<InventoryType>();
        }

        public static bool IsRetainerCategory(this InventoryCategory category)
        {
            return category is InventoryCategory.RetainerBags or InventoryCategory.RetainerEquipped or InventoryCategory
                .RetainerMarket or InventoryCategory.Crystals or InventoryCategory.Currency;
        }

        public static bool IsFreeCompanyCategory(this InventoryCategory category)
        {
            return category is InventoryCategory.FreeCompanyBags or InventoryCategory.Crystals or InventoryCategory.Currency;
        }

        public static bool IsHousingCategory(this InventoryCategory category)
        {
            return category is InventoryCategory.HousingExteriorAppearance or InventoryCategory.HousingExteriorItems or InventoryCategory.HousingExteriorStoreroom or InventoryCategory.HousingInteriorAppearance or InventoryCategory.HousingInteriorItems or InventoryCategory.HousingInteriorStoreroom;
        }

        public static bool IsCharacterCategory(this InventoryCategory category)
        {
            return !IsRetainerCategory(category) && !IsFreeCompanyCategory(category) && !IsHousingCategory(category) || category == InventoryCategory.Crystals || category == InventoryCategory.Currency;
        }
        
        public static InventoryCategory ToInventoryCategory(this InventoryType type)
        {
            switch (type)
            {
                case InventoryType.Armoire:
                    return InventoryCategory.Armoire;
                case InventoryType.Bag0 :
                    return InventoryCategory.CharacterBags;
                case InventoryType.Bag1 :
                    return InventoryCategory.CharacterBags;
                case InventoryType.Bag2 :
                    return InventoryCategory.CharacterBags;
                case InventoryType.Bag3 :
                    return InventoryCategory.CharacterBags;
                case InventoryType.ArmoryBody :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryEar :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryFeet :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryHand :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryHead :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryLegs :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryMain :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryNeck :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryOff :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryRing :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryWaist :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmoryWrist :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.ArmorySoulCrystal :
                    return InventoryCategory.CharacterArmoryChest;
                case InventoryType.RetainerMarket :
                    return InventoryCategory.RetainerMarket;
                case InventoryType.RetainerEquippedGear :
                    return InventoryCategory.RetainerEquipped;
                case InventoryType.GlamourChest :
                    return InventoryCategory.GlamourChest;
                case InventoryType.RetainerBag0 :
                    return InventoryCategory.RetainerBags;
                case InventoryType.RetainerBag1 :
                    return InventoryCategory.RetainerBags;
                case InventoryType.RetainerBag2 :
                    return InventoryCategory.RetainerBags;
                case InventoryType.RetainerBag3 :
                    return InventoryCategory.RetainerBags;
                case InventoryType.RetainerBag4 :
                    return InventoryCategory.RetainerBags;
                case InventoryType.RetainerBag5 :
                    return InventoryCategory.RetainerBags;
                case InventoryType.SaddleBag0 :
                    return InventoryCategory.CharacterSaddleBags;
                case InventoryType.SaddleBag1 :
                    return InventoryCategory.CharacterSaddleBags;
                case InventoryType.PremiumSaddleBag0 :
                    return InventoryCategory.CharacterPremiumSaddleBags;
                case InventoryType.PremiumSaddleBag1 :
                    return InventoryCategory.CharacterPremiumSaddleBags;
                case InventoryType.FreeCompanyBag0 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag1 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag2 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag3 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag4 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag5 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag6 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag7 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag8 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag9 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyBag10 :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyCrystal :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.HousingInteriorStoreroom1 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingInteriorStoreroom2 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingInteriorStoreroom3 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingInteriorStoreroom4 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingInteriorStoreroom5 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingInteriorStoreroom6 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingInteriorStoreroom7 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingInteriorStoreroom8 :
                    return InventoryCategory.HousingInteriorStoreroom;
                case InventoryType.HousingExteriorAppearance :
                    return InventoryCategory.HousingExteriorAppearance;
                case InventoryType.HousingExteriorStoreroom :
                    return InventoryCategory.HousingExteriorStoreroom;
                case InventoryType.HousingExteriorPlacedItems :
                    return InventoryCategory.HousingExteriorItems;
                case InventoryType.HousingInteriorPlacedItems1 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorPlacedItems2 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorPlacedItems3 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorPlacedItems4 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorPlacedItems5 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorPlacedItems6 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorPlacedItems7 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorPlacedItems8 :
                    return InventoryCategory.HousingInteriorItems;
                case InventoryType.HousingInteriorAppearance :
                    return InventoryCategory.HousingInteriorAppearance;
                case InventoryType.RetainerGil :
                    return InventoryCategory.Currency;
                case InventoryType.Currency :
                    return InventoryCategory.Currency;
                case InventoryType.FreeCompanyGil :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.FreeCompanyCurrency :
                    return InventoryCategory.FreeCompanyBags;
                case InventoryType.Crystal :
                    return InventoryCategory.Crystals;
                case InventoryType.RetainerCrystal :
                    return InventoryCategory.Crystals;
            }
            return InventoryCategory.Other;
        }
        public static string FormattedName(this InventoryCategory category)
        {
            switch (category)
            {
                case InventoryCategory.CharacterBags:
                    return "背包";
                case InventoryCategory.CharacterSaddleBags:
                    return "陆行鸟鞍囊";
                case InventoryCategory.CharacterPremiumSaddleBags:
                    return "豪华陆行鸟鞍囊";
                case InventoryCategory.FreeCompanyBags:
                    return "部队储物柜";
                case InventoryCategory.CharacterArmoryChest:
                    return "兵装库";
                case InventoryCategory.GlamourChest:
                    return "幻化柜";
                case InventoryCategory.CharacterEquipped:
                    return "装备中";
                case InventoryCategory.Armoire:
                    return "收藏柜";
                case InventoryCategory.RetainerBags:
                    return "雇员背包";
                case InventoryCategory.RetainerMarket:
                    return "雇员出售列表";
                case InventoryCategory.Currency:
                    return "货币";
                case InventoryCategory.Crystals:
                    return "水晶";
                case InventoryCategory.HousingExteriorAppearance:
                    return "庭院外观";
                case InventoryCategory.HousingExteriorItems:
                    return "庭院已布置物品";
                case InventoryCategory.HousingExteriorStoreroom:
                    return "庭院仓库";
                case InventoryCategory.HousingInteriorAppearance:
                    return "房屋外观";
                case InventoryCategory.HousingInteriorItems:
                    return "房屋已布置物品";
                case InventoryCategory.HousingInteriorStoreroom:
                    return "房屋仓库";
                case InventoryCategory.RetainerEquipped:
                    return "雇员装备中";
            }

            return category.ToString();
        }
        
        public static string FormattedDetailedName(this InventoryCategory category)
        {
            switch (category)
            {
                case InventoryCategory.CharacterBags:
                    return "角色背包";
                case InventoryCategory.CharacterSaddleBags:
                    return "陆行鸟鞍囊";
                case InventoryCategory.CharacterPremiumSaddleBags:
                    return "豪华陆行鸟鞍囊";
                case InventoryCategory.FreeCompanyBags:
                    return "部队储物柜";
                case InventoryCategory.CharacterArmoryChest:
                    return "兵装库";
                case InventoryCategory.GlamourChest:
                    return "幻化柜";
                case InventoryCategory.CharacterEquipped:
                    return "角色装备中";
                case InventoryCategory.Armoire:
                    return "收藏柜";
                case InventoryCategory.RetainerBags:
                    return "雇员背包";
                case InventoryCategory.RetainerMarket:
                    return "雇员出售列表";
                case InventoryCategory.Currency:
                    return "货币";
                case InventoryCategory.Crystals:
                    return "水晶";
                case InventoryCategory.HousingExteriorAppearance:
                    return "庭院外观";
                case InventoryCategory.HousingExteriorItems:
                    return "庭院已布置物品";
                case InventoryCategory.HousingExteriorStoreroom:
                    return "庭院仓库";
                case InventoryCategory.HousingInteriorAppearance:
                    return "房屋外观";
                case InventoryCategory.HousingInteriorItems:
                    return "房屋已布置物品";
                case InventoryCategory.HousingInteriorStoreroom:
                    return "房屋仓库";
                case InventoryCategory.RetainerEquipped:
                    return "雇员装备中";
            }

            return category.ToString();
        }
        
        public static string FormattedName(this InventoryType type)
        {
            switch (type)
            {
                case InventoryType.Bag0:
                    return "角色背包 - 1";
                case InventoryType.Bag1:
                    return "角色背包 - 2";
                case InventoryType.Bag2:
                    return "角色背包 - 3";
                case InventoryType.Bag3:
                    return "角色背包 - 4";
                case InventoryType.GearSet0:
                    return "套装 - 1";
                case InventoryType.GearSet1:
                    return "套装 - 2";
                case InventoryType.Currency:
                    return "货币";
                case InventoryType.Crystal:
                    return "水晶";
                case InventoryType.Mail:
                    return "邮件";
                case InventoryType.KeyItem:
                    return "重要物品";
                case InventoryType.HandIn:
                    return "任务物品";
                case InventoryType.DamagedGear:
                    return "损坏装备";
                case InventoryType.UNKNOWN_2008:
                    break;
                case InventoryType.Examine:
                    return "检查";
                case InventoryType.Armoire:
                    return "收藏柜";
                case InventoryType.GlamourChest:
                    return "幻化柜";
                case InventoryType.FreeCompanyCurrency:
                    return "部队储物柜货币";
                case InventoryType.ArmoryOff:
                    return "兵装库 - 副手";
                case InventoryType.ArmoryHead:
                    return "兵装库 - 头部";
                case InventoryType.ArmoryBody:
                    return "兵装库 - 身体";
                case InventoryType.ArmoryHand:
                    return "兵装库 - 手部";
                case InventoryType.ArmoryWaist:
                    return "兵装库 - 腰部";
                case InventoryType.ArmoryLegs:
                    return "兵装库 - 腿部";
                case InventoryType.ArmoryFeet:
                    return "兵装库 - 脚部";
                case InventoryType.ArmoryEar:
                    return "兵装库 - 耳饰";
                case InventoryType.ArmoryNeck:
                    return "兵装库 - 项链";
                case InventoryType.ArmoryWrist:
                    return "兵装库 - 手镯";
                case InventoryType.ArmoryRing:
                    return "兵装库 - 戒指";
                case InventoryType.ArmorySoulCrystal:
                    return "兵装库 - 灵魂水晶";
                case InventoryType.ArmoryMain:
                    return "兵装库 - 主手";
                case InventoryType.SaddleBag0:
                    return "陆行鸟鞍囊 - 1";
                case InventoryType.SaddleBag1:
                    return "陆行鸟鞍囊 - 2";
                case InventoryType.PremiumSaddleBag0:
                    return "高级陆行鸟鞍囊 - 1";
                case InventoryType.PremiumSaddleBag1:
                    return "高级陆行鸟鞍囊 - 2";
                case InventoryType.RetainerBag0:
                    return "雇员背包 - 1";
                case InventoryType.RetainerBag1:
                    return "雇员背包 - 2";
                case InventoryType.RetainerBag2:
                    return "雇员背包 - 3";
                case InventoryType.RetainerBag3:
                    return "雇员背包 - 4";
                case InventoryType.RetainerBag4:
                    return "雇员背包 - 5";
                case InventoryType.RetainerBag5:
                    return "雇员背包 - 6";
                case InventoryType.RetainerBag6:
                    return "雇员背包 - 7";
                case InventoryType.RetainerEquippedGear:
                    return "雇员装备中";
                case InventoryType.RetainerGil:
                    return "雇员金币";
                case InventoryType.RetainerCrystal:
                    return "雇员水晶";
                case InventoryType.RetainerMarket:
                    return "雇员出售列表";
                case InventoryType.FreeCompanyBag0:
                    return "部队储物柜 - 1";
                case InventoryType.FreeCompanyBag1:
                    return "部队储物柜 - 2";
                case InventoryType.FreeCompanyBag2:
                    return "部队储物柜 - 3";
                case InventoryType.FreeCompanyBag3:
                    return "部队储物柜 - 4";
                case InventoryType.FreeCompanyBag4:
                    return "部队储物柜 - 5";
                case InventoryType.FreeCompanyBag5:
                    return "部队储物柜 - 6";
                case InventoryType.FreeCompanyBag6:
                    return "部队储物柜 - 7";
                case InventoryType.FreeCompanyBag7:
                    return "部队储物柜 - 8";
                case InventoryType.FreeCompanyBag8:
                    return "部队储物柜 - 9";
                case InventoryType.FreeCompanyBag9:
                    return "部队储物柜 - 10";
                case InventoryType.FreeCompanyBag10:
                    return "部队储物柜 - 11";
                case InventoryType.FreeCompanyGil:
                    return "部队储物柜 - 金币";
                case InventoryType.FreeCompanyCrystal:
                    return "部队储物柜 - 水晶";
                case InventoryType.HousingInteriorAppearance:
                    return "房屋外观";
                case InventoryType.HousingInteriorPlacedItems1:
                    return "房屋已布置物品 - 1";
                case InventoryType.HousingInteriorPlacedItems2:
                    return "房屋已布置物品 - 2";
                case InventoryType.HousingInteriorPlacedItems3:
                    return "房屋已布置物品 - 3";
                case InventoryType.HousingInteriorPlacedItems4:
                    return "房屋已布置物品 - 4";
                case InventoryType.HousingInteriorPlacedItems5:
                    return "房屋已布置物品 - 5";
                case InventoryType.HousingInteriorPlacedItems6:
                    return "房屋已布置物品 - 6";
                case InventoryType.HousingInteriorPlacedItems7:
                    return "房屋已布置物品 - 7";
                case InventoryType.HousingInteriorPlacedItems8:
                    return "房屋已布置物品 - 8";
                case InventoryType.HousingInteriorStoreroom1:
                    return "房屋仓库 - 1";
                case InventoryType.HousingInteriorStoreroom2:
                    return "房屋仓库 - 2";
                case InventoryType.HousingInteriorStoreroom3:
                    return "房屋仓库 - 3";
                case InventoryType.HousingInteriorStoreroom4:
                    return "房屋仓库 - 4";
                case InventoryType.HousingInteriorStoreroom5:
                    return "房屋仓库 - 5";
                case InventoryType.HousingInteriorStoreroom6:
                    return "房屋仓库 - 6";
                case InventoryType.HousingInteriorStoreroom7:
                    return "房屋仓库 - 7";
                case InventoryType.HousingInteriorStoreroom8:
                    return "房屋仓库 - 8";
                case InventoryType.HousingExteriorAppearance:
                    return "庭院外观";
                case InventoryType.HousingExteriorPlacedItems:
                    return "庭院已布置物品";
                case InventoryType.HousingExteriorStoreroom:
                    return "庭院仓库";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return type.ToString();
        }
        public static string FormattedName(this InventoryCategory? category)
        {
            if (category.HasValue)
            {
                return FormattedName(category.Value);
            }

            return "Unknown";
        }
        public static string FormattedName(this InventoryChangeReason reason)
        {
            switch (reason)
            {
                case InventoryChangeReason.Added:
                    return "Added";
                case InventoryChangeReason.Removed:
                    return "Removed";
                case InventoryChangeReason.Moved:
                    return "Moved";
                case InventoryChangeReason.ConditionChanged:
                    return "Condition Changed";
                case InventoryChangeReason.FlagsChanged:
                    return "NQ/HQ Changed";
                case InventoryChangeReason.GlamourChanged:
                    return "Glamour Changed";
                case InventoryChangeReason.MateriaChanged:
                    return "Materia Changed";
                case InventoryChangeReason.QuantityChanged:
                    return "Quantity Changed";
                case InventoryChangeReason.SpiritbondChanged:
                    return "Spiritbond Changed";
                case InventoryChangeReason.StainChanged:
                    return "Dye Changed";
                case InventoryChangeReason.ItemIdChanged:
                    return "Item Changed";
                case InventoryChangeReason.Transferred:
                    return "Transferred";
                case InventoryChangeReason.MarketPriceChanged:
                    return "Market Price Changed";
                case InventoryChangeReason.GearsetsChanged:
                    return "Gearsets Changed";
            }
            return "Unknown";
        }
        public static string FormattedName(this CharacterType characterType)
        {
            switch (characterType)
            {
                case CharacterType.Character:
                    return "角色";
                case CharacterType.Housing:
                    return "房屋";
                case CharacterType.Retainer:
                    return "雇员";
                case CharacterType.FreeCompanyChest:
                    return "部队储物柜";
            }
            return "Unknown";
        }
        public static bool IsApplicable(this InventoryCategory inventoryCategory, CharacterType characterType)
        {
            switch (characterType)
            {
                case CharacterType.Character:
                    return IsCharacterCategory(inventoryCategory);
                case CharacterType.Retainer:
                    return IsRetainerCategory(inventoryCategory);
                case CharacterType.FreeCompanyChest:
                    return IsFreeCompanyCategory(inventoryCategory);
                case CharacterType.Housing:
                    return IsHousingCategory(inventoryCategory);
            }

            return true;
        }
    }
}