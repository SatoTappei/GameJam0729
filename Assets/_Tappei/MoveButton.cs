using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Cinemachine;

/// <summary>
/// ƒJƒƒ‰‚ÉˆÚ‚·”wŒi‚ğØ‚è‘Ö‚¦‚é
/// </summary>
public class MoveButton : MonoBehaviour
{
    /// <summary>”wŒi‚ğØ‚è‘Ö‚¦‚éƒJƒƒ‰</summary>
    [SerializeField] List<CinemachineVirtualCamera> _cameras = new List<CinemachineVirtualCamera>();
    /// <summary>Œ»İ‚ÌƒJƒƒ‰”Ô†</summary>
    int _currentNum;

    void Start()
    {
        _cameras[0].Priority = 99;
    }

    void Update()
    {

    }

    /// <summary>ƒJƒƒ‰‚ğØ‚è‘Ö‚¦‚é</summary>
    public void SwitchCamera(bool isRight)
    {
        _currentNum += isRight ? 1 : -1;
        if (_currentNum < 0) _currentNum = 3;
        else if (_currentNum > 3) _currentNum = 0;
        _cameras.ForEach(c => c.Priority = 10);
        _cameras[_currentNum].Priority = 99;
    }
}
