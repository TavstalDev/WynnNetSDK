using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents all possible item identifications in Wynncraft.
/// </summary>
public enum EIdentification
{
    /// <summary>
    /// Base damage value.
    /// </summary>
    [JsonPropertyName("baseDamage")]
    BASE_DAMAGE,

    /// <summary>
    /// Base earth damage value.
    /// </summary>
    [JsonPropertyName("baseEarthDamage")]
    BASE_EARTH_DAMAGE,

    /// <summary>
    /// Base thunder damage value.
    /// </summary>
    [JsonPropertyName("baseThunderDamage")]
    BASE_THUNDER_DAMAGE,

    /// <summary>
    /// Base water damage value.
    /// </summary>
    [JsonPropertyName("baseWaterDamage")]
    BASE_WATER_DAMAGE,

    /// <summary>
    /// Base fire damage value.
    /// </summary>
    [JsonPropertyName("baseFireDamage")]
    BASE_FIRE_DAMAGE,

    /// <summary>
    /// Base air damage value.
    /// </summary>
    [JsonPropertyName("baseAirDamage")]
    BASE_AIR_DAMAGE,

    /// <summary>
    /// Strength stat bonus.
    /// </summary>
    [JsonPropertyName("strength")]
    STRENGTH,

    /// <summary>
    /// Dexterity stat bonus.
    /// </summary>
    [JsonPropertyName("dexterity")]
    DEXTERITY,

    /// <summary>
    /// Intelligence stat bonus.
    /// </summary>
    [JsonPropertyName("intelligence")]
    INTELLIGENCE,

    /// <summary>
    /// Defence stat bonus.
    /// </summary>
    [JsonPropertyName("defence")]
    DEFENCE,

    /// <summary>
    /// Agility stat bonus.
    /// </summary>
    [JsonPropertyName("agility")]
    AGILITY,

    /// <summary>
    /// Raw health regeneration.
    /// </summary>
    [JsonPropertyName("healthRegenRaw")]
    HEALTH_REGEN_RAW,

    /// <summary>
    /// Raw spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawSpellDamage")]
    RAW_SPELL_DAMAGE,

    /// <summary>
    /// Raw main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawMainAttackDamage")]
    RAW_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Elemental defence bonus.
    /// </summary>
    [JsonPropertyName("elementalDefence")]
    ELEMENTAL_DEFENCE,

    /// <summary>
    /// Raw defence bonus.
    /// </summary>
    [JsonPropertyName("rawDefence")]
    RAW_DEFENCE,

    /// <summary>
    /// Walk speed bonus.
    /// </summary>
    [JsonPropertyName("walkSpeed")]
    WALK_SPEED,

    /// <summary>
    /// Air damage bonus.
    /// </summary>
    [JsonPropertyName("airDamage")]
    AIR_DAMAGE,

    /// <summary>
    /// Thunder damage bonus.
    /// </summary>
    [JsonPropertyName("thunderDamage")]
    THUNDER_DAMAGE,

    /// <summary>
    /// Spell damage bonus.
    /// </summary>
    [JsonPropertyName("spellDamage")]
    SPELL_DAMAGE,

    /// <summary>
    /// Raw first spell cost reduction.
    /// </summary>
    [JsonPropertyName("raw1stSpellCost")]
    RAW_1ST_SPELL_COST,

    /// <summary>
    /// Knockback bonus.
    /// </summary>
    [JsonPropertyName("knockback")]
    KNOCKBACK,

    /// <summary>
    /// Fire damage bonus.
    /// </summary>
    [JsonPropertyName("fireDamage")]
    FIRE_DAMAGE,

    /// <summary>
    /// Main attack damage bonus.
    /// </summary>
    [JsonPropertyName("mainAttackDamage")]
    MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Life steal bonus.
    /// </summary>
    [JsonPropertyName("lifeSteal")]
    LIFE_STEAL,

    /// <summary>
    /// Mana steal bonus.
    /// </summary>
    [JsonPropertyName("manaSteal")]
    MANA_STEAL,

    /// <summary>
    /// Weaken enemy debuff strength.
    /// </summary>
    [JsonPropertyName("weakenEnemy")]
    WEAKEN_ENEMY,

    /// <summary>
    /// Water defence bonus.
    /// </summary>
    [JsonPropertyName("waterDefence")]
    WATER_DEFENCE,

    /// <summary>
    /// Air defence bonus.
    /// </summary>
    [JsonPropertyName("airDefence")]
    AIR_DEFENCE,

    /// <summary>
    /// Raw dexterity bonus.
    /// </summary>
    [JsonPropertyName("rawDexterity")]
    RAW_DEXTERITY,

