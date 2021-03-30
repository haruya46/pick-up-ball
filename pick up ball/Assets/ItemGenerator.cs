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
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
