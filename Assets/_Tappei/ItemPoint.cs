using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// アイテムが隠されている場所
/// </summary>
public class ItemPoint : MonoBehaviour
{
    // アイテムを手に入れる
    // 必要なアイテムがあれば手に入る
    // 脱出

    /// <summary>マウスに追従するカーソル</summary>
    [SerializeField] GameObject _hitCursor;
    /// <summary>手に入れるのに必要なアイテム</summary>
    [SerializeField] GameObject[] _requirItems;
    /// <summary>クリックすることで手に入るアイテム</summary>
    [SerializeField] GameObject _getItem;
    /// <summary>クリックすることで失うアイテム</summary>
    [SerializeField] GameObject[] _lostItems;
    /// <summary>起こすイベント</summary>
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
        
        // 手に入れるのに必要なアイテムがあれば
        if (_requirItems.Length > 0)
        {
            // アイテムを持っているかどうかチェック
            if (psm.CheckItem(_requirItems))
            {
                // 必要なアイテムを持っている場合はアイテムを獲得
                if(_getItem) psm.AddItem(_getItem);
                gameObject.SetActive(false);
                
                // 失うアイテムがあれば
                if (_lostItems.Length > 1)
                {
                    psm.RemoveItem(_lostItems);
                }

                // 追加のイベントがあるなら実行する
                _event.Invoke();
            }
        }
        else
        {
            // アイテムが必要ないならばそのまま獲得
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
