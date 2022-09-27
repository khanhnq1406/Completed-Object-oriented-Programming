class Bill
{
    struct BillDetails
    {
        public int bill_no;
        public int items_purchased;
        public string[] item_name;
        public int[] item_price;
    }
    static void Main()
    {
        BillDetails bill;
        double total_price = 0;
        Console.Write("Input bill number: ");
        bill.bill_no = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of items purchased: ");
        bill.items_purchased = Convert.ToInt32(Console.ReadLine());
        bill.item_name = new string[bill.items_purchased];
        bill.item_price = new int[bill.items_purchased];
        for (int i = 0; i < bill.items_purchased; i++)
        {
            Console.Write("Input item name {0}: ", i+1);
            bill.item_name[i] = Console.ReadLine();
            Console.Write("Input item price for item {0}: ",i+1);
            bill.item_price[i] = Convert.ToInt32(Console.ReadLine());
            total_price = total_price + bill.item_price[i];
        }
        Console.WriteLine("Total number of items purchased are " + bill.items_purchased);
        Console.WriteLine("Total bill amount for the items purchases is " + total_price);
    }
}