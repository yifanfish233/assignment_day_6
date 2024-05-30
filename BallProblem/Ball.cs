namespace BallProblem;

public class Ball
{
    // 实例变量
    public int Size { get; private set; }
    public Color Color { get; private set; }
    private int throwCount;

    // 构造函数
    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
        throwCount = 0;
    }

    // Pop 方法，将大小设置为 0
    public void Pop()
    {
        Size = 0;
    }

    // Throw 方法，增加 throwCount，只有在球没有被 Pop 的情况下
    public void Throw()
    {
        if (Size > 0)
        {
            throwCount++;
        }
    }

    // 获取球被扔的次数
    public int GetThrowCount()
    {
        return throwCount;
    }

    // public Color GetColor()
    // {
    //     return Color;
    // }
}
