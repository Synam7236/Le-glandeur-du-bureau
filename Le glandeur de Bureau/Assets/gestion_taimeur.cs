using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gestion_taimeur : MonoBehaviour {
    public float temps = 60;
    public int maxTime = 120;
    public  Image timebar;

    void Start() {
        timebar = GetComponent<Image>();
    }
    
    void Update() {
        losingTime();
    }

    // Perd du temps
    public void losingTime() {
        temps -= Time.deltaTime;
        UpdateTime();
    }
    // Regagne du temps
    public void gainTime( float bonus ) {
        temps += bonus;
        UpdateTime();
    }

    // Actualise le temps pour rester entre 0 et le max
    private void UpdateTime() {
        temps = Mathf.Clamp( temps, 0, maxTime );
        timebar.fillAmount = temps / maxTime;
        if ( temps == 0 )
            SceneManager.LoadScene( 2 );
    }
}