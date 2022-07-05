using System;

namespace FirstGrass
{
    //나머지
    class Program
    {
        /*
         * (A+B)%C는 ((A%C) + (B%C))%C 와 같을까?
         * (A×B)%C는 ((A%C) × (B%C))%C 와 같을까?
         * 세 수 A, B, C가 주어졌을 때, 위의 네 가지 값을 구하는 프로그램을 작성하시오.
         */
        static void Main(string[] args)
        {
            string put = Console.ReadLine(); // 입력 함수
            string[] arr = put.Split(",");   // 입력받은 배열 구분자 [,] 기준으로 문자열 나누기
            int a = int.Parse(arr[0]);       // 배열 변수 arr의 첫번째 정수
            int c = int.Parse(arr[2]);       // 배열 변수 arr의 두번째 정수
            int b = int.Parse(arr[1]);       // 배열 변수 arr의 세번째 정수
            int result1 = (a + b) % c;
            int result2 = (a % c) + (b % c) % c;
            int result3 = (a * b) % c;
            int result4 = (a % c) * (b % c) % c;
            Boolean result5 = result1 == result2;
            Boolean result6 = result3 == result4;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);


        }
    }
}
