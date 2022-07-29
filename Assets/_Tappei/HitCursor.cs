using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// マウスカーソルに追従する虫眼鏡アイコン
/// </summary>
public class HitCursor : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mouse.x, mouse.y, -9);
    }
}
