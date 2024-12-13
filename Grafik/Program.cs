using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(800, 600, "God Jul");

Raylib.SetTargetFPS(60);

Vector2[] snowflakes = new Vector2[200];

for (int i = 0; i < snowflakes.Length; i++)
{
  snowflakes[i] = new Vector2(
    Random.Shared.Next(800), 
    Random.Shared.Next(600)
  );
}


Vector2 leftEye = new(375, 275);
Vector2 rightEye = new(425, 275);

Vector2 hat1 = new(400, 50);
Vector2 hat2 = new(360, 185);
Vector2 hat3 = new(440, 185);

Vector2 beard1 = new(360, 385);
Vector2 beard2 = new(400, 500);
Vector2 beard3 = new(440, 385);

while (Raylib.WindowShouldClose() == false)
{
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.SkyBlue);

  Raylib.DrawCircle(400, 300, 100, Color.Yellow);
  Raylib.DrawCircleV(leftEye, 10, Color.Black);
  Raylib.DrawCircleV(rightEye, 10, Color.Black);

  Raylib.DrawRectangle(350, 185, 100, 30, Color.White);
  Raylib.DrawTriangle(hat1, hat2, hat3, Color.Red);
  Raylib.DrawTriangle(beard1, beard2, beard3, Color.White);

  Raylib.DrawRing(
    new(400, 300),
    68, 73,
    45, 135,
    10, Color.Black
  );

  for (int i = 0; i < 200; i++)
  {
    Raylib.DrawCircleV(snowflakes[i], 3, Color.White);
  }

  Raylib.EndDrawing();
}
