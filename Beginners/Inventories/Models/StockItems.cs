using System.ComponentModel.DataAnnotations;

namespace Inventories.Models
{
    /// <summary>
    /// 在庫品
    /// </summary>
    public sealed class StockItems
    {
        public int Id { get; set; }

        [Display(Name = "品名"), Required(ErrorMessage ="{0} を入力してください。"), StringLength(50, ErrorMessage ="{0} は最大 {1} 文字までです。")]
        public string? Name { get; set; } = "";

        [Display(Name = "ロット番号"), Required(ErrorMessage = "{0} を入力してください。"), StringLength(50, ErrorMessage = "{0} は最大 {1} 文字までです。")]
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
