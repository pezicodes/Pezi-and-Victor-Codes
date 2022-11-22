using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class Test : MonoBehaviour
{

    public Image progressImageBar;

    public Text progressbarText;

    public int loadingtime = 10;

    float timestart = 0;

    void Start()
    {
        progressImageBar.color = Color.cyan;
        progressbarText.color = Color.cyan;
    }

    void Update(){
    
        timestart += Time.deltaTime;

        if (timestart > 0)
        {
            progressImageBar.fillAmount = timestart / loadingtime;

        }

        else{
            return;
        }

        progressbarText.text = ((int)(progressImageBar.fillAmount * 100)).ToString() + "%";

    }



}
