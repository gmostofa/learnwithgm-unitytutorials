using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactDistance;
    public Camera playerCamera;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
            
            Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward, Color.red);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactDistance))
            {
                if (hit.collider.tag == "mytag")
                {
                    DoorController doorController = hit.collider.GetComponent<DoorController>();
                    if (doorController != null)
                    {
                        doorController.ToggleDoor();
                    }
                }
            }
        }
    }
}
