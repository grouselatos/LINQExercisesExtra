namespace LINQExercisesExtra
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"ProductID: {ProductID} - ProductName: {ProductName} - Category: {Category} - UnitPrice: {UnitPrice} - UnitsInStock: {UnitsInStock}";
        }
    }
}
