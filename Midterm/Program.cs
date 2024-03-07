public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
        // TODO: Initialize the properties with the values passed to the constructor.
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        // TODO: Update the item's price with the new price.
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
        // TODO: Increase the item's stock quantity by the additional quantity.
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine($"Not enough stock to sell {quantitySold} items.");
        }
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item:{ItemName}, ID:{ItemId}, Price: ${Price}, Stock Quantity: {QuantityInStock}");
        // TODO: Print the details of the item (name, id, price, and stock quantity).
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        item1.PrintDetails();
        item2.PrintDetails();
        // 2. Sell some items and then print the updated details.   
        item1.SellItem(3);
        item2.SellItem(5);
        // 3. Restock an item and print the updated details.
        item1.RestockItem(5);
        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($"Item 1 in stock: {item1.IsInStock()}");
        Console.WriteLine($"Item 2 in stock: {item2.IsInStock()}");


    }
}
