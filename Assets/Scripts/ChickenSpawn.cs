using UnityEngine;

public class ChickenSpawn : MonoBehaviour
{
    [SerializeField] GameObject chicken;
    private float TimeSinceLastChicken = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (TimeSinceLastChicken <= 0.001f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                SpawnChicken();
            }
       }
       
       TimeSinceLastChicken -= Time.deltaTime;

    }

    private void SpawnChicken()
    {
        Instantiate(chicken, new Vector3(45, 1, 50), Quaternion.identity);
        TimeSinceLastChicken = 0.1f;
    }
}
