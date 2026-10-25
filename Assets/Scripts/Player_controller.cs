using Unity.VisualScripting;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float speed = 5f;

    public enum state
    {
        idle = 0,
        run,

        attack,

        hurt

    }
    public Animator animator;
    public bool attacking = false;
    public float atkduration = 1;
    public float atktimer = 1;
    


    private state currentstate = state.idle;

    public AudioSource[] slashes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            if (currentstate == state.idle)
            {
                currentstate = state.run;
                animator.SetBool("IsRunning", true);

                if (Input.GetKey(KeyCode.D))
                {
                    transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                
                }


            }
            
        }
        else
        {
            currentstate = state.idle;
            animator.SetBool("IsRunning", false);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        }

        if (attacking == false) {
        
            if (Input.GetKey(KeyCode.Space))
            {
                attacking = true;
                atktimer = atkduration;
                //use the array of audio sources 
                //get a random int from 0 to 2
                int roll = Random.Range(0, 3);
                //use random int as an index for the slashes array
                slashes[roll].Play();

            }

        
        }

        if (attacking == true) {

            atktimer -= Time.deltaTime;

            if (atktimer <= 0)
            {
                attacking = false;
            }
        }


        if (Input.GetKey(KeyCode.A)) {
            Vector3 pos = transform.position;
            gameObject.transform.position = new Vector3(pos.x - (Time.deltaTime * speed), pos.y, pos.z);
        }

        if (Input.GetKey(KeyCode.S)) {
            Vector3 pos = transform.position;
            gameObject.transform.position = new Vector3(pos.x, pos.y - (Time.deltaTime * speed), pos.z);

        }

        if (Input.GetKey(KeyCode.D)) {
            Vector3 pos = transform.position;
            gameObject.transform.position = new Vector3(pos.x + (Time.deltaTime * speed), pos.y, pos.z);

        }

        if (Input.GetKey(KeyCode.W)) {
            Vector3 pos = transform.position;
            gameObject.transform.position = new Vector3(pos.x, pos.y + (Time.deltaTime * speed), pos.z);

        }

    } 
}
