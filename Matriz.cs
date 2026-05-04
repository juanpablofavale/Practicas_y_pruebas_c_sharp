
Console.WriteLine("Prueba con matrices");
/*
string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
*/
/*
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"The first fraudulent order ID is: {fraudulentOrderIDs[0]}");
Console.WriteLine($"The second fraudulent order ID is: {fraudulentOrderIDs[1]}");
Console.WriteLine($"The third fraudulent order ID is: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent order IDs in the array.");
*/
/*
int[] inventory = {200,450,700,175,250};
int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}
Console.WriteLine($"The sum of all inventory items is: {sum}");
*/

string[] pedidos = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
foreach (string pedido in pedidos)
{
    if (pedido.StartsWith("B"))
    {
        Console.WriteLine(pedido);
    }
}