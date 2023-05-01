using UnityEngine;

#region Attributes
[DisallowMultipleComponent]
[RequireComponent(typeof(PlayerCharacterControlComponent))]
#endregion
public class Player : MonoBehaviour
{
    #region Attributes
    [Header("MOVEMENT DETAILS")]
    [SerializeField]
    #endregion
    private float _moveSpeed;
    public float MoveSpeed => _moveSpeed;

    private void Awake()
    {
        
    }
}
