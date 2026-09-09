using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents all possible major ID effects on items.
/// </summary>
public enum EMajorId
{
    /// <summary>
    /// Evershot major ID.
    /// </summary>
    [JsonPropertyName("evershot")]
    EVERSHOT,

    /// <summary>
    /// Forest's Blessing major ID.
    /// </summary>
    [JsonPropertyName("forestSBlessing")]
    FOREST_S_BLESSING,

    /// <summary>
    /// Fallout major ID.
    /// </summary>
    [JsonPropertyName("fallout")]
    FALLOUT,

    /// <summary>
    /// Twisting Threads major ID.
    /// </summary>
    [JsonPropertyName("twistingThreads")]
    TWISTING_THREADS,

    /// <summary>
    /// Pioneer's Echo major ID.
    /// </summary>
    [JsonPropertyName("pioneerSEcho")]
    PIONEER_S_ECHO,

    /// <summary>
    /// Altruism major ID.
    /// </summary>
    [JsonPropertyName("altruism")]
    ALTRUISM,

    /// <summary>
    /// Freerunner major ID.
    /// </summary>
    [JsonPropertyName("freerunner")]
    FREERUNNER,

    /// <summary>
    /// Vedette major ID.
    /// </summary>
    [JsonPropertyName("vedette")]
    VEDETTE,

    /// <summary>
    /// Reality Revision major ID.
    /// </summary>
    [JsonPropertyName("realityRevision")]
    REALITY_REVISION,

    /// <summary>
    /// Seeking Module major ID.
    /// </summary>
    [JsonPropertyName("seekingModule")]
    SEEKING_MODULE,

    /// <summary>
    /// Fission major ID.
    /// </summary>
    [JsonPropertyName("fission")]
    FISSION,

    /// <summary>
    /// Frenetic Spirit major ID.
    /// </summary>
    [JsonPropertyName("freneticSpirit")]
    FRENETIC_SPIRIT,

    /// <summary>
    /// Net Shot major ID.
    /// </summary>
    [JsonPropertyName("netShot")]
    NET_SHOT,

    /// <summary>
    /// Death Sentence major ID.
    /// </summary>
    [JsonPropertyName("deathSentence")]
    DEATH_SENTENCE,

    /// <summary>
    /// Regicide major ID.
    /// </summary>
    [JsonPropertyName("regicide")]
    REGICIDE,

    /// <summary>
    /// Self Sufficient major ID.
    /// </summary>
    [JsonPropertyName("selfSufficient")]
    SELF_SUFFICIENT,

    /// <summary>
    /// Napalm major ID.
    /// </summary>
    [JsonPropertyName("napalm")]
    NAPALM,

    /// <summary>
    /// River of Souls major ID.
    /// </summary>
    [JsonPropertyName("riverofSouls")]
    RIVER_OF_SOULS,

    /// <summary>
    /// Combo Stomp major ID.
    /// </summary>
    [JsonPropertyName("comboStomp")]
    COMBO_STOMP,

    /// <summary>
    /// Gunk Shot major ID.
    /// </summary>
    [JsonPropertyName("gunkShot")]
    GUNK_SHOT,

    /// <summary>
    /// Heartbeat major ID.
    /// </summary>
    [JsonPropertyName("heartbeat")]
    HEARTBEAT,

    /// <summary>
    /// Methodical major ID.
    /// </summary>
    [JsonPropertyName("methodical")]
    METHODICAL,

    /// <summary>
    /// Fan the Hammer major ID.
    /// </summary>
    [JsonPropertyName("fantheHammer")]
    FAN_THE_HAMMER,

    /// <summary>
    /// Wormhole major ID.
    /// </summary>
    [JsonPropertyName("wormhole")]
    WORMHOLE,

    /// <summary>
    /// Punishment major ID.
    /// </summary>
    [JsonPropertyName("punishment")]
    PUNISHMENT,

    /// <summary>
    /// Grand Influence major ID.
    /// </summary>
    [JsonPropertyName("grandInfluence")]
    GRAND_INFLUENCE,

    /// <summary>
    /// Cherry Bombs major ID.
    /// </summary>
    [JsonPropertyName("cherryBombs")]
    CHERRY_BOMBS,

    /// <summary>
    /// Greed major ID.
    /// </summary>
    [JsonPropertyName("greed")]
    GREED,

    /// <summary>
    /// Windsurf major ID.
    /// </summary>
    [JsonPropertyName("windsurf")]
    WINDSURF,

