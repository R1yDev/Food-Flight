using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float limitBound = 30;
    public float lowerBound = -10;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // destroy the food when it goes out of the screen
        if (transform.position.z > limitBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
