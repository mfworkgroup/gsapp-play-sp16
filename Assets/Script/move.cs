using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour {
    
    public Camera cam;
    public MouseLook mouseLook = new MouseLook();   
    public float speed;
	public float jumpSpeed = 0.5f;

    private float cspeed;
    private Vector3 offset;
    private bool run1;
	private Vector3 move1;
	private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        mouseLook.Init(transform, cam.transform);
        offset = cam.transform.position - transform.position;

    }

    // Update is called once per frame
    void run()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0 || Input.GetAxis("updown") != 0)
        {
            cspeed = speed;
            run1 = true;

        }
        else
        {
            cspeed = 0;
            run1 = false;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            cspeed *= 10f;
            run1 = true;

        }

        if (Input.GetKey(KeyCode.Q))
        {
            speed = 0;
        }
    }
    void Update()
    {
        RotateView();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jump = (Vector3.up + rb.velocity.normalized * 0.1f) * 0.5f * jumpSpeed;
            rb.AddForce(jump, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.velocity = new Vector3(0, 0, 0);
            rb.angularVelocity = new Vector3(0, 0, 0);
        }

    }

    void FixedUpdate()
    {
        run();
        Vector3 desiredMove = cam.transform.forward * Input.GetAxis("Vertical") + cam.transform.right * Input.GetAxis("Horizontal") + cam.transform.up * Input.GetAxis("updown");
        move1 = desiredMove.normalized;
        move1 = desiredMove * cspeed;
        rb.AddForce(move1);
        if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0 && Input.GetAxis("updown") == 0)
        {
            Vector3 a = rb.velocity;
            rb.AddForce(-a);

        }



        UpdateCameraPosition();




    }
    private void RotateView()
    {

        mouseLook.LookRotation(transform, cam.transform);
    }
    private void UpdateCameraPosition()
    {
        cam.transform.position = transform.position + offset;
    }
}
public class MouseLook
{
    public float XSensitivity = 2f;
    public float YSensitivity = 2f;
    public bool clampVerticalRotation = true;
    public float MinimumX = -90F;
    public float MaximumX = 90F;
    public bool smooth;
    public float smoothTime = 5f;
    public bool lockCursor = true;


    private Quaternion m_CharacterTargetRot;
    private Quaternion m_CameraTargetRot;
    private bool m_cursorIsLocked = true;

    public void Init(Transform character, Transform camera)
    {
        m_CharacterTargetRot = character.localRotation;
        m_CameraTargetRot = camera.localRotation;
    }


    public void LookRotation(Transform character, Transform camera)
    {
        float yRot = CrossPlatformInputManager.GetAxis("Mouse X") * XSensitivity;
        float xRot = CrossPlatformInputManager.GetAxis("Mouse Y") * YSensitivity;

        m_CharacterTargetRot *= Quaternion.Euler(0f, yRot, 0f);
        m_CameraTargetRot *= Quaternion.Euler(-xRot, 0f, 0f);

        if (clampVerticalRotation)
            m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);

        if (smooth)
        {
            character.localRotation = Quaternion.Slerp(character.localRotation, m_CharacterTargetRot,
                smoothTime * Time.deltaTime);
            camera.localRotation = Quaternion.Slerp(camera.localRotation, m_CameraTargetRot,
                smoothTime * Time.deltaTime);
        }
        else
        {
            character.localRotation = m_CharacterTargetRot;
            camera.localRotation = m_CameraTargetRot;
        }

        UpdateCursorLock();
    }

    public void SetCursorLock(bool value)
    {
        lockCursor = value;
        if (!lockCursor)
        {//we force unlock the cursor if the user disable the cursor locking helper
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void UpdateCursorLock()
    {
        //if the user set "lockCursor" we check & properly lock the cursos
        if (lockCursor)
            InternalLockUpdate();
    }

    private void InternalLockUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            m_cursorIsLocked = false;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            m_cursorIsLocked = true;
        }

        if (m_cursorIsLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else if (!m_cursorIsLocked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, MinimumX, MaximumX);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }

}