    /// <summary>
    /// Hurricane's Eye major ID.
    /// </summary>
    [JsonPropertyName("hurricaneSEye")]
    HURRICANE_S_EYE,

    /// <summary>
    /// Sorcery major ID.
    /// </summary>
    [JsonPropertyName("sorcery")]
    SORCERY,

    /// <summary>
    /// Roving Assassin major ID.
    /// </summary>
    [JsonPropertyName("rovingAssassin")]
    ROVING_ASSASSIN,

    /// <summary>
    /// Transcendence major ID.
    /// </summary>
    [JsonPropertyName("transcendence")]
    TRANSCENDENCE,

    /// <summary>
    /// Efflorescence major ID.
    /// </summary>
    [JsonPropertyName("efflorescence")]
    EFFLORESCENCE,

    /// <summary>
    /// Space Glide major ID.
    /// </summary>
    [JsonPropertyName("spaceGlide")]
    SPACE_GLIDE,

    /// <summary>
    /// Heat Shimmer major ID.
    /// </summary>
    [JsonPropertyName("heatShimmer")]
    HEAT_SHIMMER,

    /// <summary>
    /// Soul Eater major ID.
    /// </summary>
    [JsonPropertyName("soulEater")]
    SOUL_EATER,

    /// <summary>
    /// Juggle major ID.
    /// </summary>
    [JsonPropertyName("juggle")]
    JUGGLE,

    /// <summary>
    /// Flurry of Blows major ID.
    /// </summary>
    [JsonPropertyName("flurryofBlows")]
    FLURRY_OF_BLOWS,

    /// <summary>
    /// Incision Elegy major ID.
    /// </summary>
    [JsonPropertyName("incisionElegy")]
    INCISION_ELEGY,

    /// <summary>
    /// Lightning Crash major ID.
    /// </summary>
    [JsonPropertyName("lightningCrash")]
    LIGHTNING_CRASH,

    /// <summary>
    /// Living Museum major ID.
    /// </summary>
    [JsonPropertyName("livingMuseum")]
    LIVING_MUSEUM,

    /// <summary>
    /// Manic Edge major ID.
    /// </summary>
    [JsonPropertyName("manicEdge")]
    MANIC_EDGE,

    /// <summary>
    /// Enlightenment major ID.
    /// </summary>
    [JsonPropertyName("enlightenment")]
    ENLIGHTENMENT,

    /// <summary>
    /// Ignition Whirlwind major ID.
    /// </summary>
    [JsonPropertyName("ignitionWhirlwind")]
    IGNITION_WHIRLWIND,

    /// <summary>
    /// Lifestream major ID.
    /// </summary>
    [JsonPropertyName("lifestream")]
    LIFESTREAM,

    /// <summary>
    /// Peaceful Effigy major ID.
    /// </summary>
    [JsonPropertyName("peacefulEffigy")]
    PEACEFUL_EFFIGY,

    /// <summary>
    /// Strings of Fate major ID.
    /// </summary>
    [JsonPropertyName("stringsofFate")]
    STRINGS_OF_FATE,

    /// <summary>
    /// Ergosphere major ID.
    /// </summary>
    [JsonPropertyName("ergosphere")]
    ERGOSPHERE,

    /// <summary>
    /// Dead Weights major ID.
    /// </summary>
    [JsonPropertyName("deadWeight")]
    DEAD_WEIGHTS,

    /// <summary>
    /// Sublimation major ID.
    /// </summary>
    [JsonPropertyName("sublimation")]
    SUBLIMATION,

    /// <summary>
    /// Furious Effigy major ID.
    /// </summary>
    [JsonPropertyName("furiousEffigy")]
    FURIOUS_EFFIGY,

    /// <summary>
    /// Faustian Gambit major ID.
    /// </summary>
    [JsonPropertyName("faustianGambit")]
    FAUSTIAN_GAMBIT,

    /// <summary>
    /// Totemic Fuse major ID.
    /// </summary>
    [JsonPropertyName("totemicFuse")]
    TOTEMIC_FUSE,

    /// <summary>
    /// Geocentrism major ID.
    /// </summary>
    [JsonPropertyName("geocentrism")]
    GEOCENTRISM,

    /// <summary>
    /// Gruesome Knots major ID.
    /// </summary>
    [JsonPropertyName("gruesomeKnots")]
    GRUESOME_KNOTS,