    /// <summary>
    /// Mana regeneration bonus.
    /// </summary>
    [JsonPropertyName("manaRegen")]
    MANA_REGEN,

    /// <summary>
    /// Combat experience bonus.
    /// </summary>
    [JsonPropertyName("combatExperience")]
    COMBAT_EXPERIENCE,

    /// <summary>
    /// Slow enemy debuff strength.
    /// </summary>
    [JsonPropertyName("slowEnemy")]
    SLOW_ENEMY,

    /// <summary>
    /// Water damage bonus.
    /// </summary>
    [JsonPropertyName("waterDamage")]
    WATER_DAMAGE,

    /// <summary>
    /// Earth defence bonus.
    /// </summary>
    [JsonPropertyName("earthDefence")]
    EARTH_DEFENCE,

    /// <summary>
    /// Exploding damage bonus.
    /// </summary>
    [JsonPropertyName("exploding")]
    EXPLODING,

    /// <summary>
    /// Thunder defence bonus.
    /// </summary>
    [JsonPropertyName("thunderDefence")]
    THUNDER_DEFENCE,

    /// <summary>
    /// Raw agility bonus.
    /// </summary>
    [JsonPropertyName("rawAgility")]
    RAW_AGILITY,

    /// <summary>
    /// Damage reflection bonus.
    /// </summary>
    [JsonPropertyName("reflection")]
    REFLECTION,

    /// <summary>
    /// Earth damage bonus.
    /// </summary>
    [JsonPropertyName("earthDamage")]
    EARTH_DAMAGE,

    /// <summary>
    /// Health regeneration bonus.
    /// </summary>
    [JsonPropertyName("healthRegen")]
    HEALTH_REGEN,

    /// <summary>
    /// Raw health bonus.
    /// </summary>
    [JsonPropertyName("rawHealth")]
    RAW_HEALTH,

    /// <summary>
    /// Total damage bonus.
    /// </summary>
    [JsonPropertyName("damage")]
    DAMAGE,

    /// <summary>
    /// Elemental damage bonus.
    /// </summary>
    [JsonPropertyName("elementalDamage")]
    ELEMENTAL_DAMAGE,

    /// <summary>
    /// Raw attack speed bonus.
    /// </summary>
    [JsonPropertyName("rawAttackSpeed")]
    RAW_ATTACK_SPEED,

    /// <summary>
    /// Sprint speed bonus.
    /// </summary>
    [JsonPropertyName("sprint")]
    SPRINT,

    /// <summary>
    /// Raw fourth spell cost reduction.
    /// </summary>
    [JsonPropertyName("raw4thSpellCost")]
    RAW_4TH_SPELL_COST,

    /// <summary>
    /// Raw intelligence bonus.
    /// </summary>
    [JsonPropertyName("rawIntelligence")]
    RAW_INTELLIGENCE,

    /// <summary>
    /// Raw air damage bonus.
    /// </summary>
    [JsonPropertyName("rawAirDamage")]
    RAW_AIR_DAMAGE,

    /// <summary>
    /// Jump height bonus.
    /// </summary>
    [JsonPropertyName("jumpHeight")]
    JUMP_HEIGHT,

    /// <summary>
    /// Raw strength bonus.
    /// </summary>
    [JsonPropertyName("rawStrength")]
    RAW_STRENGTH,

    /// <summary>
    /// Raw elemental spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawElementalSpellDamage")]
    RAW_ELEMENTAL_SPELL_DAMAGE,

    /// <summary>
    /// Thorns damage bonus.
    /// </summary>
    [JsonPropertyName("thorns")]
    THORNS,

    /// <summary>
    /// Fire defence bonus.
    /// </summary>
    [JsonPropertyName("fireDefence")]
    FIRE_DEFENCE,

    /// <summary>
    /// Raw third spell cost reduction.
    /// </summary>
    [JsonPropertyName("raw3rdSpellCost")]
    RAW_3RD_SPELL_COST,

    /// <summary>
    /// Sprint regeneration bonus.
    /// </summary>
    [JsonPropertyName("sprintRegen")]
    SPRINT_REGEN,

    /// <summary>
    /// Poison damage bonus.
    /// </summary>
    [JsonPropertyName("poison")]
    POISON,

    /// <summary>
    /// Elemental spell damage bonus.
    /// </summary>
    [JsonPropertyName("elementalSpellDamage")]
    ELEMENTAL_SPELL_DAMAGE,

