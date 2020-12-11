using UnityEngine;
using UnityEngine.UI;
public class MoveHero : MonoBehaviour
{
    Animator animator;
    Rigidbody rb;
    CharacterController controller;
    CapsuleCollider selfCollider;
    Vector3 direction;
    public float speed = 400f;
    public float forceJump = 20f;
    public Text MoneyText;
    private bool wannaJump = false;

    private int Money = 0;
    void Start()
    {
        selfCollider = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    { 
        //Логика управлением персонажа
        
        //Гравитация
        rb.AddForce(new Vector3(0, Physics.gravity.y * 4, 0), ForceMode.Acceleration);

        if (GM.Play)
        {
            //Прыжки
            if (wannaJump && isGrounded())
            {
                rb.AddForce(new Vector3(0, forceJump, 0), ForceMode.Impulse);
                wannaJump = false;
                Debug.Log("прыжок");
            }

            //бег в стороны
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-transform.right * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }
        }
    }

    void Update()
    {   
       
        if (isGrounded())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                wannaJump = true;  
            }
        }
        AnimationController();
    }


    bool isGrounded() 
    {
        
        return Physics.Raycast(new Vector3(transform.position.x,transform.position.y+1,transform.position.z), Vector3.down, 1.5f);
        
    }

    //Функция контроля анимации персонажа
    void AnimationController() 
    {
        if (GM.Play)
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


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) 
        {
            GM.Play = false;
            animator.SetBool("Death", true);
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Money")) 
        {
            Destroy(other.gameObject);
            Money++;
            MoneyText.text = Money.ToString();
        }
    }




}
