using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="apple")
        {
            Debug.Log("Tag=Apple");
        }
        else
        {
            Debug.Log("Tag=Bomb");
        }
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }
}
