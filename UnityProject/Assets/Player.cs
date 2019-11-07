using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("速度"), Range(1, 100)]
    public int speed = 50;
    [Header("跳躍"), Range(1, 200)]
    public float jump = 2.5f;
    public bool isGround;
    private Rigidbody r3d;
    // Use this for initialization
    private void Start()
    {
        r3d = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Walk(); 
        Jump();
    }
 private void OnCollisionEnter (Collision collision)
    {
        isGround = true;
        Debug.Log("碰到東西：" + collision.gameObject);
    }
    /// <summary>
    /// 走路
    /// </summary>
    void Walk()
    {
        r3d.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0,0));
        r3d.AddForce(new Vector3(0,0,speed * Input.GetAxis("Vertical")));

    }
    /// <summary>
    /// 跳躍
    /// </summary>
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r3d.AddForce(new Vector3(0, jump,0));
        }
    }
   
}
