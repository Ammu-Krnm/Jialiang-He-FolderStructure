using UnityEngine;

public class AddColliderToComposite : MonoBehaviour
{
    public bool useMeshCollider = false; // true 使用 MeshCollider, false 使用 BoxCollider

    [ContextMenu("Add Colliders To Children")]
    void AddColliders()
    {
        foreach (Transform child in GetComponentsInChildren<Transform>())
        {
            if (child.GetComponent<Collider>() == null)
            {
                if (useMeshCollider)
                {
                    MeshFilter mf = child.GetComponent<MeshFilter>();
                    if (mf != null)
                    {
                        MeshCollider mc = child.gameObject.AddComponent<MeshCollider>();
                        mc.convex = true;
                    }
                }
                else
                {
                    child.gameObject.AddComponent<BoxCollider>();
                }
            }
        }
        Debug.Log("Colliders added!");
    }
}
