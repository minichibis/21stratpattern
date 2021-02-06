/** Sam Carpenter
*   Week 2
*   Goblin.cs
*   fragile goods
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
	
	public override void PerformInjured(){
		InjureBehavior.injure(this);
	}
	
	public override bool GetResistBleed(){
		return false;
	}
	
	public override void UpdateText(){
		if(injury == 1){
			t.text = "The goblin is bleeding!";
		} else if(injury == 2){
			t.text = "The goblin is poisoned!";
		} else if (injury == 3){
			t.text = "The goblin's bones are broken!";
		} else{
			t.text = "The goblin is uninjured!";
		}
	}
}
