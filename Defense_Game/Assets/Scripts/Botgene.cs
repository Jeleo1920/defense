using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botgene : MonoBehaviour
{
    public GameObject botPrefab;
    public float startTime;
    public float interval;

    void Start()
    {
        // startTimeで設定した時間にBotGeneメソッドを呼び出して、以降、intervalで設定した間隔でリピート実行する。
        InvokeRepeating("Gene", startTime, interval);
    }

    void Gene()
    {
        Vector3 pos = transform.position;
        Instantiate(botPrefab, new Vector3(pos.x, pos.y + 0.25f, pos.z), transform.rotation);
    }
}