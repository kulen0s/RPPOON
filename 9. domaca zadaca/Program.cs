using System;

interface Shape
{
    void accept(ShapeVisitor visitor);
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public void accept(ShapeVisitor visitor)
    {
        visitor.visitCircle(this);
    }
    public double getRadius()
    {
        return radius;
    }
}

class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }
    public void accept(ShapeVisitor visitor)
    {
        visitor.visitSquare(this);
    }
    public double getSide()
    {
        return side;
    }
}

class Triangle : Shape
{
    private double side1, side2, side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }
    public void accept(ShapeVisitor visitor)
    {
        visitor.visitTriangle(this);
    }

    public double getSide1()
    {
        return side1;
    }
    public double getSide2()
    {
        return side2;
    }
    public double getSide3()
    {
        return side3;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public void accept(ShapeVisitor visitor)
    {
        visitor.visitRectangle(this);
    }

    public double getLength()
    {
        return length;
    }
    public double getWidth()
    {
        return width;
    }
}

interface ShapeVisitor
{
    void visitCircle(Circle circle);
    void visitSquare(Square square);
    void visitTriangle(Triangle triangle);
    void visitRectangle(Rectangle rectangle); // New method for Rectangle
}

class AreaCalculator : ShapeVisitor
{
    public void visitCircle(Circle circle)
    {
        double area = Math.PI * circle.getRadius() * circle.getRadius();
        Console.WriteLine("Area of circle: " + area);
    }
    public void visitSquare(Square square)
    {
        double area = square.getSide() * square.getSide();
        Console.WriteLine("Area of square: " + area);
    }

    public void visitTriangle(Triangle triangle)
    {
        double s = (triangle.getSide1() + triangle.getSide2() + triangle.getSide3()) / 2;
        double area = Math.Sqrt(s * (s - triangle.getSide1()) * (s - triangle.getSide2()) * (s - triangle.getSide3()));
        Console.WriteLine("Area of triangle: " + area);
    }
    public void visitRectangle(Rectangle rectangle)
    {
        double area = rectangle.getLength() * rectangle.getWidth();
        Console.WriteLine("Area of rectangle: " + area);
    }
}

class PerimeterCalculator : ShapeVisitor
{
    public void visitCircle(Circle circle)
    {
        double perimeter = 2 * Math.PI * circle.getRadius();
        Console.WriteLine("Perimeter of circle: " + perimeter);
    }

    public void visitSquare(Square square)
    {
        double perimeter = 4 * square.getSide();
        Console.WriteLine("Perimeter of square: " + perimeter);
    }

    public void visitTriangle(Triangle triangle)
    {
        double perimeter = triangle.getSide1() + triangle.getSide2() + triangle.getSide3();
        Console.WriteLine("Perimeter of triangle: " + perimeter);
    }

    public void visitRectangle(Rectangle rectangle)
    {
        double perimeter = 2 * (rectangle.getLength() + rectangle.getWidth());
        Console.WriteLine("Perimeter of rectangle: " + perimeter);
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        Square square = new Square(4);
        Triangle triangle = new Triangle(3, 4, 5);
        Rectangle rectangle = new Rectangle(6, 8);

        ShapeVisitor areaCalculator = new AreaCalculator();
        ShapeVisitor perimeterCalculator = new PerimeterCalculator();

        circle.accept(areaCalculator);
        square.accept(areaCalculator);
        triangle.accept(areaCalculator);
        rectangle.accept(areaCalculator);

        Console.WriteLine();

        circle.accept(perimeterCalculator);
        square.accept(perimeterCalculator);
        triangle.accept(perimeterCalculator);
        rectangle.accept(perimeterCalculator);
    }
}
