using LinqToDB.Mapping;


namespace LinqToDB.Models
{
    [Table("products")]
    public class ProductModel
    {
        [PrimaryKey, Identity]
        [Column("id")]        
        public int ProductID { get; set; }


        [Column("name")]
        public string? ProductName { get; set; }


        [Column("description")]
        public string? Description { get; set; }


        [Column("stockquantity")]
        public int StockQuantity { get; set; }


        [Column("price")]
        public decimal Price { get; set; }


        //[Association(ThisKey = nameof(ProductModel.ProductID), OtherKey = nameof(OrderModel.ProductID))]
        //public OrderModel Relations { get; set; } = new OrderModel();


        //public static ProductModel Build(ProductModel product, OrderModel order)
        //{
        //    if (product != null)
        //    {
        //        product.Relations = order;
        //    }
        //    return product;
        //}
    }
}
