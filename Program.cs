
interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodable
{
    void ApplyPromocode(string promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizeable
{
    void SetSize(byte size);
}

interface IPricable
{
    void SetPrice(double price);
}

// Клас для книг, які мають знижки та ціну
class Book : IDiscountable, IPricable
{
    public double Price { get; set; }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Applying discount: {discount} to the book.");
    }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Book price set to {price}.");
    }
}

// Клас для верхнього одягу, який має знижки, ціну, колір та розмір
class Outerwear : IDiscountable, IPricable, IColorable, ISizeable
{
    public double Price { get; set; }
    public byte Color { get; set; }
    public byte Size { get; set; }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Applying discount: {discount} to the outerwear.");
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Applying promocode: {promocode} to the outerwear.");
    }

    public void SetColor(byte color)
    {
        Color = color;
        Console.WriteLine($"Outerwear color set to {color}.");
    }

    public void SetSize(byte size)
    {
        Size = size;
        Console.WriteLine($"Outerwear size set to {size}.");
    }

    public void SetPrice(double price)
    {
        Price = price;
        Console.WriteLine($"Outerwear price set to {price}.");
    }
}
