using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// タイトル画面のエフェクト
/// </summary>
public class Effect : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator _anim;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();

        _rb.Sleep();
        _anim.enabled = false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void WakeUp()
    {
        _rb.WakeUp();
        _anim.enabled = true;
        GetComponent<AudioSource>().Play();
        Destroy(gameObject, 5.0f);
    }
}
