using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject ballPrefab;
    float span = 1.0f;
    float delta = 0;
    int ratio = 5;
    float speed = -0.03f;

    // Start is called before the first frame update
    public void SetParameter(float span,float speed,int ratio)
    {
        this.span = span;
        this.speed = speed;
        this.ratio = ratio;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if(dice<=this.ratio)
            {
                item = Instantiate(ballPrefab) as GameObject;
            }
            else
            {
                item = Instantiate(applePrefab) as GameObject;
            }
            float x = Random.Range(-7,7);
            item.transform.position = new Vector2(x, 6);
            item.GetComponent<ItemController>().dropSpeed = this.speed;
        }
    }
}
