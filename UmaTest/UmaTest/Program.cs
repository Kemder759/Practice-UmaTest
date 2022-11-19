namespace UmaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeRecorder timeRecorder = new TimeRecorder();
            string userUmaName;
            InFo.MyInFo1();
            InFo.MyInFo2();
            Console.WriteLine("首先给你的爱马起名，没测试过能不能中文");
            userUmaName = Console.ReadLine();
            Uma uma1 = new Uma(userUmaName, 5, 5, 5, 5, 5);
            string userKeyIn;
            int userKeyInInt;
            Console.WriteLine("处于极其早期版本（谁会闲的蛋疼只学了一个月编程还是工作之余学的之后就开始写同人游戏）");
            while (timeRecorder.CurrentTime < TimeLine.URADayOne)
            {

                bool checkInPut = true;//用于检查用户输入的数字是否正确
                Console.WriteLine("==================================");
                timeRecorder.ShowTime();
                uma1.ShowUma();
                Court.ShowWinTimes();
                Console.WriteLine("做点什么呢，键盘输入数字后回车：1训练速度，2训练耐力，3训练力量，4训练根性，5训练智力，" +
                    "6休息，7游玩，8参加比赛");
                do
                {
                    Console.WriteLine("请输入范围内的数字数字");
                    userKeyIn = Console.ReadLine();
                    try
                    {
                        userKeyInInt = int.Parse(userKeyIn);//检测输入的能不能转化成数字，不能就报错
                        if (userKeyInInt >= 1 && userKeyInInt <= 8)//再检查输入的数字范围
                        {
                            checkInPut = false;//输入了选定范围的数字，就结束循环
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("请输入数字");//报错后删掉throw，这样重新执行do循环
                    }

                } while (checkInPut);//用checkInPut检查输入的是否规范


                switch (userKeyIn)
                {
                    case "1": timeRecorder.UserDrill(uma1, 1); break;
                    case "2": timeRecorder.UserDrill(uma1, 2); break;
                    case "3": timeRecorder.UserDrill(uma1, 3); break;
                    case "4": timeRecorder.UserDrill(uma1, 4); break;
                    case "5": timeRecorder.UserDrill(uma1, 5); break;
                    case "6": timeRecorder.UserDrill(uma1, 6); break;
                    case "7": timeRecorder.UserDrill(uma1, 7); break;
                    case "8":
                        {
                            if (timeRecorder.CurrentTime < TimeLine.NewerJanF)
                            {
                                Console.WriteLine("未出道，不能参加比赛");
                            }
                            else
                            {
                                timeRecorder.JoinACourt(uma1);
                            }

                        }
                        break;
                }
                Console.WriteLine("==================================");
                Console.WriteLine("------------------");
            }
            do
            {
                switch (timeRecorder.CurrentTime)
                {
                    case TimeLine.URADayOne:
                        {
                            bool checkInPut = true;//用于检查用户输入的数字是否正确
                            Console.WriteLine("==================================");
                            Console.WriteLine("开始为URA第一场比赛准备");
                            timeRecorder.ShowTime();
                            uma1.ShowUma();
                            Court.ShowWinTimes();
                            Console.WriteLine("做点什么呢，键盘输入数字后回车：1训练速度，2训练耐力，3训练力量，4训练根性，5训练智力，" +
                                "6休息，7游玩");
                            do
                            {
                                Console.WriteLine("请输入范围内的数字数字");
                                userKeyIn = Console.ReadLine();
                                try
                                {
                                    userKeyInInt = int.Parse(userKeyIn);
                                    if (userKeyInInt >= 1 && userKeyInInt <= 7)
                                    {
                                        checkInPut = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("请输入数字");
                                }

                            } while (checkInPut);
                            switch (userKeyIn)
                            {
                                case "1": timeRecorder.UserDrill(uma1, 1); break;
                                case "2": timeRecorder.UserDrill(uma1, 2); break;
                                case "3": timeRecorder.UserDrill(uma1, 3); break;
                                case "4": timeRecorder.UserDrill(uma1, 4); break;
                                case "5": timeRecorder.UserDrill(uma1, 5); break;
                                case "6": timeRecorder.UserDrill(uma1, 6); break;
                                case "7": timeRecorder.UserDrill(uma1, 7); break;
                            }
                            Console.WriteLine("==================================");
                            Console.WriteLine("------------------");
                        }
                        break;
                    case TimeLine.URADayTwo:
                        {
                            Console.WriteLine("==================================");
                            Console.WriteLine("参加URA第一场比赛");
                            timeRecorder.ShowTime();
                            uma1.ShowUma();
                            Court.ShowWinTimes();
                            timeRecorder.JoinURA(uma1);
                        }
                        break;
                    case TimeLine.URADayThree:
                        {
                            bool checkInPut = true;//用于检查用户输入的数字是否正确
                            Console.WriteLine("==================================");
                            Console.WriteLine("开始为URA第二场比赛准备");
                            timeRecorder.ShowTime();
                            uma1.ShowUma();
                            Court.ShowWinTimes();
                            Console.WriteLine("做点什么呢，键盘输入数字后回车：1训练速度，2训练耐力，3训练力量，4训练根性，5训练智力，" +
                                "6休息，7游玩");
                            do
                            {
                                Console.WriteLine("请输入范围内的数字数字");
                                userKeyIn = Console.ReadLine();
                                try
                                {
                                    userKeyInInt = int.Parse(userKeyIn);
                                    if (userKeyInInt >= 1 && userKeyInInt <= 7)
                                    {
                                        checkInPut = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("请输入数字");
                                }

                            } while (checkInPut);
                            switch (userKeyIn)
                            {
                                case "1": timeRecorder.UserDrill(uma1, 1); break;
                                case "2": timeRecorder.UserDrill(uma1, 2); break;
                                case "3": timeRecorder.UserDrill(uma1, 3); break;
                                case "4": timeRecorder.UserDrill(uma1, 4); break;
                                case "5": timeRecorder.UserDrill(uma1, 5); break;
                                case "6": timeRecorder.UserDrill(uma1, 6); break;
                                case "7": timeRecorder.UserDrill(uma1, 7); break;
                            }
                            Console.WriteLine("==================================");
                            Console.WriteLine("------------------");
                        }
                        break;
                    case TimeLine.URADayFour:
                        {
                            Console.WriteLine("==================================");
                            Console.WriteLine("参加URA第二场比赛");
                            timeRecorder.ShowTime();
                            uma1.ShowUma();
                            Court.ShowWinTimes();
                            timeRecorder.JoinURA(uma1);
                        }
                        break;
                    case TimeLine.URADayFive:
                        {
                            bool checkInPut = true;//用于检查用户输入的数字是否正确
                            Console.WriteLine("==================================");
                            Console.WriteLine("开始为URA第三场比赛准备");
                            timeRecorder.ShowTime();
                            uma1.ShowUma();
                            Court.ShowWinTimes();
                            Console.WriteLine("做点什么呢，键盘输入数字后回车：1训练速度，2训练耐力，3训练力量，4训练根性，5训练智力，" +
                                "6休息，7游玩");
                            do
                            {
                                Console.WriteLine("请输入范围内的数字数字");
                                userKeyIn = Console.ReadLine();
                                try
                                {
                                    userKeyInInt = int.Parse(userKeyIn);
                                    if (userKeyInInt >= 1 && userKeyInInt <= 7)
                                    {
                                        checkInPut = false;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("请输入数字");
                                }

                            } while (checkInPut);
                            switch (userKeyIn)
                            {
                                case "1": timeRecorder.UserDrill(uma1, 1); break;
                                case "2": timeRecorder.UserDrill(uma1, 2); break;
                                case "3": timeRecorder.UserDrill(uma1, 3); break;
                                case "4": timeRecorder.UserDrill(uma1, 4); break;
                                case "5": timeRecorder.UserDrill(uma1, 5); break;
                                case "6": timeRecorder.UserDrill(uma1, 6); break;
                                case "7": timeRecorder.UserDrill(uma1, 7); break;
                            }
                            Console.WriteLine("==================================");
                            Console.WriteLine("------------------");
                        }
                        break;
                    case TimeLine.URADaySix:
                        {
                            Console.WriteLine("==================================");
                            Console.WriteLine("参加URA第三场比赛");
                            timeRecorder.ShowTime();
                            uma1.ShowUma();
                            Court.ShowWinTimes();
                            timeRecorder.JoinURA(uma1);
                        }
                        break;
                }

            } while (timeRecorder.CurrentTime != TimeLine.URADayEnd);
            Console.WriteLine("3年的时光过去了，感谢有你");
            Court.ShowWinTimes();
            uma1.ShowUma();
            Console.WriteLine("完结撒花！！！！！");

            /*Uma uma1 = new Uma("小栗帽", 2, 2, 2, 2, 2);
            uma1.ShowUma();
            TimeRecorder timeRecorder = new TimeRecorder();
            Court court = new Court();
            timeRecorder.ShowTime();
            for (int i = 0; i < 12; i++)
            {
                timeRecorder.UserDrill(uma1, 1);
                timeRecorder.UserDrill(uma1, 2);
                timeRecorder.UserDrill(uma1, 3);
                timeRecorder.UserDrill(uma1, 4);
                timeRecorder.UserDrill(uma1, 5);
                timeRecorder.UserDrill(uma1, 6);
                timeRecorder.UserDrill(uma1, 6);
            }
            timeRecorder.ShowTime();
            uma1.ShowUma();
            timeRecorder.UserDrill(uma1, 1);
            timeRecorder.UserDrill(uma1, 1);
            uma1.ShowUma();
            court.ShowWinTimes();
            court.StartCourt(uma1,ConteLevel.TheURADayOne,LapLength.Long);
            Console.WriteLine("进行一场测试比赛");
            Console.WriteLine("查看比赛信息");
            Console.WriteLine(court.conrtInfo);
            Console.WriteLine("查看参赛者信息");
            court.CheckUma();
            Console.WriteLine("开始比赛");
            court.CourtIng();
            Console.WriteLine("查看结果");
            court.EndCount(uma1);
            Console.WriteLine("查看全部排名");
            court.CheckUma();
            court.ShowWinTimes();*/
        }
    }
    public class TimeRecorder
    {
        private TimeLine currentTime = (TimeLine)0;//记录日期，默认是0，设置别的数字用于测试    
        Random random = new Random();//实例化一个随机器用来骰随机数引出事件
        private ushort probability = 0;//用来承载随机数，然后作为参数调用对应的事件
        private ushort probabilityOther = 0;
        public TimeLine CurrentTime//记录当前日期
        {
            get { return currentTime; }
            set { currentTime = value; }
        }
        public void TimeMove()//日期推动功能
        {
            probability = (ushort)random.Next(101);//时间推动的时候获得随机数用来触发随机事件
            probabilityOther = (ushort)random.Next(101);
            currentTime += 1;
        }
        public void UserDrill(Uma u, ushort s)
        {
            Drill.StartDrill(u, s);//根据参数进行选择的训练
            TimeMove();//执行日期推动
            EventLib.EventSelect(u, probability);//触发随机事件

        }//训练，并且推动日期，并且调用随机事件
        public void ShowTime()
        {
            Console.WriteLine("当前日期是：" + CurrentTime.ToString());
        }//检查今天日期
        public void JoinACourt(Uma u)
        {
            bool checkInPut = true;
            bool courtSelected = false;
            string userKeyIn;
            int userKeyInInt;//先设定字段用来承载玩家输入的字符
            ConteLevel conteLevel = new ConteLevel();//枚举创建后需要先初始化，这样在循环语句的代码块里赋值后就能带出来
            LapLength lapLength = new LapLength();
            Court court = new Court();
            do
            {
                Console.WriteLine("参加比赛，请选择比赛规格：1为G1，2为G2，3为G3，4为退出比赛");
                do
                {
                    Console.WriteLine("请输入范围内的数字数字");
                    userKeyIn = Console.ReadLine();
                    try
                    {
                        userKeyInInt = int.Parse(userKeyIn);
                        if (userKeyInInt >= 1 && userKeyInInt <= 4)
                        {
                            checkInPut = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("请输入按要求的数字");
                    }
                } while (checkInPut);
                if (userKeyIn == "4")
                {
                    Console.WriteLine("不比了不比了，回去训练");
                    return;
                }
                switch (userKeyIn)//判断数字选择比赛级别
                {
                    case "1":
                        {
                            if (currentTime >= TimeLine.NewerJanF && currentTime < TimeLine.ClassJanF)
                            {
                                conteLevel = ConteLevel.TheG1Newer;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                            else if (currentTime >= TimeLine.ClassJanF && currentTime < TimeLine.ClassJanF)
                            {
                                conteLevel = ConteLevel.TheG1Class;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                            else
                            {
                                conteLevel = ConteLevel.TheG1Older;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                        }
                        break;
                    case "2":
                        {
                            if (currentTime >= TimeLine.NewerJanF && currentTime < TimeLine.ClassJanF)
                            {
                                conteLevel = ConteLevel.TheG2Newer;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                            else if (currentTime >= TimeLine.ClassJanF && currentTime < TimeLine.ClassJanF)
                            {
                                conteLevel = ConteLevel.TheG2Class;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                            else
                            {
                                conteLevel = ConteLevel.TheG2Older;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                        }
                        break;
                    case "3":
                        {
                            if (currentTime >= TimeLine.NewerJanF && currentTime < TimeLine.ClassJanF)
                            {
                                conteLevel = ConteLevel.TheG3Newer;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                            else if (currentTime >= TimeLine.ClassJanF && currentTime < TimeLine.ClassJanF)
                            {
                                conteLevel = ConteLevel.TheG3Class;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                            else
                            {
                                conteLevel = ConteLevel.TheG3Older;
                                Console.WriteLine("你选择了{0}", conteLevel);
                            }
                        }
                        break;
                }

                Console.WriteLine("请选择赛道长度：1为短距离，2英里，3中距离，4长距离，5退出比赛");
                checkInPut = true;
                do
                {
                    Console.WriteLine("请输入范围内的数字数字");
                    userKeyIn = Console.ReadLine();
                    try
                    {
                        userKeyInInt = int.Parse(userKeyIn);
                        if (userKeyInInt >= 1 && userKeyInInt <= 5)
                        {
                            checkInPut = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("请输入按要求的数字");
                    }
                } while (checkInPut);
                if (userKeyIn == "5")
                {
                    Console.WriteLine("不比了不比了，回去训练");
                    return;
                }
                switch (userKeyIn)//判断数字选择赛道长短
                {
                    case "1":
                        {
                            lapLength = LapLength.Short;
                            Console.WriteLine("选择了短距离");
                            courtSelected = true;
                        }
                        break;
                    case "2":
                        {
                            lapLength = LapLength.Mile;
                            Console.WriteLine("选择了短距离");
                            courtSelected = true;
                        }
                        break;
                    case "3":
                        {
                            lapLength = LapLength.Middle;
                            Console.WriteLine("选择了中距离");
                            courtSelected = true;
                        }
                        break;
                    case "4":
                        {
                            lapLength = LapLength.Long;
                            Console.WriteLine("选择了长距离");
                            courtSelected = true;
                        }
                        break;
                }

            } while (courtSelected == false);
            Console.WriteLine("选完了，该比赛了");
            court.StartCourt(u, conteLevel, lapLength);//根据上面的选项生成比赛内容
            Console.WriteLine(court.conrtInfo);//显示比赛信息
            Console.WriteLine("以下是参赛名单");
            court.CheckUma();//显示参赛者信息
            Console.WriteLine("按下回车以进行比赛");
            Console.ReadLine();
            court.CourtIng();//执行比赛
            Console.WriteLine("比赛完毕（过程省略，作者妹那能力）");
            Uma winner;
            probability = (ushort)random.Next(4);
            court.EndCount(u, out winner);
            Console.WriteLine("以下是排名");
            court.CheckUma();
            WinnerLive(probability, winner);
            Console.WriteLine("这半个月就在比赛的忙前忙后中过去了");
            TimeMove();
        }//加入比赛操作
        public void JoinURA(Uma u)
        {
            bool checkInPut = true;
            bool courtSelected = false;
            ConteLevel conteLevel = new ConteLevel();
            string userKeyIn;
            int userKeyInInt;
            LapLength lapLength = new LapLength();
            Court court = new Court();
            Console.WriteLine("请选择赛道长度：1为短距离，2英里，3中距离，4长距离");
            checkInPut = true;
            do
            {
                Console.WriteLine("请输入范围内的数字数字");
                userKeyIn = Console.ReadLine();
                try
                {
                    userKeyInInt = int.Parse(userKeyIn);
                    if (userKeyInInt >= 1 && userKeyInInt <= 4)
                    {
                        checkInPut = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("请输入按要求的数字");
                }
            } while (checkInPut);
            switch (userKeyIn)
            {
                case "1":
                    {
                        lapLength = LapLength.Short;
                        Console.WriteLine("选择了短距离");
                    }
                    break;
                case "2":
                    {
                        lapLength = LapLength.Mile;
                        Console.WriteLine("选择了短距离");
                    }
                    break;
                case "3":
                    {
                        lapLength = LapLength.Middle;
                        Console.WriteLine("选择了中距离");
                    }
                    break;
                case "4":
                    {
                        lapLength = LapLength.Long;
                        Console.WriteLine("选择了长距离");
                    }
                    break;
            }
            switch (CurrentTime)
            {
                case TimeLine.URADayTwo:
                    conteLevel = ConteLevel.TheURADayOne;
                    break;
                case TimeLine.URADayFour:
                    conteLevel = ConteLevel.TheURADayTwo;
                    break;
                case TimeLine.URADaySix:
                    conteLevel = ConteLevel.TheURADayTre;
                    break;
            }
            court.StartCourt(u,conteLevel,lapLength);
            Console.WriteLine(court.conrtInfo);//显示比赛信息
            Console.WriteLine("以下是参赛名单");
            court.CheckUma();//显示参赛者信息
            Console.WriteLine("按下回车以进行比赛");
            Console.ReadLine();
            court.CourtIng();//执行比赛
            Console.WriteLine("比赛完毕（过程省略，作者妹那能力）");
            Uma winner;
            probability = (ushort)random.Next(4);
            court.EndCount(u, out winner);
            Console.WriteLine("以下是排名");
            court.CheckUma();
            if (CurrentTime == TimeLine.URADaySix)
            {
                WinnerliveURA(winner);
            }
            
            Console.WriteLine("这半个月就在比赛的忙前忙后中过去了");
            TimeMove();
        }
        public void WinnerLive(ushort s, Uma c)
        {
            Console.WriteLine("=====胜败乃兵家常事，比完赛就...没歌，但是有歌词======");
            Console.WriteLine($"下面请欣赏{c.umaName}演唱歌曲：");
            switch (s)
            {
                case 0: Console.WriteLine("星星点灯！啊卖牛排~"); break;
                case 1: Console.WriteLine("缭乱~虹咲大呲花！"); break;
                case 2: Console.WriteLine("LaHee~~~Don e la li pho la~"); break;
                case 3: Console.WriteLine("那什么什么什么，无限大~~（忘词了"); break;
            }
        }
        public void WinnerliveURA(Uma c)
        {
            Console.WriteLine($"下面请欣赏{c.umaName}演唱歌曲：马儿蹦跳传说");
            Console.WriteLine("うーーーー(うまだっち)");
            Console.WriteLine("うーーー(うまぴょい　うまぴょい)");
            Console.WriteLine("うーー(すきだっち)　うーー(うまぽい)");
            Console.WriteLine("うまうまうみゃうみゃ 3 2 1 Fight！！");
            Console.WriteLine("不写了，太累了");
        }
    }//时间/全局记录器
    public partial class InFo
    {
        public static partial void MyInFo1();
        public static partial void MyInFo2()
        {
            Console.WriteLine("写的小说欢迎来看，连载中，在NGA里https://nga.178.com/read.php?tid=32938676");
            Console.WriteLine("还有结局了的怪文书https://nga.178.com/read.php?tid=32821078");
        }
    }
}