using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite playerup;
    public Sprite playerdown;
    public Sprite playerleft;
    public Sprite playerright;
    public GameObject weaponMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        weaponMove.transform.localScale = new Vector3(1, 1, 1);
        weaponMove.transform.localRotation = Quaternion.Euler(0, 0, -90);
        weaponMove.transform.localPosition = new Vector3(1.5f, -0.5f, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = playerleft;
            weaponMove.transform.localScale = new Vector3(-1, 1, 1);
            weaponMove.transform.localRotation = Quaternion.Euler(0, 0, 0);
            weaponMove.transform.localPosition = new Vector3(0.5f, 0f, 0f);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = playerright;
            weaponMove.transform.localScale = new Vector3(1, 1, 1);
            weaponMove.transform.localRotation = Quaternion.Euler(0, 0, 0);
            weaponMove.transform.localPosition = new Vector3(0.5f, 0f, 0f);
        }
        else
        {
            speedX = 0;
        }
        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = playerup;
            weaponMove.transform.localScale = new Vector3(1, 1, 1);
            weaponMove.transform.localRotation = Quaternion.Euler(0, 0, 90);
            weaponMove.transform.localPosition = new Vector3(-0.5f, 2f, 0f);
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = playerdown;
            weaponMove.transform.localScale = new Vector3(1, 1, 1);
            weaponMove.transform.localRotation = Quaternion.Euler (0, 0, -90);
            weaponMove.transform.localPosition = new Vector3(1.5f, -0.5f, 0f);
        }
        else
        {
            speedY = 0;
        }
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}