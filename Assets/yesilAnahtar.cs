using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesilAnahtar : MonoBehaviour
{
    AudioSource anahtarSesi;
    public GameObject kitliKap�;
    public GameObject ac�kKap�;

    private void Start()
    {
        anahtarSesi = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Karakter"))
        {
            anahtarSesi.Play();
            kitliKap�.SetActive(false);
            ac�kKap�.SetActive(true);
            Destroy(gameObject, 0.1f);
        }
    }
}
