namespace Diary.CQRS
{
    public class InventoryCommandHandlers
    {
        private readonly IRepository<InventoryItem> _repository;
        
        public InventoryCommandHandlers(IRepository<InventoryItem> repository)
        {
            _repository = repository;
        }

        // 创建事件处理
        public void Handle(CreateInventoryItem message)
        {
            var item = new InventoryItem(message.InventoryItemId, message.Name);
            _repository.Save(item, -1);
        }
        
        // 注销事件处理
        public void Handle(DeactivateInventoryItem message)
        {
            var item = _repository.GetById(message.InventoryItemId);
            item.Deactivate();
            _repository.Save(item, message.OriginalVersion);
        }
        
        // 删除事件处理
        public void Handle(RemoveItemsFromInventory message)
        {
            var item = _repository.GetById(message.InventoryItemId);
            item.Remove(message.Count);
            _repository.Save(item, message.OriginalVersion);
        }

        // 入库事件处理
        public void Handle(CheckInItemsToInventory message)
        {
            var item = _repository.GetById(message.InventoryItemId);
            item.CheckIn(message.Count);
            _repository.Save(item, message.OriginalVersion);
        }

        // 重命名事件处理
        public void Handle(RenameInventoryItem message)
        {
            var item = _repository.GetById(message.InventoryItemId);
            item.ChangeName(message.NewName);
            _repository.Save(item, message.OriginalVersion);
        }
    }
}