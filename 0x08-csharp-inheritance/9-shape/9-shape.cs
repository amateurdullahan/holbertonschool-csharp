using System;

class Shape
{
    /// <summary> shape of what to come /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    /// <summary> rectangle shape /// </summary>
    private int width;
    public int Width
    {
        get
        {
            return (width);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    private int height;
    public int Height
    {
        get
        {
            return (height);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
    
    public new int Area()
    {
        return (height * width);
    }

    public override string ToString()
    {
        string str = "[Rectangle] " + width + " / " + height;
        return (str);    
    }
}

class Square : Rectangle
{
    /// <summary> square ///</summary>
    private int size;
    
    public int Size
    {
        get
        {
            return (size);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Height = value;
                Width = value;
            }
        }
    }

    public override string ToString()
    {
        string str = "[Square] " + size + " / " + size;
        return (str);
    }
}
