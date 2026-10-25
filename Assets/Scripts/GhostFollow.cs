using UnityEngine;

public class GhostFollow : MonoBehaviour

{

    public Vector3 playerposition;
    public float followspeed = 4f;

    public GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerposition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerposition = player.transform.position;
        MoveToPlayer();


    }
    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerposition, (followspeed * Time.deltaTime));
    }
    public void Restore()
    {
        playerposition = player.transform.position;
    }
}