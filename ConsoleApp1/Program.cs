using System.Globalization;
using System.Numerics;
using ConsoleApp1;
using Raylib_cs;

Bräde bräde = new();
Raylib.SetTargetFPS(60);
Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(), "Chess");
while (!Raylib.WindowShouldClose())
{
    Raylib.ClearBackground(Color.White);
    Raylib.BeginDrawing();
    Rita(bräde);
    Raylib.EndDrawing();
}
Raylib.CloseWindow();
static void Rita(Bräde bräde)
{
    RitaBräde(bräde);
}
static void RitaBräde(Bräde bräde)
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Raylib.DrawRectangle(i * 50, j * 50, 50, 50, Color.Gray);
        }
    }
    RitaPjäser(bräde);
    Spela(bräde);
    LäsInput(bräde);
}
static void RitaPjäser(Bräde bräde)
{
    foreach (var pjäs in bräde.pjäser)
    {
        Raylib.DrawText("Bonde", (int)pjäs.pos.X * 50, (int)pjäs.pos.Y * 50, 15, Color.Red);
        if (pjäs.isChosen)
        {
            Raylib.DrawRectangle((int)pjäs.pos.X * 50, (int)pjäs.pos.Y * 50, 50, 50, Color.Red);
        }
    }
}
static Vector2 LäsInput(Bräde bräde)
{
    Vector2 a = Raylib.GetMousePosition();
    return a;
}
static void FlyttaPjäs(Vector2 input, Bräde bräde)
{
    foreach (var pjäs in bräde.pjäser)
    {
        if (pjäs.isChosen)
        {
            pjäs.pos = input;
            TaBortValdPjäs(pjäs);
        }
    }
}
static void TaBortValdPjäs(Pjäs pjäs)
{
    pjäs.isChosen = false;
}
static void Spela(Bräde bräde)
{
    Vector2 input;
    if (!KollaOmValdPjäsFinns(bräde))
    {
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            input = LäsInput(bräde);
            input = OmvandlaInput(input);
            KollaOmInputValtPjäs(input, bräde);

        }
    }
    else
    {
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            input = LäsInput(bräde);
            input = OmvandlaInput(input);
            FlyttaPjäs(input, bräde);
        }
    }
}
static void KollaOmInputValtPjäs(Vector2 a, Bräde bräde)
{
    foreach (var pjäs in bräde.pjäser)
    {
        if (pjäs.pos == a)
        {
            pjäs.isChosen = true;
        }
    }
}
static Vector2 OmvandlaInput(Vector2 a)
{
    a.X /= 50;
    a.X = (int)a.X;
    a.Y /= 50;
    a.Y = (int)a.Y;
    return a;
}
static bool KollaOmValdPjäsFinns(Bräde bräde)
{
    bool a = false;
    foreach (var pjäs in bräde.pjäser)
    {
        if (pjäs.isChosen)
        {
            a = true;
        }
    }
    return a;
}