using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoSingleton<CardDatabase>
{
    public  List<EquipmentCard> equipmentCardList = new List<EquipmentCard>();
    public  List<MonsterCard> monsterCardList = new List<MonsterCard>();
    private void Awake()
    {
        equipmentCardList.Add(new EquipmentCard( 0, "      ",     10, 10, "使指定的心魔顺时针与下一个心魔互换位置",                                                Resources.Load<Sprite>("EquipmentImages/00"),  false));
        equipmentCardList.Add(new EquipmentCard( 1, "      ",     10, 10, "使指定的心魔顺时针与下一个相间的心魔互换位置",                                          Resources.Load<Sprite>("EquipmentImages/01"),  false));
        equipmentCardList.Add(new EquipmentCard( 2, "红宝石",     10,  2, "下次攻击对目标攻击2次",                                                                 Resources.Load<Sprite>("EquipmentImages/02"),  false));
        equipmentCardList.Add(new EquipmentCard( 3, "蓝宝石",     10,  2, "选择一名心魔使其本回合免疫任何伤害",                                                    Resources.Load<Sprite>("EquipmentImages/03"),  false));
        equipmentCardList.Add(new EquipmentCard( 4, "橙水晶",     10,  2, "下次攻击伤害分摊至相邻的心魔，一回合限用一次",                                          Resources.Load<Sprite>("EquipmentImages/04"),  false));
        equipmentCardList.Add(new EquipmentCard( 5, "黄水晶",     10,  2, "下次攻击伤害分摊至相间的心魔，一回合限用一次",                                          Resources.Load<Sprite>("EquipmentImages/05"),  false));
        equipmentCardList.Add(new EquipmentCard( 6, "橙水晶",     10,  3, "下次攻击间位获得与被攻击目标同样的伤害,一回合限用一次",                                 Resources.Load<Sprite>("EquipmentImages/06"),  false));
        equipmentCardList.Add(new EquipmentCard( 7, "黄水晶",     10,  3, "下次攻击邻位获得与被攻击目标同样的伤害，一回合限用一次",                                Resources.Load<Sprite>("EquipmentImages/01"),  false));        
        equipmentCardList.Add(new EquipmentCard( 8, "酒精",       10,  2, "被击中的目标本回合内若受到“爆炸伤害”被添加3层“灼伤”",                               Resources.Load<Sprite>("EquipmentImages/08"),  false));
        equipmentCardList.Add(new EquipmentCard( 9, "燃烧的烟头", 10,100, "场上所有带有“灼伤”效果的敌人每回合受到的“灼伤”伤害+6”",                            Resources.Load<Sprite>("EquipmentImages/09"),  true));
        equipmentCardList.Add(new EquipmentCard(10, "悲鸣号角",   10,  2, "被击中的目标本回合内若受到“爆炸伤害”被添加1层“眩晕”",                               Resources.Load<Sprite>("EquipmentImages/10"),  false));
        equipmentCardList.Add(new EquipmentCard(11, "花纹手绢",   10,100, "对眩晕态的敌人攻击增加1倍",                                                             Resources.Load<Sprite>("EquipmentImages/01"),  true));
        equipmentCardList.Add(new EquipmentCard(12, "断裂铅笔",   10,  2, "对一个目标造成6点伤害，若目标处在眩晕态造成16点伤害",                                   Resources.Load<Sprite>("EquipmentImages/12"),  false));
        equipmentCardList.Add(new EquipmentCard(13, "催眠怀表",   10,  1, "令一名心魔眩晕一回合",                                                                  Resources.Load<Sprite>("EquipmentImages/01"),  false));
        equipmentCardList.Add(new EquipmentCard(14, "纸杯蛋糕",   10, 10, "休息节点回复的情绪增至15点（初始10点）",                                                Resources.Load<Sprite>("EquipmentImages/01"),  true));
        equipmentCardList.Add(new EquipmentCard(15, "幸运草",     10, 10, "情绪最大值扩充15",                                                                      Resources.Load<Sprite>("EquipmentImages/15"),  true));
        equipmentCardList.Add(new EquipmentCard(16, "秘密日记本", 10,  3, "丢弃所有手牌，重新抽一次牌",                                                            Resources.Load<Sprite>("EquipmentImages/16"),  false));
        equipmentCardList.Add(new EquipmentCard(17, "        ",   10,  3, "情绪回复15点，血量上限降低5点",                                                         Resources.Load<Sprite>("EquipmentImages/01"),  false));
        equipmentCardList.Add(new EquipmentCard(18, "面包",       10,  2, "情绪回复15点",                                                                          Resources.Load<Sprite>("EquipmentImages/18"),  false));
        equipmentCardList.Add(new EquipmentCard(19, "破碎时光",   10,  3, "每击杀1名心魔，额外回复3点情绪",                                                        Resources.Load<Sprite>("EquipmentImages/19"),  true));
        equipmentCardList.Add(new EquipmentCard(20, "结痂",       10,  3, "每回合开始获得10点护甲",                                                                Resources.Load<Sprite>("EquipmentImages/20"),  true));
        equipmentCardList.Add(new EquipmentCard(21, "鸭舌帽",     10,  3, "护甲每回合不再清空",                                                                    Resources.Load<Sprite>("EquipmentImages/21"),  true));
        equipmentCardList.Add(new EquipmentCard(22, "      ",     10,  1, "恢复50点情绪",                                                                          Resources.Load<Sprite>("EquipmentImages/01"),  false));
        equipmentCardList.Add(new EquipmentCard(23, "玩具盾牌",   10, 10, "获得60点护甲",                                                                          Resources.Load<Sprite>("EquipmentImages/23"),  false));
        equipmentCardList.Add(new EquipmentCard(24, "    ",       10, 10, "回合末攻击伤害 + 8",                                                                    Resources.Load<Sprite>("EquipmentImages/01"),  true));
        equipmentCardList.Add(new EquipmentCard(25, "临终遗言",   10, 10, "每击杀2名心魔，增加1层反击",                                                            Resources.Load<Sprite>("EquipmentImages/25"),  true));
        equipmentCardList.Add(new EquipmentCard(26, "断裂铅笔",   10,  3, "每受到一次大于4点的伤害，增加一层反击",                                                 Resources.Load<Sprite>("EquipmentImages/01"),  true));
        equipmentCardList.Add(new EquipmentCard(27, "    ",       10,  3, "对一个目标造成13点伤害，邻位受到6点伤害",                                               Resources.Load<Sprite>("EquipmentImages/01"),  false));
        equipmentCardList.Add(new EquipmentCard(28, "玩具弓",     10,  2, "对一个目标造成25点伤害",                                                                Resources.Load<Sprite>("EquipmentImages/28"),  false));
        equipmentCardList.Add(new EquipmentCard(29, "        ",   10,  3, "增加2层反击",                                                                           Resources.Load<Sprite>("EquipmentImages/01"),  false));
        equipmentCardList.Add(new EquipmentCard(30, "        ",   10,  3, "每回合开始获得10点护甲",                                                                Resources.Load<Sprite>("EquipmentImages/30"),  true));
        equipmentCardList.Add(new EquipmentCard(31, "庇佑之物",   10,  2, "自身每有1层恐惧效果，获得8点护甲",                                                      Resources.Load<Sprite>("EquipmentImages/31"),  false));
        equipmentCardList.Add(new EquipmentCard(32, "水果硬糖",   10,  2, "清空所有恐惧",                                                                          Resources.Load<Sprite>("EquipmentImages/01"),  true));
        equipmentCardList.Add(new EquipmentCard(33, "空白容器",    3,  3, "指定一只心魔进行回收，所有数值回归初始状态",                                            Resources.Load<Sprite>("EquipmentImages/01"),  false));
        equipmentCardList.Add(new EquipmentCard(34, "童年伙伴",   10,  3, "每有2层恐惧增加5点攻击力",                                                              Resources.Load<Sprite>("EquipmentImages/34"), true));
        equipmentCardList.Add(new EquipmentCard(35, "弹弓",       10,  2, "每回合增加一次攻击次数",                                                                Resources.Load<Sprite>("EquipmentImages/31"), false));
        equipmentCardList.Add(new EquipmentCard(36, "小马驹",     10,  3, "每放置三个心魔增加一次攻击次数",                                                        Resources.Load<Sprite>("EquipmentImages/01"), true));
        equipmentCardList.Add(new EquipmentCard(37, "小汽车",     10,  3, "每回合增加一次移动次数",                                                                Resources.Load<Sprite>("EquipmentImages/01"), true));
        equipmentCardList.Add(new EquipmentCard(38, "披风",        3,  3, "超出最大情绪上限的情绪回复量的1/2转化为护甲",                                           Resources.Load<Sprite>("EquipmentImages/01"), false));
        equipmentCardList.Add(new EquipmentCard(39, "吾心之声",   10,  2, "选择1名心魔，下次玩家的直接攻击所有相同心魔均受到相同伤害",                             Resources.Load<Sprite>("EquipmentImages/31"), false));
        equipmentCardList.Add(new EquipmentCard(40, "惊喜时刻",   10,  3, "选择1名心魔，场上每有1只相同心魔，下次攻击额外攻击1次",                                 Resources.Load<Sprite>("EquipmentImages/01"), true));
        equipmentCardList.Add(new EquipmentCard(41, "涌泉",       10,  3, "选择1个位置，该位置的所有种类的种子的数量翻倍",                                         Resources.Load<Sprite>("EquipmentImages/01"), true));
        equipmentCardList.Add(new EquipmentCard(42, "饱腹一餐",    3,  3, "清空1个位置上的所有种子，每清空1枚情绪上升6点",                                         Resources.Load<Sprite>("EquipmentImages/01"), false));
        equipmentCardList.Add(new EquipmentCard(43, "黑夜孤火",   10,  2, "为1名心魔添加1层畏火，若心魔具有植物性，添加3层",                                       Resources.Load<Sprite>("EquipmentImages/31"), false));
        




        monsterCardList.Add(new MonsterCard(00, "伤痕",        8,  3,  2,  1, "",                                                                                                                                       Resources.Load<Sprite>("CardImages/00"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(01, "愤怒",        5,  2,  1,  1, "击杀后爆炸,对左右位置的心魔造成8点爆炸伤害",                                                                                             Resources.Load<Sprite>("CardImages/01"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(02, "伤疤",       12,  4,  5,  2, "",                                                                                                                                       Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(03, "伤口",       20,  6,  8,  3, "",                                                                                                                                       Resources.Load<Sprite>("CardImages/03"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(04, "创伤",       30,  8, 13,  4, "",                                                                                                                                       Resources.Load<Sprite>("CardImages/04"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(05, "暴怒",        8,  4,  2,  2, "击杀后爆炸,对左右邻位的心魔造成15点爆炸伤害",                                                                                            Resources.Load<Sprite>("CardImages/05"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(06, "狂怒",       40,  7,  2,  1, "击杀后爆炸,对场上所有心魔均造成50点爆炸伤害,对主角造成15点伤害",                                                                         Resources.Load<Sprite>("CardImages/06"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(07, "嘶叫",        8,  4,  2,  2, "击杀后惨叫,对左右位置的心魔各施加1层眩晕,对玩家施加1层恐惧",                                                                             Resources.Load<Sprite>("CardImages/07"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(08, "悲鸣",        6,  3,  1,  1, "存活时,其间位的心魔攻击力减半"+"\n"+"攻击力随回合数增加",                                                                                Resources.Load<Sprite>("CardImages/08"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(09, "怜悯",        6,  3,  1,  1, "存活时,击杀其邻位的心魔情绪恢复翻倍" + "\n" + "攻击力随回合数增加",                                                                      Resources.Load<Sprite>("CardImages/09"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(10, "掮客",        6,  6,  1,  1, "怪物描述2",                                                                                                                              Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(11, "无奈伤痕",    8,  4,  2,  2, "击杀后下回合从抽牌堆中多抽取2张牌",                                                                                                  Resources.Load<Sprite>("CardImages/11"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(12, "折磨伤痕",    8,  4,  2,  2, "击杀后下回合常规攻击+15",                                                                                                            Resources.Load<Sprite>("CardImages/12"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(13, "痛苦伤痕",    8,  4,  2,  2, "存在场上时情绪每回合不再下降",                                                                                                       Resources.Load<Sprite>("CardImages/13"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(14, "无形",        1,  1,  1,  1, "放置后变身成所在位置对位的心魔",                                                                                                         Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(15, "忍耐",       10,  6,  2,  1, "放置后的3回合内无敌,第3回合结束时爆炸,对相邻心魔造成期间所承受的所有伤害",                                                               Resources.Load<Sprite>("CardImages/15"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(16, "小丑",       25,  8,  5,  1, "每回合攻击时施加X层恐惧(X为场上心魔数)",                                                                                                 Resources.Load<Sprite>("CardImages/16"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(17, "黑夜",       25,  8,  5,  1, "每回合攻击时施加2层恐惧。",                                                                                                              Resources.Load<Sprite>("CardImages/17"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(18, "蝙蝠",       16, 14,  5,  1, "1.每回合攻击时施加1层恐惧\n2.直接攻击对其无效",                                                                                          Resources.Load<Sprite>("CardImages/18"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(19, "焚者",       25,  8,  5,  1, "每回合攻击时施加X层灼伤\n(X为场上心魔数)",                                                                                               Resources.Load<Sprite>("CardImages/19"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(20, "炙鬼",       25, 14,  5,  1, "每回合攻击时施加2层灼伤",                                                                                                                Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(21, "蜘蛛",       33,  8,  5,  1, "每回合攻击时施加1层束缚(下回合抽牌数-1)",                                                                                                Resources.Load<Sprite>("CardImages/21"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(22, "负面本质",   50, 20, 45,  1, "在场上时邻位心魔攻击翻倍",                                                                                                               Resources.Load<Sprite>("CardImages/22"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));                                                              
        monsterCardList.Add(new MonsterCard(23, "冷眼圣子",   50, 20, 45,  1, "每回合为邻位的心魔恢复血量各10点",                                                                                                       Resources.Load<Sprite>("CardImages/23"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));                                                              
        monsterCardList.Add(new MonsterCard(24, "接肢护卫",   70, 20, 45,  1, "每回合为邻位的心魔生成护盾各20点",                                                                                                       Resources.Load<Sprite>("CardImages/24"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));                                                              
        monsterCardList.Add(new MonsterCard(25, "纸醉金迷",   20, 20, 45,  1, "每回合生成50护甲",                                                                                                                       Resources.Load<Sprite>("CardImages/25"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));                                                              
        monsterCardList.Add(new MonsterCard(26, "缄默幽灵",   25, 20, 35,  1, "攻击后生成30护甲并顺时针与邻位的心魔互换。",                                                                                             Resources.Load<Sprite>("CardImages/26"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(27, "自卑2",      40, 24, 35,  1, "攻击后顺时针与间位的心魔互换",                                                                                                           Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(28, "贪婪",       15,  4,  5,  1, "回合开始顺时针吞噬相邻心魔,若其血量大于自身则改变吞噬方向",                                                                              Resources.Load<Sprite>("CardImages/28"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(29, "贪婪2",      35, 16,  8,  1, "回合开始顺时针吞噬相邻心魔,若其血量大于自身则改变吞噬方向",                                                                              Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(30, "分赃",       50, 20, 35,  1, "击杀后在场的所有单位恢复15点血量",                                                                                                       Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(31, "掮客",       12,  6,  5,  1, "存活时下回合抽牌数等于场上空位数",                                                                                                       Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(32, "孵化者",    160, 33, 70,  1, "每回合攻击后在战场任意一空位置召唤一只孪生恶魔",                                                                                         Resources.Load<Sprite>("CardImages/32"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(33, "孪生恶魔",   10,  4,  0,  1, "攻击力=4+场上心魔数",                                                                                                                    Resources.Load<Sprite>("CardImages/33"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(34, "父亲",       35, 16,  8,  1, "怪物描述3",                                                                                                                              Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(35, "堂吉诃德",   50, 20, 35,  1, "主角情绪上升时'堂吉诃德'血量下降相应的量\n主角情绪下降时'堂吉诃德'血量上升相应的量",                                                     Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(36, "焦虑",       20,  8,  2,  1, "击杀后对相邻的怪物添加两层灼伤",                                                                                                         Resources.Load<Sprite>("CardImages/36"), Resources.Load<Sprite>("CardBackgrounds/2"),  false));
        monsterCardList.Add(new MonsterCard(37, "使者",        6,  1,  2,  1, "每次进行换位时添加1张牌到手牌" + "\n" + "攻击力随回合数增加",                                                                            Resources.Load<Sprite>("CardImages/37"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
        monsterCardList.Add(new MonsterCard(38, "嫉妒",        8,  4,  2,  2, "击杀对间位的心魔造成15点爆炸伤害",                                                                                                       Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
        monsterCardList.Add(new MonsterCard(39, "床下恶魔",   40, 12, 30,  1, "每回合增加（20*场上心魔数）点护甲",                                                                                                      Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
        monsterCardList.Add(new MonsterCard(40, "蜉蝣",       35,  1,  5,  1, "击杀后结算界面可选择怪物和装备卡数量+1",                                                                                                 Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
        monsterCardList.Add(new MonsterCard(41, "孤僻者",     80,  8, 40,  1, "攻击力=8*场上心魔数",                                                                                                                    Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
        monsterCardList.Add(new MonsterCard(42, "暴戾魔株",   40, 15, 20,  1, "移动时在其位置留下1枚同化种子。具有植物性。",                                                                                            Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
        monsterCardList.Add(new MonsterCard(43, "残伤魔蔓",   40, 15, 20,  1, "移动时在其位置留下2枚寄生种子。具有植物性。",                                                                                            Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
        monsterCardList.Add(new MonsterCard(44, "残伤魔蔓",   40, 15, 20,  1, "受伤时在自身所在位置留下一层余烬。具有植物性。",                                                                                         Resources.Load<Sprite>("CardImages/02"), Resources.Load<Sprite>("CardBackgrounds/2"), false));
    }                                                                      
    public EquipmentCard RandomEquipmentCard()
    {
        EquipmentCard card = CopyEquipmentCard(Random.Range(0, equipmentCardList.Count));
        return card;
    }
    public MonsterCard RandomMonsterCard()
    {
        MonsterCard card = CopyMonsterCard(Random.Range(0, monsterCardList.Count));
        return card;
    }
    public EquipmentCard CopyEquipmentCard(int _id)
    {
        var equipment = equipmentCardList[_id];
        EquipmentCard copyCard = new EquipmentCard(_id, equipment.cardName, equipment.damage,equipment.summonTimes, equipment.description,
               equipment.thisImage,equipment.isStatic);
        return copyCard;
    }
    public MonsterCard CopyMonsterCard(int _id)
    {
        var monster = monsterCardList[_id];
        MonsterCard copyCard = new MonsterCard(_id, monster.cardName, monster.health, monster.damage,monster.award, monster.summonTimes, monster.description, monster.thisImage, monster.thisBackground,monster.isStatic);
        return copyCard;

    }
}
