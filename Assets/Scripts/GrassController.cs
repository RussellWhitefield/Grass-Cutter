using UnityEngine;

public class GrassController : MonoBehaviour
{
    public AudioSource[] sfxArray;
    public Animator animator;

    public delegate void GrassDown();
    public static event GrassDown GrassDownEvent;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playerAttack")
        {
            animator.SetTrigger("grassTrigger");

            int roll = Random.Range(0, 3);
            //use random int as an index for the slashes array
            sfxArray[roll].Play();
            if (GrassDownEvent != null)
            {
                GrassDownEvent();
            }
        }
    }
}