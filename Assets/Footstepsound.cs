using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnStone;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);
        myAudioSource.volume = Random.Range(0.8f, 1.0f);

        switch (material)
        {
            case "Stone":
                myAudioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
                break;

            case "Wood":
                myAudioSource.PlayOneShot(footstepsOnStone[Random.Range(0, footstepsOnStone.Length)]);
                break;

            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Stone":
            case "Wood":
                material = collision.gameObject.tag;
                PlayFootstepSound();
                break;

            default:
                break;
        }
    }
}
