using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        
    }
    // When the animal collides with the food, both will be destroyed.
    private void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
