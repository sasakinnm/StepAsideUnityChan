using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //【課題】画面外にオブジェクトが出た場合にそのオブジェクトを破棄する処理
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("破棄");//確認用
    }
}
