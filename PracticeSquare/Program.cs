using System;

using PracticeSquare;


Plane plane = new Plane(3, 4, 5, 6);

Plane a = new Plane(1, -1, 3, -5);
Plane b = new Plane(3, 2, -1, 0);


Line line = new Line(a, b);



Console.WriteLine(plane.AngleLineAndPlane(line));



Plane plane1 = new Plane(12, 14, 2, 2);

Plane a1 = new Plane(3 ,1, 4, 6);
Plane b1 = new Plane(22, 3, 4 ,5);

Line line1 = new Line(a1, b1);

Console.WriteLine(plane1.AngleLineAndPlane(line1));
