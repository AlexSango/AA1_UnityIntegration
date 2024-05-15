using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    // Start is called before the first frame update
    public Light luz;
    void Start()
    {
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Parpadeo");

    }
    IEnumerator Parpadeo()
    {
        luz.intensity = 4;
        yield return new WaitForSeconds(0.2f);
        luz.intensity = 0;

    }
}
