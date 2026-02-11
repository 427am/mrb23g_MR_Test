using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    [Tooltip("Degrees per second around each axis")]
    public Vector3 rotationSpeed = new Vector3(0, 50, 0);

    // Update is called once per frame
    void Update()
    {
        // Multiply by Time.deltaTime to make the rotation frame-rate independent
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}