    /// <summary>
    /// Starcrossed major ID.
    /// </summary>
    [JsonPropertyName("starcrossed")]
    STARCROSSED,

    /// <summary>
    /// Chaos Reach major ID.
    /// </summary>
    [JsonPropertyName("chaosReach")]
    CHAOS_REACH,

    /// <summary>
    /// Flain Remnants major ID.
    /// </summary>
    [JsonPropertyName("flainRemnants")]
    FLAIN_REMNANTS,

    /// <summary>
    /// Lit Fuse major ID.
    /// </summary>
    [JsonPropertyName("litFuse")]
    LIT_FUSE,

    /// <summary>
    /// Rally major ID.
    /// </summary>
    [JsonPropertyName("rally")]
    RALLY,

    /// <summary>
    /// Hellfire major ID.
    /// </summary>
    [JsonPropertyName("hellfire")]
    HELLFIRE,

    /// <summary>
    /// Paragon major ID.
    /// </summary>
    [JsonPropertyName("paragon")]
    PARAGON,

    /// <summary>
    /// Divine Honor major ID.
    /// </summary>
    [JsonPropertyName("divineHonor")]
    DIVINE_HONOR,

    /// <summary>
    /// Troll Barge major ID.
    /// </summary>
    [JsonPropertyName("trollBarge")]
    TROLL_BARGE,

    /// <summary>
    /// Tidal Drift major ID.
    /// </summary>
    [JsonPropertyName("tidalDrift")]
    TIDAL_DRIFT,

    /// <summary>
    /// Guardian major ID.
    /// </summary>
    [JsonPropertyName("guardian")]
    GUARDIAN,

    /// <summary>
    /// Last Resort major ID.
    /// </summary>
    [JsonPropertyName("lastResort")]
    LAST_RESORT,

    /// <summary>
    /// Saviour's Sacrifice major ID.
    /// </summary>
    [JsonPropertyName("saviourSSacrifice")]
    SAVIOUR_S_SACRIFICE,

    /// <summary>
    /// Scarce Comfort major ID.
    /// </summary>
    [JsonPropertyName("scarceComfort")]
    SCARCE_COMFORT,

    /// <summary>
    /// Vitriol major ID.
    /// </summary>
    [JsonPropertyName("vitriol")]
    VITRIOL,

    /// <summary>
    /// Tackle major ID.
    /// </summary>
    [JsonPropertyName("tackle")]
    TACKLE,

    /// <summary>
    /// Divine Right major ID.
    /// </summary>
    [JsonPropertyName("divineRight")]
    DIVINE_RIGHT,

    /// <summary>
    /// Slow Boil major ID.
    /// </summary>
    [JsonPropertyName("slowBoil")]
    SLOW_BOIL,

    /// <summary>
    /// Stagnant Air major ID.
    /// </summary>
    [JsonPropertyName("stagnantAir")]
    STAGNANT_AIR,

    /// <summary>
    /// Old Spark major ID.
    /// </summary>
    [JsonPropertyName("oldSpark")]
    OLD_SPARK,

    /// <summary>
    /// One Unto All major ID.
    /// </summary>
    [JsonPropertyName("oneselfUntoAll")]
    ONESELF_UNTO_ALL,

    /// <summary>
    /// Temblor major ID.
    /// </summary>
    [JsonPropertyName("temblor")]
    TEMBLOR,

    /// <summary>
    /// Overwhelm major ID.
    /// </summary>
    [JsonPropertyName("overwhelm")]
    OVERWHELM,

    /// <summary>
    /// Meteor Crash major ID.
    /// </summary>
    [JsonPropertyName("meteorCrash")]
    METEOR_CRASH,

    /// <summary>
    /// Earthen Splinter major ID.
    /// </summary>
    [JsonPropertyName("earthenSplinter")]
    EARTHEN_SPLINTER,

    /// <summary>
    /// Entropy major ID.
    /// </summary>
    [JsonPropertyName("entropy")]
    ENTROPY,

    /// <summary>
    /// Fixate major ID.
    /// </summary>
    [JsonPropertyName("fixate")]
    FIXATE,

    /// <summary>
    /// Lustrate major ID.
    /// </summary>
    [JsonPropertyName("lustrate")]
    LUSTRATE,

    /// <summary>
    /// Inversion major ID.
    /// </summary>
    [JsonPropertyName("inversion")]
    INVERSION,

