using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int ChickenCount = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToChickenCount()
    {
        ChickenCount++;
        Debug.Log(ChickenCount);
    }
}
