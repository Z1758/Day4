namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
 #region 과제 1

            //음수 배제
            uint loopCount;

            //예외처리 루프
            while (true)
            {
                Console.WriteLine("몇회 반복하시겠습니까?");

                //예외 처리
                if (uint.TryParse(Console.ReadLine(), out loopCount))
                {
                    break;
                }

                Console.WriteLine("다시 입력해주세요");
            }
            for (int i = 0; i < loopCount; i++)
            {
                Console.WriteLine($"{i + 1}회 반복중입니다.");
            }
 #endregion

 #region 과제 2

            //음수 배제
            uint sum = 0;
            uint startNum;
            uint endNum;

            //예외처리 루프
            while (true)
            {
                Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요");
                bool startBool = uint.TryParse(Console.ReadLine(), out startNum);

                Console.WriteLine("끝 수를 입력해주세요");
                bool endBool = uint.TryParse(Console.ReadLine(), out endNum);

                //올바르지 않은 입력 예외 처리
                if (startBool && endBool)
                {
                    //시작수가 더 클때의 예외 처리
                    if (startNum < endNum)
                        break;

                    Console.WriteLine("시작 수가 더 작아야 합니다.");
                }
                Console.WriteLine("제대로 입력 해주세요");
            }


            for (uint i = startNum; i <= endNum; i++)
            {
                sum += i;
            }

            Console.WriteLine($"{startNum}과 {endNum} 사이 숫자의 합은 {sum} 입니다.");


#endregion

#region 과제 3

            int multiNum;

            //예외 처리
            while (true)
            {
                Console.WriteLine("출력하고자 하는 구구단을 입력해주시길 바랍니다");

                int.TryParse(Console.ReadLine(), out multiNum);

                if (1 <= multiNum && multiNum <= 9)
                {
                    break;
                }
                #region 예외처리 그리기
                Console.ForegroundColor = ConsoleColor.Red;

                //횡 길이 홀수만
                int excepWidth = 17;
                //종 길이 홀수만
                int excepHeight = 5;
                //종 중간 값
                int middleHeight = excepHeight / 2 + 1;

                //종 반복문
                for (int i = 0; i <= excepHeight; i++)
                {
                    if (i != 0)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    //횡 반복문
                    for (int j = 0; j <= excepWidth; j++)
                    {
                        if (i == 0)
                        {
                            Console.Write("_");
                        }
                        else if (i == excepHeight)
                        {

                            Console.Write("_");
                        }
                        //중앙에 도달했을때
                        else if (j == 1 + ((excepWidth - 10) / 2) && i == middleHeight)
                        {
                            //9칸을 잡아먹는다
                            Console.Write(" ");
                            Console.Write("예외처리");
                        }
                        else
                        {
                            Console.Write(" ");
                        }

                        if (j == 2 + ((excepWidth - 10)) && i == middleHeight)
                        {
                            j = excepWidth;
                        }
                    }
                    if (i != 0)
                    {
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
                Console.WriteLine();
                #endregion
            }

            //곱셈
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{multiNum} X {i} = {multiNum * i}");
            }
            Console.WriteLine();

#endregion
            
#region 과제 4

            int selectNum;

            //do while을 활용한 예외처리
            do
            {
                Console.WriteLine("1번부터 4번까지 선택해주세요");
                int.TryParse(Console.ReadLine(), out selectNum);
            } while (1 > selectNum || selectNum > 4);

            //switch로 번호 관리
            switch (selectNum)
            {
                case 1:
                    //1번
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i >= j)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();

                    }

                    Console.WriteLine();
                    break;

                case 2:
                    //2번
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - i > j)
                                Console.Write(" ");
                            else
                                Console.Write("*");
                        }
                        Console.WriteLine();

                    }

                    Console.WriteLine();
                    break;

                case 3:
                    //3번
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (4 - i < j)
                                Console.Write(" ");
                            else
                                Console.Write("*");
                        }
                        Console.WriteLine();

                    }
                    Console.WriteLine();
                    break;
                case 4:
                    //4번
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i <= j)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
#endregion
        }
    }
}