    /// <summary>
    /// Raw thunder main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawThunderMainAttackDamage")]
    RAW_THUNDER_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Raw earth main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawEarthMainAttackDamage")]
    RAW_EARTH_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Fire spell damage bonus.
    /// </summary>
    [JsonPropertyName("fireSpellDamage")]
    FIRE_SPELL_DAMAGE,

    /// <summary>
    /// Item stealing chance bonus.
    /// </summary>
    [JsonPropertyName("stealing")]
    STEALING,

    /// <summary>
    /// Raw thunder damage bonus.
    /// </summary>
    [JsonPropertyName("rawThunderDamage")]
    RAW_THUNDER_DAMAGE,

    /// <summary>
    /// Main attack range bonus.
    /// </summary>
    [JsonPropertyName("mainAttackRange")]
    MAIN_ATTACK_RANGE,

    /// <summary>
    /// Raw second spell cost reduction.
    /// </summary>
    [JsonPropertyName("raw2ndSpellCost")]
    RAW_2ND_SPELL_COST,

    /// <summary>
    /// First spell cost reduction.
    /// </summary>
    [JsonPropertyName("1stSpellCost")]
    FIRST_SPELL_COST,

    /// <summary>
    /// Third spell cost reduction.
    /// </summary>
    [JsonPropertyName("ThirdSpellCost")]
    THIRD_SPELL_COST,

    /// <summary>
    /// Raw fire damage bonus.
    /// </summary>
    [JsonPropertyName("rawFireDamage")]
    RAW_FIRE_DAMAGE,

    /// <summary>
    /// Loot bonus percentage.
    /// </summary>
    [JsonPropertyName("lootBonus")]
    LOOT_BONUS,

    /// <summary>
    /// Fire main attack damage bonus.
    /// </summary>
    [JsonPropertyName("fireMainAttackDamage")]
    FIRE_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Raw air main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawAirMainAttackDamage")]
    RAW_AIR_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Raw total damage bonus.
    /// </summary>
    [JsonPropertyName("rawDamage")]
    RAW_DAMAGE,

    /// <summary>
    /// Fourth spell cost reduction.
    /// </summary>
    [JsonPropertyName("FourthSpellCost")]
    FOURTH_SPELL_COST,

    /// <summary>
    /// Raw elemental damage bonus.
    /// </summary>
    [JsonPropertyName("rawElementalDamage")]
    RAW_ELEMENTAL_DAMAGE,

    /// <summary>
    /// Elemental main attack damage bonus.
    /// </summary>
    [JsonPropertyName("elementalMainAttackDamage")]
    ELEMENTAL_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Earth main attack damage bonus.
    /// </summary>
    [JsonPropertyName("earthMainAttackDamage")]
    EARTH_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Thunder main attack damage bonus.
    /// </summary>
    [JsonPropertyName("thunderMainAttackDamage")]
    THUNDER_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Raw maximum mana bonus.
    /// </summary>
    [JsonPropertyName("rawMaxMana")]
    RAW_MAX_MANA,

    /// <summary>
    /// Raw air spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawAirSpellDamage")]
    RAW_AIR_SPELL_DAMAGE,

    /// <summary>
    /// Second spell cost reduction.
    /// </summary>
    [JsonPropertyName("SecondSpellCost")]
    SECOND_SPELL_COST,

    /// <summary>
    /// Raw earth damage bonus.
    /// </summary>
    [JsonPropertyName("rawEarthDamage")]
    RAW_EARTH_DAMAGE,

    /// <summary>
    /// Earth spell damage bonus.
    /// </summary>
    [JsonPropertyName("earthSpellDamage")]
    EARTH_SPELL_DAMAGE,

    /// <summary>
    /// Water spell damage bonus.
    /// </summary>
    [JsonPropertyName("waterSpellDamage")]
    WATER_SPELL_DAMAGE,

    /// <summary>
    /// Raw fire spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawFireSpellDamage")]
    RAW_FIRE_SPELL_DAMAGE,

    /// <summary>
    /// Critical damage bonus percentage.
    /// </summary>
    [JsonPropertyName("criticalDamageBonus")]
    CRITICAL_DAMAGE_BONUS,

    /// <summary>
    /// Air spell damage bonus.
    /// </summary>
    [JsonPropertyName("airSpellDamage")]
    AIR_SPELL_DAMAGE,

    /// <summary>
    /// Raw thunder spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawThunderSpellDamage")]
    RAW_THUNDER_SPELL_DAMAGE,

    /// <summary>
    /// Raw water spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawWaterSpellDamage")]
    RAW_WATER_SPELL_DAMAGE,

