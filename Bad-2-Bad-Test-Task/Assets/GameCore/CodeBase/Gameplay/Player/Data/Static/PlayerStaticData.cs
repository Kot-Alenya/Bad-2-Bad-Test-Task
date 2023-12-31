using GameCore.CodeBase.Gameplay.Health.Data;
using GameCore.CodeBase.Gameplay.Weapon;
using UnityEngine;

namespace GameCore.CodeBase.Gameplay.Player.Data.Static
{
    [CreateAssetMenu(menuName = "Configurations/Player", fileName = "PlayerConfig", order = 0)]
    public class PlayerStaticData : ScriptableObject
    {
        public PlayerObjectPrefabData ObjectPrefab;
        public PlayerOuterCanvasPrefabData OuterCanvasPrefab;
        public PlayerMovementStaticData MovementData;
        public WeaponStaticData WeaponData;
        public HealthStaticData HealthData;
        public int InventorySize;
    }
}