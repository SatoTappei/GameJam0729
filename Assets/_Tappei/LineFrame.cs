using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ž©“®‚Å•Â‚¶‚é‘äŽŒ˜g
/// </summary>
public class LineFrame : MonoBehaviour
{
    Coroutine _autoClose;
    void OnEnable()
    {
        if (_autoClose != null)
        {
            StopCoroutine(_autoClose);
        }

        _autoClose = StartCoroutine(AutoClose());

        IEnumerator AutoClose()
        {
            yield return new WaitForSeconds(2.0f);
            gameObject.SetActive(false);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
