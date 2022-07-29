using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    [SerializeField] Button _button;
    /// ƒQ[ƒ€‚ÌÅ‰‚É–ß‚é

    private void Start()
    {
        _button.onClick.AddListener(() => StartCoroutine(RestartButton()));
    }

    IEnumerator RestartButton()
    {
        yield return new WaitForSeconds(1.0f);
        //Debug.Log("wait");
        SceneManager.LoadScene("Tanimura");
    }


    //public void OnClickStartButton()
    //{
    //    SceneManager.LoadScene("Tanimura");
    //}


}
