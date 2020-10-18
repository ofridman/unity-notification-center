using UnityEngine;
namespace AxlPlay
{
    public class PlayerController : MonoBehaviour
    {
        public float RotationSpeed = 5f;

        public float Speed = 5f;

        private bool canMove;
        private Vector3 moveInput;
        private Vector3 forward;
        private Vector3 right;

        private CharacterController characterController;

        private void Awake()
        {
            characterController = GetComponent<CharacterController>();
        }
        void Start()
        {
            // create a notification center delegate
            NotificationCenter.DefaultCenter.AddObserver(this, "GameStarted");
            NotificationCenter.DefaultCenter.AddObserver(this, "GamePaused");
            NotificationCenter.DefaultCenter.AddObserver(this, "GameResumed");


        }
        void GameStarted(NotificationCenter.Notification note)
        {

            canMove = true;

        }

        void GamePaused(NotificationCenter.Notification note)
        {

            canMove = false;

        }

        void GameResumed(NotificationCenter.Notification note)
        {

            canMove = true;

        }
        void Update()
        {
            if (canMove)
            {

                GetInputAndValues();
                Move();
                Rotate();

            }
        }
        void GetInputAndValues()
        {
            moveInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

            //get the input direction for the camera position.



            forward = Camera.main.transform.TransformDirection(Vector3.forward);
            forward.y = 0f;
            forward = forward.normalized;
            right = new Vector3(forward.z, 0.0f, -forward.x);
        }
        void Move()
        {
            var _move = (moveInput.x * right + moveInput.y * forward);

            _move.Normalize();


            if (_move != Vector3.zero)
            {
                characterController.SimpleMove(_move * Speed);


            }
        }
        void Rotate()
        {
            var _direction = (moveInput.x * right + moveInput.y * forward);
            if (_direction != Vector3.zero)
            {

                transform.forward = Vector3.Lerp(transform.forward, _direction, Time.deltaTime * RotationSpeed);
            }
        }

    }
}