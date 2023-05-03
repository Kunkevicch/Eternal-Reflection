using Cinemachine;
using UnityEngine;
using Zenject;

[DisallowMultipleComponent]
[RequireComponent(typeof(CinemachineTargetGroup))]
public class CameraInit : MonoBehaviour
{
    [Inject]
    private Player _player;

    [SerializeField]
    private Transform _cursorTarget;

    private CinemachineTargetGroup _targetGroup;
    private CinemachineVirtualCamera _vCam;

    private void Awake()
    {
        _targetGroup = GetComponent<CinemachineTargetGroup>();
        _vCam = GetComponent<CinemachineVirtualCamera>();
    }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _vCam.Follow = _player.transform;
        CinemachineTargetGroup.Target targetPlayer = new CinemachineTargetGroup.Target { weight = 1f, radius = 2.5f, target = _player.transform };
        CinemachineTargetGroup.Target targetCursor = new CinemachineTargetGroup.Target { weight = 1f, radius = 1f, target = _cursorTarget };

        CinemachineTargetGroup.Target[] cinemachineTargetArray = new CinemachineTargetGroup.Target[] { targetPlayer, targetCursor };
        _targetGroup.m_Targets = cinemachineTargetArray;
    }

    private void Update()
    {
        _cursorTarget.position = HelperUtilities.GetMouseWorldPosition();
        _player.transform.LookAt(new Vector3(_cursorTarget.position.x, _player.transform.position.y, _cursorTarget.position.z));
    }
}

