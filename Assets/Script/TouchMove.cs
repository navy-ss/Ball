using UnityEngine;

public class TouchMove : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       moveSpeed = 10f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                    {
                        rb.velocity = new Vector3(-moveSpeed, 0f , 0f);
                    }
                    if (touch.position.x > Screen.width / 2)
                    {
                        rb.velocity = new Vector3(moveSpeed, 0f , 0f);
                    }
                    break;
                case TouchPhase.Ended:
                    rb.velocity = new Vector3(0f,0f,0f);
                    break;
            }
        }
    }
}
