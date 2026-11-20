using System.Globalization;
using System.Numerics;
using ConsoleApp1;
using Raylib_cs;

Bräde bräde = new();

Raylib.SetTargetFPS(60);
Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(),"Chess");
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
    for(int i = 0; i<8; i++)
    {
        for(int j = 0; j<8; j++)
        {
            Raylib.DrawRectangle(i*50,j*50,50, 50, Color.Gray);
        }
    }
    RitaPjäser(bräde);
    LäsInput(bräde);
}
static void RitaPjäser(Bräde bräde)
{
    
}
static void ValdRuta(Vector2 a, Bräde bräde)
{
    Raylib.DrawRectangle((int)a.X, (int)a.Y, 55,55, Color.Blue);
    a.X /= 50;
    a.Y /= 50;
    foreach(Pjäs pjäs in bräde.pjäser)
    {
        pjäs
    }

    
}
static void LäsInput(Bräde bräde)
{
    Vector2 a = Raylib.GetMousePosition();
    if (Raylib.IsMouseButtonDown(MouseButton.Left))
    {
        ValdRuta(a, bräde);
    }
}