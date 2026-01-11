using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool hit;
    private float lifetime;

    private Animator anim;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (hit) return;
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if (lifetime > 5) gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        boxCollider.enabled = false;
        if (anim != null)
        {
            if (HasAnimatorParameter(anim, "explode"))
            {
                anim.SetTrigger("explode");
            }
            else if (anim.HasState(0, Animator.StringToHash("Explode")))
            {
                anim.Play("Explode");
            }
            else
            {
                // No explode trigger or state: immediately deactivate so projectile doesn't get stuck
                Deactivate();
            }
        }
        else
        {
            // No animator attached: just deactivate the projectile
            Deactivate();
        }
  }
    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }
    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

    private bool HasAnimatorParameter(Animator animator, string paramName)
    {
        foreach (var param in animator.parameters)
        {
            // Ensure the parameter exists and is a Trigger
            if (param.name == paramName && param.type == AnimatorControllerParameterType.Trigger)
                return true;
        }
        return false;
    }
}