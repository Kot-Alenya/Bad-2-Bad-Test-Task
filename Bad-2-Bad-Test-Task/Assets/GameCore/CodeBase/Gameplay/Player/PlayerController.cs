using GameCore.CodeBase.Gameplay.Enemy;
using GameCore.CodeBase.Gameplay.Enemy.Target;
using GameCore.CodeBase.Gameplay.Item;
using GameCore.CodeBase.Gameplay.Item.Data;
using GameCore.CodeBase.Gameplay.Item.Inventory;
using GameCore.CodeBase.Gameplay.Player.Data;
using GameCore.CodeBase.Gameplay.Player.Model;
using GameCore.CodeBase.Infrastructure.Data;
using GameCore.CodeBase.Infrastructure.Services.ProgressSaveLoader.Watcher;
using UnityEngine;

namespace GameCore.CodeBase.Gameplay.Player
{
    public class PlayerController : MonoBehaviour, IEnemyTarget, IItemCollector,
        IProgressReader<PlayerProgressData>, IProgressWriter<PlayerProgressData>
    {
        private PlayerModel _model;
        private PlayerUI _ui;

        public void Construct(PlayerModel model, PlayerUI ui)
        {
            _model = model;
            _ui = ui;
        }

        public InventoryController Inventory => _model.Inventory;

        public Vector3 Position => transform.position;

        public void Move(Vector2 direction) => _model.Movement.MovePosition(direction);

        public void Rotate(Vector2 direction) => _model.Movement.MoveRotation(direction);

        public void SelectEnemy(EnemyController enemy) => _model.Weapon.SelectEnemy(enemy);

        public void DeselectEnemy(EnemyController enemy) => _model.Weapon.DeselectEnemy(enemy);

        public void Shoot() => _model.Weapon.Shoot();

        public void TakeDamage(int value)
        {
            _model.TakeDamage(value);
            _ui.SetHealth(_model.Health.Get());
        }

        public void CollectItem(ItemData data) => _model.Inventory.AddItem(data);

        public void OnProgressLoad(PlayerProgressData progress) => _model.OnProgressLoad(progress);

        public void OnProgressSave(PlayerProgressData progress) => _model.OnProgressSave(progress);
    }
}