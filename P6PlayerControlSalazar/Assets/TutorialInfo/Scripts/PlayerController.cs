using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Optionally assign the main camera automatically if not set in Inspector
        if (maincamera == null)
        {
            maincamera = Camera.main;
        }
    }

    public float speed = 20.0f;
    public float turnspeed = 45.0f; // Changed 'private' to 'public' for visibility in the Unity Inspector
    public float horizantelInput; // Changed 'private' to 'public' for visibility in the Unity Inspector
    public float verticalInput;

    // Removed duplicate private fields for speed, turnspeed, and horizantelInput
    private readonly float forwardInput; // Marked as readonly to address IDE0044

    // Add this field to define the switch key, e.g., KeyCode.Space
    public KeyCode switchKeydown = KeyCode.Space;

    // Add this field to reference the main camera
    public Camera maincamera;

    // Add this field to reference the hood camera
    public Camera HoodCamera;

    void Update()
    {
        horizantelInput = Input.GetAxis("Horizontal");
        // Moves the vehicle forward based on vertical input
        float forwardInput = Input.GetAxis("Vertical");
        // rotates the vehicle based on horizontal input

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);   
        transform.Rotate(Vector3.up, turnspeed * horizantelInput * Time.deltaTime); // Fixed variable name to match declaration


        if (Input.GetKeyDown(switchKeydown))
        {
           maincamera.enabled = !maincamera.enabled; 

           HoodCamera.enabled = !HoodCamera.enabled; 
        }
    }
}