    /// <summary>
    /// Cosmic Capture major ID.
    /// </summary>
    [JsonPropertyName("cosmicCapture")]
    COSMIC_CAPTURE,

    /// <summary>
    /// Orbital Chain major ID.
    /// </summary>
    [JsonPropertyName("orbitalChain")]
    ORBITAL_CHAIN,

    /// <summary>
    /// Perfect Recall major ID.
    /// </summary>
    [JsonPropertyName("perfectRecall")]
    PERFECT_RECALL,

    /// <summary>
    /// Gravity Well major ID.
    /// </summary>
    [JsonPropertyName("gravityWell")]
    GRAVITY_WELL,

    /// <summary>
    /// Displace major ID.
    /// </summary>
    [JsonPropertyName("displace")]
    DISPLACE,

    /// <summary>
    /// Lockdown major ID.
    /// </summary>
    [JsonPropertyName("lockdown")]
    LOCKDOWN,

    /// <summary>
    /// Plague major ID.
    /// </summary>
    [JsonPropertyName("plague")]
    PLAGUE,

    /// <summary>
    /// Solar Wind major ID.
    /// </summary>
    [JsonPropertyName("solarWind")]
    SOLAR_WIND,

    /// <summary>
    /// Wavebreak major ID.
    /// </summary>
    [JsonPropertyName("wavebreak")]
    WAVEBREAK,

    /// <summary>
    /// Gentle Glow major ID.
    /// </summary>
    [JsonPropertyName("gentleGlow")]
    GENTLE_GLOW,

    /// <summary>
    /// Blinding Lights major ID.
    /// </summary>
    [JsonPropertyName("blindingLights")]
    BLINDING_LIGHTS,

    /// <summary>
    /// Oneiro major ID.
    /// </summary>
    [JsonPropertyName("oneiro")]
    ONEIRO,

    /// <summary>
    /// Dauntless Inferno major ID.
    /// </summary>
    [JsonPropertyName("dauntlessInferno")]
    DAUNTLESS_INFERNO,

    /// <summary>
    /// Fissure major ID.
    /// </summary>
    [JsonPropertyName("fissure")]
    FISSURE,

    /// <summary>
    /// Flashfreeze major ID.
    /// </summary>
    [JsonPropertyName("flashfreeze")]
    FLASHFREEZE,

    /// <summary>
    /// Perilous Flare major ID.
    /// </summary>
    [JsonPropertyName("perilousFlare")]
    PERILOUS_FLARE,

    /// <summary>
    /// Explosive Impact major ID.
    /// </summary>
    [JsonPropertyName("explosiveImpact")]
    EXPLOSIVE_IMPACT,

    /// <summary>
    /// Escape Route major ID.
    /// </summary>
    [JsonPropertyName("escapeRoute")]
    ESCAPE_ROUTE,

    /// <summary>
    /// Lightweight major ID.
    /// </summary>
    [JsonPropertyName("lightweight")]
    LIGHTWEIGHT,

    /// <summary>
    /// Pirouette major ID.
    /// </summary>
    [JsonPropertyName("pirouette")]
    PIROUETTE,

    /// <summary>
    /// Lunge major ID.
    /// </summary>
    [JsonPropertyName("lunge")]
    LUNGE,

    /// <summary>
    /// Taunt major ID.
    /// </summary>
    [JsonPropertyName("taunt")]
    TAUNT,

    /// <summary>
    /// Desperate Measures major ID.
    /// </summary>
    [JsonPropertyName("desperateMeasures")]
    DESPERATE_MEASURES,

    /// <summary>
    /// Rock Shield major ID.
    /// </summary>
    [JsonPropertyName("rockShield")]
    ROCK_SHIELD,

    /// <summary>
    /// Cannulate major ID.
    /// </summary>
    [JsonPropertyName("cannulate")]
    CANNULATE,

    /// <summary>
    /// Snowy Steps major ID.
    /// </summary>
    [JsonPropertyName("snowySteps")]
    SNOWY_STEPS,

    /// <summary>
    /// Phoenix Born major ID.
    /// </summary>
    [JsonPropertyName("phoenixBorn")]
    PHOENIX_BORN,

    /// <summary>
    /// Superconductor major ID.
    /// </summary>
    [JsonPropertyName("superconductor")]
    SUPERCONDUCTOR,

    /// <summary>
    /// Magnet major ID.
    /// </summary>
    [JsonPropertyName("magnet")]
    MAGNET,

