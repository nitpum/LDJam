using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Project/Inventory")]
public class Inventory : ScriptableObject
{
    public List<InventorySlot> slots;
}

[System.Serializable]
public struct InventorySlot
{
    public Item item;
    public int count;
}
