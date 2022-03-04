
using MathApp;

var pyth = new Pyhtagoras();
var circ = new Circle();
var rect = new Rectangle();
var squr = new Square();

backtostart:
Console.WriteLine("Please choose what you would like to calculate!");
Console.WriteLine("Enter one of the listed letter ( use capital letter ) : P = Pyhtagoras, C = Circle, R = Rectangle, S = Square ");
char letter = Convert.ToChar(Console.ReadLine());

if(!(letter == 'P' || letter =='C' || letter =='R' || letter == 'S'))
{
  Console.WriteLine("You have entered a wrong letter : {0} , please use CAPITAL letter or choose the right action", letter);
  Console.WriteLine("Please select one of the action, enter a letter of : P or C or R or S ");
  Console.WriteLine("----------------------------------------------------------------");
  goto backtostart;
}
  
else if (letter == 'P')
{
    Console.WriteLine("This is Hypotenuse calculator accordingly for Pyhtagoras theorem");
    Console.WriteLine("Please enter a number for side A : ");
    pyth.sidaA= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter a number for side B : ");
    pyth.sideB= Convert.ToDouble(Console.ReadLine());
    pyth.HypotenuseDisplay();
}
else if(letter == 'C')
{
    Console.WriteLine("This is Circle Area and Perimeter calculator");
    Console.WriteLine("Please enter value of the radius : ");
    circ.Radius= Convert.ToDouble(Console.ReadLine());
    circ.CircleDisplay();
}
else if( letter == 'R')
{
    Console.WriteLine("This is Rectangle Area and Perimeter calculator");
    Console.WriteLine("Please enter value of Length : ");
    rect.Length= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter value of Width : ");
    rect.Width= Convert.ToDouble(Console.ReadLine());
    rect.RectangleDisplay();
}
else if( letter == 'S')
{
    Console.WriteLine("This is Square Area and Perimeter calculator");
    Console.WriteLine("Please enter value of Side : ");
    squr.Side = Convert.ToDouble(Console.ReadLine());
    squr.SquareDisplay();
}
