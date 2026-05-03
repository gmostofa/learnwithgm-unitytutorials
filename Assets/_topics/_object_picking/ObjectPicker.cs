using DG.Tweening;
using UnityEngine;

public class ObjectPicker : MonoBehaviour
{
    public float pickupRange = 3f;
    public Transform holdPoint;
    public GameObject heldObject;
    public Vector3 previousPosition;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldObject == null)
            {
                TryPickObject();
            }
            else
            {
                DropObject();
            }
        }
    }

    private void DropObject()
    {
       Rigidbody rb = heldObject.GetComponent<Rigidbody>();
       heldObject.transform.SetParent(null);
       rb.isKinematic = false;
       
       //heldObject.transform.position = previousPosition;

       heldObject.transform.DOMove(previousPosition, 0.25f);

       heldObject = null;
    }

    private void TryPickObject()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, pickupRange))
        {
            if (hit.collider.CompareTag("Pickable"))
            {
                heldObject = hit.collider.gameObject;
                
                Rigidbody rb = heldObject.GetComponent<Rigidbody>();
                rb.useGravity = false;
                rb.isKinematic = true;
                
                previousPosition = heldObject.transform.position;
                
                //heldObject.transform.position = holdPoint.position;
                
                heldObject.transform.DOMove(holdPoint.position, 0.25f);
                heldObject.transform.SetParent(holdPoint);
            }
        }
    }
}