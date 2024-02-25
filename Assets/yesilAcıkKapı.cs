using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yesilAcıkKapı : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject playerPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Karakter"))
        {
            collision.gameObject.SetActive(false);
            winPanel.SetActive(true);
            playerPanel.SetActive(false);
        }
    }
}
