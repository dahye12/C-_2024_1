using System.ComponentModel.Design;

//140 swich를 if else if로 바꾸기 
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("점수를 입력하시오: ");
        int score = int.Parse(Console.ReadLine());

        //조건문
        switch (score/10) // 99를 넣으면 10으로 나눠지니까 몫이 9가 됨 
        {
            case 10:
            case 9:
                Console.WriteLine("A학점입니다.");
                break;
            case 8:
                Console.WriteLine("A학점입니다.");
                break;
            case 7:
                Console.WriteLine("A학점입니다.");
                break;
            case 6:
                Console.WriteLine("A학점입니다.");
                break;
             default:
                Console.WriteLine("재수강으로 분발하세요.");
                break;
        }
        
    }
}




