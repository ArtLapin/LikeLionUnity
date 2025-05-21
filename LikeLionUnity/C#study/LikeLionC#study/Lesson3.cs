using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArtLapin
{
    class Player
    {
        public string name = "";
        public int level = 1;
        public string CLASS = "";
        public int maxlevel = 100;

        private static string[] jobs = { "전사", "바바리안", "마법사", "레인저", "암살자", "힐러", "바드" };

        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
            this.CLASS = GetRandomJob();

            Console.WriteLine($"캐릭터 : {name}, 레벨 : {level} , 직업 : {CLASS} 생성완료");
        }

        public void LevelUp()
        {
            if (level < maxlevel)
            {
                level++;
                Console.WriteLine($"{name} 캐릭터 레벨업!, 현재 레벨 {level}");
            }
            else
            {
                Console.WriteLine($"{name} 캐릭터는 이미 최대 레벨에 도달했습니다!");
            }
        }

        /*
        public void CreatePlayer(string name, int level)
        {
            //Console.WriteLine("캐릭터: " + name + ", 레벨: " + level + "생성완료");
            this.name = name; //this대신에 _name을 사용할 수도 있음
            this.level = level;
            this.CLASS = GetRandomJob();
            Console.WriteLine($"캐릭터 : {name}, 레벨 : {level} , 직업 : {CLASS} 생성완료");
        }
        */
        private string GetRandomJob()
        {
            Random rand = new Random();
            int index = rand.Next(jobs.Length);
            return jobs[index];
        }
    }

    internal class Lesson3
    {
        public static void Run()
        {
            Player player1 = new Player("ArtLapin", 100); //변수선언 및 변수할당
            //player1.name = "ArtLapin";
            //player1.level = 100;
            //player1.CreatePlayer("ArtLapin", 100); //player1에 있는 CreatePlayer함수 호출(실행)
            
            Player player2 = new Player("Unity", 2);
            //player2.name = "Unity";
            //player2.level = 2;

            Player player3 = new Player("TungSahur", 10);
            Player player4 = new Player("Tralalero", 15);
            Player player5 = new Player("BrrBrrBatta", 20);

            Player[] players = {player1, player2, player3, player4, player5 }; //메모리 공간이 정해진 배열
            Console.WriteLine($"현재 플레이어 수는 {players.Length}입니다.");
            
            List<Player> playerList = new List<Player>(); //메모리 공간이 정해지지 않은 리스트

            //playerList.Add(player1);
            //playerList.Add(player2);
            //playerList.Add(player3);
            //playerList.Add(player4);
            //playerList.Add(player5);

            for (int i = 0; i < 10; i++)
            {
                string playerName = $"Player{i + 1}";
                int playerLevel = 1;

                Player player = new Player(playerName, playerLevel);
                playerList.Add(player);
            }

            Console.WriteLine($"현재 플레이어 수는 {playerList.Count}입니다.");

            player2.LevelUp();
            player2.LevelUp();
            player2.LevelUp();
            player2.LevelUp();
            player2.LevelUp();
            player2.LevelUp();
            player1.LevelUp();
            player1.LevelUp();
            player1.LevelUp();
        }
    }
}
