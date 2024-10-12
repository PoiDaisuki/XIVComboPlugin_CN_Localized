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
        [CustomComboInfo("复活 => 即刻咏唱 功能", "当即刻咏唱不在冷却时，将有复活技能的职业各自的复活技能替换为即刻咏唱。（有连续咏唱效果的时候也不会替换）\n以防万一以下是有复活技能的职业：四个治疗职业、召唤师、赤魔法师、和青魔法师。", All.JobID, All.Raise, All.Resurrection, All.Ascend, All.Verraise, All.Egeiro, All.AngelWhisper)]
        AllSwiftcastFeature = 9001,

        [OrderedEnum]
        [CustomComboInfo("海岛冲刺", "在无人岛时，将冲刺替换为海岛冲刺。\n这本来是一个SimpleTweaks提供的功能。（但是似乎坏了没修所以作者做了这么一个替换）", All.JobID, All.Sprint)]
        AllIsleSprintFeature = 9014,

        [OrderedEnum]
        [CustomComboInfo("理智同兴替换", "当理智同兴被触发时，将石工之理或农夫之智替换为理智同兴。", All.JobID, All.SolidReason, All.AgelessWords)]
        AllEurekaFeature = 9002,

        [OrderedEnum]
        [CustomComboInfo("防护职业插言功能", "如果目标可以被插言、且插言当前已经冷却完毕，则将下踢替换为插言。", All.JobID, All.LowBlow)]
        AllTankInterruptFeature = 9003,

        [OrderedEnum]
        [CustomComboInfo("雪仇/牵制/昏乱锁定功能", "如果你的雪仇/牵制/昏乱已经冷却完毕、但目标身上的相同技能效果剩余时间超过3s的话，锁定相应技能，以防止Buff被覆盖。", All.JobID, All.Reprisal, All.Addle, All.Feint)]
        AllReprisalLockoutFeature = 9010,

        [OrderedEnum]
        [CustomComboInfo("远敏团减锁定功能", "在你远敏职业的团减（如行吟）已经冷却完毕、但身上仍有（其他玩家提供的）剩余时间超过3s的对应Buff的情况下，锁定相应技能以防止Buff被覆盖。", All.JobID, All.Tactician, All.Troubadour, All.ShieldSamba)]
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
        [CustomComboInfo("占卜锁定功能", "如果身上的占卜效果剩余时间超过3秒，则锁定占卜，以防止Buff被覆盖。", AST.JobID, AST.Divination)]
        AstrologianDivinationLockoutFeature = 3308,

        [OrderedEnum]
        [CustomComboInfo("醒梦提醒（占星）", "当你的MP小于等于以下设置值、且醒梦已经冷却完毕时，将你所有正在冷却、非职能、且没有积蓄次数的能力技替换为醒梦。", AST.JobID, AST.CelestialOpposition, AST.CollectiveUnconscious, AST.Divination, AST.EarthlyStar, AST.Exaltation, AST.Macrocosmos, AST.NeutralSect, AST.Synastry, AST.Horoscope)]
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
        [CustomComboInfo("冰冻/冰封 => 耀星", "在耀星可用时，将冰封和(高)冰冻替换为耀星。", BLM.JobID, BLM.Blizzard, BLM.Blizzard2, BLM.Blizzard3, BLM.HighBlizzard2)]
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
        [CustomComboInfo("烈炎功能", "在星极火状态时，将(高)烈炎替换为核爆。", BLM.JobID, BLM.Fire2, BLM.HighFire2)]
        BlackFire2Feature = 2508,

        [OrderedEnum]
        [CustomComboInfo("冰冻功能", "在灵极冰状态时，将(高)冰冻替换为玄冰。", BLM.JobID, BLM.Blizzard2, BLM.HighBlizzard2)]
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
        [CustomComboInfo("秽浊/异言 => 详述", "当详述可用且满足下述条件时，将秽浊和异言替换为详述：刚刚使用了一个技能（GCD正在旋转）、详述的层数不满2层、且当前没有目标，或详述的层数为0。", BLM.JobID, BLM.Xenoglossy, BLM.Foul)]
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
        [CustomComboInfo("九天连箭 => 侧风诱导箭", "将九天连箭替换为侧风诱导箭，如果前者正在冷却而后者已经冷却完毕。", BRD.JobID, BRD.EmpyrealArrow)]
        BardSidewinderFeature = 2306,

        [OrderedEnum]
        [CustomComboInfo("侧风诱导箭 => 完美音调", "在放浪神的小步舞曲时，将侧风诱导箭替换为完美音调，如果诗心已满、或侧风诱导箭正在冷却中。", BRD.JobID, BRD.Sidewinder)]
        BardPerfectSidesFeature = 2314,

        [OrderedEnum]
        [CustomComboInfo("战斗的最终乐章", "如果战斗之声已经冷却完毕，则将光明神的最终乐章替换为战斗之声。\n（其实原标题是 Radiant Voice，但是为了和下面对应所以反过来了）", BRD.JobID, BRD.RadiantFinale)]
        BardRadiantFeature = 2307,

        [OrderedEnum]
        [ParentCombo(BardRadiantFeature)]
        [CustomComboInfo("光明神之声", "使用光明神的最终乐章之后，再将光明神的最终乐章替换为战斗之声。", BRD.JobID, BRD.RadiantFinale)]
        BardRadiantVoiceOption = 2315,

        [OrderedEnum]
        [CustomComboInfo("光明神强击", "如果猛者强击已经冷却完毕而光明神的最终乐章没有，则光明神的最终乐章替换为猛者强击。\n如果上面“战斗的最终乐章”功能也被启用，则战斗之声的优先级更高。", BRD.JobID, BRD.RadiantFinale)]
        BardRadiantStrikesFeature = 2309,

        [OrderedEnum]
        [CustomComboInfo("战斗之声锁定功能", "如果身上的战斗之声效果剩余时间超过3秒，则锁定战斗之声，以防止Buff被覆盖。", BRD.JobID, BRD.BattleVoice)]
        BardBattleVoiceLockoutFeature = 2312,

        [OrderedEnum]
        [CustomComboInfo("光明神的最终乐章锁定功能", "如果身上的光明神的最终乐章效果剩余时间超过3秒，则锁定战斗之声，以防止Buff被覆盖。", BRD.JobID, BRD.RadiantFinale)]
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
        [CustomComboInfo("逆瀑泄连击 - 也变为AOE触发", "如果你正在使用AOE连击，则替换为升风车或落血雨。（如果触发可用）", DNC.JobID)]
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
        [CustomComboInfo("扇舞防溢出", "如果你有四档幻扇、且GCD正在旋转，则将瀑泄/风车连击分别替换为扇舞·序或扇舞·破。", DNC.JobID, DNC.Cascade, DNC.Windmill)]
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
        [CustomComboInfo("技巧舞步锁定功能", "如果身上的技巧舞步结束效果剩余时间超过8秒，则锁定技巧舞步，以防止Buff被覆盖。", DNC.JobID, DNC.TechnicalStep)]
        DancerTechnicalLockoutFeature = 3813,

        [OrderedEnum]
        [ConflictingCombos(DancerDanceStepCombo)]
        [CustomComboInfo(
            "舞步替换功能",
            "将跳舞时会变为舞步的技能指定为以下设置的四个。\n" +
            "这个功能的意义是，确保你在开启上面的连击功能、但不使用自动跳舞功能时，仍然可以正确的跳出四个舞步。\n" +
            "你可以通过在下面为每个舞步技能指定一个不同的技能ID来将其绑定到另一个技能上。\n" +
            "默认的选项是，瀑泄、百花争艳、扇舞·序、和扇舞·破。如果被设置为0，它们会被重置为这些技能。\n" +
            "技能ID可以通过在Garland Tools上搜索技能名并点击右上角的小齿轮图标获取。\n" +
            "（译注：SimpleTweaks可以直接在游戏内显示技能的ID、以及自动跳舞不会坑你的，这个功能真没卵用）",
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
        [CustomComboInfo("苍穹刺连击 => 贯穿尖", "当你在近战攻击的范围之外时，将苍穹刺连击替换为贯穿尖。", DRG.JobID, DRG.FullThrust, DRG.HeavensThrust)]
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
        [CustomComboInfo("樱花连击 => 龙翼滑翔", "当你在近战攻击的范围之外时，将樱花连击替换为龙翼滑翔。（似乎只会替换开膛枪和樱花怒放）", DRG.JobID, DRG.Disembowel, DRG.SpiralBlow, DRG.ChaosThrust, DRG.ChaoticSpring)]
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
        [CustomComboInfo("坠星冲 => 龙炎冲", "当龙炎冲冷却完毕、或不在红莲龙血状态时，将坠星冲替换为龙炎冲。", DRG.JobID, DRG.Stardiver)]
        DragoonStarfireDiveFeature = 2208,

        [OrderedEnum]
        [CustomComboInfo("猛枪 => 战斗连祷", "在猛枪冷却时，将猛枪替换为战斗连祷。", DRG.JobID, DRG.LanceCharge)]
        DragoonLancetanyFeature = 2218,

        [OrderedEnum]
        [CustomComboInfo("战斗连祷锁定功能", "如果身上的战斗连祷效果剩余时间超过3秒，则锁定战斗连祷，以防止Buff被覆盖。", DRG.JobID, DRG.BattleLitany)]
        DragoonLitanyLockoutFeature = 2219,

        #endregion
        // ====================================================================================
        #region DARK KNIGHT

        // unused enums: 3204
        // last used enum: 3213

        [OrderedEnum]
        [CustomComboInfo("噬魂斩连击", "将噬魂斩替换为它的连击链：重斩 - 吸收斩 - 噬魂斩", DRK.JobID, DRK.Souleater)]
        DarkSouleaterCombo = 3201,

        [OrderedEnum]
        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("噬魂斩 => 伤残", "当你在近战攻击的范围之外时，将噬魂斩连击替换为伤残。", DRK.JobID, DRK.Souleater)]
        DarkSoulmendFeature = 3208,

        [OrderedEnum]
        [CustomComboInfo("刚魂连击", "将刚魂替换为它的连击链：释放 - 刚魂", DRK.JobID, DRK.StalwartSoul, DRK.Unleash)]
        DarkStalwartSoulCombo = 3202,

        [OrderedEnum]
        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("刚魂 => 掠影的蔑视", "将刚魂替换为掠影的蔑视，如果后者可用。", DRK.JobID, DRK.StalwartSoul, DRK.Unleash)]
        DarkStalsteemFeature = 3213,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("刚魂连击 - 绑定至释放", "将释放替换为它的连击链，而非刚魂。", DRK.JobID, DRK.StalwartSoul, DRK.Unleash)]
        DarkEvilStalwartSoulCombo = 3205,

        [OrderedEnum]
        [CustomComboInfo("刚魂连击 => 寂灭", "如果暗血即将溢出，则将刚魂连击替换为寂灭。（以防止暗血溢出）", DRK.JobID, DRK.StalwartSoul)]
        DRKOvercapFeature = 3203,

        [OrderedEnum]
        [CustomComboInfo("精雕怒斩 => 血乱", "将精雕怒斩替换为血乱，如果后者已经冷却完毕。", DRK.JobID, DRK.CarveAndSpit)]
        DarkDeliriumFeature = 3206,

        [OrderedEnum]
        [CustomComboInfo("暗影锋 => 暗影波动", "如果你正在使用AOE连击、或尚未解锁暗黑锋，则将暗影锋替换为暗影波动，或它们的低级（暗黑）版本。", DRK.JobID, DRK.EdgeOfDarkness, DRK.EdgeOfShadow)]
        DarkEdgeToFloodFeature = 3209,

        [OrderedEnum]
        [CustomComboInfo("血溅 => 寂灭", "如果你正在使用AOE连击，则将血溅替换为寂灭。", DRK.JobID, DRK.Bloodspiller)]
        DarkBloodspillerToQuietusFeature = 3210,

        [OrderedEnum]
        [CustomComboInfo("精雕怒斩 => 吸血深渊", "如果你正在使用AOE连击，则将精雕怒斩替换为吸血深渊。", DRK.JobID, DRK.CarveAndSpit)]
        DarkCarveToDrainFeature = 3211,

        [OrderedEnum]
        [CustomComboInfo("至黑之夜 => 献奉", "当至黑之夜正在冷却、献奉可用、且你自己身上没有献奉效果时，将至黑之夜替换为献奉。", DRK.JobID, DRK.TheBlackestNight)]
        DarkTBNToOblationFeature = 3212,

        #endregion
        // ====================================================================================
        #region GUNBREAKER

        // last used enum: 3718

        [OrderedEnum]
        [CustomComboInfo("迅连斩连击", "将迅连斩替换为它的连击链：利刃斩 - 残暴弹 - 迅连斩", GNB.JobID, GNB.SolidBarrel)]
        GunbreakerSolidBarrelCombo = 3701,

        [OrderedEnum]
        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("迅连斩 => 闪雷弹", "当你在近战攻击的范围之外时，将迅连斩连击替换为闪雷弹。", GNB.JobID, GNB.SolidBarrel)]
        GunbreakerSolidShotFeature = 3714,

        [OrderedEnum]
        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("迅连斩连击 => 爆发击", "如果晶壤已满，则将迅连斩替换为爆发击。（以防止晶壤溢出）", GNB.JobID, GNB.SolidBarrel)]
        GunbreakerBurstStrikeFeature = 3710,

        [OrderedEnum]
        [CustomComboInfo("烈牙续剑", "如果可以的话，将烈牙（及后续连击）替换为续剑。", GNB.JobID, GNB.GnashingFang)]
        GunbreakerGnashingFangContinuation = 3702,

        [OrderedEnum]
        [CustomComboInfo("爆发击续剑", "如果可以的话，将爆发击替换为续剑。", GNB.JobID, GNB.BurstStrike)]
        GunbreakerBurstStrikeCont = 3703,

        [OrderedEnum]
        [CustomComboInfo("命运之环续剑", "如果可以的话，将命运之环替换为续剑。", GNB.JobID, GNB.FatedCircle)]
        GunbreakerFatedCircleContinuation = 3716,

        [OrderedEnum]
        [CustomComboInfo("恶魔杀连击", "将恶魔杀替换为它的连击链：恶魔切 - 恶魔杀", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerDemonSlaughterCombo = 3705,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("恶魔杀连击 - 绑定至恶魔切", "将恶魔切替换为它的连击链，而非恶魔杀。", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerEvilDemonSlaughterCombo = 3709,

        [OrderedEnum]
        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("恶魔杀连击 => 命运之环", "如果晶壤即将溢出，则将恶魔杀替换为命运之环。（以防止晶壤溢出）", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerFatedCircleFeature = 3706,

        [OrderedEnum]
        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("恶魔杀连击 => 终结之心连击", "如果后者可用，则将恶魔杀连击替换为终结之心连击。（崛起之心 - 支配之心 - 终结之心）", GNB.JobID, GNB.DemonSlaughter, GNB.DemonSlice)]
        GunbreakerDemonHeartFeature = 3718,

        [OrderedEnum]
        [CustomComboInfo("爆发击 => 命运之环", "如果你正在使用AOE连击，则将爆发击替换为命运之环。", GNB.JobID, GNB.BurstStrike)]
        GunbreakerBurstStrikeToFatedCircleFeature = 3715,

        [OrderedEnum]
        [CustomComboInfo("爆发击/命运之环 => 血壤", "如果你没有晶壤，则将爆发击和命运之环替换为血壤。", GNB.JobID, GNB.BurstStrike, GNB.FatedCircle)]
        GunbreakerBloodfestOvercapFeature = 3707,

        [OrderedEnum]
        [CustomComboInfo("爆发击/命运之环 => 倍攻", "如果倍攻可用，则将爆发击和命运之环替换为倍攻。", GNB.JobID, GNB.BurstStrike, GNB.FatedCircle)]
        GunbreakerDoubleDownFeature = 3711,

        [OrderedEnum]
        [CustomComboInfo("爆发击/命运之环 => 终结之心连击", "如果后者可用，则将爆发击和命运之环替换为终结之心连击。（崛起之心 - 支配之心 - 终结之心）", GNB.JobID, GNB.BurstStrike, GNB.FatedCircle)]
        GunbreakerBurstHeartFeature = 3717,

        [OrderedEnum]
        [CustomComboInfo("无情 => 弓形冲波", "在无情的生效期间，将无情替换为弓形冲波。\n如果无情当前是音速破，则只有在GCD正在旋转时才会进行替换。（不会卡GCD）", GNB.JobID, GNB.NoMercy)]
        GunbreakerNoMercyFeature = 3708,

        [OrderedEnum]
        [CustomComboInfo("无情 => 倍攻", "当无情正在生效中、且倍攻已经冷却完毕时，将无情替换为倍攻。\n如果其他无情替换功能也被启用，则倍攻的优先级高于它们。", GNB.JobID, GNB.NoMercy)]
        GunbreakerNoMercyDoubleDownFeature = 3712,

        #endregion
        // ====================================================================================
        #region MACHINIST

        // last used enum: 3114

        [OrderedEnum]
        [ConflictingCombos(MachinistHypercomboOption)]
        [CustomComboInfo("(热)狙击弹连击", "将(热)狙击弹替换为它的连击链：(热)分裂弹 - (热)独头弹 - (热)狙击弹", MCH.JobID, MCH.CleanShot, MCH.HeatedCleanShot)]
        MachinistMainCombo = 3101,

        [OrderedEnum]
        [CustomComboInfo("散射 => 自动弩", "当处于过热状态时，将散射/霰弹枪替换为自动弩。", MCH.JobID, MCH.SpreadShot, MCH.Scattergun)]
        MachinistSpreadShotFeature = 3102,

        [OrderedEnum]
        [CustomComboInfo("热冲击/自动弩 => 超荷", "当不处于过热状态时，将热冲击和自动弩替换为超荷。", MCH.JobID, MCH.HeatBlast, MCH.BlazingShot, MCH.AutoCrossbow)]
        MachinistOverheatFeature = 3103,

        [OrderedEnum]
        [CustomComboInfo("超荷连击功能", "当处于过热状态时，将你的主要连击替换为热冲击/烈焰弹。", MCH.JobID, MCH.SplitShot, MCH.HeatedSplitShot, MCH.SlugShot, MCH.HeatedSlugShot, MCH.CleanShot, MCH.HeatedCleanShot)]
        MachinistHypercomboFeature = 3108,

        [OrderedEnum]
        [ParentCombo(MachinistHypercomboFeature)]
        [ConflictingCombos(MachinistMainCombo)]
        [CustomComboInfo("超荷连击功能 - 仅替换当前连击技能", "仅替换当前的连击技能为热冲击/烈焰弹，而非整个连击链。", MCH.JobID, MCH.SplitShot, MCH.HeatedSplitShot, MCH.SlugShot, MCH.HeatedSlugShot, MCH.CleanShot, MCH.HeatedCleanShot)]
        MachinistHypercomboOption = 3110,

        [OrderedEnum]
        [CustomComboInfo("超档替换功能", "当前者激活时，将车式浮空炮塔/后式自走人偶替换为超档车式浮空炮塔/超档后式自走人偶。", MCH.JobID, MCH.RookAutoturret, MCH.AutomatonQueen)]
        MachinistOverdriveFeature = 3104,

        [OrderedEnum]
        [CustomComboInfo("超荷 => 野火", "如果野火已经冷却完毕、且你有选中的目标，则将超荷替换为野火。", MCH.JobID, MCH.Hypercharge)]
        MachinistHyperfireFeature = 3107,

        [OrderedEnum]
        [CustomComboInfo("钻头 => 毒菌冲击", "如果没有使用整备、且你的上一个连击技能为散射/霰弹枪，则将钻头替换为毒菌冲击。", MCH.JobID, MCH.Drill)]
        MachinistBioDrillFeature = 3114,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("虹吸弹 <=> 弹射 切换功能", "将虹吸弹和弹射切换为他们两个中具有更高积蓄次数的那一个。", MCH.JobID, MCH.GaussRound, MCH.Ricochet)]
        MachinistGaussRoundRicochetFeature = 3105,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(MachinistGaussRoundRicochetFeature)]
        [CustomComboInfo("仅在过热时切换", "虹吸弹和弹射只会在过热期间互相切换。", MCH.JobID, MCH.GaussRound, MCH.Ricochet)]
        MachinistGaussRoundRicochetFeatureOption = 3109,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("回转飞锯 => 钻头/空气锚", "根据冷却的优先级，将回转飞锯替换为空气锚和钻头。（优先级如此）\n不会替换其他任何技能，所以你仍然可以看到（钻头和空气锚的）冷却时间。", MCH.JobID, MCH.Chainsaw)]
        MachinistChainsawFeature = 3113,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(MachinistChainsawFeature)]
        [CustomComboInfo("整备 => 回转飞锯", "当处于整备状态时，将整备替换为回旋飞锯。", MCH.JobID, MCH.Reassemble)]
        MachinistReassembleFeature = 3111,

        #endregion
        // ====================================================================================
        #region MONK

        // latest enum: 2034

        [OrderedEnum]
        [CustomComboInfo("(猿舞)连击 连击", "将(猿舞)连击依次替换为：(猿舞)连击 - (龙颚)正拳 - (豹袭)崩拳\n武僧的第一个技能就叫连击...", MNK.JobID, MNK.LeapingOpo, MNK.Bootshine)]
        MonkOpoCombo = 2019,

        [OrderedEnum]
        [CustomComboInfo("双龙脚连击", "将双龙脚依次替换为：双龙脚 - 双掌打 - 破碎拳", MNK.JobID, MNK.DragonKick)]
        MonkDragonKickCombo = 2020,

        [OrderedEnum]
        [ConflictingCombos(MonkAoEComboFormOption)]
        [CustomComboInfo("震脚：演武 => 双掌打", "在震脚生效期间，将演武替换为双掌打。", MNK.JobID, MNK.FormShift)]
        MonkFormSnakes = 2032,

        [OrderedEnum]
        [ConflictingCombos(MonkPerfectBalanceFeatureLockout)]
        [CustomComboInfo("震脚 => 破碎拳", "在震脚生效期间，将震脚替换为破碎拳，这样你就不用把它放在热键栏里了。", MNK.JobID, MNK.PerfectBalance)]
        MonkPerfectBalanceDemolishFeature = 2026,

        [OrderedEnum]
        [CustomComboInfo("斗气提醒", "如果你在战斗之外、且斗气不足五档，则将你的所有gcd技能替换为斗气。", MNK.JobID, MNK.TwinSnakes, MNK.TrueStrike, MNK.RisingRaptor, MNK.FormShift, MNK.SnapPunch, MNK.PouncingCoeurl, MNK.Demolish, MNK.Bootshine, MNK.LeapingOpo, MNK.DragonKick, MNK.MasterfulBlitz, MNK.Rockbreaker, MNK.ArmOfTheDestroyer, MNK.ShadowOfTheDestroyer, MNK.FourPointFury, MNK.SixSidedStar, PLD.TotalEclipse, MNK.PerfectBalance)]
        MonkMeditationReminder = 2013,

        [OrderedEnum]
        [CustomComboInfo("武僧AOE连击", "（因为一些Bug上的原因）将必杀技替换为AOE连击链：破坏神冲/破坏神脚 - 四面脚 - 地裂劲\n如果处于震脚生效期间，必杀技自动选择为具有最高伤害的AOE技能。这时，四面脚会替代必杀技成为1-2-3连击链。（必杀技=阴豆子，四面脚=阳豆子）\n如果已经获得三个轮脉，则触发的必杀技优先级将高于AOE连击。", MNK.JobID, MNK.MasterfulBlitz, MNK.FourPointFury, MNK.FormShift, PLD.TotalEclipse)]
        MonkAoECombo = 2001,

        [OrderedEnum]
        [ParentCombo(MonkAoECombo)]
        [CustomComboInfo("【实验性】不需要必杀技的AOE连击", "启用这个选项将会把AOE连击绑定至骑士的全蚀斩，而非必杀技。（这样就不需要改动必杀技了）\n" +
            "如果你想不出来怎么把全蚀斩拖进武僧的热键栏的话，以下是一些提示：用共通技能栏中转、宏、或者类似ReAction的插件。（我没用过ReAction，我也不知道怎么用）", MNK.JobID)]
        MonkAoEComboBlitzOption = 2027,

        [OrderedEnum]
        [ParentCombo(MonkAoECombo)]
        [ConflictingCombos(MonkFormSnakes)]
        [CustomComboInfo("震脚：演武 => AOE连击", "启用这个会在震脚期间将演武替换为1-2-3连击链。", MNK.JobID, MNK.FormShift)]
        MonkAoEComboFormOption = 2009,

        [OrderedEnum]
        [ParentCombo(MonkAoECombo)]
        [CustomComboInfo("AOE连击 => 万象斗气圈", "如果达到五档斗气、有选中的目标、且GCD正在旋转，则将AOE连击替换为空鸣拳/万象斗气圈。", MNK.JobID, MNK.MasterfulBlitz)]
        MonkAoEMeditationFeature = 2014,

        // [OrderedEnum]
        // [ParentCombo(MonkAoECombo)]
        // [CustomComboInfo("Monk AoE Balance Feature", "Replaces Monk's AoE Combo with Masterful Blitz if you have 3 Beast Chakra.", MNK.JobID, MNK.Rockbreaker)]
        // MonkAoEBalanceFeature = 2006,

        [OrderedEnum]
        [CustomComboInfo("双龙脚 => (猿舞)连击 自动切换", "根据当前的功力状态，自动选择正确的魔猿身形技能。\n如果当前拥有魔猿功力，则将双龙脚替换为(猿舞)连击。反之，则将(猿舞)连击替换为双龙脚。\n但是测试下来似乎是单向替换。", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkDragonKickBootshineFeature = 2002,

        [OrderedEnum]
        [CustomComboInfo("双掌打 => (龙颚)正拳 自动切换", "根据当前的功力状态，自动选择正确的盗龙身形技能。\n如果当前拥有盗龙功力，则将双掌打替换为(龙颚)正拳。反之，则将(龙颚)正拳替换为双掌打。\n但是测试下来似乎是单向替换。", MNK.JobID, MNK.TwinSnakes)]
        MonkTwinRaptorsFeature = 2030,

        [OrderedEnum]
        [CustomComboInfo("破碎拳 => (豹袭)崩拳 自动切换", "根据当前的功力状态，自动选择正确的猛豹身形技能。\n如果当前拥有猛豹功力，则将破碎拳替换为(豹袭)崩拳。反之，则将(豹袭)崩拳替换为破碎拳。\n但是测试下来似乎是单向替换。", MNK.JobID, MNK.Demolish)]
        MonkDemolishingPounceFeature = 2031,

        [OrderedEnum]
        [CustomComboInfo("仅在震脚/演武时自动切换", "启用这个选项后，以上三个自动切换功能将仅在震脚激活、或演武状态下才生效。", MNK.JobID, MNK.DragonKick)]
        MonkPerfectBalanceFuryOption = 2033,

        [OrderedEnum]
        [CustomComboInfo("(猿舞)连击/双龙脚 => 必杀技", "如果已经获得三个轮脉，则将(猿舞)连击和双龙脚替换为必杀技。", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkDragonKickBalanceFeature = 2005,

        [OrderedEnum]
        [CustomComboInfo("(猿舞)连击/双龙脚 => 轻身步法", "当你在近战攻击的范围之外、或选中其他玩家时，将(猿舞)连击和双龙脚替换为轻身步法。", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkDragonClapFeature = 2022,

        [OrderedEnum]
        [CustomComboInfo("(猿舞)连击/双龙脚 => 阴阳斗气斩", "如果达到五档斗气、且GCD正在旋转，则将(猿舞)连击和双龙脚替换为铁山靠/阴阳斗气斩。", MNK.JobID, MNK.DragonKick, MNK.Bootshine, MNK.LeapingOpo)]
        MonkChakraKickFeature = 2034,

        [OrderedEnum]
        [CustomComboInfo("阴阳斗气斩 => 万象斗气圈", "如果你最后一个使用的GCD技能为AOE连击中的一个，则将阴阳斗气斩替换为万象斗气圈。", MNK.JobID, MNK.Meditation, MNK.SteeledMeditation)]
        MonkChakraToEnlightmentFeature = 2025,

        [OrderedEnum]
        [CustomComboInfo("震脚 => 必杀技", "如果已经获得三个轮脉，则将震脚替换为必杀技。", MNK.JobID, MNK.PerfectBalance)]
        MonkPerfectBalanceFeature = 2004,

        [OrderedEnum]
        [ParentCombo(MonkPerfectBalanceFeature)]
        [CustomComboInfo("震脚锁定功能", "当震脚正被激活时，将其替换为一个无用的技能。", MNK.JobID, MNK.PerfectBalance)]
        MonkPerfectBalanceFeatureLockout = 2021,

        [OrderedEnum]
        [CustomComboInfo("红莲极意 => 义结金兰", "如果义结金兰已经冷却完毕，则将红莲极意替换为义结金兰。", MNK.JobID, MNK.RiddleOfFire)]
        MonkRiddleToBrotherFeature = 2011,

        [OrderedEnum]
        [CustomComboInfo("红莲极意 => 疾风极意", "如果红莲极意正在冷却、且疾风极意已经冷却完毕，则将红莲极意替换为疾风极意。\n如果上面的红莲极意 => 义结金兰也被启用，那么义结金兰将会拥有更高的优先级。", MNK.JobID, MNK.RiddleOfFire)]
        MonkRiddleToRiddleFeature = 2012,

        [OrderedEnum]
        [CustomComboInfo("义结金兰锁定功能", "如果身上的义结金兰效果剩余时间超过3秒，则锁定占卜，以防止Buff被覆盖。", MNK.JobID, MNK.Brotherhood)]
        MonkBrotherhoodLockoutFeature = 2028,

        #endregion
        // ====================================================================================
        #region NINJA

        // last used: 3024

        [OrderedEnum]
        [CustomComboInfo("旋风刃连击", "将旋风刃替换为它的连击链：双刃旋 - 绝风 - 旋风刃", NIN.JobID, NIN.AeolianEdge)]
        NinjaAeolianEdgeCombo = 3002,

        [OrderedEnum]
        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("旋风刃连击 => 飞刀", "当你在近战攻击的范围之外时，将旋风刃连击替换为飞刀。", NIN.JobID, NIN.ThrowingDagger)]
        NinjaThrowingEdgeFeature = 3021,

/*        [OrderedEnum]
        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Aeolian Edge to Armor Crush", "Replace Aeolian Edge with Armor Crush in its combo if you do not have its buff applied.", NIN.JobID, NIN.AeolianEdge)]
        NinjaAeolianCrushFeature = 3024,*/

        [OrderedEnum]
        [CustomComboInfo("强甲破点突连击", "将强甲破点突替换为它的连击链：双刃旋 - 绝风 - 强甲破点突", NIN.JobID, NIN.ArmorCrush)]
        NinjaArmorCrushCombo = 3001,

        [OrderedEnum]
        [CustomComboInfo("八卦无刃杀连击", "将八卦无刃杀替换为它的连击链：血雨飞花 - 八卦无刃杀", NIN.JobID, NIN.HakkeMujinsatsu, NIN.DeathBlossom)]
        NinjaHakkeMujinsatsuCombo = 3003,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(NinjaHakkeMujinsatsuCombo)]
        [CustomComboInfo("八卦无刃杀连击 - 绑定至血雨飞花", "将血雨飞花替换为它的连击链，而非八卦无刃杀。", NIN.JobID, NIN.HakkeMujinsatsu, NIN.DeathBlossom)]
        NinjaEvilHakkeMujinsatsuCombo = 3014,

        [OrderedEnum]
        [CustomComboInfo("生杀予夺 => 百雷铳", "当处于水遁状态且生杀予夺正在冷却、或处于隐遁状态时，将生杀予夺替换为攻其不备/百雷铳。", NIN.JobID, NIN.Kassatsu)]
        NinjaKassatsuTrickFeature = 3004,

        [OrderedEnum]
        [CustomComboInfo("生杀予夺 => 梦幻三段", "当生杀予夺正在冷却而梦幻三段已经冷却完毕时，将生杀予夺替换为断绝/梦幻三段。\n如果上面的生杀予夺 => 百雷铳被同时启用，那么攻其不备/百雷铳将具有更高优先级。", NIN.JobID, NIN.Kassatsu)]
        NinjaKassatsuDWaDFeature = 3015,

        [OrderedEnum]
        [CustomComboInfo("梦幻三段 => 百雷铳", "当处于水遁、或隐遁状态时，将断绝/梦幻三段替换为攻其不备/百雷铳。", NIN.JobID, NIN.DreamWithinADream)]
        NinjaDWaDTrickFeature = 3019,

        [OrderedEnum]
        [CustomComboInfo("天地人 => 命水", "当处于水遁状态时，将天地人替换为命水。", NIN.JobID, NIN.TenChiJin)]
        NinjaTCJMeisuiFeature = 3005,

        [OrderedEnum]
        [CustomComboInfo("生杀予夺：地之印 => 人之印", "在获得生杀予夺效果提高特性后，当你使用生杀予夺时，将地之印替换为人之印。", NIN.JobID, NIN.Chi)]
        NinjaKassatsuChiJinFeature = 3006,

        [OrderedEnum]
        [CustomComboInfo("隐遁 => 介毒之术", "在战斗中时，将隐遁替换为夺取/介毒之术", NIN.JobID, NIN.Hide)]
        NinjaHideMugFeature = 3007,

        [OrderedEnum]
        [CustomComboInfo("介毒之术锁定功能", "如果目标身上的介毒之术效果剩余时间超过3秒，则锁定介毒之术，以防止Buff被覆盖。", NIN.JobID, NIN.Mug, NIN.Dokumori)]
        NinjaMugLockoutFeature = 3023,

        [OrderedEnum]
        [CustomComboInfo("六道轮回 => 大虾蟆", "如果你正在使用AOE连击，则将六道轮回替换为通灵之术·大虾蟆。", NIN.JobID, NIN.Bhavacakra)]
        NinjaBhavacakraToFroggieFeature = 3022,

        [OrderedEnum]
        [ConflictingCombos(NinjaGCDNinjutsuFeature)]
        [CustomComboInfo("旋风刃 => 忍术", "如果当前正在结印，则将旋风刃及其连击替换为忍术。", NIN.JobID, NIN.AeolianEdge)]
        NinjaNinjutsuFeature = 3008,

        [OrderedEnum]
        [ConflictingCombos(NinjaNinjutsuFeature)]
        [CustomComboInfo("GCD => 忍术", "如果当前正在结印，则将你所有结印以外的GCD技能全部变为忍术。", NIN.JobID, NIN.AeolianEdge, NIN.ArmorCrush, NIN.HakkeMujinsatsu, NIN.DeathBlossom, NIN.ThrowingDagger, NIN.GustSlash, NIN.SpinningEdge, NIN.ForkedRaiju, NIN.FleetingRaiju)]
        NinjaGCDNinjutsuFeature = 3009,

        [OrderedEnum]
        [CustomComboInfo("忍术双击释放", "双击你最后使用的印来释放忍术，如果当前的忍术是土遁、风遁、水遁、劫火灭却之术、或冰晶乱流之术，那么三个印都会变成忍术。", NIN.JobID, NIN.Ten, NIN.Chi, NIN.Jin)]
        NinjaTapNinjutsuFeature = 3020,

        [OrderedEnum]
        [CustomComboInfo("强甲破点突 => 月影雷兽爪", "如果月影雷兽爪可用，则将强甲破点突替换为月影雷兽爪。", NIN.JobID, NIN.ArmorCrush)]
        NinjaArmorCrushRaijuFeature = 3012,

        [OrderedEnum]
        [CustomComboInfo("旋风刃 => 月影雷兽牙", "如果月影雷兽牙可用，则将强甲破点突替换为月影雷兽牙。", NIN.JobID, NIN.AeolianEdge)]
        NinjaAeolianEdgeRaijuFeature = 3013,

        [OrderedEnum]
        [CustomComboInfo("月影雷兽爪 <=> 月影雷兽牙 切换功能", "月影雷兽爪与月影雷兽牙会根据与目标间的距离自动切换。（与上面的两个替换功能配合使用）", NIN.JobID, NIN.ForkedRaiju, NIN.FleetingRaiju)]
        NinjaSmartRaijuFeature = 3016,

        #endregion
        // ====================================================================================
        #region PALADIN

        // used enums: 1913, 1901, 1909, 1910, 1906
        // latest enum: 1922

        [OrderedEnum]
        [CustomComboInfo("王权剑连击", "将战女神之怒/王权剑替换为它的连击链：先锋剑 - 暴乱剑 - 战女神之怒/王权剑", PLD.JobID, PLD.RoyalAuthority, PLD.RageOfHalone)]
        PaladinRoyalAuthorityCombo = 1902,

        [OrderedEnum]
        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("王权剑 => 投盾", "当你在近战攻击的范围之外时，将战女神之怒/王权剑替换为投盾。", PLD.JobID, PLD.RoyalAuthority, PLD.RageOfHalone)]
        PaladinRoyalLobFeature = 1912,

        [OrderedEnum]
        [CustomComboInfo("王权剑 => 圣灵", "如果已经有神圣魔法效果提高效果，则将王权剑替换为圣灵。（会在王权剑前插入一个圣灵保证Buff不会被覆盖）", PLD.JobID, PLD.RoyalAuthority, PLD.RageOfHalone)]
        PaladinRoyalAuthorityNotBurstStrikeFeature = 1919,

        [OrderedEnum]
        [CustomComboInfo("王权剑 => 赎罪剑", "当处于忠义之剑状态时，将王权剑替换为赎罪剑。（现在没有忠义之剑，变成赎罪剑三个触发连击了）", PLD.JobID, PLD.RageOfHalone, PLD.RoyalAuthority)]
        PaladinRoyalAuthorityAtonementFeature = 1903,

        [OrderedEnum]
        [CustomComboInfo("投盾 => 圣灵", "当处于神圣魔法效果提高效果时，将投盾替换为圣灵。", PLD.JobID, PLD.ShieldLob)]
        PaladinShieldLobToNotBurstStrikeFeature = 1921,

        [OrderedEnum]
        [ParentCombo(PaladinShieldLobToNotBurstStrikeFeature)]
        [CustomComboInfo("投盾 => 圣灵 不动功能", "如果当前没有移动，那么即使不处于神圣魔法效果提高，也将投盾替换为圣灵。", PLD.JobID, PLD.ShieldLob)]
        PaladinShieldLobToNotBurstStrikeOption = 1922,

        /*[OrderedEnum]
        [CustomComboInfo("Holy Spirit to Atonement", "Replace Holy Spirit with Atonement while Divine Might or Requiescat are not up.", PLD.JobID, PLD.NotBurstStrike)]
        PaladinNotBurstStrikeToAtonement = 1916,*/

        [OrderedEnum]
        [CustomComboInfo("日珥斩连击", "将日珥斩替换为它的连击链：全蚀斩 - 日珥斩", PLD.JobID, PLD.Prominence, PLD.TotalEclipse)]
        PaladinProminenceCombo = 1904,

        [OrderedEnum]
        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("日珥斩连击 => 圣环", "如果已经有神圣魔法效果提高效果，则将日珥斩替换为圣环。（会在日珥斩前插入一个圣环保证Buff不会被覆盖）", PLD.JobID)]
        PaladinNotFatedCircleOvercapFeature = 1918,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(PaladinProminenceCombo)]
        [CustomComboInfo("日珥斩连击 - 绑定至全蚀斩", "将全蚀斩替换为它的连击链，而非日珥斩。", PLD.JobID, PLD.Prominence, PLD.TotalEclipse)]
        PaladinEvilProminenceCombo = 1907,

        [OrderedEnum]
        [CustomComboInfo("安魂祈祷/绝对统治 => 悔罪", "当激活时，将安魂祈祷/绝对统治替换为悔罪，包括整个悔罪连击。", PLD.JobID, PLD.Requiescat, PLD.Imperator)]
        PaladinRequiescatCombo = 1905,

        [OrderedEnum]
        [ParentCombo(PaladinRequiescatCombo)]
        [CustomComboInfo("安魂祈祷 等级同步", "如果悔罪尚不可用、或已经使用但后续连击尚未解锁，则将安魂祈祷替换为圣灵。", PLD.JobID, PLD.Requiescat, PLD.Imperator)]
        PaladinRequiescatComboSpirit = 1917,

        [OrderedEnum]
        [CustomComboInfo("圣灵/圣环 => 悔罪", "当悔罪可用时，将圣灵和圣环替换为悔罪。（也会变为荣耀之剑）", PLD.JobID, PLD.NotBurstStrike, PLD.NotFatedCircle)]
        PaladinConfiteorFeature = 1906,

        [OrderedEnum]
        [CustomComboInfo("AOE连击 => 悔罪", "当安魂祈祷/绝对统治激活时，将AOE连击技能替换为悔罪，及其后续连击。", PLD.JobID, PLD.TotalEclipse, PLD.Prominence)]
        PaladinNotFatedCircleFeature = 1910,

        [OrderedEnum]
        [CustomComboInfo("圣灵 => 圣环", "如果你正在使用AOE连击，则将圣灵替换为圣环。", PLD.JobID, PLD.NotBurstStrike)]
        PaladinHolySpiritToHolyCircleFeature = 1914,

        [OrderedEnum]
        [CustomComboInfo("战逃反应 => 安魂祈祷/绝对统治", "当战逃反应生效时，将战逃反应替换为安魂祈祷/绝对统治。（也会变为荣耀之剑）\n如果战逃反应现在是沥血剑的话，替换只会在GCD转圈期间启用。（不会卡GCD）", PLD.JobID, PLD.NotNoMercy)]
        PaladinNotNoMercyToRequiescat = 1920,

/*        [OrderedEnum]
        [CustomComboInfo("Fight or Flight to Goring Blade", "Replace Fight or Flight with Goring Blade while the effect is active.", PLD.JobID, PLD.NotNoMercy)]
        PaladinNotNoMercyToNotSonicBreak = 1915,*/

        [OrderedEnum]
        [CustomComboInfo("盾牌猛击 => 下踢", "当下踢冷却完毕时，将盾牌猛击替换为下踢。\n可以和防护职业插言功能一起使用。", PLD.JobID, PLD.ShieldBash)]
        PaladinLowBashFeature = 1911,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("深奥之灵/偿赎剑 <=> 厄运流转 自动切换", "将深奥之灵/偿赎剑和厄运流转替换为你当前能够使用的那个。（或者CD最快的那个）", PLD.JobID, PLD.SpiritsWithin, PLD.Expiacion, PLD.CircleOfScorn)]
        PaladinScornfulSpiritsFeature = 1908,

        #endregion
        // ====================================================================================
        #region PICTOMANCER

        // last used enum: 4210

        [OrderedEnum]
        [CustomComboInfo("减色混合 连击切换", "如果当前正处于减色混合状态，则将你的普通连击替换为减色混合连击。", PCT.JobID, PCT.FireInRed, PCT.Fire2InRed)]
        PictSubFeature = 4201,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(PictSubFeature)]
        [CustomComboInfo("调色值防溢出", "如果你的下一个技能将会使调色值溢出，则将你的连击技能替换为减色混合。", PCT.JobID, PCT.FireInRed, PCT.Fire2InRed)]
        PictSubOvercapOption = 4207,

        [OrderedEnum]
        [ParentCombo(PictSubFeature)]
        [CustomComboInfo("连击技能 => 移动功能", "如果在没有即刻咏唱时移动，则将你的连击技能替换为神圣之白。", PCT.JobID, PCT.FireInRed, PCT.Fire2InRed)]
        PictSubMovementOption = 4208,

        [OrderedEnum]
        [CustomComboInfo("神圣之白 => 彗星之黑", "如果彗星之黑可用，则将神圣之白替换为彗星之黑。", PCT.JobID, PCT.HolyInWhite)]
        PictCometFeature = 4202,

        [OrderedEnum]
        [CustomComboInfo("彩绘 => 构想", "如果对应的彩绘已经发动，则将你对应的的彩绘技能替换为构想技能。\n如：绒球彩绘 => 绒球构想、翅膀彩绘 => 翅膀构想、重锤彩绘 => 重锤构想", PCT.JobID, PCT.CreatureMotif, PCT.WeaponMotif, PCT.LandscapeMotif)]
        PictMotifFeature = 4204,

        [OrderedEnum]
        [CustomComboInfo("重锤构想 => 重锤敲章", "如果可以的话，将重锤构想替换为重锤敲章。（及其之后重锤连击）", PCT.JobID, PCT.SteelMuse)]
        PictHammerFeature = 4205,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("减色混合 => 彗星之黑", "如果已经处于色调反转状态，则将减色混合替换为彗星之黑。（以防止Buff覆盖导致丢失一个彗星之黑）", PCT.JobID, PCT.SubtractivePalette)]
        PictSubCometFeature = 4210,

        [OrderedEnum]
        [CustomComboInfo("星空构想 => 天星棱光", "如果天星棱光可用，则将星空构想替换为天星棱光。", PCT.JobID, PCT.ScenicMuse)]
        PictStarFeature = 4206,

        #endregion
        // ====================================================================================
        #region REAPER

        // latest enum: 3926

        [OrderedEnum]
        [CustomComboInfo("切割连击", "将切割替换为它的连击链：切割 - 增盈切割 - 地狱切割", RPR.JobID, RPR.Slice, RPR.InfernalSlice)]
        ReaperSliceCombo = 3901,

        [OrderedEnum]
        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("切割连击 - 绑定至地狱切割", "将地狱切割替换为它的连击链，而非切割。", RPR.JobID, RPR.InfernalSlice)]
        ReaperInfernalSliceCombo = 3910,

        [OrderedEnum]
        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("切割连击 => 勾刃", "当你在近战攻击的范围之外时，将切割连击替换为勾刃。", RPR.JobID, RPR.Slice)]
        ReaperHarpeSliceFeature = 3921,

        [OrderedEnum]
        [CustomComboInfo("旋转钐割连击", "将旋转钐割替换为它的连击链：旋转钐割 - 噩梦钐割", RPR.JobID, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperScytheCombo = 3902,

        [OrderedEnum]
        [ParentCombo(ReaperScytheCombo)]
        [CustomComboInfo("旋转钐割连击 - 绑定至噩梦钐割", "将噩梦钐割替换为它的连击链，而非旋转钐割。", RPR.JobID, RPR.NightmareScythe)]
        ReaperNightmareScytheCombo = 3911,

        [OrderedEnum]
        [CustomComboInfo("夜游魂衣 => 团契", "当处于化身附体状态时，将夜游魂衣替换为团契。", RPR.JobID, RPR.Enshroud)]
        ReaperEnshroudCommunioFeature = 3903,

        [OrderedEnum]
        [CustomComboInfo("隐匿挥割&束缚挥割 => 绞决/缢杀&断首", "当拥有妖异之镰状态效果时，将隐匿挥割替换为绞决/缢杀中受到效果提高强化的那个。束缚挥割则替换为断首。", RPR.JobID, RPR.BloodStalk, RPR.GrimSwathe)]
        ReaperStalkingSwathingFeature = 3917,

        [OrderedEnum]
        [CustomComboInfo("切割/死亡之影 => 绞决/缢杀", "当拥有妖异之镰状态效果、或处于化身附体状态时，将切割和死亡之影替换为绞决和缢杀。", RPR.JobID, RPR.Slice, RPR.ShadowOfDeath, RPR.SoulSlice)]
        ReaperGibbetGallowsFeature = 3904,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("交换绞决和缢杀的位置", "反过来将切割替换为缢杀、死亡之影替换为绞决。", RPR.JobID, RPR.Slice, RPR.ShadowOfDeath, RPR.SoulSlice)]
        ReaperGibbetGallowsSwap = 3918,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("绞决 - 缢杀连击", "将绞决和缢杀替换为受到效果提高强化的那个，但仅在连击中生效。在经过增强后，它会被从死亡之影/灵魂切割中移除。\n上一句的原文为：It is removed from Shadow of Death/Soul Slice as a result after one is enhanced，我没看懂。", RPR.JobID, RPR.Gibbet, RPR.Gallows)]
        ReaperGibbetGallowsComboOption = 3925,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("死亡之影由灵魂切割替代", "让灵魂切割取代死亡之影，成为被绞决/缢杀替换的那个。", RPR.JobID, RPR.Slice, RPR.ShadowOfDeath, RPR.SoulSlice)]
        ReaperGibbetGallowsSoulSliceOption = 3919,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsSoulSliceOption)]
        [CustomComboInfo("绞决/缢杀 解除附体连击", "将虚无收割和交错收割重新绑定至灵魂切割和切割连击。", RPR.JobID, RPR.Slice)]
        ReaperGibbetGallowsShroudOption = 3920,

        [OrderedEnum]
        [CustomComboInfo("绞决 <=> 缢杀 自动切换", "将绞决和缢杀自动替换为他们中受到效果提高强化的那个。", RPR.JobID, RPR.Gibbet, RPR.Gallows)]
        ReaperGibbetGallowsOption = 3905,

        [OrderedEnum]
        [ParentCombo(ReaperGibbetGallowsOption)]
        [CustomComboInfo("仅在化身附体时切换", "仅在化身附体时自动切换绞决和缢杀。（虚无收割和交错收割）", RPR.JobID, RPR.Gibbet, RPR.Gallows)]
        ReaperGibbetGallowsShroudOnlyOption = 3924,

        [OrderedEnum]
        [CustomComboInfo("旋转钐割 => 断首", "当拥有妖异之镰状态效果、或处于化身附体状态时，将旋转钐割替换为断首。", RPR.JobID, RPR.SpinningScythe)]
        ReaperGuillotineFeature = 3909,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("团契自动切换", "当仅剩一档夜游魂时，将绞决/缢杀/断首替换为团契。", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.Gibbet, RPR.Gallows, RPR.Guillotine, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperComboCommunioFeature = 3906,

        [OrderedEnum]
        [CustomComboInfo("缢杀/绞决&断首 => 夜游魂切割&夜游魂钐割", "当你拥有2档或以上虚无魂时，将缢杀/绞决和断首分别替换为夜游魂切割和夜游魂钐割。", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.Gibbet, RPR.Gallows, RPR.Guillotine, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperLemureFeature = 3912,

        [OrderedEnum]
        [CustomComboInfo("缢杀/绞决/断首 => 祭牲", "当拥有虚无魂状态效果、且祭牲可用时，在GCD旋转期间将缢杀/绞决/断首替换为祭牲。", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.Gibbet, RPR.Gallows, RPR.Guillotine, RPR.SpinningScythe, RPR.NightmareScythe)]
        ReaperSacrificiumFeature = 3926,

        [OrderedEnum]
        [CustomComboInfo("神秘环 => 大丰收", "当你拥有死亡祭品状态效果时，将神秘环替换为大丰收。", RPR.JobID, RPR.ArcaneCircle)]
        ReaperHarvestFeature = 3907,

        [OrderedEnum]
        [CustomComboInfo("地狱入境/地狱出境 => 回退", "当处于回退预备状态时，同时将地狱入境和地狱出境替换为回退。（而非原版的只替换另一个）\n你可以在下面设置一个可选的延迟：", RPR.JobID, RPR.HellsIngress, RPR.HellsEgress)]
        ReaperRegressFeature = 3908,

        [OrderedEnum]
        [CustomComboInfo("隐匿挥割 => 暴食", "如果暴食已经冷却完毕，则将隐匿挥割替换为暴食。", RPR.JobID, RPR.BloodStalk)]
        ReaperBloodStalkFeature = 3913,

        [OrderedEnum]
        [CustomComboInfo("束缚挥割 => 暴食", "如果暴食已经冷却完毕，则将束缚挥割替换为暴食。", RPR.JobID, RPR.GrimSwathe)]
        ReaperGrimSwatheFeature = 3914,

        [OrderedEnum]
        [CustomComboInfo("隐匿挥割 => 束缚挥割", "如果你正在使用AOE连击，则将隐匿挥割替换为束缚挥割。", RPR.JobID, RPR.BloodStalk)]
        ReaperBloodStalkToGrimSwatheFeature = 3922,

        [OrderedEnum]
        [CustomComboInfo("灵魂切割 => 灵魂钐割", "如果你正在使用AOE连击，则将灵魂切割替换为灵魂钐割。", RPR.JobID, RPR.SoulSlice)]
        ReaperSoulSliceToSoulScytheFeature = 3923,

        [OrderedEnum]
        [CustomComboInfo("播种魂提醒", "如果你在战斗之外、且不处于播种魂状态，则将你的切割连击、灵魂切割和死亡之影替换为播种魂。", RPR.JobID, RPR.Slice, RPR.InfernalSlice, RPR.ShadowOfDeath, RPR.WaxingSlice, RPR.SoulSlice)]
        ReaperSoulsowReminderFeature = 3915,

        [OrderedEnum]
        [CustomComboInfo("Soulsow Feature", "如果你有选中的目标、且处于播种魂状态，则将旋转钐割替换为收获月。反之如果你没有选中的目标且不处于播种魂时，将死亡之影替换为播种魂。", RPR.JobID, RPR.SpinningScythe, RPR.NightmareScythe, RPR.ShadowOfDeath)]
        ReaperSoulsowFeature = 3916,

        #endregion
        // ====================================================================================
        #region RED MAGE

        // latest enum: 3526

        [OrderedEnum]
        [CustomComboInfo("连攻连击（魔三连）", "将连攻替换为它的连击链：(魔)回刺 - (魔)交击斩 - (魔)连攻。", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeCombo = 3502,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("连攻连击锁定功能", "如果你的平衡量谱不到50/50，且赤核爆已经解锁，则将连攻连击替换为赤核爆。（此时的赤核爆无法使用，以防止打出咸鱼近战连击）", RDM.JobID, RDM.Redoublement)]
        RedMageComboReminderFeature = 3515,

        [OrderedEnum]
        [ParentCombo(RedMageComboReminderFeature)]
        [CustomComboInfo("连攻连击锁定 - 用核爆替换", "用核爆替换赤核爆，以避免队列问题。", RDM.JobID, RDM.Redoublement)]
        RedMageComboReminderOption = 3517,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("连攻连击 => 划圆斩", "如果你正在使用赤震雷/赤烈风，则将连攻连击替换为划圆斩。", RDM.JobID, RDM.Redoublement)]
        RedMageComboToMoulinetFeature = 3521,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("魔六连", "在获得三档魔元集后，将连攻/划圆斩替换为后续连击。（赤核爆/赤神圣 - 焦热 - 决断）\n如果使用这个选项，连攻和划圆斩将固定被替换为赤核爆。即如果你需要使用赤神圣，那么必须手动选择。", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeComboPlus = 3508,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeComboPlus)]
        [CustomComboInfo("魔六连 - 固定使用赤神圣", "如果你已经解锁赤神圣，则将上面选项中的连攻和划圆斩固定替换为赤神圣，而非赤核爆。（解锁赤神圣之前仍会将其替换为赤核爆）", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeComboPlusVerholy = 3509,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("连攻 => 魔续斩", "当你在近战攻击的范围之外时，将连攻连击替换为魔续斩。（只会替换为魔续斩）", RDM.JobID, RDM.Redoublement)]
        RedMageMeleeComboReprise = 3518,

        [OrderedEnum]
        [ParentCombo(RedMageMeleeComboReprise)]
        [CustomComboInfo("在平衡量谱不足50/50时也替换", "如果你的平衡量谱不到50/50的话，也将连攻连击替换为魔续斩。（同样只会替换为魔续斩）", RDM.JobID, RDM.Redoublement)]
        RedMageMeleeComboRepriseOption = 3519,

        [OrderedEnum]
        [SecretCustomCombo]
        [ParentCombo(RedMageMeleeCombo)]
        [CustomComboInfo("魔六连++", "在获得三档魔元集后，将连攻/划圆斩替换为后续连击。（赤核爆/赤神圣 - 焦热 - 决断）\n如果使用这个选项，将会自动选择赤核爆/赤神圣中更合适的那个。（而非上面选项的固定替换）", RDM.JobID, RDM.Redoublement, RDM.Moulinet)]
        RedMageMeleeComboPlusPlus = 3503,

        [OrderedEnum]
        [CustomComboInfo("赤火炎/赤飞石 => 摇荡/震荡/激荡", "如果没有对应的触发，则将赤火炎/赤飞石替换为摇荡/震荡/激荡。\n在84级-93级这个等级区间内，触发技能的威力（340威力+5魔元）反常的不如激荡（360威力+2*2魔元）高。因此在84级-93级之间时，赤火炎和赤飞石会被固定替换为激荡。", RDM.JobID, RDM.Verstone, RDM.Verfire, RDM.Verthunder, RDM.Verthunder3)]
        RedMageVerprocCombo = 3504,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [ConflictingCombos(RedMageVerprocComboVerstoneOption)]
        [CustomComboInfo("不要替换赤火炎", "赤火炎不会被替换为激荡。（或任何与它们有关的技能）", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboVerfireOption = 3524,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [ConflictingCombos(RedMageVerprocComboVerfireOption)]
        [CustomComboInfo("不要替换赤飞石", "赤飞石不会被替换为激荡。（或任何与它们有关的技能）", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboVerstoneOption = 3525,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [CustomComboInfo("赤火炎/赤飞石 => 赤暴雷/赤暴风", "当处于连续咏唱、即刻咏唱、或失传连锁咏唱状态时，将赤火炎和赤飞石分别替换为赤闪雷/赤暴雷和赤疾风/赤暴风。\n虽然作者没写，但是促进也会触发这个效果。", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboPlus = 3505,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("起手：赤飞石 => 赤疾风/赤暴风", "当不处于战斗状态时，将赤飞石替换为赤疾风/赤暴风。", RDM.JobID, RDM.Verstone)]
        RedMageVerprocOpenerFeatureStone = 3506,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("起手：赤火炎 => 赤闪雷/赤暴雷", "当不处于战斗状态时，将赤火炎替换为赤闪雷/赤暴雷。", RDM.JobID, RDM.Verfire)]
        RedMageVerprocOpenerFeatureFire = 3507,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("起手：使用赤闪雷/赤暴雷而非赤火炎", "使用赤闪雷/赤暴雷作为上述触发替换的基础技能，而非赤火炎。\n这样你就可以带着促进Buff使用赤火炎，来使用一个更优化的起手。（完全没明白这是什么意思，原文如下：）\nThis is so you can use Verfire(赤火炎) by itself even with acceleration(促进) up to use a slightly more optimal opener.", RDM.JobID, RDM.Verthunder)]
        RedMageVerprocComboVerthunderOption = 3526,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocComboPlus)]
        [CustomComboInfo("赤火炎/赤飞石 => 赤暴雷/赤暴风 - 额外选项", "如果你已经拥有赤飞石预备/赤火炎预备状态的话，对应的短读条技能将不会被替换为其相对的长读条技能（赤暴雷/赤暴风），除非此时两个触发均可使用。\n与当前的赤魔起手略微不兼容。", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboPlusOption = 3523,

        [OrderedEnum]
        [ParentCombo(RedMageVerprocCombo)]
        [CustomComboInfo("赤火炎/赤飞石 => 魔续斩 移动功能", "如果在没有任何瞬发技能时移动，则将赤火炎/赤飞石替换为魔续斩。（如果魔续斩可以使用的话）", RDM.JobID, RDM.Verstone, RDM.Verfire)]
        RedMageVerprocComboReprise = 3520,

        [OrderedEnum]
        [ConflictingCombos(RedMageVerprocComboPlus)]
        [CustomComboInfo("赤暴雷/赤暴风 => 焦热", "当焦热可用的时候，将赤暴雷和赤暴风替换为焦热。\n这个功能已经被包含在上面“赤火炎/赤飞石 => 赤暴雷/赤暴风”功能中，这个选项是为那些不想启用那个功能的人准备的。", RDM.JobID, RDM.Veraero, RDM.Verthunder, RDM.Veraero3, RDM.Verthunder3)]
        RedMageVeraeroVerThunderScorchFeature = 3510,

        [OrderedEnum]
        [CustomComboInfo("赤魔法师AOE连击", "当处于连续咏唱或即刻咏唱状态时，将赤震雷和赤烈风替换为散碎/冲击。（其他可以瞬发的Buff应该也可以，未测试）", RDM.JobID, RDM.Veraero2, RDM.Verthunder2)]
        RedMageAoECombo = 3501,

        [OrderedEnum]
        [CustomComboInfo("划圆斩锁定功能", "如果你的平衡量谱不到50/50，且赤核爆已经解锁，则通过将划圆斩替换为医治来防止你打不够三发魔划圆斩。", RDM.JobID, RDM.Moulinet)]
        RedMageMoulinetReminderFeature = 3514,

        [OrderedEnum]
        [CustomComboInfo("鼓励 => 魔元化", "如果鼓励正在冷却、而魔元化已经冷却完毕，则将鼓励替换为魔元化。", RDM.JobID, RDM.Embolden)]
        RedMageEmboldenFeature = 3511,

        [OrderedEnum]
        [CustomComboInfo("鼓励锁定功能", "如果身上的鼓励效果剩余时间超过3秒，则锁定鼓励，以防止Buff被覆盖。", RDM.JobID, RDM.Embolden)]
        RedMageEmboldenLockoutFeature = 3522,

        [OrderedEnum]
        [CustomComboInfo("促进 => 即刻咏唱", "如果促进正在冷却、而即刻咏唱已经冷却完毕，则将促进替换为即刻咏唱。", RDM.JobID, RDM.Acceleration)]
        RedMageAccelerationFeature = 3512,

        [OrderedEnum]
        [SecretCustomCombo]
        [CustomComboInfo("飞刺 => 六分反击", "如果飞刺正在冷却、而六分反击已经冷却完毕，则将飞刺替换为六分反击。", RDM.JobID, RDM.Fleche)]
        RedMageContreSixteFeature = 3513,

        [OrderedEnum]
        [CustomComboInfo("醒梦提醒（赤魔）", "当你的MP小于等于以下设置值、且醒梦已经冷却完毕时，将你所有正在冷却、非职能、且没有积蓄次数的能力技替换为醒梦。", RDM.JobID, RDM.Embolden, RDM.Manafication, RDM.Fleche, RDM.ContreSixte)]
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
        [CustomComboInfo("暴风斩连击", "将暴风斩替换为它的连击链：重劈 - 凶残裂 - 暴风斩", WAR.JobID, WAR.StormsPath)]
        WarriorStormsPathCombo = 2101,

        [OrderedEnum]
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("暴风斩 => 暴风碎", "如果身上没有战场风暴效果，则将连击中的暴风斩替换为暴风碎。\n因为你仍然需要在战场风暴效果结束之前手动补上它，所以这既不是一个按钮替换功能，也不是Buff自动保持功能。", WAR.JobID, WAR.StormsPath)]
        WarriorStormsPathEyeFeature = 2116,

        [OrderedEnum]
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("暴风斩连击 => 飞斧", "当你在近战攻击的范围之外时，将暴风斩连击替换为飞斧。", WAR.JobID, WAR.StormsPath)]
        WarriorStormsPathahawkFeature = 2110,

        [OrderedEnum]
        [CustomComboInfo("暴风碎连击", "将暴风碎替换为它的连击链：重劈 - 凶残裂 - 暴风碎", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeCombo = 2102,

        [OrderedEnum]
        [ParentCombo(WarriorStormsEyeCombo)]
        [ConflictingCombos(WarriorStormsEyeslaughtFeature)]
        [CustomComboInfo("暴风碎连击 => 飞斧", "当你在近战攻击的范围之外时，将暴风碎连击替换为飞斧。", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeahawkFeature = 2112,

        [OrderedEnum]
        [ParentCombo(WarriorStormsEyeCombo)]
        [ConflictingCombos(WarriorStormsEyeslaughtFeature)]
        [CustomComboInfo("暴风碎连击 - 飞斧替代功能", "如果连击还没到暴风碎，则将暴风碎替换为飞斧。", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeHawkReplacementFeature = 2113,

        [OrderedEnum]
        [ParentCombo(WarriorStormsEyeCombo)]
        [ConflictingCombos(WarriorStormsEyeHawkReplacementFeature, WarriorStormsEyeahawkFeature)]
        [CustomComboInfo("暴风碎连击 => 猛攻", "如果连击还没到暴风碎、或者你在近战攻击的范围之外，则将暴风碎替换为猛攻。", WAR.JobID, WAR.StormsEye)]
        WarriorStormsEyeslaughtFeature = 2117,

        [OrderedEnum]
        [CustomComboInfo("秘银暴风连击", "将秘银暴风替换为它的连击链：超压斧 - 秘银暴风", WAR.JobID, WAR.MythrilTempest)]
        WarriorMythrilTempestCombo = 2103,

        [OrderedEnum]
        [CustomComboInfo("超压斧连击", "将超压斧替换为它的连击链：超压斧 - 秘银暴风", WAR.JobID, WAR.Overpower)]
        WarriorOverpowerCombo = 2104,

        [OrderedEnum]
        [CustomComboInfo("秘银暴风连击 => 地毁人亡", "如果兽魂即将溢出，则将秘银暴风连击替换为地毁人亡。（以防止兽魂溢出）", WAR.JobID, WAR.MythrilTempest, WAR.StormsEye, WAR.StormsPath)]
        WarriorGaugeOvercapFeature = 2105,

        [OrderedEnum]
        [CustomComboInfo("原初的解放：AOE连击 => 地毁人亡", "在原初的解放生效期间，将秘银暴风连击替换为地毁人亡。", WAR.JobID, WAR.MythrilTempest)]
        WarriorInnerReleaseFeature = 2106,

        [OrderedEnum]
        [ParentCombo(WarriorInnerReleaseFeature)]
        [CustomComboInfo("原初的解放 飞斧选项", "在原初的解放生效期间，将暴风碎替换为飞斧。", WAR.JobID, WAR.MythrilTempest, WAR.StormsPath)]
        WarriorInnerReleaseahawkOption = 2111,

        [OrderedEnum]
        [CustomComboInfo("原初的勇猛 -> 原初的直觉", "当等级同步至76级以下时，将原初的勇猛替换为原初的直觉。", WAR.JobID, WAR.NascentFlash)]
        WarriorNascentFlashFeature = 2107,

        [OrderedEnum]
        [CustomComboInfo("原初的解放 => 蛮荒崩裂", "如果蛮荒崩裂可用，则将原初的解放替换为蛮荒崩裂。", WAR.JobID, WAR.Berserk, WAR.InnerRelease)]
        WarriorPrimalRendFeature = 2108,

        [OrderedEnum]
        [CustomComboInfo("秘银暴风连击 => 蛮荒崩裂", "如果蛮荒崩裂可用，则将秘银暴风连击替换为蛮荒崩裂。", WAR.JobID, WAR.MythrilTempest)]
        WarriorMythrilRendFeature = 2109,

        [OrderedEnum]
        [CustomComboInfo("裂石飞环 => 地毁人亡", "如果你正在使用AOE连击，则将原初之魂/裂石飞环替换为钢铁旋风/地毁人亡。", WAR.JobID, WAR.FellCleave, WAR.InnerBeast)]
        WarriorFellCleaveToDecimateFeature = 2115,

        [OrderedEnum]
        [CustomComboInfo("动乱 => 群山隆起", "如果你正在使用AOE连击，则将动乱替换为群山隆起。", WAR.JobID, WAR.Upheaval)]
        WarriorUporgyFeature = 2114,

        [OrderedEnum]
        [CustomComboInfo("动乱/群山隆起 => 原初的震怒", "如果原初的震怒可用，则将动乱和群山隆起替换为原初的震怒。", WAR.JobID, WAR.Upheaval, WAR.Orogeny)]
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
        [CustomComboInfo("醒梦提醒（白魔）", "当你的MP小于等于以下设置值、且醒梦已经冷却完毕时，将你所有正在冷却、非职能、且没有积蓄次数的能力技替换为醒梦。", WHM.JobID, WHM.PresenceOfMind, WHM.Assize, WHM.Temperance, WHM.PlenaryIndulgence, WHM.Tetragrammaton, WHM.Asylum, WHM.Aquaveil, WHM.LiturgyOfTheBell, WHM.Benediction)]
        WhiteMageLucidReminderFeature = 2406,

        #endregion
        // ====================================================================================
    }
}
