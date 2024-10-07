using XIVComboExpandedestPlugin.Attributes;
using XIVComboExpandedestPlugin.Combos;

namespace XIVComboExpandedestPlugin
{
    /// <summary>
    /// Combo presets.
    /// </summary>
    public enum CustomComboPreset
    {
        // ====================================================================================
        #region MULTIPLE CLASSES/DOL

        // Latest enum: 9014

        [OrderedEnum]
        [CustomComboInfo("复活 => 即刻咏唱 功能", "当即刻咏唱不在冷却时，将有复活技能的职业各自的复活技能替换为即刻咏唱。（有连续咏唱Buff的时候也不会替换）\n以防万一以下是有复活技能的职业：四个治疗职业、召唤师、赤魔法师、和青魔法师。", All.JobID, All.Raise, All.Resurrection, All.Ascend, All.Verraise, All.Egeiro, All.AngelWhisper)]
        AllSwiftcastFeature = 9001,

        [OrderedEnum]
        [CustomComboInfo("海岛冲刺", "在无人岛时，将冲刺替换为海岛冲刺。\n这本来是一个SimpleTweaks提供的功能。（但是似乎坏了没修所以作者做了这么一个替换）", All.JobID, All.Sprint)]
        AllIsleSprintFeature = 9014,

        [OrderedEnum]
        [CustomComboInfo("理智同兴替换", "当理智同兴被触发时，将石工之理或农夫之智替换为理智同兴。", All.JobID, All.SolidReason, All.AgelessWords)]
        AllEurekaFeature = 9002,

        [OrderedEnum]
        [CustomComboInfo("防护职业插言功能", "如果目标可以被插言、且插言当前不在冷却，则将下踢替换为插言。", All.JobID, All.LowBlow)]
        AllTankInterruptFeature = 9003,

        [OrderedEnum]
        [CustomComboInfo("雪仇/牵制/昏乱锁定功能", "在雪仇/牵制/昏乱不在冷却、但目标已有剩余时间超过3s的对应Debuff的情况下，锁定相应技能以防止Buff被覆盖。", All.JobID, All.Reprisal, All.Addle, All.Feint)]
        AllReprisalLockoutFeature = 9010,

        [OrderedEnum]
        [CustomComboInfo("远敏团减锁定功能", "在你远敏职业的团减（如行吟）不在冷却、但身上仍有（其他玩家提供的）剩余时间超过3s的对应Buff的情况，锁定相应技能以防止Buff被覆盖。", All.JobID, All.Tactician, All.Troubadour, All.ShieldSamba)]
        AllRangedDefenseCooldownLockoutFeature = 9011,

        [OrderedEnum]
        [CustomComboInfo("抛竿 => 提钩", "在钓鱼时，将抛竿替换为提钩。", All.JobID, All.Cast)]
        DolCastHookFeature = 9004,

        [OrderedEnum]
        [CustomComboInfo("抛竿 => 刺鱼", "在水下时，将抛竿替换为刺鱼。", All.JobID, All.Cast)]
        DolCastGigFeature = 9005,

        [OrderedEnum]
        [CustomComboInfo("拍击水面 => 熟练技巧", "在水下时，将拍击水面替换为熟练技巧。", All.JobID, All.SurfaceSlap)]
        DolSurfaceTradeFeature = 9006,

        [OrderedEnum]
        [CustomComboInfo("大鱼猎手 => 嘉慧", "在水下时，将大鱼猎手替换为嘉慧。", All.JobID, All.PrizeCatch)]
        DolPrizeBountyFeature = 9007,

        [OrderedEnum]
        [CustomComboInfo("钓组 => 打捞", "在水下时，将钓组替换为打捞。", All.JobID, All.Snagging)]
        DolSnaggingSalvageFeature = 9008,

        [OrderedEnum]
        [CustomComboInfo("垂钓之光 => 电水流", "在水下时，将垂钓之光替换为电水流。", All.JobID, All.CastLight)]
        DolCastLightElectricCurrentFeature = 9009,

        [OrderedEnum]
        [CustomComboInfo("直钓提钩", "当技能可用、且当前不在提钩成功率降低（耐心）状态时，将精准/强力提钩替换为普通提钩。\n（原标题为 Hooking Hooksets，但我实在想不出来怎么翻比较好）", All.JobID, All.PrecisionHookset, All.PowerfulHookset)]
        DolHookingHooksetsFeature = 9012,

        [OrderedEnum]
        [CustomComboInfo("撒饵 => 抛竿", "在你已经有撒饵Buff，或GP少于100（在提钩成功率降低（耐心）状态下则为150）的情况下，将撒饵替换为抛竿。\n（同上，原标题为 Chummy Casts）", All.JobID, All.Chum)]
        DolChummyCastFeature = 9013,

        #endregion

        #region ASTROLOGIAN

        // latest enum: 3308

        [OrderedEnum]
        [CustomComboInfo("出卡I => 星极/灵极抽卡", "如果当前没有已经抽出的奥秘卡，将出卡I替换为星极/灵极抽卡。", AST.JobID, AST.Play1)]
        AstrologianCardsOnDrawFeature = 3301,

        /*[OrderedEnum]
        [CustomComboInfo("Play to Astrodyne", "Play becomes Astrodyne when you have 3 seals.\nIf Draw on Play is enabled, Astrodyne replaces Draw on Play while Draw is on Cooldown.", AST.JobID, AST.Play)]
        AstrologianAstrodynePlayFeature = 3304,*/

        [OrderedEnum]
        [CustomComboInfo("抽卡锁定功能", "在持有未使用的奥秘卡的情况下，将抽卡替换为凶星，以防止重复抽卡。（只要用出去一张就可以继续抽）", AST.JobID, AST.AstralDraw)]
        AstrologianDrawLockoutFeature = 3306,

        [OrderedEnum]
        [CustomComboInfo("福星 -> 吉星 等级同步", "在等级同步至26级以下时，将福星替换为吉星。", AST.JobID, AST.Benefic2)]
        AstrologianBeneficFeature = 3303,

        [OrderedEnum]
        [CustomComboInfo("占卜锁定功能", "如果身上的占卜Buff剩余时间超过3秒，则锁定占卜。（防止副本中Buff被覆盖）", AST.JobID, AST.Divination)]
        AstrologianDivinationLockoutFeature = 3308,

        [OrderedEnum]
        [CustomComboInfo("醒梦提醒（占星）", "当你的MP小于等于以下设置值、且醒梦不在冷却时，将你所有正在冷却、非职能、且没有积蓄次数的能力技替换为醒梦。", AST.JobID, AST.CelestialOpposition, AST.CollectiveUnconscious, AST.Divination, AST.EarthlyStar, AST.Exaltation, AST.Macrocosmos, AST.NeutralSect, AST.Synastry, AST.Horoscope)]
        AstrologianLucidReminderFeature = 3305,

        #endregion
        // ====================================================================================
        #region BLACK MAGE

        // latest enum: 2530

        [OrderedEnum]
        [CustomComboInfo("冰澈 <=> 炽炎 切换功能", "将冰澈或炽炎替换为你当能够使用的技能。\n如果被同步至无法使用他们的等级，则替换为冰结或火炎。", BLM.JobID, BLM.Blizzard4, BLM.Fire4)]
        BlackEnochianFeature = 2501,

