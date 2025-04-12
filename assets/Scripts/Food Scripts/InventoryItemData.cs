using UnityEngine;

[CreateAssetMenu(menuName = "Food Item Data")]
public class InventoryItemData : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite icon;
}
