using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Vector2 _jumpForce;
    [SerializeField] private SceneData _sceneData;
    private float _startPos = 0;
    private Rigidbody2D _thisRigidbody;

    private void Start()
    {
        _thisRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            switch (touch.phase)
            {
                case TouchPhase.Stationary:
                case TouchPhase.Moved:
                    _startPos = touch.position.x * 24f / Screen.width - 12f;
                    if (_startPos < transform.localPosition.x)
                        transform.position = new Vector3(transform.localPosition.x - 0.1f, transform.localPosition.y, 0);
                    if (_startPos > transform.localPosition.x)
                        transform.position = new Vector3(transform.localPosition.x + 0.1f, transform.localPosition.y, 0);
                    break;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _sceneData.BallHitsAdd();
        _thisRigidbody.AddForce(_jumpForce * (collision.transform.position.y < transform.position.y ? 1 : -1), ForceMode2D.Impulse);
        if (collision.transform.tag == "Platform")
            collision.transform.GetComponent<PlatformColor>().BallTouchThis();
    }

    public void ChangeRigidbodySimulated()
    {
        _thisRigidbody.simulated = !_thisRigidbody.simulated;
    }
}
