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

    //�y�ۑ�z��ʊO�ɃI�u�W�F�N�g���o���ꍇ�ɂ��̃I�u�W�F�N�g��j�����鏈��
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("�j��");//�m�F�p
    }
}
