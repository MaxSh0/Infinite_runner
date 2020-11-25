using UnityEngine;

public class MoveHero : MonoBehaviour
{
    Animator animator;
    CharacterController controller;
    Vector3 direction;
    public float speed = 10f;
    public float forceJump = 10f;
    public float gravity = 20f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Логика управлением персонажа
        float input = Input.GetAxis("Horizontal");
        if (controller.isGrounded)
        {
            direction = new Vector3(input, 0f, 0f);
            direction = transform.TransformDirection(direction) * speed;

            if (Input.GetButton("Jump"))
            {
                direction.y = forceJump;
            }
        }
        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);
        AnimationController();
    }

    //Функция контроля анимации персонажа
    void AnimationController() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            animator.SetTrigger("Jump");
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Left", true);
            animator.SetBool("Right", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Right", true);
            animator.SetBool("Left", false);
        }
        else
        {
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }
    }
}
