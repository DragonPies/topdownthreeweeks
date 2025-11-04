using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private float walkspeed = 5f;
    [SerializeField] private float runspeed = 10f;

    private float currentSpeed;
   private Vector2 movement;
    private Rigidbody2D rb2D;

    [HideInInspector] public Vector2 direction;

    public SpriteRenderer spriteRenderer;
    public Sprite FacingUp;
    public Sprite FacingDown;
    public Sprite FacingLeft;
    public Sprite FacingRight;


    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        currentSpeed = walkspeed;
        direction = Vector2.down;
    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        rb2D.linearVelocity = movement * currentSpeed;

       
    }

    private void FixedUpdate()
    {
        // Handle sprite direction
        if (direction == Vector2.up)
        {
            spriteRenderer.sprite = FacingUp;
        }
        else if (direction == Vector2.down)
        {
            spriteRenderer.sprite = FacingDown;
        }
        else if (direction == Vector2.left)
        {
            spriteRenderer.sprite = FacingLeft;
        }
        else if (direction == Vector2.right)
        {
            spriteRenderer.sprite = FacingRight;
        }
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();

        if (ctx.ReadValue<Vector2>() != Vector2.zero)
        {
            direction = ctx.ReadValue<Vector2>();
        }
    }


    public void Run(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 1) //pressed
        {
            currentSpeed = runspeed;
        }
        else //released
        {
            currentSpeed = walkspeed;
        }
    }


}

