using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HudManager : MonoBehaviour
{
   [SerializeField] public Text salud;
  public static HudManager instance;
    // Start is called before the first frame update
    void Start()
    {
    Awake();    
    }

    // Update is called once per frame
    void Update()
    {
    
    }

      private void Awake()

  {

    if (instance == null)
    {
      instance = this;
      Debug.Log(instance);
      DontDestroyOnLoad(gameObject);
      
    }
  }

    public void SetSelectedText(string newText)
    {
        salud.text = newText;
    }

}
