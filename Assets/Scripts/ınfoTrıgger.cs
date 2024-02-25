using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ınfoTrıgger : MonoBehaviour
{
    public GameObject ınfoCube;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            ınfoCube.SetActive(true);
        }
        
    }
}
