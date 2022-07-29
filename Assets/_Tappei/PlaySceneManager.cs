using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// �Q�[���S�̂��Ǘ�����
/// </summary>
public class PlaySceneManager : MonoBehaviour
{
    /// <summary>�䎌�g</summary>
    [SerializeField] GameObject _lineFrame;
    /// <summary>�䎌��\������e�L�X�g</summary>
    [SerializeField] Text _lineText;
    /// <summary>�l�������A�C�e����\��������g</summary>
    [SerializeField] Transform _itemParent;

    /// <summary>���ݎ����Ă���A�C�e��</summary>
    Dictionary<string, GameObject> _haveItemDic = new Dictionary<string, GameObject>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>�����A�C�e����ǉ�</summary>
    public void AddItem(GameObject item)
    {
        string key = item.GetComponent<Item>().Key;

        _lineFrame.SetActive(true);
        _lineText.text = key + "����ɓ��ꂽ�I";
        var obj = Instantiate(item, Vector3.zero, Quaternion.identity);
        obj.transform.SetParent(_itemParent);
        obj.transform.localScale = Vector3.one;
        _haveItemDic.Add(key, obj);
    }

    /// <summary>�����A�C�e�����폜</summary>
    public void RemoveItem(GameObject[] items)
    {
       for(int i = 0;i < items.Length; i++)
       {
            string key = items[i].GetComponent<Item>().Key;

            _haveItemDic.TryGetValue(key, out GameObject result);
            Destroy(result);
       }
    }

    /// <summary>�K�v�ȃA�C�e�����������Ă��邩�`�F�b�N</summary>
    public bool CheckItem(GameObject[] items)
    {
        for(int i = 0; i < items.Length; i++)
        {
            string key = items[i].GetComponent<Item>().Key;
            if (!_haveItemDic.ContainsKey(key)) return false;
        }
        return true;
    }

    /// <summary>�Q�[���N���A�̃C�x���g</summary>
    public void GameClear()
    {
        SceneManager.LoadScene("Result");
    }
}
