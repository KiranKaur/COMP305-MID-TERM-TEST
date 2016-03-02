using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankNumber=4;
    public EnemyController tank;
    //public GameObject tank;
	
	// Use this for initialization
	void Start () {
		this._GenerateTanks ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate Clouds
	private void _GenerateTanks() {
        for (int tankCount = 0; tankCount < this.tankNumber; tankCount++)
            Instantiate(tank.gameObject);
    }
	}

