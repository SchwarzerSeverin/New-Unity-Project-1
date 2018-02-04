using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour {

    public Scene szene;
    public CharacterController player;
   
    enum GameState {Start, Park, Graben, House, Win}
    float lastStateChange = 0.0f;
    GameState currentState = GameState.House;


   

        // Use this for initialization
        void Start () {
        RenderSettings.fog = true;
        player.transform.SetPositionAndRotation(new Vector3(269, 2, 142), new Quaternion(0, 0, 0, 0));
        setCurrentState(GameState.Park);
	}
	
    void setCurrentState(GameState state)
    {
        currentState = state;
        lastStateChange = Time.time;
    }

    float GetStateElapsed()
    {
        return Time.time - lastStateChange;
    }
	// Update is called once per frame
	void Update () {

        if (player.transform.position == new Vector3(326, 3, -36))
        {
            currentState = GameState.Graben;
        }
        if(player.transform.position ==new Vector3(292, 12, -193))
        {
            currentState = GameState.House;
        }
        

        switch (currentState)
        {
             
            case GameState.Start:
                RenderSettings.fog = true;
                break;

            case GameState.Park:
                RenderSettings.fog = false;
                break;

            case GameState.Graben:
                RenderSettings.fog = true;
               
                break;

            case GameState.House:
                RenderSettings.fogDensity =1;
                break;

            case GameState.Win:

                break;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Trigger_win")
        {
            player.transform.SetPositionAndRotation(new Vector3(269, 2, 142), new Quaternion(0, 0, 0, 0));
            currentState = GameState.Win;
        }
    }
}
