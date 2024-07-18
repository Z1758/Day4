namespace Day4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region 심화 과제 1
            int toDetermine;

            while (true)
            {
                Console.WriteLine("1. 마을");
                Console.WriteLine("2. 사냥터");
                Console.WriteLine("3. 상점");

                Console.WriteLine("이동 할 장소를 설정해주세요");

                int.TryParse(Console.ReadLine(), out toDetermine);
                Console.ForegroundColor = ConsoleColor.Blue;
                switch (toDetermine)
                {

                    case 1:
                        Console.WriteLine("마을로 이동하였습니다");
                        break;
                    case 2:
                        Console.WriteLine("사냥터로 이동하였습니다");
                        break;
                    case 3:
                        Console.WriteLine("상점으로 이동하였습니다");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("1,2,3 어느것도 아니에요");
                        Console.ResetColor();
                        //continue로 인해 break에 도달하지 못하고 무한 루프
                        continue;

                }
                Console.ResetColor();
                break;
            }
            #endregion




            #region 심화 과제 2

            //다이아몬드 크기 변수
            int diaSize = 0;

            Console.WriteLine("출력할 다이아몬드를 홀수로 입력:");


            while (true)
            {
                bool numFlag = int.TryParse(Console.ReadLine(), out diaSize);
                if (diaSize == 1)
                {
                    Console.WriteLine("1이 아닌값을 입력하시오");
                }
                //정수가 아닌 경우
                else if (!numFlag)
                {
                    Console.WriteLine("숫자를 입력하세요");
                }
                else if (diaSize % 2 == 0)
                {
                    Console.WriteLine("홀수를 입력하세요");
                }
                //루프 탈출
                else
                {
                    break;
                }
            }

            //다이아몬드 크기의 중간값
            int middleNum = diaSize / 2;


            //종렬 개행용 반복문
            for (int columnI = 0; columnI < diaSize; columnI++)
            {
                //횡렬 입력용 반복문
                for (int rowJ = 0; rowJ < diaSize; rowJ++)
                {

                    //종렬의 값이 홀수의 중간값에 도달하면 *만 대입
                    if (columnI == middleNum)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("*");
                    }

                    //종렬의 값이 중간값 보다 낮을때
                    else if (columnI < middleNum)
                    {
                        // 종렬 i의 값과 중간값을 이용해 *를 대입할 범위를 지정
                        if (rowJ >= middleNum - columnI && rowJ <= middleNum + columnI)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("*");

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                        }
                    }

                    //종렬의 값이 중간값 보다 높을때
                    else if (columnI > middleNum)
                    {
                        // i가 중간값보다 커졌기 때문에 계산 변경
                        
                        // 종렬 i의 값에 중간값을 빼고 1을 더한 수를 다이아몬드 최대 크기 값에 빼서 범위를 지정해줌
                        // 변수와 반복문을 최대한 적게 쓰려고 없는 머리 쥐어 짜내서 나온 결과
                        if (rowJ >= columnI - middleNum && rowJ <= diaSize - (columnI - middleNum + 1))
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("*");

                        }

                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");

                        }
                    }
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
            #endregion

            #region 다른 방식들


            //반복문과 변수를 추가한 다른 방식

            Console.WriteLine("\n추가 1\n");

            Console.WriteLine("출력할 다이아몬드를 홀수로 입력:");

            int diaSize2;

            int.TryParse(Console.ReadLine(), out diaSize2);
            
            int topMiddle = diaSize2 / 2;
            
            //윗부분만 입력
            for (int i = 0; i < topMiddle; i++)
            {
                for(int j = 0; j < diaSize2; j++)
                {
                    if(j>= topMiddle - i && topMiddle + i >= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
            // 감소 연산자를 적용할 새로운 변수
            int bottomNum = diaSize2;

            // 밑부분을 따로 나눴다
            for (int x = 0; x < diaSize2; x++)
            {
                
                for (int y = 0; y  < bottomNum; y++)
                {
                    if ( y>= x  ) { 
                          Console.Write("*");
                    }
                    else
                    {
                          Console.Write(" ");
                    }
                }
                bottomNum--;
                Console.WriteLine();
            }


            Console.WriteLine("\n추가 2\n");



            // 인터넷에서 찾아본 다른 방식의 코드
            // 나는 if 조건문으로 범위를 지정해서 문자열을 입력한 반면
            // 이 코드는 for문만 사용했다


            int diamondSize = 7;
            int halfSize = diamondSize / 2;

            // 윗부분
            // for문 안에 for문을 두번 사용

            for (int i = 0; i <= halfSize; i++)
            {
                // 먼저 공백을 중간값 - i 까지 찍고
                for (int j = 0; j < halfSize - i ; j++)
                {
                    Console.Write(" ");

                }
                // 공백을 찍은 자리에 이어서  2 * i + 1 자리 만큼의 별만 입력하고 나머지 공백 입력은 생략
                for (int j = 0; j <  2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                // 그리고 개행
                // 다이아몬드 사이즈의 중간값까지 반복
                Console.WriteLine();
            }

            // 밑부분
            // i에 중간값 -1을 대입하고 감소연산자를 사용
            for (int i = halfSize-1 ; i >=0 ; i--)
            {
                // 중간값 - i가 j보다 작아질때까지 별의 입력을 반복한다
                // 이 반복문은 i가 점점 줄어들기 때문에 공백이 점점 늘어난다
                for (int j = 0; j < halfSize - i; j++)
                {
                    Console.Write(" ");

                }

                // 별만 입력하는 반복문 공식은 윗부분과 같다
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            #endregion
        }
    }

   
}
