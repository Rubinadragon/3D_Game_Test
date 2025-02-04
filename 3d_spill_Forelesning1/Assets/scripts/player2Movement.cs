using UnityEngine;

public class player2Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;

    private PlayerControls playerControls;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    //Skru p� action map
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
        Vector2 inputVector = playerControls.Player2.Move.ReadValue<Vector2>();

        //Vector3 er en variabel
        Vector3 movementVector = new Vector3(inputVector.x, 0f, inputVector.y);
        //Debug.Log(movementVector);

        transform.Translate(movementVector * movementSpeed * Time.deltaTime);
    }
}
