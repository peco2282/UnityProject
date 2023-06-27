using System.Diagnostics.CodeAnalysis;
using UnityEngine;

[SuppressMessage("ReSharper", "IdentifierTypo")]
public class PlayerController : MonoBehaviour
{
  [SerializeField] private Animator animator;

  private bool _isMoving;

  [SerializeField] private float speed;

  private float _hval, _vval;
  private static readonly int IsMove = Animator.StringToHash("isMove");
  private static readonly int Goal = Animator.StringToHash("Goal");

  // Start is called before the first frame update
  void Start()
  {
    _hval    = Input.GetAxis("Horizontal");
    _vval    = Input.GetAxis("Vertical");
    animator = GetComponent<Animator>();
    if (animator == null) Debug.Log("Animation component cannot find.");
  }

  // Update is called once per frame
  void Update()
  {
    var state = false;
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      state = true;
      transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }

    if (Input.GetKey(KeyCode.RightArrow))
    {
      state              =  true;
      transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    if (Input.GetKey(KeyCode.UpArrow))
    {
      state              =  true;
      transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
    }

    animator.SetBool(IsMove, state);
  }

  void OnCollisionEnter(Collision other)
  {
    Debug.Log(other);
    Debug.Log("collisionenter.");
  }
}