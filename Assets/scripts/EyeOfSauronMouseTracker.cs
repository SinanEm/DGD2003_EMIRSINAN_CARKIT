using UnityEngine;

public class EyeOfSauronMouseTracker : MonoBehaviour
{
    public Camera mainCamera;
    public float rotationSpeed = 5f;

    void Update()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Mathf.Abs(mainCamera.transform.position.z - transform.position.z);

        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);

        Vector3 direction = worldPos - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }
}