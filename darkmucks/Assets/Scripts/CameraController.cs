using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float Yrotation = 0f;
    public float Sensitivity;
    public GameObject player;



    void Update()
    {
        float mouse_x = Input.GetAxis("Mouse X") * Time.deltaTime * Sensitivity;
        float mouse_y = Input.GetAxis("Mouse Y") * Time.deltaTime * Sensitivity;

        player.transform.Rotate(Vector3.up * mouse_x);
        Yrotation -= mouse_y;
        Yrotation = Mathf.Clamp(Yrotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(Yrotation, 0, 0);

    }
}
