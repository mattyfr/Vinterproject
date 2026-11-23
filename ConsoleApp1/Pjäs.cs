using System;
using System.Numerics;

namespace ConsoleApp1;

public class Pjäs
{
    private bool isWhite;
    public Vector2 pos = new Vector2(Random.Shared.Next(0,8), Random.Shared.Next(0,8));
    public bool isChosen;
}
