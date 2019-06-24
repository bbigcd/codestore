using System;

namespace Diary.CQRS
{
    // 事件
    public class Event : Message
    {
        public int Version; 
    }

    // 创建事件
    public class InventoryItemCreated : Event 
    {
        public readonly Guid Id;
        public readonly string Name;

        public InventoryItemCreated(Guid id, string name)
        {
            Id = id;
            Name = name;            
        }
    }

    // 重命名事件
    public class InventoryItemRenamed : Event
    {
        public readonly Guid Id;
        public readonly string NewName;

        public InventoryItemRenamed(Guid id, string newName)
        {
            Id = id;
            NewName = newName;
        }
    }

    // 停用事件
    public class InventoryItemDeactivated : Event
    {
        public readonly Guid Id;
        public InventoryItemDeactivated(Guid id)
        {
            Id = id;
        }        
    }

    // 入库事件
    public class ItemsCheckedInToInventory : Event
    {
        public Guid Id;
        public readonly int Count;

        public ItemsCheckedInToInventory(Guid id, int count)
        {
            Id = id;
            Count = count;            
        }
    }

    // 出库事件
    public class ItemsRemovedFromInventory : Event
    {
        public Guid Id;
        public readonly int Count;

        public ItemsRemovedFromInventory(Guid id, int count)
        {
            Id = id;
            Count = count;
        }
    }
}