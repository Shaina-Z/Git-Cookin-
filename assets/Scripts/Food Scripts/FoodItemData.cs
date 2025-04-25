using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Food Item Data")]
public class FoodItemData : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite icon;
}
