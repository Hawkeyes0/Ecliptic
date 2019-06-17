using System;
using System.Collections.Generic;
using Ecliptic.Entities.Warehouse;

namespace Ecliptic.Spi.Warehouse
{
    public interface WarehouseService<TKey>
    {
        List<Storage> GetStorage(TKey matId, string batchNum, TKey shelfId);

        /// <summary>
        /// 根据移动记录进行库存操作，并保存移动记录。<br/>
        /// 如符合条件的库存不存在或操作后库存为负数则报错并回滚。<br/>
        /// 如果是入库操作，则增加一条库存数据；如果是出库操作，指定库存优先，否则按先进先出规则分配。
        /// </summary>
        void DoMovelog(List<MoveLog> movelogs);
    }
}
