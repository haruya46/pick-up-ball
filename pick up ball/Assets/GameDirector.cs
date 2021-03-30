using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timeText;
    GameObject pointText;
    float time = 30.0f;
    public int point = 0;
    GameObject generator;
    
    public void GetApple()
    {
        this.point += 2;
        
    }
    public void Getball()
    {
        this.point -= 2;
    }

    void Start()
    {
        this.generator = GameObject.Find("ItemGenerator");
        this.timeText = GameObject.Find("Time");
        this.pointText = GameObject.Find("point");
    }

    
    void Update()
    {
        this.time -= Time.deltaTime;
        if (this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().SetParameter(1000.0f,
                0, 0);
            SceneManager.LoadScene("ClerScenes");
           
        }
        else if (0 <= this.time && this.time < 5)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                0.9f, -0.04f, 3);
        }
        else if (5 <= this.time && this.time < 10)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                0.4f, -0.06f, 6);
        }
        else if (10 <= this.time && this.time < 20)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                0.7f, -0.07f, 4);
        }
        else if (20 <= this.time && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                1.0f, -0.03f, 4);
        }


        this.timeText.GetComponent<Text>().text =
            this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text =
            this.point.ToString() + "point";
    }
   
}
