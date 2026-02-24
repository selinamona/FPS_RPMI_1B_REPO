using UnityEngine;
using UnityEngine.InputSystem;

public class FP_Controller : MonoBehaviour
{
    #region General Variables
    [Header("Movement and Look")]
    [SerializeField] GameObject camHolder; //ref en el inspector del objecto a rotar
    [SerializeField] float speed = 5f;
    [SerializeField] float crouchSpeed = 5f;
    [SerializeField] float springSpeed = 5f;
    [SerializeField] float maxForce = 1f; //fuerza maxima de aceleracion
    [SerializeField] float sensitivity = 0.1f; //sensebilidad del raton

    [Header("Player State Bools")]
    [SerializeField] bool isSprinting;
    [SerializeField] bool isCrouching;
    #endregion

    //Variables de autorefrerencia
    Rigidbody rb;

    //variables de input
    Vector2 moveInput;
    Vector2 lookInput;
    float loopRotation;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Lock del cusor del raton
        Cursor.lockState = CursorLockMode.Locked; //Lockea el cursor en el centro de la pantalla
        Cursor.visible = false; //Apaga la visualizacion del cursor
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region input methods
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {

    }
    public void OnCrouch(InputAction.CallbackContext context)
    {

    }
    public void OnSprint(InputAction.CallbackContext context)
    {

    }
    #endregion


}
