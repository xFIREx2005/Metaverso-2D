using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprPlayer;
    private Vector2 moveDirection;
    public float speed;
    public GameObject bullet;
    public int life;
    public Text txtVida;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprPlayer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        txtVida.text = life.ToString();
        ProcessInputs();
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        sprPlayer.flipX = (mousePos.x < screenPoint.x);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    public void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }

    public void DamageEnemy(int damageBullet)
    {
        life -= damageBullet;
        StartCoroutine(Damage());
        if (life <= 0)
        {
            SceneManager.LoadScene("Perdeu");
        }
    }

    IEnumerator Damage()
    {
        sprPlayer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprPlayer.color = Color.white;
    }
}
