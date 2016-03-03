using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankNumber=4;
    public EnemyController tank;
    public Text LiveLabel;
    public Text ScoreLabel;
    //public GameObject tank;

    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue;
    private int _livesValue;

    // Use this for initialization
    void Start () {
		this._GenerateTanks ();
        this.intialize();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    // PUBLIC ACCESS METHOD
    public int Scorevalue
    {
        get
        {
            return this._scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score:" + this._scoreValue;
        }
    }
    public int Livesvalue
    {
        get
        {
            return this._livesValue;
        }
        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else {
                this.LiveLabel.text = "Lives:" + this._livesValue;
            }
        }
    }

    // generate Clouds
    private void _GenerateTanks() {
        for (int tankCount = 0; tankCount < this.tankNumber; tankCount++)
            Instantiate(tank.gameObject);
    }

    private void intialize()
    {

        this.Scorevalue = 0;
        this.Livesvalue = 5;
    }

    private void _endGame()
    {
        //this.HighScoreLabel.text = "HighScore:" + this._scoreValue;
       // this.GameOverLabel.enabled = true;
        //this.HighScoreLabel.enabled = true;
        this.LiveLabel.enabled = false;
        this.ScoreLabel.enabled = false;
        //this.buttercup.gameObject.SetActive(false);
        //this.star.gameObject.SetActive(false);
        //this.RestartButton.gameObject.SetActive(true);
        //this._gameOverSound.Play();
    }

    
}

