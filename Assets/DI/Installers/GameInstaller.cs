using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField]
    private Player _player;

    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<Player>().FromComponentInNewPrefab(_player).AsSingle().NonLazy();
    }
}