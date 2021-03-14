using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mybotset : MonoBehaviour
{
    private int setCount;
    private Text countLabel;
    private int getGPpoint;
    private GPManager gpm;
    public int price;
    public GameObject myBotPrefab;
    private GameObject myBotBase;

    // Start is called before the first frame update
    void Start()
    {
        setCount = 0;
        gpm = GameObject.Find("GPLabel").GetComponent<GPManager>();
        myBotBase = GameObject.Find("MyBotBase");
    }

    // Update is called once per frame
    void Update()
    {
        getGPpoint = gpm.gpPoint;
        setCount = getGPpoint / price;
    }

    public void OnMyBotButtonClicked()
    {
        // （復習）この条件の意味は？
        if (setCount > 0)
        {
            Instantiate(myBotPrefab, myBotBase.transform.position+new Vector3(0,1,0), myBotBase.transform.rotation);
            gpm.ReduceGP(price);
            Debug.Log("生成しました");
        }
    }
}
