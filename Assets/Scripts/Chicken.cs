using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Pool;

public class Chicken : MonoBehaviour
{
    private GameObject chosenCoop;
    [SerializeField] NavMeshAgent chickenAgent;

    public IObjectPool<Chicken> Pool { get; set; }

    private void Update()
    {
        if (chosenCoop != null)
        {
            //chickenAgent.SetDestination(chosenCoop.);
        }
    }
    private void OnEnable()
    {
        chickenAgent = GetComponent<NavMeshAgent>();
        var Coops = GameObject.FindGameObjectsWithTag("ChickenCoop");
        chosenCoop = Coops[Random.Range(0, Coops.Length)];
        chickenAgent.SetDestination(chosenCoop.transform.position);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == chosenCoop)
        {
            //GameManager.Instance.AddToChickenCount();
            gameObject.SetActive(false);
            //Pool.Release(this);
        }
    }
}
