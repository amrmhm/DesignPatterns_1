using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Design_Patterns.Proxy.EX;

public class DbContext
{
    private Dictionary<int, Product> updatedObjects = new Dictionary<int, Product>();

    public Product getProduct(int id)
    {
        // Automatically generate SQL statements
        // to read the product with the given ID.
        Console.WriteLine($"SELECT * FROM products WHERE product_id = {id} \n");

        // Simulate reading a product object from a database.
        var product = new ProxyProduct(this, id);
        product.setName("Product 2");

        return product;
    }

    public void saveChanges()
    {
        // Automatically generate SQL statements
        // to update the database.
        foreach (var updatedObject in updatedObjects.Values)
            Console.WriteLine($"UPDATE products SET name = '{updatedObject.getName()}' WHERE product_id = {updatedObject.getId()} \n");

        updatedObjects.Clear();
    }

    public void markAsChanged(Product product)
    {
        updatedObjects[product.getId()] = product;
    }
}
