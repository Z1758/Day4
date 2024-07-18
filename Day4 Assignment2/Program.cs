namespace Day4_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //이닝
            int innings = 0;

            // cpu의 세자리 수
            int firstCpuNumber, secondCpuNumber, thirdCpuNumber;

           
            Random rand = new Random();
            int cpuBaseballNumber;

            // cpu도 예외 처리
            while (true)
            {
                cpuBaseballNumber = rand.Next(0, 999);
                //    cpuBaseballNumber = 023; 디버그용
                firstCpuNumber = cpuBaseballNumber / 100 % 10;
                secondCpuNumber = cpuBaseballNumber / 10 % 10;
                thirdCpuNumber = cpuBaseballNumber / 1 % 10;

                if (firstCpuNumber == secondCpuNumber || firstCpuNumber == thirdCpuNumber || secondCpuNumber == thirdCpuNumber)
                {

                    continue;
                }

                break;
            }

            //무한 루프
            while (true)
            {
                Console.WriteLine($"\n{innings + 1}이닝\n");

                // 1. 세자리 수 입력

                int baseballNumber;
                int firstNumber, secondNumber, thirdNumber;
                

                Console.WriteLine("첫번째 자리 수를 입력 해주세요");

                //이상한 값 예외처리
                if (int.TryParse(Console.ReadLine(), out firstNumber))
                {

                    if (0 > firstNumber || firstNumber > 9)
                    {
                        Console.WriteLine("0~9 사이의 수를 입력해 주세요");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("0~9 사이의 수를 입력해 주세요");
                    continue;

                }
                Console.WriteLine("두번째 자리 수를 입력 해주세요");
                if (int.TryParse(Console.ReadLine(), out secondNumber))
                {


                    if (0 > secondNumber || secondNumber > 9)
                    {
                        Console.WriteLine("0~9 사이의 수를 입력해 주세요");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("0~9 사이의 수를 입력해 주세요");
                    continue;

                }


                Console.WriteLine("세번째 자리 수를 입력 해주세요");
                if (int.TryParse(Console.ReadLine(), out thirdNumber))
                { 
                    if (0 > thirdNumber || thirdNumber > 9)
                    {
                        Console.WriteLine("0~9 사이의 수를 입력해 주세요");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("0~9 사이의 수를 입력해 주세요");
                    continue;
                }

                //단순히 숫자를 더하는게 아닌 문자열로 바꿔서 대입
                int.TryParse(firstNumber.ToString()+ secondNumber.ToString() + thirdNumber.ToString(), out baseballNumber);

                
                // 2. 동일한 수 예외 처리 ex) 111




                // 먼저 세자리 수 인지 확인
                if (0 <= baseballNumber && baseballNumber < 1000)
                {

                   

                    // 중복 수 예외 처리
                    if (firstNumber == secondNumber || firstNumber == thirdNumber || secondNumber == thirdNumber)
                    {
                        Console.WriteLine("중복 되는 수가 있습니다.");
                        continue;
                    }

                }
                //아니면 루프
                else
                {
                    continue;
                }


                Console.WriteLine();
                Console.WriteLine($"당신의 수   {baseballNumber:000}");
                Console.WriteLine($"컴퓨터의 수 {cpuBaseballNumber:000} (디버깅 확인용)");

                // 3. 일치한 수 마다 1스트라이크 +

                int strikeCount = 0;

                if (firstNumber == firstCpuNumber)
                {
                    strikeCount++;
                    
                }
                if (secondNumber == secondCpuNumber)
                {
                    strikeCount++;
                   
                }
                if (thirdNumber == thirdCpuNumber)
                {
                    strikeCount++;
                    
                }

                // 4. 수가 일치하나 자릿수가 다르면 1볼 +

                int ballCount = 0;
                //플레이어의 첫자리수 == 컴퓨터의 두번째 자리수 or 플레이어의 첫자리수 == 컴퓨터의 세번째 자리수
                if (firstNumber == secondCpuNumber || firstNumber == thirdCpuNumber)
                {
                    ballCount++;
                   
                }
                if (secondNumber == firstCpuNumber || secondNumber == thirdCpuNumber)
                {
                    ballCount++;
                    
                }
                if (thirdNumber == firstCpuNumber || thirdNumber == secondCpuNumber)
                {
                    ballCount++;
                    
                }

                Console.WriteLine($"\n{strikeCount}스트라이크");
                Console.WriteLine($"{ballCount}볼\n");
                // 5. 일치 하는 수가 하나도 없을시 스트라이크 볼 대신 아웃
                if (strikeCount == 0 && ballCount == 0)
                {
                    Console.WriteLine("아웃!\n");
                }


                // 6. 스트라이크 모두 나올때까지 유저는 계속 입력 그리고 입력 한번에 이닝 +
                

                //이닝 증가
                innings++;

                // 7. 11이닝이 되기 전까지 3스트라이크를 내면 유저의 승, 11이닝이 될 때까지 3스트라이크가 나오지 않았다면 컴퓨터의 승리

                if(strikeCount == 3)
                {
                    Console.WriteLine("우승!");
                    break;
                }

                //11이닝 시합 끝
                if (innings == 11)
                {
                    Console.WriteLine("컴퓨터 승!");
                    break;
                }

                
            }


            

        }
    }
}
