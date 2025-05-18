using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int inventorySize = 3;
    public InventorySlot[] slots;

    private void Awake()
    {
        slots = new InventorySlot[inventorySize];
        for (int i = 0; i < inventorySize; i++)
        {
            slots[i] = new InventorySlot();
        }
    }

    public bool AddItem(FoodItemData item, int amount = 1)
    {
        // Look for existing stackable slot
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == item)
            {
                slots[i].quantity += amount;
                return true;
            }
        }

        // Look for empty slot
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null)
            {
                slots[i].item = item;
                slots[i].quantity = amount;
                return true;
            }
        }

        // Inventory full
        return false;
    }

    public void RemoveItem(int slotIndex)
    {
        if (slotIndex < 0 || slotIndex >= slots.Length) return;

        slots[slotIndex].item = null;
        slots[slotIndex].quantity = 0;
    }
}
