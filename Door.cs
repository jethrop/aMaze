using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
	bool opening = false;
	public float stopHeight;
	//Audio
	public AudioClip[] doorSounds;
	public AudioSource doorSoundSource;

	void Start () {
		locked.Equals (true);
		opening.Equals (false);
		print ("locked is");
		print (locked);
		print ("opening is");
		print (opening);
		print ("Variables have been set");
	}

public void Unlock () {
	// You'll need to set "locked" to false here
	locked.Equals (false);
	print ("Door is unlocked");
		print (locked);
}	
    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
		if (locked.Equals (false)) {
			opening.Equals (true); 
			print ("Door should be opening");
		} else {
			doorSoundSource.clip = doorSounds [1];
			doorSoundSource.Play ();
			print ("Door is locked");
		}
	}
        // (optionally) Else
            // Play a sound to indicate the door is locked


void Update() {
		print (locked);
		//print (opening);
		while (opening.Equals (true)) {
			if (transform.position.y < stopHeight) {
				transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
				doorSoundSource.clip = doorSounds [0];
				doorSoundSource.Play ();
				print ("Door is opening");
			}
		}
	}


}

