using System.Collections;

namespace UmaTest
{
    public class Uma
    {
        private int speed = 1;
        private int stamia = 1;
        private int power = 1;
        private int will = 1;
        private int intelligence = 1;
        private int phystrength = 100;
        private Mood umaMood = Mood.Nomal;
        public readonly string umaName;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (speed < 1)
                {
                    speed = 1;
                }
                else
                {
                    speed = value;
                }
                if (speed > 1200)
                {
                    speed = 1200;
                }

            }
        }//速度
        public int Stamia
        {
            get { return stamia; }
            set
            {
                if (stamia < 1)
                {
                    stamia = 1;
                }
                else
                {
                    stamia = value;
                }
                if (stamia > 1200)
                {
                    stamia = 1200;
                }
            }
        }//耐力
        public int Power
        {
            get { return power; }
            set
            {
                if (power < 1)
                {
                    power = 1;
                }
                else
                {
                    power = value;
                }
                if (power > 1200)
                {
                    power = 1200;
                }
            }
        }//力量
        public int Will
        {
            get { return will; }
            set
            {
                if (will < 1)
                {
                    will = 1;
                }
                else
                {
                    will = value;
                }
                if (will > 1200)
                {
                    will = 1200;
                }
            }
        }//根性
        public int Intelligence
        {
            get { return intelligence; }
            set
            {
                if (intelligence < 1)
                {
                    intelligence = 1;
                }
                else
                {
                    intelligence = value;
                }
                if (intelligence > 1200)
                {
                    intelligence = 1200;
                }
            }
        }//智力
        public int Phystrength
        {
            get { return phystrength; }
            set
            {
                phystrength = value;
                if (phystrength > 100)
                {
                    phystrength = 100;
                }
                if (phystrength < 0)
                {
                    phystrength = 0;
                }
            }
        }//体力
        public Mood UmaMood
        {
            get { return umaMood; }
            set { umaMood = value; }
        }//心情
        public Uma(string name, int Spe, int Sta, int Pow, int Wil, int Inte)
        {
            umaName = name;
            Speed = Spe;
            Stamia = Sta;
            Power = Pow;
            Will = Wil;
            Intelligence = Inte;
        }//构造器
        public void ShowUma()
        {
            Console.WriteLine($"此时数值：名字：{umaName}，速度：{Speed}，耐力：{Stamia}，力量：" +
                $"{Power}，根性：{Will}，智力：{Intelligence}，心情：{UmaMood}，体力：{Phystrength}");
        }//检查状态

        public static LapLength lapLength = LapLength.Mile;//全局设定，赛道长度
        public static bool operator >(Uma u1, Uma u2)
        {
            if (lapLength == LapLength.Short)
            {
                if (u1.Stamia >= 250)
                {
                    if (u2.Stamia >= 250)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 250)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//短距离的时候
            else if (lapLength == LapLength.Mile)
            {
                if (u1.Stamia >= 500)
                {
                    if (u2.Stamia >= 500)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 500)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//英里的时候
            else if (lapLength == LapLength.Middle)
            {
                if (u1.Stamia >= 750)
                {
                    if (u2.Stamia >= 750)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 750)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//中距离的时候
            else
            {
                if (u1.Stamia >= 1000)
                {
                    if (u2.Stamia >= 1000)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 1000)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) > (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//长举例的时候
        }//重构运算符作为比赛计量器
        public static bool operator >=(Uma u1, Uma u2)
        {
            if (lapLength == LapLength.Short)
            {
                if (u1.Stamia >= 250)
                {
                    if (u2.Stamia >= 250)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 250)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//短距离的时候
            else if (lapLength == LapLength.Mile)
            {
                if (u1.Stamia >= 500)
                {
                    if (u2.Stamia >= 500)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 500)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//英里的时候
            else if (lapLength == LapLength.Middle)
            {
                if (u1.Stamia >= 750)
                {
                    if (u2.Stamia >= 750)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 750)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//中距离的时候
            else
            {
                if (u1.Stamia >= 1000)
                {
                    if (u2.Stamia >= 1000)
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (u2.Stamia >= 1000)
                    {
                        return false;
                    }
                    else
                    {
                        return (u1.Speed + u1.Power + u1.Will + u1.Intelligence) >= (u2.Speed + u2.Power + u2.Will + u2.Intelligence);
                    }
                }
            }//长举例的时候
        }
        public static bool operator <(Uma u1, Uma u2)
        {
            return !(u1 >= u2);
        }
        public static bool operator <=(Uma u1, Uma u2)
        {
            return !(u1 < u2);
        }



    }//赛马娘数据
    public enum Mood : ushort
    {
        TooBad = 1,
        Bad = 2,
        Nomal = 3,
        Good = 4,
        TooGood = 5
    }//心情枚举
    public enum TimeLine
    {
        UnWayJunF = 0,//未出道6月上半月
        UnWayJunS,
        UnWayJulF,
        UnWayJulS,
        UnWayAugF,
        UnWayAugS,
        UnWaySepF,
        UnWaySepS,
        UnWayOctF,
        UnWayOctS,
        UnWayNovF,
        UnWayNovS,
        UnWayDecF,
        UnWayDecS,
        NewerJanF,//新手年1月上半月
        NewerJanS,
        NewerFebF,
        NewerFebS,
        NewerMarF,
        NewerMarS,
        NewerAprF,
        NewerAprS,
        NewerMayF,
        NewerMayS,
        NewerJunF,
        NewerJunS,
        NewerJulF,
        NewerJulS,
        NewerAugF,
        NewerAugS,
        NewerSepF,
        NewerSepS,
        NewerOctF,
        NewerOctS,
        NewerNovF,
        NewerNovS,
        NewerDecF,
        NewerDecS,
        ClassJanF,//经典年1月上半月
        ClassJanS,
        ClassFebF,
        ClassFebS,
        ClassMarF,
        ClassMarS,
        ClassAprF,
        ClassAprS,
        ClassMayF,
        ClassMayS,
        ClassJunF,
        ClassJunS,
        ClassJulF,
        ClassJulS,
        ClassAugF,
        ClassAugS,
        ClassSepF,
        ClassSepS,
        ClassOctF,
        ClassOctS,
        ClassNovF,
        ClassNovS,
        ClassDecF,
        ClassDecS,
        olderJanF,//古马年1月上半月
        olderJanS,
        olderFebF,
        olderFebS,
        olderMarF,
        olderMarS,
        olderAprF,
        olderAprS,
        olderMayF,
        olderMayS,
        olderJunF,
        olderJunS,
        olderJulF,
        olderJulS,
        olderAugF,
        olderAugS,
        olderSepF,
        olderSepS,
        olderOctF,
        olderOctS,
        olderNovF,
        olderNovS,
        olderDecF,
        olderDecS,
        URADayOne,//URA大赛第一天
        URADayTwo,
        URADayThree,
        URADayFour,
        URADayFive,
        URADaySix,
        URADayEnd,//尘埃落定
    }//时间枚举
    public enum LapLength
    {
        Short,
        Mile,
        Middle,
        Long
    }//赛道长度枚举
    public enum ConteLevel
    {
        Thetest = 0,
        TheG3Newer = 1,
        TheG2Newer,
        TheG1Newer,
        TheG3Class,
        TheG2Class,
        TheG1Class,
        TheG3Older,
        TheG2Older,
        TheG1Older,
        TheURADayOne,
        TheURADayTwo,
        TheURADayTre
    }//比赛级别枚举
    public class Drill
    {
        public static void StartDrill(Uma u, ushort s)//训练选择和体力判断
        {
            if (s != 5 && s != 6 && s != 7)
            {
                if (u.Phystrength >= 20)
                {
                    switch (s)
                    {
                        case 1: SpeDrill(u); break;
                        case 2: StaDrill(u); break;
                        case 3: PowDrill(u); break;
                        case 4: WilDrill(u); break;
                    }
                }
                else
                {
                    Console.WriteLine("训练失败");
                    if (u.UmaMood != Mood.TooBad)
                    {
                        u.UmaMood -= 1;
                        Console.WriteLine("心情下降了");
                    }
                    else
                    {
                        Console.WriteLine("心情已经很糟了，属性下降");
                        u.Speed -= 10;
                        u.Stamia -= 10;
                        u.Power -= 10;
                        u.Will -= 10;
                    }
                }
            }
            else
            {
                if (s == 5)
                {
                    InteDrill(u);
                }
                else if (s == 6)
                {
                    TakeARest(u);
                }
                else
                {
                    Joureny(u);
                }
            }


        }
        public static void SpeDrill(Uma uma)//速度训练主加速度副加力量
        {
            uma.Speed += 35;
            uma.Power += 10;
            uma.Will += 5;
            uma.Phystrength -= 20;
            Console.WriteLine("训练了速度");
        }
        public static void StaDrill(Uma uma)//耐力训练主加耐力副加根性
        {
            uma.Stamia += 35;
            uma.Will += 10;
            uma.Power += 5;
            uma.Phystrength -= 20;
            Console.WriteLine("训练了耐力");
        }
        public static void PowDrill(Uma uma)//力量训练主加力量副加耐力
        {
            uma.Power += 35;
            uma.Stamia += 10;
            uma.Speed += 5;
            uma.Phystrength -= 20;
            Console.WriteLine("训练了力量");
        }
        public static void WilDrill(Uma uma)//根性训练主加根性副加速度
        {
            uma.Will += 35;
            uma.Speed += 10;
            uma.Stamia += 5;
            uma.Phystrength -= 20;
            Console.WriteLine("训练了根性");
        }
        public static void InteDrill(Uma uma)//智力训练
        {
            uma.Intelligence += 35;
            uma.Speed += 10;
            uma.Phystrength += 10;
            Console.WriteLine("训练了智力");
        }
        public static void TakeARest(Uma uma)//休息
        {
            Random rand = new Random();
            ushort s = (ushort)rand.Next(101);
            if (s >= 0 && s < 80)
            {
                uma.Phystrength += 50;
                Console.WriteLine("正常休息");
            }
            else if (s >= 80 && s < 90)
            {
                uma.Phystrength += 70;
                Console.WriteLine("充分休息");
            }
            else
            {
                uma.Phystrength += 30;
                Console.WriteLine("休息不足");
            }
        }
        public static void Joureny(Uma uma)
        {
            Random rand = new Random();
            ushort s = (ushort)rand.Next(6);
            if (s >= 0 && s < 3)
            {
                Console.WriteLine("野外郊游");
                uma.Phystrength += 20;
                if (uma.UmaMood == Mood.TooGood)
                {
                    Console.WriteLine("心情极好，属性小加");
                    uma.Speed += 2;
                    uma.Stamia += 2;
                    uma.Power += 2;
                    uma.Will += 2;
                }
                else
                {
                    uma.UmaMood += 1;
                }

            }
            else
            {
                Console.WriteLine("逛商业街");
                if (uma.UmaMood >= Mood.Good)
                {
                    Console.WriteLine("心情极好，属性小加");
                    uma.Speed += 2;
                    uma.Stamia += 2;
                    uma.Power += 2;
                    uma.Will += 2;
                    uma.UmaMood = Mood.TooGood;
                }
                else
                {
                    uma.UmaMood += 2;
                }

            }
            //出游
        }
    }//训练与休息相关
    public class EventLib
    {
        public static void EventSelect(Uma u, ushort p)
        {
            if (p > 0 && p < 60)
            {
                Event0(u);
            }
            else if (p >= 60 && p < 90)
            {
                Event1(u);
            }
            else if (p >= 90 && p < 95)
            {
                Event2(u);
            }
            else if (p >= 95 && p < 100)
            {
                Event3(u);
            }
            else if (p == 100)
            {
                Event4(u);
            }
        }
        public static void Event0(Uma uma)
        {
            uma.Will += 0;
            uma.Power += 0;
            uma.Stamia += 0;
            uma.Speed += 0;
            uma.Intelligence += 0;
            Console.WriteLine("这段日子无事发生");
        }
        public static void Event1(Uma uma)
        {
            uma.Will += 5;
            uma.Power += 5;
            uma.Stamia += 5;
            uma.Speed += 5;
            uma.Intelligence += 5;
            Console.WriteLine("这段日子收获小幅度");
        }
        public static void Event2(Uma uma)
        {
            uma.Will += 10;
            uma.Power += 10;
            uma.Stamia += 10;
            uma.Speed += 10;
            uma.Intelligence += 10;
            Console.WriteLine("这段日子收获中幅度");
        }
        public static void Event3(Uma uma)
        {
            uma.Will += 15;
            uma.Power += 15;
            uma.Stamia += 15;
            uma.Speed += 15;
            uma.Intelligence += 15;
            Console.WriteLine("这段日子收获大幅度");
        }
        public static void Event4(Uma uma)
        {
            uma.Will += 20;
            uma.Power += 20;
            uma.Stamia += 20;
            uma.Speed += 20;
            uma.Intelligence += 20;
            uma.Phystrength += 40;
            Console.WriteLine("这段日子收获大幅度，且回复体力");
        }
    }//事件数据库
    public class ContestUma : DictionaryBase
    {
        public void Add(Uma newUma) => Dictionary.Add(newUma.umaName, newUma);
        public Uma this[string name]
        {
            get { return (Uma)Dictionary[name]; }
            set { Dictionary[name] = value; }
        }
        public Uma this[int i]
        {
            get { return (Uma)Dictionary[i]; }
            set { Dictionary[i] = value; }
        }

    }//参赛者集合
    public class Court
    {
        public ContestUma umas = new ContestUma();
        private static ushort winedConrts = 0;
        public string conrtInfo = "暂无比赛";//用于记录比赛数据
        public Uma[] umaIncon;//马娘数组
        private static void WinAConrts()//胜场计算
        {
            winedConrts += 1;
        }
        public static void ShowWinTimes()
        {
            Console.WriteLine($"此时胜场：{winedConrts}场");
        }
        public void StartCourt(Uma u, ConteLevel level, LapLength lap)//根据比赛级别生成对手，调整赛道信息
        {
            Uma.lapLength = lap;
            umas.Clear();
            switch (level)
            {
                case ConteLevel.TheG3Newer:
                    umas = ContestLib.JoinTheG3Newer();//先利用集合方便的往集合里添加对手
                    break;
                case ConteLevel.TheG2Newer:
                    umas = ContestLib.JoinTheG2Newer();
                    break;
                case ConteLevel.TheG1Newer:
                    umas = ContestLib.JoinTheG1Newer();
                    break;
                case ConteLevel.TheG3Class:
                    umas = ContestLib.JoinTheG3Class();
                    break;
                case ConteLevel.TheG2Class:
                    umas = ContestLib.JoinTheG2Class();
                    break;
                case ConteLevel.TheG1Class:
                    umas = ContestLib.JoinTheG1Class();
                    break;
                case ConteLevel.TheG3Older:
                    umas = ContestLib.JoinTheG3Older();
                    break;
                case ConteLevel.TheG2Older:
                    umas = ContestLib.JoinTheG2Older();
                    break;
                case ConteLevel.TheG1Older:
                    umas = ContestLib.JoinTheG1Older();
                    break;
                case ConteLevel.TheURADayOne:
                    umas = ContestLib.JoinTheURADayOne();
                    break;
                case ConteLevel.TheURADayTwo:
                    umas = ContestLib.JoinTheURADayTwo();
                    break;
                case ConteLevel.TheURADayTre:
                    umas = ContestLib.JoinTheURADayTre();
                    break;
                case ConteLevel.Thetest:
                    umas = ContestLib.TestContest();
                    break;
            }
            umas.Add(u);
            conrtInfo = "比赛类型：" + level + "，比赛距离：" + lap;//录入比赛信息
            umaIncon = new Uma[umas.Count];
            int b = 0;
            foreach (DictionaryEntry uma in umas)//在用集合轻松的添加元素后，再把元素赋给数组方便排序和遍历
            {
                umaIncon[b] = uma.Value as Uma;
                b++;
            }
        }
        public void CheckUma()
        {
            for (int i = 0; i < umaIncon.Length; i++)
            {
                Console.WriteLine($"选手{i + 1}号：名字：{umaIncon[i].umaName}，速度{umaIncon[i].Speed}，" +
                    $"耐力{umaIncon[i].Stamia}，力量{umaIncon[i].Power}，根性{umaIncon[i].Will}，智力{umaIncon[i].Intelligence}，" +
                    $"除耐力外其余属性加起来为{umaIncon[i].Speed + umaIncon[i].Power + umaIncon[i].Will + umaIncon[i].Intelligence}");
            }
        }//按顺序排列
        public void CourtIng()
        {
            for (int i = 0; i < umaIncon.Length; i++)
            {
                for (int j = i + 1; j < umaIncon.Length; j++)
                {
                    if (umaIncon[i] < umaIncon[j])
                    {
                        Uma timp = umaIncon[i];
                        umaIncon[i] = umaIncon[j];
                        umaIncon[j] = timp;
                    }
                }
            }
        }//比赛过程，根据大小，转换为比赛后的排名排序
        public void EndCount(Uma u,out Uma w)//检查结果
        {
            Console.WriteLine("比赛结束了");
            bool weAreWinner = false;
            Uma winnerUma = u;//先假定胜者是我们
            foreach (Uma item in umaIncon)
            {
                if (item > winnerUma)
                {
                    winnerUma = item;//如果集合里有大于我们的，把胜者变成它
                }
            }
            if (u >= winnerUma)
            {
                weAreWinner = true;
            }
            if (weAreWinner)
            {
                Console.WriteLine("我们赢了");
                WinAConrts();//同时胜场加1
            }
            else
            {
                Console.WriteLine("我们输了");
            }
            w = umaIncon[0];
        }
    }//比赛记录器与操作器
    public class ContestLib
    {
        public static ContestUma TestContest()
        {
            ContestUma umas = new ContestUma();
            umas.Add(new Uma($"对手{5}", 50, 50, 50, 50, 50));
            umas.Add(new Uma($"对手{4}", 50, 50, 50, 50, 50));
            umas.Add(new Uma($"对手{3}", 40, 40, 40, 40, 40));
            umas.Add(new Uma($"对手{2}", 40, 40, 40, 40, 40));
            umas.Add(new Uma($"对手{1}", 30, 30, 30, 30, 30));

            return umas;
        }//测试用对手
        public static ContestUma JoinTheG3Newer()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 7; i++)
            {
                csp = (int)random.Next(70);
                cst = (int)random.Next(70);
                cpw = (int)random.Next(70);
                cin = (int)random.Next(70);
                cwl = (int)random.Next(70);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG2Newer()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 11; i++)
            {
                csp = (int)random.Next(170);
                cst = (int)random.Next(170);
                cpw = (int)random.Next(170);
                cin = (int)random.Next(170);
                cwl = (int)random.Next(170);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG1Newer()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 15; i++)
            {
                csp = random.Next(270);
                cst = random.Next(270);
                cpw = random.Next(270);
                cin = random.Next(270);
                cwl = random.Next(270);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG3Class()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 7; i++)
            {
                csp = (int)random.Next(340);
                cst = (int)random.Next(340);
                cpw = (int)random.Next(340);
                cin = (int)random.Next(340);
                cwl = (int)random.Next(340);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG2Class()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 11; i++)
            {
                csp = (int)random.Next(440);
                cst = (int)random.Next(440);
                cpw = (int)random.Next(440);
                cin = (int)random.Next(440);
                cwl = (int)random.Next(440);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG1Class()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 15; i++)
            {
                csp = (int)random.Next(540);
                cst = (int)random.Next(540);
                cpw = (int)random.Next(540);
                cin = (int)random.Next(540);
                cwl = (int)random.Next(540);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG3Older()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 7; i++)
            {
                csp = (int)random.Next(610);
                cst = (int)random.Next(610);
                cpw = (int)random.Next(610);
                cin = (int)random.Next(610);
                cwl = (int)random.Next(610);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG2Older()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 11; i++)
            {
                csp = (int)random.Next(710);
                cst = (int)random.Next(710);
                cpw = (int)random.Next(710);
                cin = (int)random.Next(710);
                cwl = (int)random.Next(710);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheG1Older()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 15; i++)
            {
                csp = (int)random.Next(810);
                cst = (int)random.Next(810);
                cpw = (int)random.Next(810);
                cin = (int)random.Next(810);
                cwl = (int)random.Next(810);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheURADayOne()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 15; i++)
            {
                csp = (int)random.Next(820);
                cst = (int)random.Next(820);
                cpw = (int)random.Next(820);
                cin = (int)random.Next(820);
                cwl = (int)random.Next(820);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheURADayTwo()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 15; i++)
            {
                csp = (int)random.Next(840);
                cst = (int)random.Next(840);
                cpw = (int)random.Next(840);
                cin = (int)random.Next(840);
                cwl = (int)random.Next(840);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
        public static ContestUma JoinTheURADayTre()
        {
            ContestUma umas = new ContestUma();
            int csp, cst, cpw, cwl, cin;
            Random random = new Random();
            for (int i = 1; i <= 15; i++)
            {
                csp = (int)random.Next(870);
                cst = (int)random.Next(870);
                cpw = (int)random.Next(870);
                cin = (int)random.Next(870);
                cwl = (int)random.Next(870);
                umas.Add(new Uma($"对手{i}", csp, cst, cpw, cwl, cin));
            }
            return umas;
        }
    }//对手数据库，根据比赛级别分配对手
    public partial class InFo
    {
        public static partial void MyInFo1()
        {
            Console.WriteLine("本程序由非程序员出身的写同人文的赛马娘爱好者用业余时间一个月自学C#（没学完）花了三个晚上写的，所以没有后续版本也完全免费");
        }
        public static partial void MyInFo2();
    }
}
