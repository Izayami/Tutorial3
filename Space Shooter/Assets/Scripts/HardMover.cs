using UnityEngine;
using System.Collections;

public class HardMover : MonoBehaviour
{
     public float speed;

     public static bool hardmode;

     private Rigidbody rb;

     void Start(){
          if (hardmode == false)
     {
          rb = GetComponent<Rigidbody>();
          rb.velocity = transform.forward * speed;
     }
      else if (hardmode == true)
     {
              rb = GetComponent<Rigidbody>();
          rb.velocity = transform.forward * -20;
     }
     }
void Update()
{
if (Input.GetKeyDown(KeyCode.H))
{
     speed = -30;
     hardmode = true;
}
if (Input.GetKeyDown(KeyCode.N))
{
speed = -5;
hardmode = false;
}
}
}