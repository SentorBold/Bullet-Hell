using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Playercan : MonoBehaviour
{
    // Start is called before the first frame update
    public int startHp;
    int hp;
    public float bulletCooldown;
    float bullerTimer;
    public UnityEngine.UI.Text can;
    public float cantext;
    // Start is called before the first frame update
    void Start()
    {
        hp = startHp;
    }

    // Update is called once per frame
    void Update()
    {
        bullerTimer -= Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet" && bullerTimer <= 0)
        {
            hp -= 1;
            print(hp);
            bullerTimer = bulletCooldown;
            can.text = (int)cantext + "";
            cantext--;
            if (hp == 0)
            {
                SceneManager.LoadScene("Dead");
            }
        }
    }
}
