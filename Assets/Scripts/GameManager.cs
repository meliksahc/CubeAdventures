using UnityEngine;

public class GameManager : MonoBehaviour
{
	#region Singleton class: GameManager

	public static GameManager Instance;

	void Awake ()
	{
		if (Instance == null) {
			Instance = this;
		}
	}

	#endregion

	Camera cam;
    public float timeScaleFactor = 1f;
    public CharacterP ball;
	public Trajectory trajectory;
	[SerializeField] float pushForce = 4f;

	bool isDragging = false;

	Vector2 startPoint;
	Vector2 endPoint;
	Vector2 direction;
	Vector2 force;
	float distance;

	public Animator kameraAnimasyon;
	public Animator cAnimasyon;

	public AudioSource tıklamaSesi;

	//---------------------------------------
	void Start ()
	{
		cam = Camera.main;
		ball.DesactivateRb ();
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			tıklamaSesi.Play();
			kameraAnimasyon.SetBool("kameraRed", true);
			cAnimasyon.SetBool("TutCek", true);
            Time.timeScale = 0.3f;
            isDragging = true;
			OnDragStart ();
		}
		if (Input.GetMouseButtonUp (0)) {
			tıklamaSesi.Play();
            kameraAnimasyon.SetBool("kameraRed", false);
            cAnimasyon.SetBool("TutCek", false);
            Time.timeScale = 1f;
            isDragging = false;
			OnDragEnd ();
		}

		if (isDragging) {
			OnDrag ();
		}
	}

	//-Drag--------------------------------------
	void OnDragStart ()
	{
		ball.DesactivateRb ();
		startPoint = cam.ScreenToWorldPoint (Input.mousePosition);

		trajectory.Show ();
	}

	void OnDrag ()
	{
		endPoint = cam.ScreenToWorldPoint (Input.mousePosition);
		distance = Vector2.Distance (startPoint, endPoint);
		direction = (startPoint - endPoint).normalized;
		force = direction * distance * pushForce;

		//just for debug
		Debug.DrawLine (startPoint, endPoint);


		trajectory.UpdateDots (ball.pos, force);
	}

	void OnDragEnd ()
	{
		//push the ball
		ball.ActivateRb ();

		ball.Push (force);

		trajectory.Hide ();
	}
}
