using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Make a static instance
    public static GameManager instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoStuff()
    {
        Debug.Log("GameManager is doing stuff!");
    }
}
