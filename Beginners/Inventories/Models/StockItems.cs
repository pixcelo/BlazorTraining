using System.ComponentModel.DataAnnotations;

namespace Inventories.Models
{
    /// <summary>
    /// 在庫品
    /// </summary>
    public sealed class StockItems
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string? Name { get; set; } = "";

        [Required, StringLength(50)]
        public string? LotNumber { get; set; } = "";

        public int Quantity { get; set; }

        public DateTime ArrivalDate { get; set; }

        /// <summary>
        /// 同じレコードを同時に更新した場合に検知するための情報
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();
    }
}
