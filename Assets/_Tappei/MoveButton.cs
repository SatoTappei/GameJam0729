using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Cinemachine;

/// <summary>
/// �J�����Ɉڂ��w�i��؂�ւ���
/// </summary>
public class MoveButton : MonoBehaviour
{
    /// <summary>�w�i��؂�ւ���J����</summary>
    [SerializeField] List<CinemachineVirtualCamera> _cameras = new List<CinemachineVirtualCamera>();
    /// <summary>���݂̃J�����ԍ�</summary>
    int _currentNum;

    void Start()
    {
        _cameras[0].Priority = 99;
    }

    void Update()
    {

    }

    /// <summary>�J������؂�ւ���</summary>
    public void SwitchCamera(bool isRight)
    {
        _currentNum += isRight ? 1 : -1;
        if (_currentNum < 0) _currentNum = 3;
        else if (_currentNum > 3) _currentNum = 0;
        _cameras.ForEach(c => c.Priority = 10);
        _cameras[_currentNum].Priority = 99;
    }
}
