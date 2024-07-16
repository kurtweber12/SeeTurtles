using UnityEngine;

public class TurtleController : MonoBehaviour
{
    private Animator animator;
    public Transform oceanDestination;
    public float walkSpeed = 1.0f;
    public LayerMask groundLayer; 
    
    private bool isWalking = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        gameObject.SetActive(false); 
    }

    void Update()
    {
        if (isWalking)
        {
            float step = walkSpeed * Time.deltaTime;
            Vector3 targetPosition = Vector3.MoveTowards(transform.position, oceanDestination.position, step);

            // Adjust the target position to follow the ground
            if (Physics.Raycast(targetPosition + Vector3.up, Vector3.down, out RaycastHit hit, Mathf.Infinity, groundLayer))
            {
                targetPosition.y = hit.point.y;
            }

            transform.position = targetPosition;

            // Check if the turtle has reached the ocean
            if (Vector3.Distance(transform.position, oceanDestination.position) < 0.1f)
            {
                isWalking = false;
                animator.SetBool("IsWalking", false); 
                gameObject.SetActive(false); 
            }
        }
    }

    public void StartWalking()
    {
        isWalking = true;
        animator.SetBool("IsWalking", true); 
        gameObject.SetActive(true); 
    }
}
