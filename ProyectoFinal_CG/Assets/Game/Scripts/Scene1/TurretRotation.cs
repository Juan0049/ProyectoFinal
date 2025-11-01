using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    private float rotationSpeed = 25f;

    void Update()
    {
        transform.Rotate(new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));
    }
}
