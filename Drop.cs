using UnityEngine;

public class Drop : MonoBehaviour
{
    float timeToWait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;


    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
