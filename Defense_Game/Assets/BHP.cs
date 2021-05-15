using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class BHP : MonoBehaviour
{
   // public GameObject effectPrefab;
    // ★★追加
    // 2種類目のエフェクトを入れるための箱
    public GameObject effectPrefab2;
    public int hp = 5;//hpを5にする。SliderのMaxValueとValueはここの値に合わせます
    private Slider _slider;//Sliderの値を代入する_sliderを宣言
    public GameObject slider;//体力ゲージに指定するSlider

    // Use this for initialization
    void Start()
    {
        _slider = slider.GetComponent<Slider>();//sliderを取得する
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = hp;//スライダーとHPの紐づけ
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")//衝突した相手のタグがEnemyなら
        {
            hp -= 1;//hpを-1ずつ変える
        }

        if (hp <= 0)//もしhpが0以下なら
        { // もう１種類のエフェクを発生させる。
            GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
            Destroy(effect2, 2.0f);

            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Bullet")//衝突した相手のタグがEnemyなら
        {
            hp -= 1;//hpを-1ずつ変える
        }

        if (hp <= 0)//もしhpが0以下なら
        {
            // もう１種類のエフェクを発生させる。
            GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
            Destroy(effect2, 2.0f);

            Destroy(this.gameObject);
        }
    }

}