    /// <summary>
    /// Alter Ego major ID.
    /// </summary>
    [JsonPropertyName("alterEgo")]
    ALTER_EGO,

    /// <summary>
    /// Mangle major ID.
    /// </summary>
    [JsonPropertyName("mangle")]
    MANGLE,

    /// <summary>
    /// Intangible major ID.
    /// </summary>
    [JsonPropertyName("intangible")]
    INTANGIBLE,

    /// <summary>
    /// Ice Storm major ID.
    /// </summary>
    [JsonPropertyName("iceStorm")]
    ICE_STORM,

    /// <summary>
    /// Pounce major ID.
    /// </summary>
    [JsonPropertyName("pounce")]
    POUNCE,

    /// <summary>
    /// Hawkeye major ID.
    /// </summary>
    [JsonPropertyName("hawkeye")]
    HAWKEYE,

    /// <summary>
    /// Orbwalk major ID.
    /// </summary>
    [JsonPropertyName("orbwalk")]
    ORBWALK,

    /// <summary>
    /// Burnt Shadows major ID.
    /// </summary>
    [JsonPropertyName("burntShadows")]
    BURNT_SHADOWS,

    /// <summary>
    /// Fright or Flight major ID.
    /// </summary>
    [JsonPropertyName("frightorFlight")]
    FRIGHT_OR_FLIGHT,

    /// <summary>
    /// Festive Spirit major ID.
    /// </summary>
    [JsonPropertyName("festiveSpirit")]
    FESTIVE_SPIRIT,

    /// <summary>
    /// Sun Eater major ID.
    /// </summary>
    [JsonPropertyName("sunEater")]
    SUN_EATER,

    /// <summary>
    /// Reckless Abandon major ID.
    /// </summary>
    [JsonPropertyName("recklessAbandon")]
    RECKLESS_ABANDON,

    /// <summary>
    /// Expunge major ID.
    /// </summary>
    [JsonPropertyName("expunge")]
    EXPUNGE,

    /// <summary>
    /// Brachiate major ID.
    /// </summary>
    [JsonPropertyName("brachiate")]
    BRACHIATE,

    /// <summary>
    /// Rusted Ichor major ID.
    /// </summary>
    [JsonPropertyName("rustedIchor")]
    RUSTED_ICHOR,

    /// <summary>
    /// Find Thyself major ID.
    /// </summary>
    [JsonPropertyName("findThyself")]
    FIND_THYSELF,

    /// <summary>
    /// Madness major ID.
    /// </summary>
    [JsonPropertyName("madness")]
    MADNESS,

    /// <summary>
    /// Clamber major ID.
    /// </summary>
    [JsonPropertyName("clamber")]
    CLAMBER,

    /// <summary>
    /// Split Second major ID.
    /// </summary>
    [JsonPropertyName("splitSecond")]
    SPLIT_SECOND,

    /// <summary>
    /// Spectral Memory major ID.
    /// </summary>
    [JsonPropertyName("spectralMemory")]
    SPECTRAL_MEMORY,

    /// <summary>
    /// Insoluble major ID.
    /// </summary>
    [JsonPropertyName("insoluble")]
    INSOLUBLE,

    /// <summary>
    /// Bound by Blood major ID.
    /// </summary>
    [JsonPropertyName("boundbyBlood")]
    BOUND_BY_BLOOD,

    /// <summary>
    /// Mob Mentality major ID.
    /// </summary>
    [JsonPropertyName("mobMentality")]
    MOB_MENTALITY,

    /// <summary>
    /// Lasso major ID.
    /// </summary>
    [JsonPropertyName("lasso")]
    LASSO,

    /// <summary>
    /// Coagulate major ID.
    /// </summary>
    [JsonPropertyName("coagulate")]
    COAGULATE,

    /// <summary>
    /// Flight Burst major ID.
    /// </summary>
    [JsonPropertyName("flightBurst")]
    FLIGHT_BURST,

    /// <summary>
    /// Culicidae Creed major ID.
    /// </summary>
    [JsonPropertyName("culicidaeCreed")]
    CULICIDAE_CREED,

    /// <summary>
    /// Power Fist major ID.
    /// </summary>
    [JsonPropertyName("powerFist")]
    POWER_FIST,

    /// <summary>
    /// Brutal Blow major ID.
    /// </summary>
    [JsonPropertyName("brutalBlow")]
    BRUTAL_BLOW
}
