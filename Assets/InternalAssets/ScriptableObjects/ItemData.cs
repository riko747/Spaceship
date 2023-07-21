using InternalAssets.Scripts.Ship.Items;
using UnityEngine;

namespace InternalAssets.ScriptableObjects
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "Items/ItemData", order = 1)]
    public class ItemData : ScriptableObject
    {
        public string ItemName;
    }
}
