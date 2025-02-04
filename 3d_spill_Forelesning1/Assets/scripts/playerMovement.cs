using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Sette opp hastighet på spiller
    [SerializeField] float movementSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Deklarere variabel
    private PlayerControls playerControls;

    [SerializeField]
    private Transform startPosition;

    //Lage klasse
    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    //Skru på action map
    private void OnEnable()
    {
        playerControls.Enable();
    }

    //Skru av action map
    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");

        //Under: til input actions
        Vector2 inputVector = playerControls.Player1.Move.ReadValue<Vector2>();

        //Vector3 er en variabel
        Vector3 movementVector = new Vector3(inputVector.x, 0f, inputVector.y);
        //Debug.Log(movementVector);

        transform.Translate(movementVector * movementSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.position = startPosition.position;
        Debug.Log("Kollisjon");
    }
}
