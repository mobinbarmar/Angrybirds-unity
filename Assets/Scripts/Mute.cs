using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    private bool mute = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MuteToggle(){
        if(mute == false){
            mute = true;
            AudioListener.volume = 0;
        }else{
            mute = false;
            AudioListener.volume = 1;
        }
    }
    
}
