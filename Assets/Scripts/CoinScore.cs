using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinScore : MonoBehaviour
{
    public TextMeshProUGUI _text;
    public AudioSource CoinSes;
    public static int totalScore;
    Animator cAnimation;
    private void Start()
    {
        cAnimation = GetComponent<Animator>();
        totalScore = 0;
    }
    private void Update()
    {
        _text.text = totalScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            cAnimation.SetTrigger("sarý");
            CoinSes.Play();
            Destroy(collision.gameObject);
            totalScore++;
            _text.text = totalScore.ToString();
        }
        if (collision.gameObject.CompareTag("Dusman"))
        {
            cAnimation.SetTrigger("dusman");
        }
    }
}
