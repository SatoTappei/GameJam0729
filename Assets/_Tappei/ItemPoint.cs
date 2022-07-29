using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// �A�C�e�����B����Ă���ꏊ
/// </summary>
public class ItemPoint : MonoBehaviour
{
    // �A�C�e������ɓ����
    // �K�v�ȃA�C�e��������Ύ�ɓ���
    // �E�o

    /// <summary>�}�E�X�ɒǏ]����J�[�\��</summary>
    [SerializeField] GameObject _hitCursor;
    /// <summary>��ɓ����̂ɕK�v�ȃA�C�e��</summary>
    [SerializeField] GameObject[] _requirItems;
    /// <summary>�N���b�N���邱�ƂŎ�ɓ���A�C�e��</summary>
    [SerializeField] GameObject _getItem;
    /// <summary>�N���b�N���邱�ƂŎ����A�C�e��</summary>
    [SerializeField] GameObject[] _lostItems;
    /// <summary>�N�����C�x���g</summary>
    [SerializeField] UnityEvent _event;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        PlaySceneManager psm = FindObjectOfType<PlaySceneManager>();
        
        // ��ɓ����̂ɕK�v�ȃA�C�e���������
        if (_requirItems.Length > 0)
        {
            // �A�C�e���������Ă��邩�ǂ����`�F�b�N
            if (psm.CheckItem(_requirItems))
            {
                // �K�v�ȃA�C�e���������Ă���ꍇ�̓A�C�e�����l��
                if(_getItem) psm.AddItem(_getItem);
                gameObject.SetActive(false);
                
                // �����A�C�e���������
                if (_lostItems.Length > 1)
                {
                    psm.RemoveItem(_lostItems);
                }

                // �ǉ��̃C�x���g������Ȃ���s����
                _event.Invoke();
            }
        }
        else
        {
            // �A�C�e�����K�v�Ȃ��Ȃ�΂��̂܂܊l��
            if (_getItem) psm.AddItem(_getItem);
            gameObject.SetActive(false);
        }
    }

    private void OnMouseEnter()
    {
        _hitCursor.SetActive(true);
    }

    private void OnMouseExit()
    {
        _hitCursor.SetActive(false);
    }
}
