using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingV2 : MonoBehaviour
{

    // 弾のGameObject
    public GameObject bullet;

    // 弾丸発射点のGameObjectのTransfom
    public Transform muzzle;

    public float speed = 10000; // 弾丸の速度
    public float timeOut = 20; // 時間を打つ間隔を指定
    private float timeElapsed; //経過時間を格納

    private float time; //経過した時間
    public float destroyTime = 10;　//弾が消えるまでの時間

    void Start()
    {

    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        time += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // 弾丸の複製(プレファブした弾GObjectを)
            GameObject bullets = Instantiate(bullet) as GameObject;

            // 変数：弾の力
            Vector3 force;

            // 弾丸のはじめ位置を調整
            bullets.transform.position = muzzle.position;
            // foceを計算する
            force = this.gameObject.transform.forward * speed;

            // Rigidbodyに力を加える
            bullets.GetComponent<Rigidbody>().AddForce(force);

            timeElapsed = 0.0f;

            Debug.Log("撃ちました。");

        }

        if(time >= destroyTime)
        {
            
        }

    }

}