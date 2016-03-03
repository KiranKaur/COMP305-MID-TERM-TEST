using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
	public float speed;
	public Boundary boundary;
    public GameController gameController;

	// get a reference to the camera to make mouse input work
	//public Camera camera; 
	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 _newPosition = new Vector2(0.0f, 0.0f);
    private Transform _transform;

    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();

    }

	// Update is called once per frame
	void Update () {
		this._CheckInput ();
	}

    private void _CheckInput()
    {
        this._newPosition = gameObject.GetComponent<Transform>().position; // current position

        //movement by keyboard
        if (Input.GetAxis("Horizontal") > 0 )
        {
            this._newPosition.x += this.speed; // add move value to current position
        }


        if (Input.GetAxis("Horizontal") < 0)
        {
            this._newPosition.x -= this.speed; // subtract move value to current position
        }
        gameObject.GetComponent<Transform>().position = this._newPosition;
    }

		// movement by mouse
		/*Vector2 mousePosition = Input.mousePosition;
		this._newPosition.x = this.camera.ScreenToWorldPoint (mousePosition).x;

		this._BoundaryCheck ();

		
	}*/

	private void _BoundaryCheck() {
		if (this._newPosition.x < this.boundary.xMin) {
			this._newPosition.x = this.boundary.xMin;
		}

		if (this._newPosition.x > this.boundary.xMax) {
			this._newPosition.x = this.boundary.xMax;
		}
	}
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            //this._starCollisionSound.Play();
            Debug.Log("Star Collision");
            this.gameController.Scorevalue += 10;


        }
        if (other.gameObject.CompareTag("Tank"))
        {
            //this._weaponCollisionSound.Play();
            this.gameController.Livesvalue -= 1;
        }
    }
}
