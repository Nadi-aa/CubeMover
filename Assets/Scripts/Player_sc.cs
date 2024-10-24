using UnityEngine;

public class Player_sc : MonoBehaviour
{
    public float speed = 5.0f;

    void Start()
    {
        transform.position = new Vector3(-2, 0, 0);  
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }



}


