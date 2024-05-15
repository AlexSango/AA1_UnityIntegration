using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource Telefono;
    public AudioClip Tef;
    // Start is called before the first frame update
    void Start()
    {
        Telefono = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Telefono"))
        {
            Telefono.PlayOneShot(Tef);
        }
    }
    */
}
