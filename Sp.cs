using UnityEngine;

public class Sp : MonoBehaviour
{

    float xAngle = 0f;
    float yAngle = 0.5f;
    float zAngle = 0f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
