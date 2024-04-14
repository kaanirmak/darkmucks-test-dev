using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    void Update()
    {
        Vector3 vector_1 = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        Vector3 vector_2 = vector_1 * speed * Time.deltaTime;
        transform.Translate(vector_2);
    }
}