        [OrderedEnum]
        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("冰澈/炽炎 => 异言 移动功能", "如果在没有三连/即刻咏唱时移动，则将炽炎和冰澈替换为异言。", BLM.JobID, BLM.Blizzard4, BLM.Fire4)]
        BlackEnochianXenoglossyFeature = 2520,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("绝望（防呆）功能", "如果处在星极火且MP小于2400时，将炽炎和冰澈替换为绝望。（防止绝望的发现打不出去绝望）", BLM.JobID, BLM.Blizzard4, BLM.Fire4)]
        BlackEnochianDespairFeature = 2510,

        [OrderedEnum]
        [CustomComboInfo("冰结 <=> 火炎 切换功能", "根据当前的元素状态，将冰结或火炎替换为你正在使用的那个。", BLM.JobID, BLM.Blizzard, BLM.Fire)]
        BlackEnochianButNotFeature = 2524,

        [OrderedEnum]
        [CustomComboInfo("核爆 => 绝望", "当你不在使用AOE时，将核爆替换为绝望。（当绝望可用时）", BLM.JobID, BLM.Flare, BLM.Freeze, BLM.Fire2, BLM.HighFire2)]
        BlackFlareDespairFeature = 2511,

        [OrderedEnum]
        [CustomComboInfo("核爆 => 耀星", "在耀星可用时，将核爆替换为耀星。", BLM.JobID, BLM.Flare)]
        BlackFlareStarFeature = 2527,

        [OrderedEnum]
        [CustomComboInfo("绝望 => 耀星", "在耀星可用、且MP=0或>=2400时，将绝望替换为耀星。", BLM.JobID, BLM.Despair)]
        BlackDespairStarFeature = 2530,

        [OrderedEnum]
        [CustomComboInfo("冰冻/冰封 => 耀星", "在耀星可用时，将冰封和（高）冰冻替换为耀星。", BLM.JobID, BLM.Blizzard, BLM.Blizzard2, BLM.Blizzard3, BLM.HighBlizzard2)]
        BlackBlizzardStarFeature = 2529,

        [OrderedEnum]
        [CustomComboInfo("高闪雷 => 高震雷 功能", "当你使用AOE技能、且技能可用时，将高闪雷替换为高震雷。", BLM.JobID, BLM.Thunder, BLM.Thunder3, BLM.HighThunder)]
        BlackThunder2Feature = 2526,

        [OrderedEnum]
        [CustomComboInfo("玄冰 <=> 核爆 切换功能", "将玄冰或核爆替换为你当前能够使用的技能。", BLM.JobID, BLM.Freeze, BLM.Flare)]
        BlackFreezeFlareFeature = 2502,

        [OrderedEnum]
        [ParentCombo(BlackFreezeFlareFeature)]
        [CustomComboInfo("玄冰/核爆 => 秽浊 移动功能", "如果在没有三连/即刻咏唱、已获得秽浊效果提高特性（瞬发秽浊）、且秽浊可用时移动，则将玄冰和核爆替换为秽浊。", BLM.JobID, BLM.Freeze, BLM.Flare)]
        BlackFreezeFlareFoulFeature = 2521,

        [OrderedEnum]
        [CustomComboInfo("灵极魂功能", "当你没有选中的目标、且处于灵极冰状态时，将你所有的冰系魔法替换为灵极魂。", BLM.JobID, BLM.Freeze, BLM.Blizzard4, BLM.Blizzard, BLM.Blizzard2, BLM.Blizzard3, BLM.HighBlizzard2, BLM.Fire4, BLM.Flare)]
        BlackUmbralSoulFeature = 2503,

        [OrderedEnum]
        [CustomComboInfo("星灵移位功能", "当你没有选中的目标、且处于星极火/灵极冰状态时，将所有非同系魔法替换为星灵移位。", BLM.JobID, BLM.Freeze, BLM.Blizzard4, BLM.Blizzard, BLM.Blizzard2, BLM.Blizzard3, BLM.HighBlizzard2, BLM.Fire4, BLM.Flare, BLM.Despair, BLM.Fire, BLM.Fire2, BLM.Fire3, BLM.HighFire2)]
        BlackTransposeFeature = 2516,

        [OrderedEnum]
        [CustomComboInfo("灵极魂 => 星灵移位", "当你不处于灵极冰状态时，将灵极魂替换为星灵移位。", BLM.JobID, BLM.UmbralSoul)]
        BlackUmbralSoulTransposeFeature = 2518,

        [OrderedEnum]
        [CustomComboInfo("烈炎功能", "在星极火状态时，将（高）烈炎替换为核爆。", BLM.JobID, BLM.Fire2, BLM.HighFire2)]
        BlackFire2Feature = 2508,

        [OrderedEnum]
        [CustomComboInfo("冰冻功能", "在灵极冰状态时，将（高）冰冻替换为玄冰。", BLM.JobID, BLM.Blizzard2, BLM.HighBlizzard2)]
        BlackBlizzard2Feature = 2509,

        [OrderedEnum]
        [CustomComboInfo("烈炎/冰冻功能选项", "烈炎和冰冻只在你有满档星极火/灵极冰的状态下，才会替换为核爆或玄冰。", BLM.JobID, BLM.Blizzard2)]
        BlackFireBlizzard2Option = 2514,

        [OrderedEnum]
        [CustomComboInfo("黑魔纹 => 魔纹步", "在黑魔纹发动时，将黑魔纹替换为魔纹步。\n！！！在使用这个功能前先关闭原版游戏的技能变换功能！！！", BLM.JobID, BLM.LeyLines)]
        BlackLeyLinesFeature = 2504,

        [OrderedEnum]
        [CustomComboInfo("火炎 => 爆炎 功能", "在不处于星极火状态、或触发火苗Buff时，将火炎替换为爆炎。如果悖论可用，也会替换为悖论。", BLM.JobID, BLM.Fire)]
        BlackFireFeature = 2505,

        [OrderedEnum]
        [ParentCombo(BlackFireFeature)]
        [CustomComboInfo("火炎 => 爆炎 功能选项", "如果星极火状态的档数不满，火炎也会成为爆炎。", BLM.JobID, BLM.Fire)]
        BlackFireOption = 2515,

        [OrderedEnum]
        [CustomComboInfo("冰结 => 冰封", "在冰封解锁后、且不处于三档灵极冰状态时，将冰结替换为冰封。", BLM.JobID, BLM.Blizzard)]
        BlackBlizzardFeature = 2506,

        [OrderedEnum]
        [CustomComboInfo("崩溃 => 异言", "当异言可用时，将崩溃替换为异言。", BLM.JobID, BLM.Scathe)]
        BlackScatheFeature = 2507,

        [OrderedEnum]
        [CustomComboInfo("秽浊/异言 => 详述", "当详述可用且满足下述条件时，将秽浊和异言替换为详述：刚刚使用了一个技能（GCD正在冷却）且详述的层数不满2层、当前没有目标、或详述的层数为0。", BLM.JobID, BLM.Xenoglossy, BLM.Foul)]
        BlackXenoAmpFeature = 2512,

        [OrderedEnum]
        [CustomComboInfo("异言 => 秽浊", "当你使用AOE技能、或异言尚未解锁时，将异言替换为秽浊。", BLM.JobID, BLM.Xenoglossy)]
        BlackXenoFoulFeature = 2522,

        [OrderedEnum]
        [CustomComboInfo("三连咏唱 => 即刻咏唱", "当三连咏唱的积蓄次数不满、且即刻咏唱可用，或三连咏唱尚未解锁时，将三连咏唱替换为即刻咏唱。", BLM.JobID, BLM.Triplecast)]
        BlackTripleswiftFeature = 2523,

        [OrderedEnum]
        [CustomComboInfo("耀星 => 魔泉", "当耀星不可用时，将耀星替换为魔泉。", BLM.JobID, BLM.FlareStar)]
        BlackFlareFontFeature = 2525,

        #endregion
        // ====================================================================================
        #region BARD

        // latest enum: 2315

        [OrderedEnum]
        [CustomComboInfo("爆发射击 => 辉煌箭", "当被触发时，将强力/爆发射击替换为直线射击/辉煌箭。", BRD.JobID, BRD.HeavyShot, BRD.BurstShot)]
        BardStraightShotUpgradeFeature = 2302,

        [OrderedEnum]
        [CustomComboInfo("伶牙俐齿功能", "如果目标身上没有风Dot，或伶牙俐齿尚未解锁，则将伶牙俐齿替换为（狂）风蚀箭。", BRD.JobID, BRD.IronJaws)]
        BardIronJawsFeature = 2311,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("伶牙俐齿 Plus", "如果目标身上没有对应的Dot，则将伶牙俐齿替换为对应的Dot技能。\n如果伶牙俐齿不可用，则会在这两个Dot技能之间切换。\n这是伶牙俐齿功能的一个独立功能。如果同时启用，则会覆盖它的效果。", BRD.JobID, BRD.IronJaws)]
        BardIronJawsFeaturePlus = 2303,

        [OrderedEnum]
        [CustomComboInfo("百首龙牙箭 => 绝峰箭", "当灵魂之声量谱到达80点时，将连珠箭/百首龙牙箭替换为绝峰箭。", BRD.JobID, BRD.QuickNock, BRD.Ladonsbite)]
        BardApexFeature = 2304,

        [OrderedEnum]
        [CustomComboInfo("百首龙牙箭 => 影噬箭", "当被触发时，将连珠箭/百首龙牙箭替换为广域群射/影噬箭。", BRD.JobID, BRD.QuickNock, BRD.Ladonsbite)]
        BardShadowbiteFeature = 2305,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("九天连箭 => 侧风诱导箭", "将九天连箭替换为侧风诱导箭，如果前者正在冷却而后者已经完成冷却。", BRD.JobID, BRD.EmpyrealArrow)]
        BardSidewinderFeature = 2306,

        [OrderedEnum]
        [CustomComboInfo("侧风诱导箭 => 完美音调", "在放浪神的小步舞曲时，将侧风诱导箭替换为完美音调，如果诗心已满、或侧风诱导箭正在冷却中。", BRD.JobID, BRD.Sidewinder)]
        BardPerfectSidesFeature = 2314,

        [OrderedEnum]
        [CustomComboInfo("战斗的最终乐章", "如果战斗之声已经完成冷却，则将光明神的最终乐章替换为战斗之声。\n（其实原标题是 Radiant Voice，但是为了和下面对应所以反过来了）", BRD.JobID, BRD.RadiantFinale)]
        BardRadiantFeature = 2307,

        [OrderedEnum]
        [ParentCombo(BardRadiantFeature)]
        [CustomComboInfo("光明神之声", "使用光明神的最终乐章之后，再将光明神的最终乐章替换为战斗之声。", BRD.JobID, BRD.RadiantFinale)]
        BardRadiantVoiceOption = 2315,

        [OrderedEnum]
        [CustomComboInfo("光明神强击", "如果猛者强击已经完成冷却而光明神的最终乐章没有，则光明神的最终乐章替换为猛者强击。\n如果上面“战斗的最终乐章”功能也被启用，则战斗之声的优先级更高。", BRD.JobID, BRD.RadiantFinale)]
        BardRadiantStrikesFeature = 2309,

        [OrderedEnum]
        [CustomComboInfo("战斗之声锁定功能", "如果身上的战斗之声Buff剩余时间超过3秒，则锁定战斗之声。（防止副本中Buff被覆盖）", BRD.JobID, BRD.BattleVoice)]
        BardBattleVoiceLockoutFeature = 2312,

        [OrderedEnum]
        [CustomComboInfo("光明神的最终乐章锁定功能", "如果身上的光明神的最终乐章Buff剩余时间超过3秒，则锁定战斗之声。（防止副本中Buff被覆盖）", BRD.JobID, BRD.RadiantFinale)]
        BardRadiantLockoutFeature = 2313,

        [OrderedEnum]
        [CustomComboInfo("纷乱箭 => 辉煌箭", "在已经触发鹰眼状态时，将纷乱箭替换为直线射击/辉煌箭。", BRD.JobID, BRD.Barrage)]
        BardBarrageFeature = 2308,

        [OrderedEnum]
        [CustomComboInfo("碎心箭 => 死亡箭雨", "如果你最近的GCD使用的是AOE技能（连珠箭/百首龙牙箭/广域群射/影噬箭），则将失血箭/碎心箭替换为死亡箭雨。", BRD.JobID, BRD.HeartbreakShot, BRD.Bloodletter)]
        BardRainFeature = 2310,

        #endregion
        // ====================================================================================
        #region DANCER

        // latest enum: 3827

        [OrderedEnum]
        [SecretCustomCombo]
        [ConflictingCombos(DancerDanceComboCompatibility)]
        [CustomComboInfo("（半）自动跳舞", "在跳舞时，将标准舞步和技巧舞步替换为对应的舞步技能。", DNC.JobID, DNC.StandardStep, DNC.TechnicalStep)]
        DancerDanceStepCombo = 3802,

        [OrderedEnum]
        [ConflictingCombos(DancerSingleTargetProcs)]
        [CustomComboInfo("瀑泄连击", "将瀑泄替换为连击（喷泉）或触发（逆瀑泄、坠喷泉）中可用的那个。", DNC.JobID, DNC.Cascade)]
        DancerSingleTargetMultibutton = 3804,

        [OrderedEnum]
        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("瀑泄连击 - 仅连击", "不要将瀑泄连击替换为他们的触发技能。（仅瀑泄 - 喷泉连击）", DNC.JobID)]
        DancerSingleTargetMultibuttonNoProcs = 3814,

        [OrderedEnum]
        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("瀑泄 => 剑舞", "当处于进攻之探戈状态、且你有超过50点伶俐时，将瀑泄连击替换为剑舞。", DNC.JobID)]
        DancerSingleTargetMultibuttonSaber = 3823,

        [OrderedEnum]
        [CustomComboInfo("逆瀑泄连击", "将逆瀑泄替换为坠喷泉，如果后者可用。", DNC.JobID, DNC.ReverseCascade)]
        DancerReverseCascadeCombo = 3818,

        [OrderedEnum]
        [ParentCombo(DancerReverseCascadeCombo)]
        [CustomComboInfo("逆瀑泄连击 - 也变为AOE触发", "如果你正在使用AOE技能，则替换为升风车或落血雨。（如果触发可用）", DNC.JobID)]
        DancerReverseCascadeComboAoE = 3819,

        [OrderedEnum]
        [ConflictingCombos(DancerSingleTargetMultibutton)]
        [CustomComboInfo("单体技能 触发替换功能", "如果触发可用，则将单体技能替换为对应的触发技能。（瀑泄 => 逆瀑泄、喷泉 => 坠喷泉）", DNC.JobID, DNC.Cascade, DNC.Fountain)]
        DancerSingleTargetProcs = 3811,

        [OrderedEnum]
        [ConflictingCombos(DancerAoeProcs)]
        [CustomComboInfo("风车连击", "将风车替换为连击（落刃雨）或触发（升风车、落血雨）中可用的那个。", DNC.JobID, DNC.Windmill)]
        DancerAoeMultibutton = 3805,

        [OrderedEnum]
        [ParentCombo(DancerAoeMultibutton)]
        [CustomComboInfo("风车连击 - 仅连击", "不要将风车连击替换为他们的触发技能。（仅风车 - 落刃雨连击）", DNC.JobID)]
        DancerAoeMultibuttonNoProcs = 3816,

        [OrderedEnum]
        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("风车 => 剑舞", "当处于进攻之探戈状态、且你有超过50点伶俐时，将风车连击替换为剑舞。", DNC.JobID)]
        DancerAoeMultibuttonSaber = 3824,

        [OrderedEnum]
        [CustomComboInfo("升风车连击", "将升风车替换为落血雨，如果后者可用。", DNC.JobID, DNC.RisingWindmill)]
        DancerRisingWindmillCombo = 3817,

        [OrderedEnum]
        [ConflictingCombos(DancerAoeMultibutton)]
        [CustomComboInfo("AOE技能 触发替换功能", "如果触发可用，则将AOE技能替换为对应的触发技能。（风车 => 升风车、落刃雨 => 落血雨）", DNC.JobID, DNC.Windmill, DNC.Bladeshower)]
        DancerAoeProcs = 3812,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("剑舞防溢出", "如果你的伶俐值超过85点，则将瀑泄/风车连击替换为剑舞。", DNC.JobID, DNC.Cascade, DNC.Windmill)]
        DancerCombosToSaberDanceOvercap = 3826,

        [OrderedEnum]
        [CustomComboInfo("扇舞·序 => 扇舞·破", "如果你正在使用AOE连击，则将扇舞·序替换为扇舞·破。", DNC.JobID, DNC.FanDance1)]
        DancerFanDance1to2 = 3820,

        [OrderedEnum]
        [CustomComboInfo("扇舞·序/破 => 扇舞·急", "当处于扇舞·急预备状态时，将扇舞·序和扇舞·破替换为扇舞·急。", DNC.JobID, DNC.FanDance1, DNC.FanDance2)]
        DancerFanDanceCombo = 3801,

        [OrderedEnum]
        [ParentCombo(DancerFanDanceCombo)]
        [CustomComboInfo("扇舞·序/破 => 扇舞·终", "如果也处于扇舞·终预备状态时，也将扇舞·序和扇舞·破替换为扇舞·终。", DNC.JobID, DNC.FanDance1, DNC.FanDance2)]
        DancerFanDance4Combo = 3809,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("扇舞防溢出", "如果你有四档幻扇、且GCD正在转圈，则将瀑泄/风车连击分别替换为扇舞·序或扇舞·破。", DNC.JobID, DNC.Cascade, DNC.Windmill)]
        DancerCombosToFanDance = 3825,

        [OrderedEnum]
        [CustomComboInfo("百花争艳 => 扇舞·终", "将百花争艳替换为扇舞·终，当后者可用的时候。", DNC.JobID, DNC.Flourish)]
        DancerFlourishFanDance4Feature = 3808,

        [OrderedEnum]
        [CustomComboInfo("百花争艳 => 扇舞·急", "将百花争艳替换为扇舞·急，当后者可用的时候。\n如果上面的扇舞·终替换功能也被启用，那么这里的优先级会更高。", DNC.JobID, DNC.Flourish)]
        DancerFlourishFanDance3Feature = 3810,

        [OrderedEnum]
        [CustomComboInfo("进攻之探戈 => 流星舞", "在使用进攻之探戈之后，将其替换为流星舞。", DNC.JobID, DNC.Devilment)]
        DancerDevilmentFeature = 3806,

        [OrderedEnum]
        [CustomComboInfo("标准舞步 => 落幕舞", "当落幕舞可用时，将标准舞步替换为落幕舞。", DNC.JobID, DNC.StandardStep)]
        DancerLastDanceFeature = 3821,

        [OrderedEnum]
        [CustomComboInfo("标准舞步 => 技巧舞步", "当标准舞步正在冷却时，将标准舞步替换为技巧舞步。", DNC.JobID, DNC.StandardStep)]
        DancerStandardechnicalStepFeature = 3822,

        [OrderedEnum]
        [CustomComboInfo("技巧舞步锁定功能", "如果身上的技巧舞步结束Buff剩余时间超过8秒，则锁定技巧舞步。（防止副本中Buff被覆盖）", DNC.JobID, DNC.TechnicalStep)]
        DancerTechnicalLockoutFeature = 3813,

        [OrderedEnum]
        [ConflictingCombos(DancerDanceStepCombo)]
        [CustomComboInfo(
            "舞步替换功能",
            "将跳舞时会变为舞步的技能指定为以下设置的四个。" +
            "\n这个功能的意义是，确保你在开启上面的连击功能、但不使用自动跳舞功能时，仍然可以正确的跳出四个舞步。" +
            "\n你可以通过在下面为每个舞步技能指定一个不同的技能ID来将其绑定到另一个技能上。" +
            "\n默认的选项是，瀑泄、百花争艳、扇舞·序、和扇舞·破。如果被设置为0，它们会被重置为这些技能。" +
            "\n技能ID可以通过在Garland Tools上搜索技能名并点击右上角的小齿轮图标获取。" +
            "\n（译注：SimpleTweaks可以直接在游戏内显示技能的ID、以及自动跳舞不会坑你的，这个功能真没卵用）",
            DNC.JobID)]
        DancerDanceComboCompatibility = 3807,

        [OrderedEnum]
        [CustomComboInfo("扇舞·破 => 绿叶小踢腿", "在跳舞期间将扇舞·破替换为绿叶小踢腿。（因为“hotbar shenanigans”，大概是作者懒得解决的冲突）", DNC.JobID, DNC.FanDance2)]
        DancerJeteShenanigans = 3827,

        #endregion
        // ====================================================================================
        #region DRAGOON

        // latest enum: 2220

        [OrderedEnum]
        [CustomComboInfo("苍穹刺连击", "将直刺/苍穹刺替换为它的整个连击链：\n精准刺/龙眼雷电 - 贯通刺/前冲刺 - 直刺/苍穹刺 - 龙牙龙爪 - 云蒸龙变", DRG.JobID, DRG.FullThrust, DRG.HeavensThrust)]
        DragoonFullThrustCombo = 2204,

        [OrderedEnum]
        [ParentCombo(DragoonFullThrustCombo)]
        [CustomComboInfo("苍穹刺连击 - 从贯通刺/前冲刺开始", "当没有进行连击的时候，将苍穹刺替换为贯通刺/前冲刺，而不是精准刺。\n从结果上来说，即是删去了苍穹刺连击的第一个技能，以便与樱花连击相区分，但是需要从其他地方找一个精准刺来开始这条连击链。", DRG.JobID, DRG.FullThrust, DRG.HeavensThrust)]
        DragoonFullThrustComboOption = 2210,

        [OrderedEnum]
        [ParentCombo(DragoonFullThrustCombo)]
        [CustomComboInfo("苍穹刺连击 => 贯穿尖", "当你在近战攻击技能的范围之外时，将苍穹刺连击替换为贯穿尖。", DRG.JobID, DRG.FullThrust, DRG.HeavensThrust)]
        DragoonFullThrustTalonFeature = 2211,

        [OrderedEnum]
        [CustomComboInfo("樱花连击", "将樱花怒放/樱花缭乱替换为它的整个连击链：\n精准刺/龙眼雷电 - 开膛枪/螺旋击 - 樱花怒放/樱花缭乱 - 龙尾大回旋 - 云蒸龙变", DRG.JobID, DRG.ChaosThrust, DRG.ChaoticSpring)]
        DragoonChaosThrustCombo = 2203,

        [OrderedEnum]
        [ParentCombo(DragoonChaosThrustCombo)]
        [CustomComboInfo("樱花连击 - 从开膛枪/螺旋击开始", "当没有进行连击的时候，将樱花怒放/樱花缭乱替换为开膛枪/螺旋击，而不是精准刺。\n从结果上来说，即是删去了樱花连击的第一个技能，以便与直刺连击相区分，但是需要从其他地方找一个精准刺来开始这条连击链。", DRG.JobID, DRG.ChaosThrust, DRG.ChaoticSpring)]
        DragoonChaosThrustComboOption = 2209,

        [OrderedEnum]
        [CustomComboInfo("苍穹刺连击 => 樱花缭乱", "在使用开膛枪/螺旋击后，将苍穹刺替换为樱花怒放/樱花缭乱，及后续的连击。\n与上面的苍穹刺连击一起用的话，相当于把苍穹刺连击替换为樱花连击。", DRG.JobID, DRG.FullThrust, DRG.HeavensThrust)]
        DragoonFullChaosFeature = 2215,

        [OrderedEnum]
        [CustomComboInfo("樱花连击 => 龙翼滑翔", "当你在近战攻击技能的范围之外时，将樱花连击替换为龙翼滑翔。（似乎只会替换开膛枪和樱花怒放）", DRG.JobID, DRG.Disembowel, DRG.SpiralBlow, DRG.ChaosThrust, DRG.ChaoticSpring)]
        DragoonChaoticGlideFeature = 2220,

        [OrderedEnum]
        [CustomComboInfo("精准刺/龙眼雷电 => 天龙点睛", "将精准刺/龙眼雷电替换为天龙点睛，如果后者可用。", DRG.JobID, DRG.FullThrust, DRG.ChaosThrust, DRG.TrueThrust)]
        DragoonRaidenWyrmwindFeature = 2213,

        [OrderedEnum]
        [CustomComboInfo("山境酷刑连击", "将山境酷刑替换为它的整个连击链：死天枪 - 音速刺 - 山境酷刑", DRG.JobID, DRG.CoerthanTorment)]
        DragoonCoerthanTormentCombo = 2202,

        [OrderedEnum]
        [ParentCombo(DragoonCoerthanTormentCombo)]
        [CustomComboInfo("山境酷刑连击 => 天龙点睛", "将山境酷刑连击替换为天龙点睛，如果后者可用。", DRG.JobID, DRG.CoerthanTorment)]
        DragoonWyrmwindFeature = 2207,

        [OrderedEnum]
        [CustomComboInfo("跳跃 => 幻象冲", "将跳跃替换为幻象冲，如果后者可用。\n！！！译注：原版游戏有这个技能变换功能，不需要用这里的！！！", DRG.JobID, DRG.Jump, DRG.HighJump)]
        DragoonJumpFeature = 2201,

        [OrderedEnum]
        [CustomComboInfo("坠星冲 => 龙炎冲", "在龙炎冲冷却完毕、或不在红莲龙血状态时，将坠星冲替换为龙炎冲。", DRG.JobID, DRG.Stardiver)]
        DragoonStarfireDiveFeature = 2208,

        [OrderedEnum]
        [CustomComboInfo("猛枪 => 战斗连祷", "在猛枪冷却时，将猛枪替换为战斗连祷。", DRG.JobID, DRG.LanceCharge)]
        DragoonLancetanyFeature = 2218,

        [OrderedEnum]
        [CustomComboInfo("战斗连祷锁定功能", "如果身上的战斗连祷Buff剩余时间超过3秒，则锁定战斗连祷。（防止副本中Buff被覆盖）", DRG.JobID, DRG.BattleLitany)]
        DragoonLitanyLockoutFeature = 2219,

        #endregion
        // ====================================================================================
        #region DARK KNIGHT

        // unused enums: 3204
        // last used enum: 3213

        [OrderedEnum]
        [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain.", DRK.JobID, DRK.Souleater)]
        DarkSouleaterCombo = 3201,

        [OrderedEnum]
        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("Souleater to Unmend", "Replace Souleater's combo with Unmend while out of melee range.", DRK.JobID, DRK.Souleater)]
        DarkSoulmendFeature = 3208,

        [OrderedEnum]
        [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain.", DRK.JobID, DRK.StalwartSoul, DRK.Unleash)]
        DarkStalwartSoulCombo = 3202,

        [OrderedEnum]
        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("Stalwart Soul to Disesteem", "Replace Stalwart Soul's combo with Disesteem while it is available.", DRK.JobID, DRK.StalwartSoul, DRK.Unleash)]
        DarkStalsteemFeature = 3213,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("Evil Stalwart Soul Combo", "Replace Unleash with its combo chain, instead.", DRK.JobID, DRK.StalwartSoul, DRK.Unleash)]
        DarkEvilStalwartSoulCombo = 3205,

        [OrderedEnum]
        [CustomComboInfo("Dark Knight Gauge Overcap Feature", "Replace AoE combo with gauge spender if you are about to overcap.", DRK.JobID, DRK.StalwartSoul)]
        DRKOvercapFeature = 3203,

        [OrderedEnum]
        [CustomComboInfo("Delirium Feature", "Replaces Carve and Spit with Delirium if its cooldown is up .", DRK.JobID, DRK.CarveAndSpit)]
        DarkDeliriumFeature = 3206,

        [OrderedEnum]
        [CustomComboInfo("Edge to Flood Feature", "Replaces Edge of Darkness/Shadow with Flood of Darkness/Shadow if currently using your AoE combo (as well as synced content before you unlock Edge).", DRK.JobID, DRK.EdgeOfDarkness, DRK.EdgeOfShadow)]
        DarkEdgeToFloodFeature = 3209,

        [OrderedEnum]
        [CustomComboInfo("Bloodspiller to Quietus Feature", "Replaces Bloodspiller with Quietus if currently using your AoE combo.", DRK.JobID, DRK.Bloodspiller)]
        DarkBloodspillerToQuietusFeature = 3210,

        [OrderedEnum]
        [CustomComboInfo("Carve and Spit to Abyssal Drain", "Replaces Carve and Spit with Abyssal Drain if currently using your AoE combo.", DRK.JobID, DRK.CarveAndSpit)]
        DarkCarveToDrainFeature = 3211,

        [OrderedEnum]
        [CustomComboInfo("The Blackest Night to Oblation", "Replaces The Blackest Night with Oblation if The Blackest Night is on cooldown, Oblation is usable, and you currently do not have it applied to yourself.", DRK.JobID, DRK.TheBlackestNight)]
        DarkTBNToOblationFeature = 3212,

        #endregion
        // ====================================================================================
        #region GUNBREAKER

        // last used enum: 3718

        [OrderedEnum]
        [CustomComboInfo("Solid Barrel Combo", "Replace Solid Barrel with its combo chain.", GNB.JobID, GNB.SolidBarrel)]
        GunbreakerSolidBarrelCombo = 3701,

        [OrderedEnum]
        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("Solid Barrel to Lightning Shot", "Replace Solid Barrel's combo with Lightning Shot while out of melee range.", GNB.JobID, GNB.SolidBarrel)]
        GunbreakerSolidShotFeature = 3714,

        [OrderedEnum]
        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("Solid Barrel Combo to Burst Strike", "In addition to the Solid Barrel Combo, add Burst Strike when charges are full.", GNB.JobID, GNB.SolidBarrel)]
        GunbreakerBurstStrikeFeature = 3710,

        [OrderedEnum]
        [CustomComboInfo("Gnashing Fang Continuation", "Replace Gnashing Fang with Continuation when appropriate.", GNB.JobID, GNB.GnashingFang)]
        GunbreakerGnashingFangContinuation = 3702,

        [OrderedEnum]
        [CustomComboInfo("Burst Strike Continuation", "Replace Burst Strike with Continuation when appropriate.", GNB.JobID, GNB.BurstStrike)]
        GunbreakerBurstStrikeCont = 3703,

        [OrderedEnum]
        [CustomComboInfo("Fated Circle Continuation", "Replace Fated Circle with Continuation when appropriate.", GNB.JobID, GNB.FatedCircle)]
        GunbreakerFatedCircleContinuation = 3716,

        [OrderedEnum]
        [CustomComboInfo("Demon Slaughter Combo", "Replace Demon Slaughter with its combo chain.", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerDemonSlaughterCombo = 3705,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("Evil Demon Slaughter Combo", "Replace Demon Slice with its combo chain, instead.", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerEvilDemonSlaughterCombo = 3709,

        [OrderedEnum]
        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("Demon Slaughter Combo to Fated Circle", "In addition to the Demon Slaughter combo, add Fated Circle when charges are full.", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerFatedCircleFeature = 3706,

        [OrderedEnum]
        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("Demon Slaughter Combo to Lion Heart Combo", "Replace the Demon Slaughter combo with the Lion Heart (Reign of Beasts) combo when available.", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerDemonHeartFeature = 3718,

        [OrderedEnum]
        [CustomComboInfo("Burst Strike to Fated Circle", "Replace Burst Strike with Fated Circle if you are currently using your AoE combo.", GNB.JobID, GNB.BurstStrike)]
        GunbreakerBurstStrikeToFatedCircleFeature = 3715,

        [OrderedEnum]
        [CustomComboInfo("Burst Strike/Fated Circle to Bloodfest", "Replace Burst Strike and Fated Circle with Bloodfest if you have no powder gauge.", GNB.JobID, GNB.BurstStrike, GNB.FatedCircle)]
        GunbreakerBloodfestOvercapFeature = 3707,

        [OrderedEnum]
        [CustomComboInfo("Burst Strike/Fated Circle to Double Down", "Replace Burst Strike and Fated Circle with Double Down when it is available.", GNB.JobID, GNB.BurstStrike, GNB.FatedCircle)]
        GunbreakerDoubleDownFeature = 3711,

        [OrderedEnum]
        [CustomComboInfo("Burst Strike/Fated Circle to Lion Heart Combo", "Replace Burst Strike and Fated Circle with the Lion Heart combo when it is available.", GNB.JobID, GNB.BurstStrike, GNB.FatedCircle)]
        GunbreakerBurstHeartFeature = 3717,

        [OrderedEnum]
        [CustomComboInfo("No Mercy to Bow Shock", "Replace No Mercy with Bow Shock while No Mercy is active.\nIf No Mercy is currently Sonic Break, it will only take effect while the GCD is rolling.", GNB.JobID, GNB.NoMercy)]
        GunbreakerNoMercyFeature = 3708,

        [OrderedEnum]
        [CustomComboInfo("No Mercy to Double Down", "Replace No Mercy with Double Down while No Mercy is active and it is off-cooldown.\nThis takes priority over Bow Shock/Sonic Break if the No Mercy feature is enabled.", GNB.JobID, GNB.NoMercy)]
        GunbreakerNoMercyDoubleDownFeature = 3712,

        #endregion
        // ====================================================================================
        #region MACHINIST

        // last used enum: 3114

        [OrderedEnum]
        [ConflictingCombos(MachinistHypercomboOption)]
        [CustomComboInfo("(Heated) Shot Combo", "Replace either form of Clean Shot with its combo chain.", MCH.JobID, MCH.CleanShot, MCH.HeatedCleanShot)]
        MachinistMainCombo = 3101,

        [OrderedEnum]
        [CustomComboInfo("Spread Shot Heat", "Replace Spread Shot with Auto Crossbow when overheated.", MCH.JobID, MCH.SpreadShot, MCH.Scattergun)]
        MachinistSpreadShotFeature = 3102,

        [OrderedEnum]
        [CustomComboInfo("Hypercharge Feature", "Replace Heat Blast and Auto Crossbow with Hypercharge when not overheated.", MCH.JobID, MCH.HeatBlast, MCH.BlazingShot, MCH.AutoCrossbow)]
        MachinistOverheatFeature = 3103,

        [OrderedEnum]
        [CustomComboInfo("Hypercharge Combo Feature", "Replace your main combo actions with Heat Blast while overheated.", MCH.JobID, MCH.SplitShot, MCH.HeatedSplitShot, MCH.SlugShot, MCH.HeatedSlugShot, MCH.CleanShot, MCH.HeatedCleanShot)]
        MachinistHypercomboFeature = 3108,

        [OrderedEnum]
        [ParentCombo(MachinistHypercomboFeature)]
        [ConflictingCombos(MachinistMainCombo)]
        [CustomComboInfo("Hypercharge Combo Option", "Only replace your current combo action with Heat Blast.", MCH.JobID, MCH.SplitShot, MCH.HeatedSplitShot, MCH.SlugShot, MCH.HeatedSlugShot, MCH.CleanShot, MCH.HeatedCleanShot)]
        MachinistHypercomboOption = 3110,

        [OrderedEnum]
        [CustomComboInfo("Overdrive Feature", "Replace Rook Autoturret and Automaton Queen with Overdrive while active.", MCH.JobID, MCH.RookAutoturret, MCH.AutomatonQueen)]
        MachinistOverdriveFeature = 3104,

        [OrderedEnum]
        [CustomComboInfo("Hypercharge to Wildfire", "Hypercharge becomes Wildfire if Wildfire is off-cooldown and you have a target.", MCH.JobID, MCH.Hypercharge)]
        MachinistHyperfireFeature = 3107,

        [OrderedEnum]
        [CustomComboInfo("Drill to Bioblaster", "Drill becomes Bioblaster if Reassemble is not active and your last combo action was Spread Shot/Scattergun.", MCH.JobID, MCH.Drill)]
        MachinistBioDrillFeature = 3114,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Gauss Round / Ricochet Feature", "Replace Gauss Round and Ricochet with one or the other depending on which has more charges.", MCH.JobID, MCH.GaussRound, MCH.Ricochet)]
        MachinistGaussRoundRicochetFeature = 3105,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(MachinistGaussRoundRicochetFeature)]
        [CustomComboInfo("Gauss Round / Ricochet Overheat Option", "Gauss Round/Ricochet will only replace each other while Overheated.", MCH.JobID, MCH.GaussRound, MCH.Ricochet)]
        MachinistGaussRoundRicochetFeatureOption = 3109,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Chainsaw Cycling Feature", "Replace Chainsaw with Air Anchor and Drill, based on the priority of each cooldown. Does not replace any other actions, so you can easily watch their cooldowns.", MCH.JobID, MCH.Chainsaw)]
        MachinistChainsawFeature = 3113,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(MachinistChainsawFeature)]
        [CustomComboInfo("Reassemble to Chainsaw", "Reassemble becomes Chainsaw's cycling actions while Reassemble is active.", MCH.JobID, MCH.Reassemble)]
        MachinistReassembleFeature = 3111,

        #endregion
        // ====================================================================================
        #region MONK

        // latest enum: 2034

        [OrderedEnum]
        [CustomComboInfo("Leaping Opo Combo", "Replace Leaping Opo/Bootshine with Monk's Leaping Opo/Rising Raptor/Pouncing Coeurl combo.", MNK.JobID, MNK.LeapingOpo, MNK.Bootshine)]
        MonkOpoCombo = 2019,

        [OrderedEnum]
        [CustomComboInfo("Dragon Kick Combo", "Replace Dragon Kick with Monk's Dragon Kick combo.", MNK.JobID, MNK.DragonKick)]
        MonkDragonKickCombo = 2020,

        [OrderedEnum]
        [ConflictingCombos(MonkAoEComboFormOption)]
        [CustomComboInfo("Form Shift to Twin Snakes", "Replace Form Shift with Twin Snakes during Perfect Balance.", MNK.JobID, MNK.FormShift)]
        MonkFormSnakes = 2032,

        [OrderedEnum]
        [ConflictingCombos(MonkPerfectBalanceFeatureLockout)]
        [CustomComboInfo("Perfect Balance to Demolish", "Replace Perfect Balance with Demolish while in Perfect Balance, so you don't need it on your bar separately.", MNK.JobID, MNK.PerfectBalance)]
        MonkPerfectBalanceDemolishFeature = 2026,

        [OrderedEnum]
        [CustomComboInfo("Meditation Reminder", "Your GCDs become Meditate out of combat if you don't have the Fifth Chakra open.", MNK.JobID, MNK.TwinSnakes, MNK.TrueStrike, MNK.RisingRaptor, MNK.FormShift, MNK.SnapPunch, MNK.PouncingCoeurl, MNK.Demolish, MNK.Bootshine, MNK.LeapingOpo, MNK.DragonKick, MNK.MasterfulBlitz, MNK.Rockbreaker, MNK.ArmOfTheDestroyer, MNK.ShadowOfTheDestroyer, MNK.FourPointFury, MNK.SixSidedStar, PLD.TotalEclipse, MNK.PerfectBalance)]
        MonkMeditationReminder = 2013,

        [OrderedEnum]
        [CustomComboInfo("AoE Combo", "Replaces Masterful Blitz (for bug reasons) with the AoE combo chain, or whatever your most damaging move is when Perfect Balance is active.\nFour-Point Fury becomes AoE combo chain in order of forms during Perfect Balance.\nMasterful Blitz replaces the AoE combo when you have 3 Beast Chakra.", MNK.JobID, MNK.MasterfulBlitz, MNK.FourPointFury, MNK.FormShift, PLD.TotalEclipse)]
        MonkAoECombo = 2001,

        [OrderedEnum]
        [ParentCombo(MonkAoECombo)]
        [CustomComboInfo("Experimental No-Blitz Option", "Enabling this option makes it so that Total Eclipse is the basis for your main AoE combo, and Masterful Blitz is untouched.\n" +
            "To get Total Eclipse onto your Monk hotbar, use a shared hotbar, a macro, or a plugin like ReAction.", MNK.JobID)]
        MonkAoEComboBlitzOption = 2027,

        [OrderedEnum]
        [ParentCombo(MonkAoECombo)]
        [ConflictingCombos(MonkFormSnakes)]
        [CustomComboInfo("Form Shift Option", "Enabling this option has Form Shift turn into 1-2-3 AoE combo in Perfect Balance.", MNK.JobID, MNK.FormShift)]
        MonkAoEComboFormOption = 2009,

        [OrderedEnum]
        [ParentCombo(MonkAoECombo)]
        [CustomComboInfo("Meditation Feature", "Replaces AoE combo with Howling Fist/Enlightment if you have the Fifth Chakra open, have a target, and you have just used an action.", MNK.JobID, MNK.MasterfulBlitz)]
        MonkAoEMeditationFeature = 2014,

        // [OrderedEnum]
        // [ParentCombo(MonkAoECombo)]
        // [CustomComboInfo("Monk AoE Balance Feature", "Replaces Monk's AoE Combo with Masterful Blitz if you have 3 Beast Chakra.", MNK.JobID, MNK.Rockbreaker)]
        // MonkAoEBalanceFeature = 2006,

        [OrderedEnum]
        [CustomComboInfo("Draconic Leap", "Replaces Dragon Kick with Leaping Opo/Bootshine if Opo-Opo's Fury is up, as well as vice versa for Leaping Opo in combos.", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkDragonKickBootshineFeature = 2002,

        [OrderedEnum]
        [CustomComboInfo("Twin Raptors", "Replaces Twin Snakes with Rising Raptor/True Strike if Raptor's Fury is up, as well as vice versa for Rising Raptor in combos.", MNK.JobID, MNK.TwinSnakes)]
        MonkTwinRaptorsFeature = 2030,

        [OrderedEnum]
        [CustomComboInfo("Demolishing Pounce", "Replaces Demolish with Pouncing Coeurl/Snap Punch if Coeurl's Fury is up, as well as vice versa for Pouncing Coeurl in combos.", MNK.JobID, MNK.Demolish)]
        MonkDemolishingPounceFeature = 2031,

        [OrderedEnum]
        [CustomComboInfo("Perfect Balance Fury Option", "With this enabled, the three above Fury features only apply during Perfect Balance or Form Shift.", MNK.JobID, MNK.DragonKick)]
        MonkPerfectBalanceFuryOption = 2033,

        [OrderedEnum]
        [CustomComboInfo("Dragon Kick/Leaping Opo Balance Feature", "Replaces Dragon Kick and Leaping Opo with Masterful Blitz if you have 3 Beast Chakra.", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkDragonKickBalanceFeature = 2005,

        [OrderedEnum]
        [CustomComboInfo("Leaping Dragon Clap Feature", "Replaces Dragon Kick and Leaping Opo with Thunderclap if you are out of melee range, or have a player targeted.", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkDragonClapFeature = 2022,

        [OrderedEnum]
        [CustomComboInfo("Dragon Kick to Forbidden Chakra", "Replaces Dragon Kick and Leaping Opo with Forbidden Chakra while available, during global cooldown.", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkChakraKickFeature = 2034,

        [OrderedEnum]
        [CustomComboInfo("Forbidden Chakra to Enlightment Feature", "Replaces Forbidden Chakra with Enlightenment if your last-used GCD action was Arm/Shadow of the Destroyer, Four-Point Fury, or Rockbreaker.", MNK.JobID, MNK.Meditation, MNK.SteeledMeditation)]
        MonkChakraToEnlightmentFeature = 2025,

        [OrderedEnum]
        [CustomComboInfo("Perfect Balance Feature", "Perfect Balance becomes Masterful Blitz while you have 3 Beast Chakra.", MNK.JobID, MNK.PerfectBalance)]
        MonkPerfectBalanceFeature = 2004,

        [OrderedEnum]
        [ParentCombo(MonkPerfectBalanceFeature)]
        [CustomComboInfo("Perfect Balance Feature: Lockout", "Perfect Balance becomes a useless action while Perfect Balance is active.", MNK.JobID, MNK.PerfectBalance)]
        MonkPerfectBalanceFeatureLockout = 2021,

        [OrderedEnum]
        [CustomComboInfo("Riddle of Fire to Brotherhood", "Riddle of Fire becomes Brotherhood if Brotherhood is on cooldown.", MNK.JobID, MNK.RiddleOfFire)]
        MonkRiddleToBrotherFeature = 2011,

        [OrderedEnum]
        [CustomComboInfo("Riddle of Fire to Riddle of Wind", "Riddle of Fire becomes Riddle of Wind if the former is on cooldown and the latter is not.\nIf Riddle of Fire to Brotherhood is enabled, Brotherhood takes priority.", MNK.JobID, MNK.RiddleOfFire)]
        MonkRiddleToRiddleFeature = 2012,

        [OrderedEnum]
        [CustomComboInfo("Brotherhood Lockout Feature", "Brotherhood is locked out while it is available and more than 3s are left on its buff, to prevent overwriting raid buffs.", MNK.JobID, MNK.Brotherhood)]
        MonkBrotherhoodLockoutFeature = 2028,

        #endregion
        // ====================================================================================
        #region NINJA

        // last used: 3024

        [OrderedEnum]
        [CustomComboInfo("Aeolian Edge Combo", "Replace Aeolian Edge with its combo chain.", NIN.JobID, NIN.AeolianEdge)]
        NinjaAeolianEdgeCombo = 3002,

        [OrderedEnum]
        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Aeolian Edge to Throwing Dagger", "Replace Aeolian Edge combo with Throwing Dagger if you are out of range.", NIN.JobID, NIN.ThrowingDagger)]
        NinjaThrowingEdgeFeature = 3021,

/*        [OrderedEnum]
        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Aeolian Edge to Armor Crush", "Replace Aeolian Edge with Armor Crush in its combo if you do not have its buff applied.", NIN.JobID, NIN.AeolianEdge)]
        NinjaAeolianCrushFeature = 3024,*/

        [OrderedEnum]
        [CustomComboInfo("Armor Crush Combo", "Replace Armor Crush with its combo chain.", NIN.JobID, NIN.ArmorCrush)]
        NinjaArmorCrushCombo = 3001,

        [OrderedEnum]
        [CustomComboInfo("Hakke Mujinsatsu Combo", "Replace Hakke Mujinsatsu with its combo chain.", NIN.JobID, NIN.HakkeMujinsatsu, NIN.DeathBlossom)]
        NinjaHakkeMujinsatsuCombo = 3003,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(NinjaHakkeMujinsatsuCombo)]
        [CustomComboInfo("Evil Hakke Mujinsatsu Combo", "Replace Death Blossom with its combo chain instead.", NIN.JobID, NIN.HakkeMujinsatsu, NIN.DeathBlossom)]
        NinjaEvilHakkeMujinsatsuCombo = 3014,

        [OrderedEnum]
        [CustomComboInfo("Kassatsu to Kunai's Bane", "Replaces Kassatsu with Kunai's Bane/Trick Attack while Suiton is up and Kassatsu is on cooldown, or Hidden is up.", NIN.JobID, NIN.Kassatsu)]
        NinjaKassatsuTrickFeature = 3004,

        [OrderedEnum]
        [CustomComboInfo("Kassatsu to Dream Within a Dream", "Replaces Kassatsu with Dream Within a Dream if the former is on cooldown and the latter is not.\nIf you have Kassatsu to Trick on, Trick Attack takes priority over DwaD.", NIN.JobID, NIN.Kassatsu)]
        NinjaKassatsuDWaDFeature = 3015,

        [OrderedEnum]
        [CustomComboInfo("Dream Within a Dream to Kunai's Bane", "Replaces Dream Within a Dream with Kunai's Bane/Trick Attack while Suiton or Hidden is active.", NIN.JobID, NIN.DreamWithinADream)]
        NinjaDWaDTrickFeature = 3019,

        [OrderedEnum]
        [CustomComboInfo("Ten Chi Jin to Meisui", "Replaces Ten Chi Jin (the move) with Meisui while Suiton is up.", NIN.JobID, NIN.TenChiJin)]
        NinjaTCJMeisuiFeature = 3005,

        [OrderedEnum]
        [CustomComboInfo("Kassatsu Chi/Jin Feature", "Replaces Chi with Jin while Kassatsu is up if you have Enhanced Kassatsu.", NIN.JobID, NIN.Chi)]
        NinjaKassatsuChiJinFeature = 3006,

        [OrderedEnum]
        [CustomComboInfo("Hide to Dokumori", "Replaces Hide with Dokumori/Mug while in combat.", NIN.JobID, NIN.Hide)]
        NinjaHideMugFeature = 3007,

        [OrderedEnum]
        [CustomComboInfo("Dokumori Lockout Feature", "Locks out Dokumori/Mug while it is available and more than 3s remain on its debuff, to prevent overwriting raid buffs.", NIN.JobID, NIN.Mug, NIN.Dokumori)]
        NinjaMugLockoutFeature = 3023,

        [OrderedEnum]
        [CustomComboInfo("Bhavacakra to Hellfrog Medium", "Replaces Bhavacakra with Hellfrog Medium while you are in the midst of your AoE combo.", NIN.JobID, NIN.Bhavacakra)]
        NinjaBhavacakraToFroggieFeature = 3022,

        [OrderedEnum]
        [ConflictingCombos(NinjaGCDNinjutsuFeature)]
        [CustomComboInfo("Aeolian to Ninjutsu Feature", "Replaces Aeolian Edge (combo) with your current Ninjutsu action if any Mudra are used.", NIN.JobID, NIN.AeolianEdge)]
        NinjaNinjutsuFeature = 3008,

        [OrderedEnum]
        [ConflictingCombos(NinjaNinjutsuFeature)]
        [CustomComboInfo("GCDs to Ninjutsu Feature", "Every non-Mudra GCD becomes your current Ninjutsu action while Mudras are being used.", NIN.JobID, NIN.AeolianEdge, NIN.ArmorCrush, NIN.HakkeMujinsatsu, NIN.DeathBlossom, NIN.ThrowingDagger, NIN.GustSlash, NIN.SpinningEdge, NIN.ForkedRaiju, NIN.FleetingRaiju)]
        NinjaGCDNinjutsuFeature = 3009,

        [OrderedEnum]
        [CustomComboInfo("Ninjutsu Double-Tap Feature", "Double-tapping your last-used mudra executes your current Ninjutsu action, or replaces all three if it is currently Doton/Huton/Suiton/Goka/Hyosho.", NIN.JobID, NIN.Ten, NIN.Chi, NIN.Jin)]
        NinjaTapNinjutsuFeature = 3020,

        [OrderedEnum]
        [CustomComboInfo("Armor Crush / Forked Raiju Feature", "Replaces Armor Crush with Forked Raiju when available.", NIN.JobID, NIN.ArmorCrush)]
        NinjaArmorCrushRaijuFeature = 3012,

        [OrderedEnum]
        [CustomComboInfo("Aeolian Edge / Fleeting Raiju Feature", "Replaces the Aeolian Edge combo with Fleeting Raiju when available.", NIN.JobID, NIN.AeolianEdge)]
        NinjaAeolianEdgeRaijuFeature = 3013,

        [OrderedEnum]
        [CustomComboInfo("Forked/Fleeting Raiju Switch Feature", "Forked/Fleeting Raiju change depending on distance from target (works with the Raiju features).", NIN.JobID, NIN.ForkedRaiju, NIN.FleetingRaiju)]
        NinjaSmartRaijuFeature = 3016,

        #endregion
        // ====================================================================================
        #region PALADIN

        // used enums: 1913, 1901, 1909, 1910, 1906
        // latest enum: 1922

        [OrderedEnum]
        [CustomComboInfo("Royal Authority Combo", "Replace Royal Authority/Rage of Halone with its combo chain.", PLD.JobID, PLD.RoyalAuthority, PLD.RageOfHalone)]
        PaladinRoyalAuthorityCombo = 1902,

        [OrderedEnum]
        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("Royal Authority to Shield Lob", "Replace Royal Authority/Rage of Halone's combo with Shield Lob when out of melee range.", PLD.JobID, PLD.RoyalAuthority, PLD.RageOfHalone)]
        PaladinRoyalLobFeature = 1912,

        [OrderedEnum]
        [CustomComboInfo("Royal Authority to Holy Spirit", "Replace Royal Authority with Holy Spirit while Divine Might is active", PLD.JobID, PLD.RoyalAuthority, PLD.RageOfHalone)]
        PaladinRoyalAuthorityNotBurstStrikeFeature = 1919,

        [OrderedEnum]
        [CustomComboInfo("Royal Authority Atonement Feature", "Replace Royal Authority with Atonement when under the effect of Sword Oath.", PLD.JobID, PLD.RageOfHalone, PLD.RoyalAuthority)]
        PaladinRoyalAuthorityAtonementFeature = 1903,

        [OrderedEnum]
        [CustomComboInfo("Shield Lob to Holy Spirit", "Replace Shield Lob with Holy Spirit while Divine Might is active.", PLD.JobID, PLD.ShieldLob)]
        PaladinShieldLobToNotBurstStrikeFeature = 1921,

        [OrderedEnum]
        [ParentCombo(PaladinShieldLobToNotBurstStrikeFeature)]
        [CustomComboInfo("Shield Lob to Holy Spirit Movement Option", "Also replace Shield Lob with Holy Spirit while not moving, even if Divine Might is not active.", PLD.JobID, PLD.ShieldLob)]
        PaladinShieldLobToNotBurstStrikeOption = 1922,

        /*[OrderedEnum]
        [CustomComboInfo("Holy Spirit to Atonement", "Replace Holy Spirit with Atonement while Divine Might or Requiescat are not up.", PLD.JobID, PLD.NotBurstStrike)]
        PaladinNotBurstStrikeToAtonement = 1916,*/

        [OrderedEnum]
        [CustomComboInfo("Prominence Combo", "Replace Prominence with its combo chain.", PLD.JobID, PLD.Prominence, PLD.TotalEclipse)]
        PaladinProminenceCombo = 1904,

        [OrderedEnum]
        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("AoE Combo to Holy Circle", "Add Holy Circle before Prominence in your combo if Divine Might is active.", PLD.JobID)]
        PaladinNotFatedCircleOvercapFeature = 1918,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("Evil Prominence Combo", "Replace Total Eclipse with its combo chain, instead.", PLD.JobID, PLD.Prominence, PLD.TotalEclipse)]
        PaladinEvilProminenceCombo = 1907,

        [OrderedEnum]
        [CustomComboInfo("Imperator Confiteor", "Replace Imperator/Requiescat with Confiteor while active. Includes Confiteor combo.", PLD.JobID, PLD.Requiescat, PLD.Imperator)]
        PaladinRequiescatCombo = 1905,

        [OrderedEnum]
        [ParentCombo(PaladinRequiescatCombo)]
        [CustomComboInfo("Requiescat Confiteor Level-sync Feature", "Replace Requiescat with Holy Spirit if Confiteor is not available, or already used and its combo is not unlocked.", PLD.JobID, PLD.Requiescat, PLD.Imperator)]
        PaladinRequiescatComboSpirit = 1917,

        [OrderedEnum]
        [CustomComboInfo("Confiteor Feature", "Replace Holy Spirit/Circle with Confiteor and its combo when it is available, as well as Blade of Honor.", PLD.JobID, PLD.NotBurstStrike, PLD.NotFatedCircle)]
        PaladinConfiteorFeature = 1906,

        [OrderedEnum]
        [CustomComboInfo("AoE Combo to Imperator Spells", "Replace your AoE combo actions with applicable spells while you have Imperator is active.", PLD.JobID, PLD.TotalEclipse, PLD.Prominence)]
        PaladinNotFatedCircleFeature = 1910,

        [OrderedEnum]
        [CustomComboInfo("Holy Spirit to Holy Circle", "Replace Holy Spirit with Holy Circle if your last combo action was Total Eclipse or Prominence.", PLD.JobID, PLD.NotBurstStrike)]
        PaladinHolySpiritToHolyCircleFeature = 1914,

        [OrderedEnum]
        [CustomComboInfo("Fight or Flight to Imperator", "Replace Fight or Flight with Imperator/Requiescat while the effect is active, as well as Blade of Honor.\nIf Fight or Flight is currently Goring Blade, this only will take effect during the global cooldown.", PLD.JobID, PLD.NotNoMercy)]
        PaladinNotNoMercyToRequiescat = 1920,

/*        [OrderedEnum]
        [CustomComboInfo("Fight or Flight to Goring Blade", "Replace Fight or Flight with Goring Blade while the effect is active.", PLD.JobID, PLD.NotNoMercy)]
        PaladinNotNoMercyToNotSonicBreak = 1915,*/

        [OrderedEnum]
        [CustomComboInfo("Shield Blash to Low Blow", "Replace Shield Bash to Low Blow when it is on cooldown.\nAlso works with Tank Interrupt feature.", PLD.JobID, PLD.ShieldBash)]
        PaladinLowBashFeature = 1911,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Scornful Spirits Feature", "Replace Spirits Within and Circle of Scorn with whichever is available soonest.", PLD.JobID, PLD.SpiritsWithin, PLD.Expiacion, PLD.CircleOfScorn)]
        PaladinScornfulSpiritsFeature = 1908,

        #endregion
        // ====================================================================================
        #region PICTOMANCER

        // last used enum: 4210

        [OrderedEnum]
        [CustomComboInfo("Subtracting Your Combos", "Replace your normal combos with subtractive combos while you have Subtractive Palette active.", PCT.JobID, PCT.FireInRed, PCT.Fire2InRed)]
        PictSubFeature = 4201,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(PictSubFeature)]
        [CustomComboInfo("Cleansing Your Palette", "Replace your combos with Subtractive Palette if your next action will overcap gauge.", PCT.JobID, PCT.FireInRed, PCT.Fire2InRed)]
        PictSubOvercapOption = 4207,

        [OrderedEnum]
        [ParentCombo(PictSubFeature)]
        [CustomComboInfo("Hallowed Movement", "Replace your combos with Holy in White if you are moving and don't have an instant cast.", PCT.JobID, PCT.FireInRed, PCT.Fire2InRed)]
        PictSubMovementOption = 4208,

        [OrderedEnum]
        [CustomComboInfo("Holy Comets!", "Replace Holy in White with Comet in Black when available.", PCT.JobID, PCT.HolyInWhite)]
        PictCometFeature = 4202,

        [OrderedEnum]
        [CustomComboInfo("A Motif for a Muse", "Replace your motifs with muses when you already have those motifs active.", PCT.JobID, PCT.CreatureMotif, PCT.WeaponMotif, PCT.LandscapeMotif)]
        PictMotifFeature = 4204,

        [OrderedEnum]
        [CustomComboInfo("Steel Your Hammers", "Replace Steel Muse with Hammer Stamp when available.", PCT.JobID, PCT.SteelMuse)]
        PictHammerFeature = 4205,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Subtract Your Comets Before It's Too Late!", "Replace Subtractive Palette with Comet in Black if available to prevent overwriting.", PCT.JobID, PCT.SubtractivePalette)]
        PictSubCometFeature = 4210,

        [OrderedEnum]
        [CustomComboInfo("Prisms in your Starscape", "Replace Scenic Muse with Star Prism when available.", PCT.JobID, PCT.ScenicMuse)]
        PictStarFeature = 4206,

        #endregion
        // ====================================================================================
        #region REAPER

        // latest enum: 3926

        [OrderedEnum]
        [CustomComboInfo("Slice Combo", "Replace Slice with its combo chain.", RPR.JobID, RPR.Slice, RPR.InfernalSlice)]
        ReaperSliceCombo = 3901,

        [OrderedEnum]
        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Infernal Slice Combo", "Replace Infernal Slice with its combo chain and removes Slice's combo.", RPR.JobID, RPR.InfernalSlice)]
        ReaperInfernalSliceCombo = 3910,

        [OrderedEnum]
        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Slice to Harpe", "Replace Slice combo with Harpe if you are out of range.", RPR.JobID, RPR.Slice)]
        ReaperHarpeSliceFeature = 3921,

        [OrderedEnum]
        [CustomComboInfo("Scythe Combo", "Replace Spinning Scythe with its combo chain.", RPR.JobID, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperScytheCombo = 3902,

        [OrderedEnum]
        [ParentCombo(ReaperScytheCombo)]
        [CustomComboInfo("Nightmare Scythe Combo", "Replace Nightmare Scythe with its combo chain and removes Spinning Scythe's combo.", RPR.JobID, RPR.NightmareScythe)]
        ReaperNightmareScytheCombo = 3911,

        [OrderedEnum]
        [CustomComboInfo("Enshroud Communio Feature", "Replace Enshroud with Communio when Enshrouded.", RPR.JobID, RPR.Enshroud)]
        ReaperEnshroudCommunioFeature = 3903,

        [OrderedEnum]
        [CustomComboInfo("Stalking and Swathing Feature", "While you have Soul Reaver, Blood Stalk becomes whichever spender is enhanced, and Grim Swathe becomes Guillotine.", RPR.JobID, RPR.BloodStalk, RPR.GrimSwathe)]
        ReaperStalkingSwathingFeature = 3917,

        [OrderedEnum]
        [CustomComboInfo("Gibbets and Gallows Feature", "Slice and Shadow of Death are replaced with Gibbet and Gallows while Soul Reaver or Shroud is active.", RPR.JobID, RPR.Slice, RPR.ShadowOfDeath, RPR.SoulSlice)]
        ReaperGibbetGallowsFeature = 3904,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("Gibbets and Gallows Feature Swap", "Swaps Gibbet/Gallows for the Gibbet and Gallows Feature.", RPR.JobID, RPR.Slice, RPR.ShadowOfDeath, RPR.SoulSlice)]
        ReaperGibbetGallowsSwap = 3918,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("Gibbets and Gallows Combo", "Gibbet becomes Gallows when Gallows is enhanced and vice-versa, but only in combo. It is removed from Shadow of Death/Soul Slice as a result after one is enhanced.", RPR.JobID, RPR.Gibbet, RPR.Gallows)]
        ReaperGibbetGallowsComboOption = 3925,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("Gibbets and Gallows Soul Slice Option", "Have Soul Slice be replaced in the Gibbets and Gallows Feature instead of Shadow of Death.", RPR.JobID, RPR.Slice, RPR.ShadowOfDeath, RPR.SoulSlice)]
        ReaperGibbetGallowsSoulSliceOption = 3919,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsSoulSliceOption)]
        [CustomComboInfo("Gibbet and Gallows Shroud Decombo", "Uncombos Void/Cross Reaping and spreads them across Soul Slice/Slice Combo.", RPR.JobID, RPR.Slice)]
        ReaperGibbetGallowsShroudOption = 3920,

        [OrderedEnum]
        [CustomComboInfo("Enhanced Gallows and Gibbets Feature", "Gibbet becomes Gallows when Gallows is enhanced and vice-versa.", RPR.JobID, RPR.Gibbet, RPR.Gallows)]
        ReaperGibbetGallowsOption = 3905,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsOption)]
        [CustomComboInfo("Shroud Only Option", "Only swap Gibbet/Gallows when Enshrouded.", RPR.JobID, RPR.Gibbet, RPR.Gallows)]
        ReaperGibbetGallowsShroudOnlyOption = 3924,

        [OrderedEnum]
        [CustomComboInfo("Guillotine Feature", "Spinning Scythe gets replaced with Guillotine while Soul Reaver or Shroud is active.", RPR.JobID, RPR.SpinningScythe)]
        ReaperGuillotineFeature = 3909,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Combo Communio Feature", "When one stack is left of Shroud, Communio replaces Gibbet/Gallows/Guillotine.", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.Gibbet, RPR.Gallows, RPR.Guillotine, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperComboCommunioFeature = 3906,

        [OrderedEnum]
        [CustomComboInfo("Lemure Feature", "When you have two or more stacks of Void Shroud, Lemure Slice/Scythe replaces Gibbet/Gallows and Guillotine respectively.", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.Gibbet, RPR.Gallows, RPR.Guillotine, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperLemureFeature = 3912,

        [OrderedEnum]
        [CustomComboInfo("Sacrificium Feature", "While under Void Shroud and Sacrificium is available, replace Gibbet/Gallows/Guillotine with Sacrificium during global cooldown.", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.Gibbet, RPR.Gallows, RPR.Guillotine, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperSacrificiumFeature = 3926,

        [OrderedEnum]
        [CustomComboInfo("Arcane Circle Harvest Feature", "Replace Arcane Circle with Plentiful Harvest when you have stacks of Immortal Sacrifice.", RPR.JobID, RPR.ArcaneCircle)]
        ReaperHarvestFeature = 3907,

        [OrderedEnum]
        [CustomComboInfo("Regress Feature", "Both Hell's Ingress and Hell's Egress turn into Regress when Threshold is active, instead of just the opposite of the one you used.\nYou can set an optional delay for this below:", RPR.JobID, RPR.HellsIngress, RPR.HellsEgress)]
        ReaperRegressFeature = 3908,

        [OrderedEnum]
        [CustomComboInfo("Blood Stalk to Gluttony Feature", "When Gluttony is off-cooldown, Blood Stalk will turn into Gluttony.", RPR.JobID, RPR.BloodStalk)]
        ReaperBloodStalkFeature = 3913,

        [OrderedEnum]
        [CustomComboInfo("Grim Swathe to Gluttony Feature", "When Gluttony is off-cooldown, Grim Swathe will turn into Gluttony.", RPR.JobID, RPR.GrimSwathe)]
        ReaperGrimSwatheFeature = 3914,

        [OrderedEnum]
        [CustomComboInfo("Blood Stalk to Grim Swathe Feature", "Blood Stalk turns into Grim Swathe if you are in the midst of your AoE combo.", RPR.JobID, RPR.BloodStalk)]
        ReaperBloodStalkToGrimSwatheFeature = 3922,

        [OrderedEnum]
        [CustomComboInfo("Soul Slice to Soul Scythe Feature", "Soul Slice turns into Soul Scythe if you are in the midst of your AoE combo.", RPR.JobID, RPR.SoulSlice)]
        ReaperSoulSliceToSoulScytheFeature = 3923,

        [OrderedEnum]
        [CustomComboInfo("Soulsow Reminder Feature", "Slice Combo, Soul Slice and Shadow of Death become Soulsow out of combat if you don't have it active.", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.ShadowOfDeath, RPR.WaxingSlice, RPR.SoulSlice)]
        ReaperSoulsowReminderFeature = 3915,

        [OrderedEnum]
        [CustomComboInfo("Soulsow Feature", "Spinning Scythe becomes Harvest Moon when Soulsow is active and you have a target. Shadow of Death becomes Soulsow if you have no target and Soulsow isn't active.", RPR.JobID, RPR.SpinningScythe, RPR.NightmareScythe, RPR.ShadowOfDeath)]
        ReaperSoulsowFeature = 3916,

        #endregion
        // ====================================================================================
        #region RED MAGE

        // latest enum: 3526

        [OrderedEnum]
        [CustomComboInfo("Redoublement Combo", "Replaces Redoublement with its combo chain, following enchantment rules.", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeCombo = 3502,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("Redoublement Combo Lockout Feature", "Prevents you from using Redoublement combo if you have less than 50/50 gauge and have Verflare unlocked by replacing it with Verflare (which is unusable).", RDM.JobID, RDM.Redoublement)]
        RedMageComboReminderFeature = 3515,

        [OrderedEnum]
        [ParentCombo(RedMageComboReminderFeature)]
        [CustomComboInfo("Redoublement Combo Lockout Option", "Replaces Redoublement with Flare instead of Verflare, to prevent queueing issues.", RDM.JobID, RDM.Redoublement)]
        RedMageComboReminderOption = 3517,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("Redoublement Combo to Moulinet", "Replaces Redoublement Combo with Moulinet if you have been using Veraero/Verthunder 2.", RDM.JobID, RDM.Redoublement)]
        RedMageComboToMoulinetFeature = 3521,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("Redoublement Combo Plus", "Replaces Redoublement/Moulinet with the combo spells after you have gained 3 mana stacks.\nVerflare will always be picked, meaning you must still manually press Verholy if appropriate.", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeComboPlus = 3508,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeComboPlus)]
        [CustomComboInfo("Redoublement Combo Plus Verholy Swap", "Swaps Verflare with Verholy in your melee combo (unless you aren't at a level you can use it).", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeComboPlusVerholy = 3509,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("Redoublement Combo to Reprise", "Replaces Redoublement combo with Enchanted Reprise if you are out of melee range.", RDM.JobID, RDM.Redoublement)]
        RedMageMeleeComboReprise = 3518,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeComboReprise)]
        [CustomComboInfo("Redoublement Combo to Reprise Under-50 Option", "Enchanted Reprise will also replace Redoublement combo if you are under 50 black or white Mana.", RDM.JobID, RDM.Redoublement)]
        RedMageMeleeComboRepriseOption = 3519,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("Redoublement Combo Plus Plus", "Replaces Redoublement/Moulinet with the combo spells after you have gained 3 mana stacks.\nVerflare or Verholy will be picked, whichever is more appropriate.", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeComboPlusPlus = 3503,

        [OrderedEnum]
        [CustomComboInfo("Verproc into Jolt", "Replaces Verstone/Verfire with Jolt/Scorch when no proc is available. In the strange gap between level 84-93 where Jolt 3 is always better, Verstone/verfire will always be replaced with Jolt 3.", RDM.JobID, RDM.Verstone, RDM.Verfire, RDM.Verthunder, RDM.Verthunder3)]
        RedMageVerprocCombo = 3504,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [ConflictingCombos(RedMageVerprocComboVerstoneOption)]
        [CustomComboInfo("Verproc into Jolt Verfire Opt Out", "Verfire does NOT change into Jolt (or any Jolt-related actions).", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboVerfireOption = 3524,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [ConflictingCombos(RedMageVerprocComboVerfireOption)]
        [CustomComboInfo("Verproc into Jolt Verstone Opt Out", "Verstone does NOT change into Jolt (or any Jolt-related actions).", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboVerstoneOption = 3525,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [CustomComboInfo("Verproc into Jolt Plus", "Additionally replaces Verstone/Verfire with Veraero/Verthunder if Dualcast, Swiftcast, or Lost Chainspell are up.", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboPlus = 3505,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("Verproc into Jolt Plus Opener Feature (Stone)", "Turns Verstone into Veraero when out of combat.", RDM.JobID, RDM.Verstone)]
        RedMageVerprocOpenerFeatureStone = 3506,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("Verproc into Jolt Plus Opener Feature (Fire)", "Turns Verfire into Verthunder when out of combat.", RDM.JobID, RDM.Verfire)]
        RedMageVerprocOpenerFeatureFire = 3507,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("Verproc into Jolt Plus Verthunder Option", "Verthunder is used as the base for the black magic side of Verproc into Jolt, not Verfire.\nThis is so you can use Verfire by itself even with acceleration up to use a slightly more optimal opener.", RDM.JobID, RDM.Verthunder)]
        RedMageVerprocComboVerthunderOption = 3526,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("Verproc into Jolt Plus Option", "Verstone/Verfire never get replaced by their respective long cast (Veraero/Verthunder) if usable (unless both are usable).\nMildly incompatible with current RDM opener.", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboPlusOption = 3523,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [CustomComboInfo("Verproc into Reprise Movement Feature", "Verstone/Verfire additionally turn into Enchanted Reprise (if available) if you are moving and don't have any instant casts available.", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboReprise = 3520,

        [OrderedEnum]
        [ConflictingCombos(RedMageVerprocComboPlus)]
        [CustomComboInfo("Veraero/Verthunder into Scorch", "Replaces Veraero/Verthunder 1/3 with Scorch when it's available.\nThis feature is already in Verproc into Jolt Plus, this is for people who don't want to use that.", RDM.JobID, RDM.Veraero, RDM.Verthunder, RDM.Veraero3, RDM.Verthunder3)]
        RedMageVeraeroVerThunderScorchFeature = 3510,

        [OrderedEnum]
        [CustomComboInfo("Red Mage AoE Combo", "Replaces Veraero/Verthunder 2 with Impact when Dualcast or Swiftcast are active.", RDM.JobID, RDM.Veraero2, RDM.Verthunder2)]
        RedMageAoECombo = 3501,

        [OrderedEnum]
        [CustomComboInfo("Moulinet Lockout Feature", "Prevents you from using Moulinet below 50/50 gauge by replacing it with Physick if you have Verflare unlocked.", RDM.JobID, RDM.Moulinet)]
        RedMageMoulinetReminderFeature = 3514,

        [OrderedEnum]
        [CustomComboInfo("Embolden to Manafication", "Replaces Embolden with Manafication if the former is on cooldown and the latter is not.", RDM.JobID, RDM.Embolden)]
        RedMageEmboldenFeature = 3511,

        [OrderedEnum]
        [CustomComboInfo("Embolden Lockout Feature", "Locks out Embolden if it is available and more than 3s remain on its buff, to prevent overwriting raid buffs.", RDM.JobID, RDM.Embolden)]
        RedMageEmboldenLockoutFeature = 3522,

        [OrderedEnum]
        [CustomComboInfo("Acceleration to Swiftcast", "Replaces Acceleration with Swiftcast if the former is on cooldown and the latter is not.", RDM.JobID, RDM.Acceleration)]
        RedMageAccelerationFeature = 3512,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Fleche to Contre-Sixte", "Replaces Fleche with Contre-Sixte if the former is on cooldown and the latter is not.", RDM.JobID, RDM.Fleche)]
        RedMageContreSixteFeature = 3513,

        [OrderedEnum]
        [CustomComboInfo("Red Mage Lucid Dreaming Reminder", "All your non-role action cooldowns (that don't have charges) become Lucid Dreaming if they aren't up and Lucid Dreaming is, and you have less-than-or-equal-to a set amount of MP.", RDM.JobID, RDM.Embolden, RDM.Manafication, RDM.Fleche, RDM.ContreSixte)]
        RedMageLucidReminderFeature = 3516,

        #endregion
        // ====================================================================================
        #region SAGE

        [OrderedEnum]
        [CustomComboInfo("Soteria into Kardia", "Soteria turns into Kardia when not active or Soteria is on-cooldown.", SGE.JobID, SGE.Soteria)]
        SageKardiaFeature = 4001,

        [OrderedEnum]
        [CustomComboInfo("Phlegma into Dyskrasia", "Phlegma turns into Dyskrasia when you are out of charges or are currently not targeting anything.", SGE.JobID, SGE.Phlegma, SGE.Phlegmara, SGE.Phlegmaga)]
        SagePhlegmaBalls = 4002,

        [OrderedEnum]
        [CustomComboInfo("Phlegma into Toxikon", "Phlegma turns into Toxikon if you have addersting and are either out of range or out of charges.\nThis is prioritized over Dyskrasia if the 'Phlegma into Dyskrasia' feature is enabled.", SGE.JobID, SGE.Phlegma, SGE.Phlegmara, SGE.Phlegmaga)]
        SagePhlegmaToxicBalls = 4003,

        [OrderedEnum]
        [CustomComboInfo("Phlegma into Psyche", "Phlegma turns into Psyche while the GCD is rolling and it is off cooldown.", SGE.JobID, SGE.Phlegma, SGE.Phlegmara, SGE.Phlegmaga)]
        SagePhlegmaPsychicBalls = 4010,

        [OrderedEnum]
        [CustomComboInfo("Taurochole into Druochole", "Replaces Taurochole with Druochole if the former is on cooldown.\nYou should probably still keep the latter on your bar for certain scenarios.", SGE.JobID, SGE.Taurochole)]
        SageTauroDruoFeature = 4004,

        [OrderedEnum]
        [CustomComboInfo("Eukrasia into Eukrasian Dosis", "Eukrasia turns into Eukrasian Dosis while you have it active.\nThis doesn't save a button or really much else, I just like how it feels.", SGE.JobID, SGE.Eukrasia)]
        SageEukrasiaDosisFeature = 4006,

        [OrderedEnum]
        [CustomComboInfo("Toxikon Movement Feature", "Dosis turns into Toxikon while you are moving and don't have Eukrasia.", SGE.JobID, SGE.Dosis, SGE.Dosis2, SGE.Dosis3)]
        SageToxikonMovementFeature = 4008,

        [OrderedEnum]
        [CustomComboInfo("Phlegma Movement Feature", "Dosis turns into Phlegma while you are moving, don't have Eukrasia, and are in range to use it.", SGE.JobID, SGE.Dosis, SGE.Dosis2, SGE.Dosis3)]
        SagePhlegmaMovementFeature = 4009,

        [OrderedEnum]
        [CustomComboInfo("Extreme Button Saver", "This changes your targeted healing actions into AoE heals if you have no target.\nRecommended only if you have disabilities, or REALLY like having a smaller hotbar, at the expense of having to untarget a lot.", SGE.JobID, SGE.Haima, SGE.Druochole, SGE.Taurochole, SGE.Krasis, SGE.Diagnosis, SGE.Pneuma)]
        SageExtremeButtonSaverFeature = 4007,

        [OrderedEnum]
        [CustomComboInfo("Sage Lucid Dreaming Reminder", "All your non-role action cooldowns (that don't have charges) become Lucid Dreaming if they aren't up and Lucid Dreaming is, and you have less-than-or-equal-to a set amount of MP.", SGE.JobID, SGE.Kardia, SGE.Soteria, SGE.Zoe, SGE.Pepsis, SGE.Physis, SGE.Physis2, SGE.Ixochole, SGE.Holos, SGE.Rhizomata, SGE.Krasis, SGE.Kerachole, SGE.Taurochole, SGE.Haima, SGE.Panhaima, SGE.Pneuma)]
        SageLucidReminderFeature = 4005,

        #endregion
        // ====================================================================================
        #region SAMURAI

        [OrderedEnum]
        [CustomComboInfo("Gekko Combo", "Replace Gekko with its combo chain.", SAM.JobID, SAM.Gekko)]
        SamuraiGekkoCombo = 3402,

        [OrderedEnum]
        [ParentCombo(SamuraiGekkoCombo)]
        [CustomComboInfo("Gekko Combo Option", "Start the Gekko combo chain with Jinpu instead of Gyofu/Hakaze.", SAM.JobID, SAM.Gekko)]
        SamuraiGekkoOption = 3415,

        [OrderedEnum]
        [ParentCombo(SamuraiGekkoCombo)]
        [CustomComboInfo("Gekko to Enpi", "Replace Gekko Combo with Enpi if you are out of melee range.", SAM.JobID, SAM.Gekko)]
        SamuraiGekkoEnpiFeature = 3425,

        [OrderedEnum]
        [CustomComboInfo("Kasha Combo", "Replace Kasha with its combo chain.", SAM.JobID, SAM.Kasha)]
        SamuraiKashaCombo = 3403,

        [OrderedEnum]
        [ParentCombo(SamuraiKashaCombo)]
        [CustomComboInfo("Kasha Combo Option", "Start the Kasha combo chain with Shifu instead of Gyofu/Hakaze.", SAM.JobID, SAM.Kasha)]
        SamuraiKashaOption = 3416,

        [OrderedEnum]
        [CustomComboInfo("Yukikaze Combo", "Replace Yukikaze with its combo chain.", SAM.JobID, SAM.Yukikaze)]
        SamuraiYukikazeCombo = 3401,

        [OrderedEnum]
        [CustomComboInfo("Mangetsu Combo", "Replace Mangetsu with its combo chain.", SAM.JobID, SAM.Mangetsu, SAM.Fuga, SAM.Fuko)]
        SamuraiMangetsuCombo = 3404,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(SamuraiMangetsuCombo)]
        [CustomComboInfo("Evil Mangetsu Combo", "Replace Fuga/Fuko with its combo chain, instead.", SAM.JobID, SAM.Mangetsu, SAM.Fuga, SAM.Fuko)]
        SamuraiEvilMangetsuCombo = 3417,

        [OrderedEnum]
        [CustomComboInfo("Oka Combo", "Replace Oka with its combo chain.", SAM.JobID, SAM.Oka)]
        SamuraiOkaCombo = 3405,

        [OrderedEnum]
        [ConflictingCombos(SamuraiIaijutsuTsubameGaeshiFeature)]
        [CustomComboInfo("Tsubame-gaeshi to Iaijutsu", "Replace Tsubame-gaeshi with Iaijutsu when Sen is not empty.", SAM.JobID, SAM.TsubameGaeshi)]
        SamuraiTsubameGaeshiIaijutsuFeature = 3406,

        [OrderedEnum]
        [ConflictingCombos(SamuraiIaijutsuShohaFeature)]
        [CustomComboInfo("Tsubame-gaeshi to Shoha", "Replace Tsubame-gaeshi with Shoha when meditation is 3 and either you have used Tsubame or it wouldn't clip the GCD.", SAM.JobID, SAM.TsubameGaeshi)]
        SamuraiTsubameGaeshiShohaFeature = 3407,

        [OrderedEnum]
        [ConflictingCombos(SamuraiTsubameGaeshiIaijutsuFeature)]
        [CustomComboInfo("Iaijutsu to Tsubame-gaeshi", "Replace Iaijutsu with Tsubame-gaeshi when Sen is empty.", SAM.JobID, SAM.Iaijutsu)]
        SamuraiIaijutsuTsubameGaeshiFeature = 3408,

        [OrderedEnum]
        [ConflictingCombos(SamuraiTsubameGaeshiShohaFeature)]
        [CustomComboInfo("Iaijutsu to Shoha", "Replace Iaijutsu with Shoha when meditation is 3 and either you have used Tsubame or for a short period of time after Iaijutsu.", SAM.JobID, SAM.Iaijutsu)]
        SamuraiIaijutsuShohaFeature = 3409,

        [OrderedEnum]
        [CustomComboInfo("Ogi-Namikiri to Shoha", "Replace Ogi-Namikiri with Shoha when meditation is 3 and either you have used Tsubame or it wouldn't clip the GCD.", SAM.JobID, SAM.Ikishoten, SAM.OgiNamikiri)]
        SamuraiNamikiriShohaFeature = 3423,

        [OrderedEnum]
        [CustomComboInfo("Iaijutsu/Tsubame to Shoha Persistence Option", "Makes it so Shoha doesn't disappear after a short amount of time after Iaijutsu.", SAM.JobID, SAM.Iaijutsu, SAM.TsubameGaeshi)]
        SamuraiShohaGCDOption = 3421,

        [OrderedEnum]
        [CustomComboInfo("Iaijutsu/Tsubame to Shoha Inbetween Option", "Makes it so Shoha doesn't appear inbetween Iaijutsu and Tsubame.", SAM.JobID, SAM.Iaijutsu, SAM.TsubameGaeshi)]
        SamuraiShohaBetweenOption = 3422,

        [OrderedEnum]
        [CustomComboInfo("Ikishoten Namikiri Feature", "Replace Ikishoten with Ogi Namikiri and then Kaeshi Namikiri when available.", SAM.JobID, SAM.Ikishoten)]
        SamuraiIkishotenNamikiriFeature = 3411,

        [OrderedEnum]
        [CustomComboInfo("Shinten to Senei", "Replace Hissatsu: Shinten with Senei when its cooldown is up.", SAM.JobID, SAM.Shinten)]
        SamuraiSeneiFeature = 3413,

        [OrderedEnum]
        [CustomComboInfo("Senei to Guren Level Sync", "Replace Hissatsu: Senei with Guren if you are at a level where you can't use Senei.", SAM.JobID, SAM.Shinten, SAM.Senei)]
        SamuraiSeneiGurenFeature = 3419,

        [OrderedEnum]
        [CustomComboInfo("Shinten to Shoha", "Replace Hissatsu: Shinten with Shoha when Meditation is full.", SAM.JobID, SAM.Shinten)]
        SamuraiShohaFeature = 3412,

        [OrderedEnum]
        [CustomComboInfo("Shinten to Kyuten", "Replace Hissatsu: Shinten with Kyuten if your last combo action was Fuga/Fuko/Mangetsu/Oka.", SAM.JobID, SAM.Shinten)]
        SamuraiShintenToKyutenFeature = 3427,

        [OrderedEnum]
        [CustomComboInfo("Kyuten to Guren", "Replace Hissatsu: Kyuten with Guren when its cooldown is up.", SAM.JobID, SAM.Kyuten)]
        SamuraiGurenFeature = 3414,

        [OrderedEnum]
        [CustomComboInfo("Yukikaze to Meditate", "Replace Yukikaze with Meditate while you have no target.", SAM.JobID, SAM.Yukikaze)]
        SamuraiYukikazeMeditateFeature = 3426,

        #endregion
        // ====================================================================================
        #region SCHOLAR

        // latest enum: 2811

        [OrderedEnum]
        [CustomComboInfo("Adloquium to Physick Level Sync", "Change Adloquium to Physick when level-synced.", SCH.JobID, SCH.Adloquium)]
        ScholarAdloPhysickSyncFeature = 2810,

        [OrderedEnum]
        [CustomComboInfo("Seraph Fey Blessing/Consolation", "Change Fey Blessing into Consolation when Seraph is out.\nNot needed anymore, but some people still have the old XIVCombo muscle memory.", SCH.JobID, SCH.FeyBless)]
        ScholarSeraphConsolationFeature = 2801,

        [OrderedEnum]
        [CustomComboInfo("ED Aetherflow", "Change Energy Drain into Aetherflow when you have no more Aetherflow stacks.", SCH.JobID, SCH.EnergyDrain, SCH.Excogitation, SCH.Lustrate, SCH.SacredSoil, SCH.Indomitability)]
        ScholarEnergyDrainFeature = 2802,

        [OrderedEnum]
        [ParentCombo(ScholarEnergyDrainFeature)]
        [CustomComboInfo("Everything Aetherflow", "Change every Aetherflow action into Aetherflow when you have no more Aetherflow stacks.\nIndomitability and Excogitation also become available with Recitation.", SCH.JobID, SCH.EnergyDrain, SCH.Excogitation, SCH.Lustrate, SCH.SacredSoil, SCH.Indomitability)]
        ScholarEverythingFeature = 2803,

        [OrderedEnum]
        [CustomComboInfo("Excogitation to Recitation", "Change Excogitation into Recitation when the latter is off-cooldown.", SCH.JobID, SCH.Excogitation)]
        ScholarExcogRecitationFeature = 2808,

        [OrderedEnum]
        [CustomComboInfo("Fairy Feature", "Change every action that requires a fairy into Summon Eos if you do not have a fairy summoned.", SCH.JobID, SCH.WhisperingDawn, SCH.FeyIllumination, SCH.FeyBless, SCH.Aetherpact, SCH.Dissipation, SCH.SummonSeraph, SCH.Consolation)]
        ScholarFairyFeature = 2804,

        [OrderedEnum]
        [CustomComboInfo("Ruin 2 to Chain Stratagem", "Ruin 2 becomes Chain Stratagem for a short while after you have used any action (and if it's off cooldown).", SCH.JobID, SCH.Ruin2)]
        ScholarRuinChainFeature = 2807,

        [OrderedEnum]
        [CustomComboInfo("Chain Stratagem Lockout Feature", "Locks out Chain Stratagem while it is available and more than 3s remain on its debuff, to prevent overwriting raid buffs.", SCH.JobID, SCH.ChainStratagem)]
        ScholarChainLockoutFeature = 2811,

        [OrderedEnum]
        [CustomComboInfo("Ruin 2 Movement Feature", "Ruin/Broil becomes Ruin 2 while you are moving.", SCH.JobID, SCH.Ruin, SCH.Broil, SCH.Broil2, SCH.Broil3, SCH.Broil4)]
        ScholarRuin2MovementFeature = 2809,

        [OrderedEnum]
        [CustomComboInfo("Scholar Lucid Dreaming Reminder", "All your non-role action cooldowns (that don't have charges) become Lucid Dreaming if they aren't up and Lucid Dreaming is, and you have less-than-or-equal-to a set amount of MP.", SCH.JobID, SCH.Aetherflow, SCH.EmergencyTactics, SCH.WhisperingDawn, SCH.FeyIllumination, SCH.FeyBless, SCH.Dissipation, SCH.ChainStratagem, SCH.Indomitability, SCH.Excogitation, SCH.SacredSoil, SCH.Recitation, SCH.DeploymentTactics, SCH.SummonSeraph)]
        ScholarLucidReminderFeature = 2806,

        #endregion
        // ====================================================================================
        #region SUMMONER

        // latest enum: 2721

        [OrderedEnum]
        [CustomComboInfo("Enkindle/Summon Switch", "When (Solar) Bahamut/Phoenix are summoned, Enkindle (Solar) Bahamut/Phoenix will replace Summon (Solar) Bahamut/Phoenix.", SMN.JobID, SMN.SummonBahamut, SMN.SummonPhoenix, SMN.DreadwyrmTrance, SMN.Aethercharge)]
        SummonerDemiCombo = 2701,

        [OrderedEnum]
        [CustomComboInfo("Demi Flow Feature", "When you can use Astral Flow, it will replace Summon (Solar) Bahamut/Summon Phoenix/Dreadwyrm Trance.", SMN.JobID, SMN.SummonBahamut, SMN.SummonPhoenix, SMN.DreadwyrmTrance, SMN.Aethercharge)]
        SummonerDemiFlowFeature = 2716,

        [OrderedEnum]
        [ConflictingCombos(SummonerOutburstOfBrillianceFeature, SummonerRuiningShineFeature)]
        [CustomComboInfo("Shiny Enkindle Feature", "When (Solar) Bahamut/Phoenix are summoned, changes Gemshine and Precious Brilliance with Enkindle.", SMN.JobID, SMN.Gemshine, SMN.PreciousBrilliance)]
        SummonerShinyDemiCombo = 2708,

        [OrderedEnum]
        [ConflictingCombos(SummonerOutburstOfBrillianceFeature, SummonerRuiningShineFeature)]
        [CustomComboInfo("Shiny Flow Feature", "When Bahamut/Phoenix/Solar Bahamut are summoned, changes Gemshine and Precious Brilliance with Astral Flow.", SMN.JobID, SMN.Gemshine, SMN.PreciousBrilliance)]
        SummonerShinyFlowCombo = 2711,

        [OrderedEnum]
        [CustomComboInfo("ED Necrotize", "Change Necrotize/Fester into Energy Drain when out of Aetherflow stacks", SMN.JobID, SMN.Fester, SMN.Necrotize)]
        SummonerEDFesterCombo = 2702,

        [OrderedEnum]
        [CustomComboInfo("ES Painflare", "Change Painflare into Energy Syphon when out of Aetherflow stacks", SMN.JobID, SMN.Painflare)]
        SummonerESPainflareCombo = 2703,

        [OrderedEnum]
        [CustomComboInfo("ES Level Sync", "Change Energy Siphon into Energy Drain when level synced below its acquisition.", SMN.JobID, SMN.Painflare, SMN.EnergySyphon)]
        SummonerEStoED = 2721,

        [OrderedEnum]
        [CustomComboInfo("Mountain Buster Feature", "Gemshine and Precious Brilliance become Mountain Buster while you have Titan's Favor.", SMN.JobID, SMN.Ruin1, SMN.Ruin2, SMN.Ruin3, SMN.Gemshine, SMN.Outburst, SMN.TriDisaster, SMN.PreciousBrilliance)]
        SummonerMountainBusterFeature = 2710,

        [OrderedEnum]
        [CustomComboInfo("Summoning Flow Feature", "When you have Favor, or (Solar) Bahamut/Phoenix are summoned, your summoning actions become Astral Flow.", SMN.JobID, SMN.SummonRuby, SMN.SummonIfrit, SMN.SummonIfrit2, SMN.SummonTopaz, SMN.SummonTitan, SMN.SummonTitan2, SMN.SummonEmerald, SMN.SummonGaruda, SMN.SummonGaruda2)]
        SummonerSummoningFlowFeature = 2712,

        [OrderedEnum]
        [CustomComboInfo("Flowing Ruin Feature", "Change Ruin into Astral Flow when you have Favor, or have Deathflare/Rekindle/Sunflare available and unused.", SMN.JobID, SMN.Ruin1, SMN.Ruin2, SMN.Ruin3, SMN.Gemshine)]
        SummonerFlowingRuinFeature = 2715,

        [OrderedEnum]
        [CustomComboInfo("Shiny Ruin Feature", "Change Ruin into Gemburst when attuned.", SMN.JobID, SMN.Ruin1, SMN.Ruin2, SMN.Ruin3)]
        SummonerShinyRuinFeature = 2709,

        [OrderedEnum]
        [CustomComboInfo("Further Ruin Feature", "Change Ruin into Ruin 4 when available and appropriate.", SMN.JobID, SMN.Ruin1, SMN.Ruin2, SMN.Ruin3, SMN.Gemshine)]
        SummonerFurtherRuinFeature = 2705,

        [OrderedEnum]
        [ConflictingCombos(SummonerShinyDemiCombo, SummonerShinyFlowCombo)]
        [CustomComboInfo("Ruining Shine Feature", "Change Gemshine into Ruin while not attuned.\nThis lets you keep Ruin on your bar, so you can always use it for movement.\nAll the above Ruin features apply to Gemshine while this feature is enabled, and will be disabled on Ruin.", SMN.JobID, SMN.Gemshine)]
        SummonerRuiningShineFeature = 2717,

        [OrderedEnum]
        [CustomComboInfo("Flowing Outburst Feature", "Change Outburst/Tri-disaster into Astral Flow when you have Favor, or have Deathflare/Rekindle/Sunflare available and unused.", SMN.JobID, SMN.Outburst, SMN.TriDisaster, SMN.PreciousBrilliance)]
        SummonerFlowingOutburstFeature = 2714,

        [OrderedEnum]
        [CustomComboInfo("Shiny Outburst Feature", "Change Outburst/Tri-disaster into Precious Brilliance when attuned.", SMN.JobID, SMN.Outburst, SMN.TriDisaster)]
        SummonerShinyOutburstFeature = 2706,

        [OrderedEnum]
        [CustomComboInfo("Further Outburst Feature", "Change Outburst/Tri-disaster into Ruin 4 when available and appropriate.", SMN.JobID, SMN.Outburst, SMN.TriDisaster, SMN.PreciousBrilliance)]
        SummonerFurtherOutburstFeature = 2707,

        [OrderedEnum]
        [ConflictingCombos(SummonerShinyDemiCombo, SummonerShinyFlowCombo)]
        [CustomComboInfo("Outburst of Brilliance Feature", "Change Precious Brilliance into Outburst while not attuned.\nThis lets you keep Outburst on your bar, so you can always use it for movement.\nAll the above Outburst features apply to Gemshine while this feature is enabled, and will be disabled on Outburst.", SMN.JobID, SMN.PreciousBrilliance)]
        SummonerOutburstOfBrillianceFeature = 2718,

        [OrderedEnum]
        [CustomComboInfo("Carby Feature", "Every action that cannot be used without summoning carbuncle becomes Summon Carbuncle while a pet is not summoned.", SMN.JobID, SMN.RadiantAegis, SMN.Aethercharge, SMN.DreadwyrmTrance, SMN.SummonBahamut, SMN.SummonEmerald,
            SMN.SummonGaruda, SMN.SummonGaruda2, SMN.SummonRuby, SMN.SummonIfrit, SMN.SummonIfrit2, SMN.SummonTopaz, SMN.SummonTitan, SMN.SummonTitan2, SMN.Gemshine, SMN.PreciousBrilliance, SMN.AstralFlow)]
        SummonerCarbyFeature = 2704,

        [OrderedEnum]
        [CustomComboInfo("Searing Light Lockout Feature", "Locks out Searing Light if it is available and more than 3s remain on its buff, to prevent overwriting raid buffs.", SMN.JobID, SMN.SearingLight)]
        SummonerSearingLockoutFeature = 2720,

        [OrderedEnum]
        [CustomComboInfo("Summoner Lucid Dreaming Reminder", "All your non-role action cooldowns (that don't have charges) become Lucid Dreaming if they aren't up and Lucid Dreaming is, and you have less-than-or-equal-to a set amount of MP.", SMN.JobID, SMN.EnergyDrain, SMN.EnergySyphon, SMN.RadiantAegis, SMN.SearingLight, SMN.SummonBahamut, SMN.DreadwyrmTrance, SMN.EnkindleBahamut, SMN.Aethercharge)]
        SummonerLucidReminderFeature = 2713,

        #endregion
        // ====================================================================================
        #region VIPER

        // last used enum: 4116

        [OrderedEnum]
        [CustomComboInfo("Fanged Tails", "Your last-used action becomes Serpent's Tail when it is active.\nIn Reawakening, this applies to *all* your combo actions (because it's pretty hard to track your combo step there).", VPR.JobID, VPR.SteelFangs, VPR.ReavingFangs, VPR.SteelMaw, VPR.ReavingMaw, VPR.HuntersCoil, VPR.SwiftskinsCoil, VPR.HuntersDen, VPR.SwiftskinsDen)]
        ViperTailFeature = 4101,

        [OrderedEnum]
        [CustomComboInfo("Reaving Steel", "Steel/Reaving Fangs/Maw will become whatever current combo starter is empowered.", VPR.JobID, VPR.SteelFangs, VPR.ReavingFangs, VPR.SteelMaw, VPR.ReavingMaw)]
        ViperReavingSteelFeature = 4115,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Striking Fangs", "The last action of your combo will become whatever usable combo ender is currently empowered.", VPR.JobID, VPR.SteelFangs, VPR.ReavingFangs, VPR.SteelMaw, VPR.ReavingMaw)]
        ViperStrikingFangsFeature = 4116,

        [OrderedEnum]
        [CustomComboInfo("Coiling Dens", "Replace your left/right combos with each Coil/Den action while they are available.", VPR.JobID, VPR.SteelFangs, VPR.ReavingFangs, VPR.SteelMaw, VPR.ReavingMaw)]
        ViperCoilFeature = 4102,

        [OrderedEnum]
        [ParentCombo(ViperCoilFeature)]
        [CustomComboInfo("Coiling Dens Coil Swap Option", "Swap the Coil actions for your left/right actions (so Swiftskin's Coil is left and Hunter's Coil is right).", VPR.JobID, VPR.SteelMaw, VPR.ReavingMaw)]
        ViperCoilFeatureSwapOption = 4110,

        [OrderedEnum]
        [ParentCombo(ViperCoilFeature)]
        [CustomComboInfo("Coiling Dens Den Swap Option", "Swap the Den actions for your left/right actions (so Swiftskin's Den is left and Hunter's Den is right).", VPR.JobID, VPR.SteelMaw, VPR.ReavingMaw)]
        ViperCoilFeatureDenSwapOption = 4114,

        [OrderedEnum]
        [ParentCombo(ViperCoilFeature)]
        [CustomComboInfo("Coiling Dens Reawakening Option", "Additionally replace your aoe combos with Third/Fourth Generation instead of First/Second.", VPR.JobID, VPR.SteelMaw, VPR.ReavingMaw)]
        ViperCoilAwakenedOption = 4103,

        [OrderedEnum]
        [CustomComboInfo("Bloody Fangs", "Replace your left/right combos and Coil/Den moves with the Twinfang/blood actions while they are available.", VPR.JobID, VPR.SteelFangs, VPR.ReavingFangs, VPR.SteelMaw, VPR.ReavingMaw, VPR.HuntersCoil, VPR.SwiftskinsCoil, VPR.HuntersDen, VPR.SwiftskinsDen)]
        ViperBloodFangFeature = 4104,

        [OrderedEnum]
        [CustomComboInfo("Twin Tails", "Replace Twinfang/blood with Serpent's Tail when it is active.", VPR.JobID, VPR.Twinfang, VPR.Twinblood)]
        ViperTwinTailsFeature = 4108,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Twisted Twins", "Replace Twinfang/blood with the other when buffed and active.", VPR.JobID, VPR.Twinfang, VPR.Twinblood)]
        ViperTwistedTwinsFeature = 4111,

        [OrderedEnum]
        [CustomComboInfo("Atmospheric Ouroboros", "Replace Fourth Generation with Ouroboros if it is available and you are on your last stack of Anguine Tribute.", VPR.JobID, VPR.ReavingFangs, VPR.ReavingMaw, VPR.SwiftskinsCoil, VPR.SwiftskinsDen)]
        ViperOuroborosFeature = 4105,

        [OrderedEnum]
        [CustomComboInfo("Writhing Steel Fangs", "Replace your Steel Fangs combo with Writhing Snap while out of melee range.", VPR.JobID, VPR.SteelFangs)]
        ViperSteelFangRangedFeature = 4106,

        [OrderedEnum]
        [CustomComboInfo("Slithering Reaving Fangs", "Replace your Reaving Fangs combo with Slither while out of melee range or targeting a player.", VPR.JobID, VPR.ReavingFangs)]
        ViperDreadFangDashFeature = 4107,

        [OrderedEnum]
        [CustomComboInfo("Snapping Fury", "Have Uncoiled Fury replace Writhing Snap if you have Rattling Coil stacks.", VPR.JobID, VPR.WrithingSnap)]
        ViperSnapUncoiledFuryFeature = 4109,

        [OrderedEnum]
        [CustomComboInfo("Twin Fury", "Have Twinfang/Twinblood replace Uncoiled Fury in order when available after Uncoiled Fury.", VPR.JobID, VPR.UncoiledFury)]
        ViperTwinFuryFeature = 4112,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("Reawakened Fangs", "Steel Fangs will become your entire Reawakening combo while it is available.", VPR.JobID, VPR.SteelFangs)]
        ViperReawakenedFangsFeature = 4113,

        #endregion
        // ====================================================================================
        #region WARRIOR

        // last used enum: 2118

        [OrderedEnum]
        [CustomComboInfo("Storm's Path Combo", "Replace Storm's Path with its combo chain.", WAR.JobID, WAR.StormsPath)]
        WarriorStormsPathCombo = 2101,

        [OrderedEnum]
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Storm's Path to Storm's Eye", "Replace Storm's Path in its combo with Storm's Eye if Surging Tempest is not up.\nSince you still want to reapply it before the buff runs out, this is not a button replacement, nor is it an auto-upkeep feature.", WAR.JobID, WAR.StormsPath)]
        WarriorStormsPathEyeFeature = 2116,

        [OrderedEnum]
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Storm's Path to Tomahawk", "Replace Storm's Path's combo with Tomahawk when out of melee range.", WAR.JobID, WAR.StormsPath)]
        WarriorStormsPathahawkFeature = 2110,

        [OrderedEnum]
        [CustomComboInfo("Storm's Eye Combo", "Replace Storm's Eye with its combo chain.", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeCombo = 2102,

        [OrderedEnum]
        [ParentCombo(WarriorStormsEyeCombo)]
        [ConflictingCombos(WarriorStormsEyeslaughtFeature)]
        [CustomComboInfo("Storm's Eye to Tomahawk", "Replace Storm's Eye's combo with Tomahawk when out of melee range.", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeahawkFeature = 2112,

        [OrderedEnum]
        [ParentCombo(WarriorStormsEyeCombo)]
        [ConflictingCombos(WarriorStormsEyeslaughtFeature)]
        [CustomComboInfo("Storm's Eye Tomahawk Replacement", "Replace Storm's Eye with Tomahawk while Storm's Eye is not available for use in combo.", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeHawkReplacementFeature = 2113,

        [OrderedEnum]
        [ParentCombo(WarriorStormsEyeCombo)]
        [ConflictingCombos(WarriorStormsEyeHawkReplacementFeature, WarriorStormsEyeahawkFeature)]
        [CustomComboInfo("Storm's Eye Onslaught Replacement", "Replace Storm's Eye with Onslaught while Storm's Eye is not available for use in combo, or you are out of melee range.", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeslaughtFeature = 2117,

        [OrderedEnum]
        [CustomComboInfo("Mythril Tempest Combo", "Replace Mythril Tempest with its combo chain.", WAR.JobID, WAR.MythrilTempest)]
        WarriorMythrilTempestCombo = 2103,

        [OrderedEnum]
        [CustomComboInfo("Overpower Combo", "Replace Overpower with its combo chain.", WAR.JobID, WAR.Overpower)]
        WarriorOverpowerCombo = 2104,

        [OrderedEnum]
        [CustomComboInfo("Warrior Gauge Overcap Feature", "Replace AoE combo with gauge spender if you are about to overcap.", WAR.JobID, WAR.MythrilTempest, WAR.StormsEye, WAR.StormsPath)]
        WarriorGaugeOvercapFeature = 2105,

        [OrderedEnum]
        [CustomComboInfo("Inner Release AoE to Decimate Feature", "Replace AoE combo with Decimate during Inner Release.", WAR.JobID, WAR.MythrilTempest)]
        WarriorInnerReleaseFeature = 2106,

        [OrderedEnum]
        [ParentCombo(WarriorInnerReleaseFeature)]
        [CustomComboInfo("Inner Release Feature Tomahawk Option", "Replace Storm's Eye with Tomahawk during Inner Release.", WAR.JobID, WAR.MythrilTempest, WAR.StormsPath)]
        WarriorInnerReleaseahawkOption = 2111,

        [OrderedEnum]
        [CustomComboInfo("Nascent Flash Feature", "Replace Nascent Flash with Raw intuition when level synced below 76", WAR.JobID, WAR.NascentFlash)]
        WarriorNascentFlashFeature = 2107,

        [OrderedEnum]
        [CustomComboInfo("Primal Rend Feature", "Replace Inner Release with Primal Rend when available.", WAR.JobID, WAR.Berserk, WAR.InnerRelease)]
        WarriorPrimalRendFeature = 2108,

        [OrderedEnum]
        [CustomComboInfo("Mythril Rend Feature", "Replace your AoE combos of choice with Primal Rend when available.", WAR.JobID, WAR.MythrilTempest)]
        WarriorMythrilRendFeature = 2109,

        [OrderedEnum]
        [CustomComboInfo("Fell Cleave to Decimate Feature", "Replaces Fell Cleave/Inner Beast with Decimate/Steel Cyclone if you are in the midst of your AoE combo.", WAR.JobID, WAR.FellCleave, WAR.InnerBeast)]
        WarriorFellCleaveToDecimateFeature = 2115,

        [OrderedEnum]
        [CustomComboInfo("Upheaval to Orogeny", "Replace your Upheaval with Orogeny while you are in the midst of your AoE combo.", WAR.JobID, WAR.Upheaval)]
        WarriorUporgyFeature = 2114,

        [OrderedEnum]
        [CustomComboInfo("Primal Upheaval", "Replace Upheaval/Orogeny with Primal Wrath while available.", WAR.JobID, WAR.Upheaval, WAR.Orogeny)]
        WarriorPrimalUpheavalFeature = 2118,

        #endregion
        // ====================================================================================
        #region WHITE MAGE

        [OrderedEnum]
        [CustomComboInfo("安慰之心 => 苦难之心", "如果苦难之心可用，则将安慰之心替换为苦难之心。", WHM.JobID, WHM.AfflatusSolace)]
        WhiteMageSolaceMiseryFeature = 2401,

        [OrderedEnum]
        [CustomComboInfo("狂喜之心 => 苦难之心", "如果苦难之心可用、且当前有选定的目标，则将狂喜之心替换为苦难之心。", WHM.JobID, WHM.AfflatusRapture)]
        WhiteMageRaptureMiseryFeature = 2402,

        [OrderedEnum]
        [CustomComboInfo("神圣 => 苦难之心", "如果苦难之心可用、且当前有选定的目标，则将神圣/豪圣替换为苦难之心。", WHM.JobID, WHM.Holy, WHM.Holyga)]
        WhiteMageHolyMiseryFeature = 2405,

        [OrderedEnum]
        [CustomComboInfo("神圣 => 闪飒", "如果闪飒可用、且当前有选定的目标，则将神圣/豪圣替换为闪飒。\n如果上面的苦难之心替换功能也被启用，则苦难之心的优先级更高。", WHM.JobID, WHM.Holy, WHM.Holyga)]
        WhiteMageHolyGlareFeature = 2407,

        [OrderedEnum]
        [CustomComboInfo("救疗 -> 治疗 等级同步", "在等级同步至30级以下时，将救疗替换为治疗。", WHM.JobID, WHM.Cure2)]
        WhiteMageCureFeature = 2403,

        [OrderedEnum]
        [CustomComboInfo("治疗百合功能", "当治疗百合开放时，将救疗替换为安慰之心、将医治替换为狂喜之心。", WHM.JobID, WHM.Cure2, WHM.Medica)]
        WhiteMageAfflatusFeature = 2404,

        [OrderedEnum]
        [CustomComboInfo("醒梦提醒（白魔）", "当你的MP小于等于以下设置值、且醒梦不在冷却时，将你所有正在冷却、非职能、且没有积蓄次数的能力技替换为醒梦。", WHM.JobID, WHM.PresenceOfMind, WHM.Assize, WHM.Temperance, WHM.PlenaryIndulgence, WHM.Tetragrammaton, WHM.Asylum, WHM.Aquaveil, WHM.LiturgyOfTheBell, WHM.Benediction)]
        WhiteMageLucidReminderFeature = 2406,

        #endregion
        // ====================================================================================
    }
}
