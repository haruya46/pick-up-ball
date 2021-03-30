using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip ballSE;
    AudioSource aud;
    GameObject director;


     void Start()
    {
        this.director = GameObject.Find("GameDirector");
        this.aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="apple")
        {
            this.director.GetComponent<GameDirector>().GetApple();
            this.aud.PlayOneShot(this.appleSE);
        }
        else
        {
            this.director.GetComponent<GameDirector>().Getball();
            this.aud.PlayOneShot(this.ballSE);
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
