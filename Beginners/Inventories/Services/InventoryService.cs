using Inventories.Data;
using Inventories.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventories.Services
{
    public class InventoryService
    {
        private readonly IDbContextFactory<InventoryDbContext> dbContextFactory;

        public event EventHandler? Changed;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dbContextFactory"></param>
        public InventoryService(
            IDbContextFactory<InventoryDbContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        /// <summary>
        /// 在庫情報を全件取得する
        /// </summary>
        /// <returns></returns>
        public async ValueTask<IEnumerable<StockItems>> GetSAllAsync()
        {
            await using var dbContext = await this.dbContextFactory.CreateDbContextAsync();
            return await dbContext.StockItems.ToListAsync();
        }

        /// <summary>
        /// 在庫情報を取得する
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async ValueTask<StockItems?> GetAsync(int id)
        {
            await using var dbContext = await this.dbContextFactory.CreateDbContextAsync();
            return await dbContext.StockItems.FindAsync(id);
        }

        /// <summary>
        /// 在庫情報を登録する
        /// </summary>
        /// <param name="stockItem"></param>
        /// <returns></returns>
        public async ValueTask AddAsync(StockItems stockItem)
        {
            await using var dbContext = await this.dbContextFactory.CreateDbContextAsync();
            await dbContext.StockItems.AddAsync(stockItem);
            await dbContext.SaveChangesAsync();
            this.Changed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// 在庫情報を更新する
        /// </summary>
        /// <param name="stockItem"></param>
        /// <returns></returns>
        public async ValueTask UpdateAsync(StockItems stockItem)
        {
            await using var dbContext = await this.dbContextFactory.CreateDbContextAsync();
            dbContext.StockItems.Update(stockItem);
            await dbContext.SaveChangesAsync();
            this.Changed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// 在庫情報を削除する
        /// </summary>
        /// <param name="stockItem"></param>
        /// <returns></returns>
        public async ValueTask DeleteAsync(StockItems stockItem)
        {
            await using var dbContext = await this.dbContextFactory.CreateDbContextAsync();
            dbContext.StockItems.Remove(stockItem);
            await dbContext.SaveChangesAsync();
            this.Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}
