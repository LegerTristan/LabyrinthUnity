using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f, rotationSpeed = 100f;
    private float currentSpeed;

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = speed * 2;
        }
        else
        {
            currentSpeed = speed;
        }
        transform.Rotate(Vector3.up * rotationSpeed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.right * currentSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }
}
