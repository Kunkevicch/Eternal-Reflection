using UnityEngine;

#region Attributes
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Player))]
#endregion
public class PlayerCharacterControlComponent : MonoBehaviour
{ 
    private Player _player;
    

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        
    }
}
