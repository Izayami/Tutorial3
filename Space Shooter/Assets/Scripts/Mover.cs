using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
     public float speed;

     public static bool hardmode;

     private Rigidbody rb;

     void Start()
     {
          hardmode = false;
          rb = GetComponent<Rigidbody>();
          rb.velocity = transform.forward * speed;
     }
void Update()
{
if (Input.GetKeyDown(KeyCode.H))
{
     speed = -50;
     hardmode = true;
}
if (Input.GetKeyDown(KeyCode.N))
{
speed = -5;
hardmode = false;
}
}
}