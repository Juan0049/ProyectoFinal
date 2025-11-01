using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.DrawRay(ray.origin, ray.direction * 100f, Color.cyan, 1f);
            }
        }
    }
}
