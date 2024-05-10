using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float duration = 4f;
    public int damage = 10;
    public Rigidbody2D bulletRb;
    public Player player;

    private void Awake()
    {
        bulletRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", duration);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bulletRb.MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.TakeDamage(damage);
            DestroyBullet();
        }
    }
}
