using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float duration = 4f;
    public Rigidbody2D bulletRb;

    private void Awake()
    {
        bulletRb = GetComponent<Rigidbody2D>();
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
}
