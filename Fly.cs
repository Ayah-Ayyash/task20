using UnityEngine;

public class Fly : MonoBehaviour
{
   float speed = 10f;
   Transform player;
    Vector3 playerPosition;
    
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition ,Time.deltaTime*speed);

         //playerPosition ,Time.deltaTime*speed);
    }
}
