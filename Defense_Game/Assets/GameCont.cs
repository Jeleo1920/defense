using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCont : MonoBehaviour
{

    public GameObject pointerOBJ;

    // マウスでクリックした時に表示させるオブジェクト
    public GameObject defenderOBJ;
    public int ObjectNum;//出現させるオブジェクトの最高値を格納
    int ObjectWk;//現在のオブジェクト数を格納
    GameObject[] GO; // クリックしておいたゲームオブジェクトを格納
    private int setCount;
    private Text countLabel;
    private int getGPpoint;
    private GPManager gpm;
    public int price;
    private int type;
    private GameObject pObj;
    private GameObject rObj;

    public int Type { get => type; set => type = value; }

    // Start is called before the first frame update
    void Start()
    {
        setCount = 0;
        gpm = GameObject.Find("GPLabel").GetComponent<GPManager>();
        pObj = (GameObject)Resources.Load("Prefab/handgun");
        rObj = (GameObject)Resources.Load("Prefab/kantuu");
    }

    // Update is called once per frame
    void Update()
    {
        /************************
        * レイキャスト
        * マウスがクリックされた位置（オブジェクト）を表示
        ************************/
        // メインカメラから見たマウスポインタの位置をRaycastで取得
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        GO = GameObject.FindGameObjectsWithTag("Player");
        // 変数(GO)の個数を変数ObjectWkに格納
        ObjectWk = GO.Length;

        getGPpoint = gpm.gpPoint;
        setCount = getGPpoint / price;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            Debug.Log("Ray:" + hit.collider.gameObject.name);
            pointerOBJ.transform.position = hit.point;

            if (ObjectWk < ObjectNum)
            {
                if (setCount > 0)
                {
                    // 左クリックされた時
                    if (Input.GetMouseButtonDown(0))
                    {
                        if(type == 1)
                        {
                            GameObject Defender = Instantiate(pObj, hit.point, Quaternion.identity) as GameObject;
                            gpm.ReduceGP(3);
                        }
                        if (type == 2)
                        {
                            GameObject Defender = Instantiate(rObj, hit.point, Quaternion.identity) as GameObject;
                            gpm.ReduceGP(5);
                        }
                        // プレファブ化したゲームオブジェクトをインスタンス化
                        //GameObject Defender = Instantiate(defenderOBJ, hit.point, Quaternion.identity) as GameObject;
                    }
                }
            }
        }
    }
}
