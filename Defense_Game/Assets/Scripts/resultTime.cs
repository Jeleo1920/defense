using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultTime : MonoBehaviour
{

    public Text timeText;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        time = Timer.getTime();
        timeText.text = string.Format("{0}耐えたよ!!", time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
