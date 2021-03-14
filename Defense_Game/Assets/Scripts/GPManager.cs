using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPManager : MonoBehaviour
{
    private Text gpLabel;
    public int gpPoint;
    private float timeElapsed; //経過時間を格納
    public float addPointTime; //ポイント加算する時間

    void Start()
    {
        gpPoint = 0;
        gpLabel = GetComponent<Text>();
        gpLabel.text = "資材:" + gpPoint.ToString("D10"); // 0埋めの表示の仕方
    }

    public void AddGP(int amount)
    {
        gpPoint += amount;
        gpLabel.text = "資材:" + gpPoint.ToString("D10");
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed >= addPointTime)
        {
            gpPoint += 1;
            Debug.Log("ポイント増加");
            gpLabel.text = "資材:" + gpPoint.ToString("D10");
            timeElapsed = 0.0f;
        }
    }

    public void ReduceGP(int amount)
    {
        gpPoint -= amount;
        gpLabel.text = "資材:" + gpPoint.ToString("D10");
    }

}