using UnityEngine;

public class SpwnMnger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] animalPrefb;
    private int spwnPosZ = 24;
    private int spwnPosX = 28;
    private int startDelay = 1;
    private float spwnInterval = 0.5f;
    void Start()
    {
        //auto repeat the spwn function after a delay of 2 seconds and repeat every 1.5 seconds
        InvokeRepeating("spawnAnimals", startDelay, spwnInterval);
    }

    void spawnAnimals() {
        //randomly generate animal index and spwn postion
        int animalIndex = Random.Range(0, animalPrefb.Length);
        Vector3 spwnPos = new Vector3(Random.Range(-spwnPosX, spwnPosX), 0, spwnPosZ);
        Instantiate(animalPrefb[animalIndex], spwnPos, animalPrefb[animalIndex].transform.rotation);

    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
