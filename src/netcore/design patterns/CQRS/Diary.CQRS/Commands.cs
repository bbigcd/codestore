using System;

namespace Diary.CQRS
{
    // 命令
    public class Command : Message
    {
        
    }

    // 创建命令
    public class CreateInventoryItem : Command
    {
        public readonly Guid InventoryItemId;
        public readonly string Name;

        public CreateInventoryItem(Guid inventoryItemId, string name)
        {
            InventoryItemId = inventoryItemId;
            Name = name;
        }
    }

    // 注销命令
    public class DeactivateInventoryItem : Command 
    {
        public readonly Guid InventoryItemId;
        public readonly int OriginalVersion;

        public DeactivateInventoryItem(Guid inventoryItemId, int originalVersion)
        {
            InventoryItemId = inventoryItemId;
            OriginalVersion = originalVersion;
        }
    }

    // 重命名命令
    public class RenameInventoryItem : Command {
        public readonly Guid InventoryItemId;
        public readonly string NewName;
        public readonly int OriginalVersion;

        public RenameInventoryItem(Guid inventoryItemId, string newName, int originalVersion)
        {
            InventoryItemId = inventoryItemId;
            NewName = newName;
            OriginalVersion = originalVersion;
        }
    }

    // 入库命令
    public class CheckInItemsToInventory : Command {
        public Guid InventoryItemId;
        public readonly int Count;
        public readonly int OriginalVersion;

        public CheckInItemsToInventory(Guid inventoryItemId, int count, int originalVersion) {
            InventoryItemId = inventoryItemId;
            Count = count;
            OriginalVersion = originalVersion;
        }
    }

    // 出库命令
    public class RemoveItemsFromInventory : Command {
        public Guid InventoryItemId;
        public readonly int Count;
        public readonly int OriginalVersion;

        public RemoveItemsFromInventory(Guid inventoryItemId, int count, int originalVersion)
        {
            InventoryItemId = inventoryItemId;
            Count = count;
            OriginalVersion = originalVersion;
        }
    }
}