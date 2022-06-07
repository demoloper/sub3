using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class gameScript : MonoBehaviour
{
    public GameObject spawn;
    public GameObject finish;
    //public GameObject prefab;
    public int zaman;
    // Start is called before the first frame update
    void Start()
    {
        zaman = 5;
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOMoveZ(3, zaman).OnStepComplete(()=>sorgu());
        }
        

    }
    void sorgu()
    {
        
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("sads");
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("ccc");
            }
        

        
        

    }
}
