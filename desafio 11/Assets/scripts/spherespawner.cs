using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherespawner : MonoBehaviour
{
      public GameObject sphere;
      public GameObject sphere2;

    private Vector3 SpawnLocation;

    private int spawncooldown;
    
    [SerializeField]
    [Range(0f,5f)]
    public int maxspawn;
     [SerializeField]
    [Range(0f,5f)]
    public int maxspawn2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    spawner();
    spawner2();

    }

    public void spawner()
    {
    
         if (Input.GetKey(KeyCode.Alpha1))
    
    {
      if (maxspawn  <  5  )
        {   
        SpawnLocation = new Vector3(Random.Range(-16f,16f),1, Random.Range(-16f,16f));
        Instantiate (sphere,transform.position = SpawnLocation ,transform.rotation);
        maxspawn++; 
        }   
    }
    }
    
    
    public void spawner2()
    {
       if (Input.GetKey(KeyCode.Alpha1))
       {  

     if (maxspawn2  <  5  )
        {
        SpawnLocation = new Vector3(Random.Range(-16f,16f),1, Random.Range(-16f,16f));
        Instantiate (sphere2,transform.position = SpawnLocation ,transform.rotation);
        maxspawn2++; 
        }   
       }

    }





}




