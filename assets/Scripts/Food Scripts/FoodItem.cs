using UnityEngine;

public abstract class FoodItemdata : ScriptableObject
{
    public string itemName;
    public string displayName;
    public Sprite icon;
}

[System.Serializable]
[CreateAssetMenu(menuName = "Food/Meat")]
public class Meat : FoodItem
{
    public bool isVegan;
    public bool isCooked;
}
