using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPivot : MonoBehaviour
{
    public Camera cam;
    public Transform gunHolder;
    public Transform firePoint;
    public GameObject bullet;

    private void Update()
    {
        RotateGun();
        PlayerInput();
    }

    void RotateGun()
    {
        Vector2 distancevector = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition) - (Vector2)gunHolder.position;
        float angle = Mathf.Atan2(distancevector.y, distancevector.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void PlayerInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }
}
