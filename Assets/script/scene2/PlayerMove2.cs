using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionAsset InputActions;
    private InputAction moveAction;

    private Vector2 movementVector;
    private float speed = 2f;

    private InputAction jumpAction;
    private float jump = 5f;

    private Animator animasi;
    public Rigidbody2D rb;

    public bool Lantai = false;
    public bool Dinding = false;

    public TextMeshProUGUI skorteks;
    public bool atasbox = false;
    void Awake()
    {
        skorteks.text = managerDragon.Instance.skorscene2.ToString();
    }
    public void TambahSkor(int jumlah)
    {
        managerDragon.Instance.skorscene2 += jumlah;
        skorteks.text = managerDragon.Instance.skorscene2.ToString();
    }
    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }
    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }
    void Start()
    {
        moveAction = InputActions.FindAction("Move");
        jumpAction = InputActions.FindAction("Jump");
        animasi = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public void onBox(bool status)
    {
        atasbox = status;
    }
    // Update is called once per frame
    void Update()
    {
        movementVector = moveAction.ReadValue<Vector2>();
        rb.linearVelocity = new Vector2(movementVector.x * speed, rb.linearVelocity.y);

       if (movementVector.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movementVector.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        animasi.SetBool("run", movementVector.x != 0);
        animasi.SetBool("ground", Lantai);
        animasi.SetBool("jump", !Lantai);

        if (jumpAction.triggered && (Lantai||Dinding||atasbox))
        {
            Jump();
            animasi.SetTrigger("jump");
        }
    }
    private void Jump()
    {
        if (Dinding && !Lantai)
        {
            rb.linearVelocity = new Vector2(movementVector.x, jump);
        } else
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
        }
        Lantai = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("NextScene"))
        {
            SceneManager.LoadScene("Permainan2");
        }
    }
}



