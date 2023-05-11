using Exercise02;

List<Product> itemlist = new List<Product>
            {
           new Product { Id = 1,  Name = "Biscuit  " },
           new Product { Id = 2,  Name = "Chocolate" },
           new Product { Id = 3,  Name = "Butter   " },
           new Product { Id = 4,  Name = "Brade    " },
           new Product { Id = 5,  Name = "Honey    " }
            };

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvoiceNo=100, ProductId = 3,  Quantity = 800 },
           new Purchase { InvoiceNo=101, ProductId = 5,  Quantity = 650 },
           new Purchase { InvoiceNo=102, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=103, ProductId = 4,  Quantity = 700 },
           new Purchase { InvoiceNo=104, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=105, ProductId = 4,  Quantity = 650 },
           new Purchase { InvoiceNo=106, ProductId = 1,  Quantity = 458 }
            };

Console.Write("\nSample : Generate a Right Join between two data sets : ");
Console.Write("\n--------------------------------------------------\n");
Console.Write("Here is the Product List : ");
Console.Write("\n-------------------------\n");


foreach (var item in itemlist)
{
    var x = item.Id;
    var y = item.Name;
    Console.WriteLine("Item Id: " + x + " Title: " + y);
}




Console.Write("\nHere is the Purchase List : ");
Console.Write("\n--------------------------\n");

foreach (var item in purchlist)
{
    var x = item.InvoiceNo;
    var y = item.ProductId;
    var z = item.Quantity;
    Console.WriteLine("Invoice No: " + x + " Product Id : " + y + "  Quantity : " + z);
}


Console.Write("\nHere is the list after joining  : \n\n");
Console.WriteLine("Product ID\t\tProduct Name\tPurchase Quantity");
Console.WriteLine("-------------------------------------------------------");

string[] itemName = new string[5];
var i = 0;
foreach (var item in itemlist)
{
    itemName[i] = item.Name;
    i++;
}

foreach (var item2 in purchlist)
{
    if (item2.ProductId==3 & itemName[2]== "Butter   ")
    {
        Console.WriteLine(item2.ProductId + "\t\t" + itemName[2] + "\t\t" + item2.Quantity);
    }
    else if (item2.ProductId == 5 & itemName[4] == "Honey    ")
    {
        Console.WriteLine(item2.ProductId + "\t\t" + itemName[4] + "\t\t" + item2.Quantity);
    } else if (item2.ProductId == 3 & itemName[2] == "Butter   ")
    {
        Console.WriteLine(item2.ProductId + "\t\t" + itemName[2] + "\t\t" + item2.Quantity);
    } else if (item2.ProductId == 4 & itemName[3] == "Brade    ")
    {
        Console.WriteLine(item2.ProductId + "\t\t" + itemName[3] + "\t\t" + item2.Quantity);
    }
    else if (item2.ProductId == 3 & itemName[2] == "Butter   ")
    {
        Console.WriteLine(item2.ProductId + "\t\t" + itemName[2] + "\t\t" + item2.Quantity);
    }
    else if (item2.ProductId == 4 & itemName[3] == "Brade    ")
    {
        Console.WriteLine(item2.ProductId + "\t\t" + itemName[3] + "\t\t" + item2.Quantity);
    }
    else if (item2.ProductId == 1 & itemName[0] == "Biscuit  ")
    {
        Console.WriteLine(item2.ProductId + "\t\t" + itemName[0] + "\t\t" + item2.Quantity);
    }



}


Console.ReadLine();