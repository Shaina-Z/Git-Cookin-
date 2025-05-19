using UnityEngine;

[CreateAssetMenu(menuName = "Food/Vegetable")]
public class Vegetable : FoodItemData
{
    public bool isPrepped;
    public bool isWashed;
    public string cuttingMethod;
}
