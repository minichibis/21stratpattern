/** Sam Carpenter
*   Week 2
*   Skeleton.cs
*   enemy that resists bleed
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
	
	public override void PerformInjured(){
		InjureBehavior.injure(this);
	}
	
	public override bool GetResistBleed(){
		return true;
	}
	
	public override void UpdateText(){
		if(injury == 1){
			t.text = "The skeleton is bleeding!";
		} else if(injury == 2){
			t.text = "The skeleton is poisoned!";
		} else if (injury == 3){
			t.text = "The skeleton's bones are broken!";
		} else{
			t.text = "The skeleton is uninjured!";
		}
	}
}