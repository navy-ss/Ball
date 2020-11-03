using UnityEngine;

public class InputController : MonoBehaviour {

    void Update () {

        if (Input.GetMouseButtonUp (0)) {

            Vector3 worldMousePsition = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 100f));

            Vector3 direction = worldMousePsition - Camera.main.transform.position;

            RaycastHit hit;

            if (Physics.Raycast (Camera.main.transform.position, direction, out hit, 100f)) {

                Debug.DrawLine (Camera.main.transform.position, hit.point, Color.green, 0.5f);

                if (hit.rigidbody != null && hit.collider.gameObject.tag == "Ball") {
                    hit.rigidbody.AddForce (0f, 300f, 0f);
                }
                
            } else {

                Debug.DrawLine (Camera.main.transform.position, worldMousePsition, Color.red, 0.5f);
                
            }
            
        }
        
    }
}