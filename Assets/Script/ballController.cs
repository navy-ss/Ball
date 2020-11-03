
using UnityEngine;

public class ballController : MonoBehaviour
{
    private Rigidbody rb;
    public Joystick joystick;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
 
    void HandleMovement()
    {
        float moveHorizontal = joystick.Horizontal;
        Vector3 movement = new Vector3(moveHorizontal*0.1f, 0, 0);
        transform.position = transform.position + movement;
    }
   void Update()
    {
       /* 
        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(new Vector3(0f, 500f, 0f));
        }*/
        HandleMovement();
        
    }

    
    /*
      void Update () {
         if (Input.touchCount > 0)
         {
             var touch = Input.GetTouch(0);
             if (touch.position.x < Screen.width/2)
             {
                rb.Velocity = new Vector3(- moveSpeed, 0f , 0f); 
             }
             else if (touch.position.x > Screen.width/2)
             {
                rb.Velocity = new Vector3(moveSpeed, 0f, 0f); 
             }
         }
         
     }
     */
}
