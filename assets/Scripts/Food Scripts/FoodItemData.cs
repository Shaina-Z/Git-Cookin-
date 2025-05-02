using UnityEngine;

public abstract class FoodItemData : ScriptableObject
{
    public string itemName;
    public string displayName;
    public Sprite icon;
}

[System.Serializable]
[CreateAssetMenu(menuName = "Food/Meat")]
public class Meat : FoodItemData
{
    public bool isVegan;
    public bool isCooked;
}
