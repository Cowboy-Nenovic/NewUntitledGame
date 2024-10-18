using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D body;
    private bool grounded;
    private Vector3 mousePos;
    private Camera mainCam;
       
       void Start(){
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
       }
       private void Awake()
   {
    body = GetComponent<Rigidbody2D>();
       
   }

    private void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        float horizontalMousePos = mousePos.x;
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * 2, body.velocity.y);

        if (horizontalMousePos > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalMousePos < 0.01f)
            transform.localScale = new Vector3(-1,1,1);

        if (Input.GetKeyDown(KeyCode.Space) == true && grounded)
        Jump();


    }

    private void Jump()
    {
        body.velocity = Vector2.up * 5;
        grounded = false;
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

}
