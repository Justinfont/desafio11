using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //public Vector3 movimiento;
    public float speed = 3f;
    public int health = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movefoward();
        moveleft();
        moveright();
        movebackwards();
        camera_rotation_right();
        camera_rotation_left();
        healthstatus();
        gameover();
      
    }
    private void movefoward()
    {
                 if (Input.GetKey(KeyCode.W))
        {
         transform.Translate(Vector3.forward * speed * Time.deltaTime);
         
        }

    }
    private void moveright()
       {              if (Input.GetKey(KeyCode.D))
        {
       transform.Translate(Vector3.right * speed * Time.deltaTime); 
        } 
      
       }
    private void moveleft()
       {              if (Input.GetKey(KeyCode.A))
        {
       transform.Translate(Vector3.left * speed * Time.deltaTime); 
        } 
      
       }
    private void movebackwards()
       { 
            
                      if (Input.GetKey(KeyCode.S))
        {
                        
       transform.Translate(Vector3.back * speed * Time.deltaTime); 
        } 
      
       }
         
   public void camera_rotation_left() 
   {
      if (Input.GetKey(KeyCode.LeftArrow))
      {
         transform.Rotate(0,-2,0);
      }
   }
     public void camera_rotation_right() 
   {
      if (Input.GetKey(KeyCode.RightArrow))
      {
         transform.Rotate(0,2,0);
      }
   }


   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("healing_sphere"))
      {
         Destroy(other.gameObject);
         health++;
      }

      if (other.CompareTag("posion_sphere"))
      {
         Destroy(other.gameObject);
         health--;  
      }

   }

   private void healthstatus()
   {
   HudManager.instance.SetSelectedText(health.ToString());
   }

   public void gameover()
   {
      if (health <= 0)
      {
         Destroy(gameObject);
         Debug.Log("Game Over");
      }
   }

}
