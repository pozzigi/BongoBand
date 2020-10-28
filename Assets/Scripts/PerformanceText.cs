using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerformanceText : MonoBehaviour
{

    public string ScoreLabelName;

    // Start is called before the first frame update

    void Start(){    
        
        PlayerPrefs.SetInt(ScoreLabelName, 0); //Sets Score to be always 0 when starting

    }

    // Update is called once per frame
    void Update(){

        //Updates the Score Text
        GetComponent<Text>().text = PlayerPrefs.GetInt(ScoreLabelName, 0) + "";
        

    }
}
