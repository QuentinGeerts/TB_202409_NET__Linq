using DemoVarAnonyme.Models;

List<Product> products =
[
    new Product(1, "Ordinateur portable", 999.99M)
    {
        Tags = ["Informatique", "Ordinateur", "Gaming"]
    },
    new Product(2, "Souris gaming", 99.99M)
    {
        Tags = ["Informatique", "Périphérique", "Gaming"]
    },
    new Product(3, "Montre connectée", 249.99M)
    {
        Tags = ["Informatique", "Montre"]
    }
];

for (int i = 0; i < products.Count; i++)
{ 
    var product = new { ProductName = products[i].Name, ProductPrice = products[i].Price };
    Console.WriteLine($"{product.ProductName} {product.ProductPrice}");
    Console.WriteLine(product.GetType());
    Console.WriteLine();
}