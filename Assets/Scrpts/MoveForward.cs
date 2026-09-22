using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 40.0f;
    
    void Update()
    {
        //make the food move on the z axis
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
