using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private GameObject player;
    public AudioSource atýsSes;

    Animator enemyAnim;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        enemyAnim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Karakter");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance < 8)
        {
            timer += Time.deltaTime;

            if (timer > 2f)
            {
                atýsSes.Play();
                enemyAnim.SetBool("attackEnemy", true);
                timer = 0;
                shoot();
            }
        }
        else
        {
            enemyAnim.SetBool("attackEnemy", false);
        }

        
    }
    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }


}
