using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float speed = 5.0f;
    public float HorizontalInput; 
    public float xAxis = -30;
    public GameObject proPrefab;
    
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        // move the player on the x axis
        transform.Translate(HorizontalInput*speed*Time.deltaTime,0,0);
        // make the player stay inside the screen (on bouth sides)
        
        if(transform.position.x < xAxis)
        {
            transform.position = new Vector3(xAxis, transform.position.y , transform.position.z);
        }
        else if (transform.position.x > -xAxis)
        {
            transform.position = new Vector3(-xAxis, transform.position.y , transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            //lunch the food from the player when space is pressed
           Instantiate(proPrefab, transform.position, proPrefab.transform.rotation);
        }
       
    }
}
