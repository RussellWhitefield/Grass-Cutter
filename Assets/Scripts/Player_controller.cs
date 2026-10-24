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

    private state currentstate = state.idle;

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

                else;
                

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
