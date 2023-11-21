using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    public AudioSource source;

    private void OnMouseDown()
    {
        source.pitch = Mathf.Pow(2f, transform.localPosition.x / 12f);
        source.Play();
    }


    private void OnTriggerEnter(Collider other)
    {
        source.pitch = Mathf.Pow(2f, transform.localPosition.x / 12f);

        source.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        source.Stop();
    }
}
