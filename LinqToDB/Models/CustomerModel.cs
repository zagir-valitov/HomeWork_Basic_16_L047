using LinqToDB.Mapping;


namespace LinqToDB.Models
{
    [Table("customers")]
    public class CustomerModel
    {
        [PrimaryKey, Identity]
        [Column("id")]
        public int CustomerID { get; set; }


        [Column("firstname")]
        public string? FirstName { get; set; }

        
        [Column("lastname")]
        public string? LastName { get; set; }


        [Column("age")]
        public int Age { get; set; }


        [Association(ThisKey = nameof(CustomerModel.CustomerID), OtherKey = nameof(OrderModel.CustomerID))]
        public OrderModel Relations { get; set; } = new OrderModel();
    }
}
