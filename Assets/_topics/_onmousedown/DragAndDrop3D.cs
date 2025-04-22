using UnityEngine;

public class DragAndDrop3D : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    public Transform dropZone;

    void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            var tempPosition = GetMouseWorldPos() + offset;
            tempPosition.y = 0.5f;
            transform.position = tempPosition;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
        
        float distance = Vector3.Distance(transform.position, dropZone.position);
        if (distance < 1.0f) 
        {
            Debug.Log("Yummy! 🍎🐻");
            Destroy(gameObject);
        }
    }

    Vector3 GetMouseWorldPos()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            return hit.point;
        }
        return transform.position;
    }
}