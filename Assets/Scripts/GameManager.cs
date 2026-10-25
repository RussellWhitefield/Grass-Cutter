using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int grassCount;

    private void OnEnable()
    {
        GrassController.GrassDownEvent += CountGrass;
    }

    private void OnDisable()
    {
        GrassController.GrassDownEvent -= CountGrass;
    }

    public void CountGrass()
    {
        grassCount++;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
