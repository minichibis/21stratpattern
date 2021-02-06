/** Sam Carpenter
*   Week 2
*   BoneShatter.cs
*   make em into beanbag chairs
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneShatter: MonoBehaviour, InjureBehavior
{
    public void injure(Enemy e){
		e.injury = 3;
	}
}

