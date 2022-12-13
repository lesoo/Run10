using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
//플젝
{
    GameObject timerText;
    GameObject scoreText;
    GameObject generator;
    GameObject hpGauge;
  

    float time = 120.0f;
    int score = 0;
    

    public void GetItem1()
    {
        this.score += 5;
    }

    public void GetItem2()
    {
        this.score += 10;
    }
   
 
    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("time");
        this.scoreText = GameObject.Find("score");
        
        this.hpGauge=GameObject.Find("hpGauge");
        
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;

        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        this.scoreText.GetComponent<Text>().text = this.score.ToString() ;

        if(this.hpGauge.GetComponent<Image>().fillAmount<=0){
             SceneManager.LoadScene("GameoverScene");
        }
        if(this.time<0){
            SceneManager.LoadScene("GameClearScene");
        }
    }
    
    public void DecreaseHp(){
        this.hpGauge.GetComponent<Image>().fillAmount-=0.1f;
    }
    

}
