using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] GameObject targetObj;
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projSpawn;
    private GameObject chicken;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var target = GameObject.FindGameObjectsWithTag("Chicken");
        chicken = target[Random.Range(0, target.Length)];
        Instantiate(projectile, new Vector3(projSpawn.transform.position.x, projSpawn.transform.position.y, projSpawn.transform.position.z), Quaternion.identity);
    }
}
