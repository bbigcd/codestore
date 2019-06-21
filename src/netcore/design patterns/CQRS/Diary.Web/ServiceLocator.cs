using Diary.CQRS;

namespace Diary.Web
{
    public class ServiceLocator
    {
        public FakeBus Bus { get; set; }

        public ServiceLocator()
        {
            Bus = new FakeBus();
            var storage = new EventStore(Bus);
            var rep = new Repository<InventoryItem>(storage);
            var commands = new InventoryCommandHandlers(rep);
            Bus.RegisterHandler<CheckInItemsToInventory>(commands.Handle);
            Bus.RegisterHandler<CreateInventoryItem>(commands.Handle);
            Bus.RegisterHandler<DeactivateInventoryItem>(commands.Handle);
            Bus.RegisterHandler<RemoveItemsFromInventory>(commands.Handle);
            Bus.RegisterHandler<RenameInventoryItem>(commands.Handle);
            var detail = new InventoryItemDetailView();
            Bus.RegisterHandler<InventoryItemCreated>(detail.Handle);
            Bus.RegisterHandler<InventoryItemDeactivated>(detail.Handle);
            Bus.RegisterHandler<InventoryItemRenamed>(detail.Handle);
            Bus.RegisterHandler<ItemsCheckedInToInventory>(detail.Handle);
            Bus.RegisterHandler<ItemsRemovedFromInventory>(detail.Handle);
            var list = new InventoryListView();
            Bus.RegisterHandler<InventoryItemCreated>(list.Handle);
            Bus.RegisterHandler<InventoryItemRenamed>(list.Handle);
            Bus.RegisterHandler<InventoryItemDeactivated>(list.Handle);
        }
    }
}