using UnityEngine;

public class playerctl : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rd;
    private bool faceRight = true;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rd.MovePosition(rd.position + Vector2.right * moveX * speed * Time.deltaTime*10);

        if (Input.GetKeyDown(KeyCode.Space))
            rd.AddForce(Vector2.up * 8000);
        if (moveX > 0 && !faceRight)
            flip();
        else if (moveX < 0 && faceRight)
            flip();
    }
    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

    }
}
