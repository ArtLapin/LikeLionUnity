using System;

namespace ArtLapin
{
    internal class Lesson2 
    {
        static string msg = "Hello C#"; //멤버변수
        const int number9 = 1; //컴파일타임에서 결정
        //readonly int number10 = 2; //컴파일이 아닌 런타임상에서 상수결정이라 멤버변수로 못씀.
        //const int number11 = new Random().Next(); //값이 정해져야 사용가능, 런타임 단계에서 난수값 생성
        static readonly int number12 = new Random().Next(); //readonly는 런타임단계에서 결정되기 때문에 랜덤난수값 생성 후 적용 가능
        public static void Run() //Static(미리 자리를 잡음), Dynamic
        {
            Console.WriteLine("A");
            Console.WriteLine("B");
            PrintMessage();
            //숫자 타입
            int number1 = 0;
            int number2 = 10;
            
            float number3 = 0.3f;
            float number4 = 10.0f;

            double number6 = 0.3d;
            double number7 = 10.123d;
            double number8 = -3.7d;
            //논리 타입
            bool isOn = true;
            bool ismute = false;
            //문자 타입
            char character1 = 'A';
            char character2 = '안';

            string str1 = "A";
            string str2 = "안녕하세요";

            //string msg = "Hello C#"; 지역변수는 static 못붙임.
            Console.WriteLine(msg);
            Console.WriteLine(number9);
            //Console.WriteLine(number10);
            Console.WriteLine(number12);
        }
        public static void PrintMessage()
        {
            Console.WriteLine("C");
        }
    }
}