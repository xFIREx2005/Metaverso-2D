using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FazendaLife : MonoBehaviour
{
    public Text txtVida;
    public float life = 5;
    private void Update()
    {
        txtVida.text = life.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if(life > 0)
            {
                life--;
                Destroy(collision.gameObject);
                if (life <= 0)
                {
                    SceneManager.LoadScene("Perdeu");
                }
            } 
            
        }
    }
}
