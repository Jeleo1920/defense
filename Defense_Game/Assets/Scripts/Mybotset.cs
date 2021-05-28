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
    public int ObjectNum;//出現させるオブジェクトの最高値を格納
    int ObjectWk;//現在のオブジェクト数を格納
    GameObject[] GO; // クリックしておいたゲームオブジェクトを格納
    private GameObject camera;
    private GameCont gamecont;
    private int numtype;


    // Start is called before the first frame update
    void Start()
    {
        setCount = 0;
        gpm = GameObject.Find("GPLabel").GetComponent<GPManager>();
        myBotBase = GameObject.Find("MyBotBase");
        camera = GameObject.Find("Main Camera");
        gamecont = camera.GetComponent<GameCont>();
        if(this.gameObject.name == "Hundgunbutton")
        {
            numtype = 1;
        }
        if (this.gameObject.name == "riflebutton")
        {
            numtype = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        getGPpoint = gpm.gpPoint;
        setCount = getGPpoint / price;
        GO = GameObject.FindGameObjectsWithTag("Player");
        // 変数(GO)の個数を変数ObjectWkに格納
        ObjectWk = GO.Length;
    }

    public void OnMyBotButtonClicked()
    {
        //if (ObjectWk < ObjectNum)
        //{
        //    // （復習）この条件の意味は？
        //    if (setCount > 0)
        //    {
        //        Instantiate(myBotPrefab, myBotBase.transform.position + new Vector3(0, 1, 0), myBotBase.transform.rotation);
        //        gpm.ReduceGP(price);
        //        Debug.Log("生成しました");
        //    }
        // }
        gamecont.Type = numtype;

    }
}
