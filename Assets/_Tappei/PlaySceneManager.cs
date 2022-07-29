using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// ゲーム全体を管理する
/// </summary>
public class PlaySceneManager : MonoBehaviour
{
    /// <summary>台詞枠</summary>
    [SerializeField] GameObject _lineFrame;
    /// <summary>台詞を表示するテキスト</summary>
    [SerializeField] Text _lineText;
    /// <summary>獲得したアイテムを表示させる枠</summary>
    [SerializeField] Transform _itemParent;

    /// <summary>現在持っているアイテム</summary>
    Dictionary<string, GameObject> _haveItemDic = new Dictionary<string, GameObject>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>所持アイテムを追加</summary>
    public void AddItem(GameObject item)
    {
        string key = item.GetComponent<Item>().Key;

        _lineFrame.SetActive(true);
        _lineText.text = key + "を手に入れた！";
        var obj = Instantiate(item, Vector3.zero, Quaternion.identity);
        obj.transform.SetParent(_itemParent);
        obj.transform.localScale = Vector3.one;
        _haveItemDic.Add(key, obj);
    }

    /// <summary>所持アイテムを削除</summary>
    public void RemoveItem(GameObject[] items)
    {
       for(int i = 0;i < items.Length; i++)
       {
            string key = items[i].GetComponent<Item>().Key;

            _haveItemDic.TryGetValue(key, out GameObject result);
            Destroy(result);
       }
    }

    /// <summary>必要なアイテムを所持しているかチェック</summary>
    public bool CheckItem(GameObject[] items)
    {
        for(int i = 0; i < items.Length; i++)
        {
            string key = items[i].GetComponent<Item>().Key;
            if (!_haveItemDic.ContainsKey(key)) return false;
        }
        return true;
    }

    /// <summary>ゲームクリアのイベント</summary>
    public void GameClear()
    {
        SceneManager.LoadScene("Result");
    }
}