    /// <summary>
    /// Raw fire main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawFireMainAttackDamage")]
    RAW_FIRE_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Neutral spell damage bonus.
    /// </summary>
    [JsonPropertyName("neutralSpellDamage")]
    NEUTRAL_SPELL_DAMAGE,

    /// <summary>
    /// Neutral damage bonus.
    /// </summary>
    [JsonPropertyName("neutralDamage")]
    NEUTRAL_DAMAGE,

    /// <summary>
    /// Raw neutral main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawNeutralMainAttackDamage")]
    RAW_NEUTRAL_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Thunder spell damage bonus.
    /// </summary>
    [JsonPropertyName("thunderSpellDamage")]
    THUNDER_SPELL_DAMAGE,

    /// <summary>
    /// Raw earth spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawEarthSpellDamage")]
    RAW_EARTH_SPELL_DAMAGE,

    /// <summary>
    /// Raw neutral damage bonus.
    /// </summary>
    [JsonPropertyName("rawNeutralDamage")]
    RAW_NEUTRAL_DAMAGE,

    /// <summary>
    /// Raw water damage bonus.
    /// </summary>
    [JsonPropertyName("rawWaterDamage")]
    RAW_WATER_DAMAGE,

    /// <summary>
    /// Healing efficiency bonus.
    /// </summary>
    [JsonPropertyName("healingEfficiency")]
    HEALING_EFFICIENCY,

    /// <summary>
    /// Raw elemental main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawElementalMainAttackDamage")]
    RAW_ELEMENTAL_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Air main attack damage bonus.
    /// </summary>
    [JsonPropertyName("airMainAttackDamage")]
    AIR_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Raw neutral spell damage bonus.
    /// </summary>
    [JsonPropertyName("rawNeutralSpellDamage")]
    RAW_NEUTRAL_SPELL_DAMAGE,

    /// <summary>
    /// Base health bonus.
    /// </summary>
    [JsonPropertyName("baseHealth")]
    BASE_HEALTH,

    /// <summary>
    /// Base earth defence bonus.
    /// </summary>
    [JsonPropertyName("baseEarthDefence")]
    BASE_EARTH_DEFENCE,

    /// <summary>
    /// Base fire defence bonus.
    /// </summary>
    [JsonPropertyName("baseFireDefence")]
    BASE_FIRE_DEFENCE,

    /// <summary>
    /// Base thunder defence bonus.
    /// </summary>
    [JsonPropertyName("baseThunderDefence")]
    BASE_THUNDER_DEFENCE,

    /// <summary>
    /// Base water defence bonus.
    /// </summary>
    [JsonPropertyName("baseWaterDefence")]
    BASE_WATER_DEFENCE,

    /// <summary>
    /// Base air defence bonus.
    /// </summary>
    [JsonPropertyName("baseAirDefence")]
    BASE_AIR_DEFENCE,

    /// <summary>
    /// Neutral main attack damage bonus.
    /// </summary>
    [JsonPropertyName("neutralMainAttackDamage")]
    NEUTRAL_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Leveled experience bonus.
    /// </summary>
    [JsonPropertyName("leveledXpBonus")]
    LEVELED_XP_BONUS,

    /// <summary>
    /// Incoming damage from mobs modifier.
    /// </summary>
    [JsonPropertyName("damageFromMobs")]
    DAMAGE_FROM_MOBS,

    /// <summary>
    /// Leveled loot bonus.
    /// </summary>
    [JsonPropertyName("leveledLootBonus")]
    LEVELED_LOOT_BONUS,

    /// <summary>
    /// Gathering experience bonus.
    /// </summary>
    [JsonPropertyName("gatheringExperience")]
    GATHERING_EXPERIENCE,

    /// <summary>
    /// Gathering experience bonus.
    /// </summary>
    [JsonPropertyName("gatherXpBonus")]
    GATHER_XP_BONUS,

    /// <summary>
    /// Gathering speed bonus.
    /// </summary>
    [JsonPropertyName("gatherSpeed")]
    GATHER_SPEED,

    /// <summary>
    /// Loot quality bonus.
    /// </summary>
    [JsonPropertyName("lootQuality")]
    LOOT_QUALITY,

    /// <summary>
    /// Raw water main attack damage bonus.
    /// </summary>
    [JsonPropertyName("rawWaterMainAttackDamage")]
    RAW_WATER_MAIN_ATTACK_DAMAGE,

    /// <summary>
    /// Agility stat bonus.
    /// </summary>
    AGILITYBONUS,

    /// <summary>
    /// Strength stat bonus.
    /// </summary>
    STRENGTHBONUS
}
