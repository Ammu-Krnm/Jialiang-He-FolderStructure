using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DraggableObject : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 offset;
    private Camera mainCamera;
    private bool isDragging = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (isDragging)
        {
            // 根据鼠标位置更新物体位置
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = mainCamera.WorldToScreenPoint(transform.position).z; // 保持原来的深度
            Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos) + offset;
            transform.position = worldPos;
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        rb.isKinematic = true; // 拿起时关闭物理
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mainCamera.WorldToScreenPoint(transform.position).z;
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        offset = transform.position - worldPos;
    }

    void OnMouseUp()
    {
        isDragging = false;
        rb.isKinematic = false; // 松开鼠标恢复物理
    }
}
