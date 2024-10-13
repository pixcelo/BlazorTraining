namespace Inventories.Models
{
    /// <summary>
    /// 在庫品
    /// </summary>
    public sealed class StockItems
    {
        public int Id { get; set; }

        public string? Name { get; set; } = "";

        public string? LotNumber { get; set; } = "";

        public int Quantity { get; set; }

        public DateTime ArrivalDate { get; set; }
    }
}
