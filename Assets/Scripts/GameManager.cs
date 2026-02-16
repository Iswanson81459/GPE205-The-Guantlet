using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Prefab")]
    public static GameManager instance;
    public GameObject playerControllerPrefab;
    public GameObject playerPawnPrefab;
    public Transform spawnLocation;
    [Header("Up-to-date Lists")]
    public List<Pawn> tanks;
    public List<Controller> players;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        tanks = new List<Pawn>();
        players = new List<Controller>();        
    }

    void Start()
    {
        // Start The GAME!!!
        StartGame();
    }

    public void StartGame()
    {
        // Do everything we need to start the game
        // Spawn Player
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        // Spawn a tank pawn (and store it in tanks)
        Pawn tempTankPawn = SpawnTank(playerPawnPrefab);

        // Spawn a player controller (and store it in players)
        Controller tempPlayerController = SpawnPlayerController(playerControllerPrefab);

        // Have the player possess the pawn\
        tempPlayerController.Possess(tempTankPawn);
    }

    public Pawn SpawnTank(GameObject prefab) 
    {
        GameObject tempTankObject = Instantiate<GameObject>(prefab, spawnLocation.position, Quaternion.identity);
        return tempTankObject.GetComponent<Pawn>();
    }

    public Controller SpawnPlayerController (GameObject prefab)
    {
        GameObject tempPlayer = Instantiate<GameObject>(prefab, Vector3.zero, Quaternion.identity);
        return tempPlayer.GetComponent<Controller>();
    }
}
