namespace BallProblem;

    
class Program
{
    static void Main(string[] args)
    {

        Color redColor = new Color(255, 0, 0);
        Ball ball1 = new Ball(5, redColor);
        Ball ball2 = new Ball(10, new Color(0, 255, 0));
        Ball ball3 = new Ball(15, new Color(0, 0, 255));
        
        ball1.Throw();
        ball1.Throw();
        ball2.Throw();
        ball2.Throw();
        ball2.Throw();
        ball3.Throw();


        ball1.Pop();
        ball2.Pop();


        ball1.Throw();
        ball2.Throw();


        Console.WriteLine("Ball 1 throw count: " + ball1.GetThrowCount());
        Console.WriteLine("Ball 2 throw count: " + ball2.GetThrowCount());
        Console.WriteLine("Ball 3 throw count: " + ball3.GetThrowCount());
    }
}