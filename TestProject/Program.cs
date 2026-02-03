string[] Fraud_ids = {"B123", "C234", "A345", "C4", "B177", "CS350", "C305", "B179"};

foreach (string id in Fraud_ids)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}