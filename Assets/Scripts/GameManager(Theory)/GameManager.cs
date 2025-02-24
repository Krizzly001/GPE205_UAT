using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Make a static instance
    public static GameManager instance;
    public PlayerController playerController;

    // Prefabs
    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab;
    public Transform playerSpawnTransform;


    // List that holds our player(s)
    public List<PlayerController> players;

    public void SpawnPlayer()
    {
        // Spawn Player controller prefab at (0,0,0) location with no rotation
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity) as GameObject;

        // Spawn the tankPawn and connect it to the controller
        GameObject newPawnObj = Instantiate(tankPawnPrefab, playerSpawnTransform.position, playerSpawnTransform.rotation) as GameObject;

        Controller newController = newPlayerObj.GetComponent<Controller>();
        Pawn newPawn = newPawnObj.GetComponent<Pawn>();

        // Hook them up!
        newController.pawn = newPawn;



    }
    


     

    // Awake called before start() can run
    // Makes sure
    private void Awake()
    {
        // If are instance doesnt exist yet...
        if(instance == null)
        {
            //This is the instance
            // this == class GameManager
            instance = this;

            //Dont destroy the singlton, if we load a new scene
            DontDestroyOnLoad(gameObject);
        }
        else{
            // but if it does have a instance, destroy this game object
            Destroy(gameObject);
        }
        
    }
    






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.DoStuff();
        SpawnPlayer();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   

    public void DoStuff()
    {
        Debug.Log("GameManager is doing stuff!");
    }

     public void RegisterPlayerController(PlayerController controller)
    {
        playerController = controller;
    }
}
