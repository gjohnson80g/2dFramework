using UnityEngine;
using System.Collections;

public class GUIHelper : MonoBehaviour  {

		
	public static void RelativeUI()
	//TODO; Set the correct height and width for your projects build settings
		{
			GUI.matrix = Matrix4x4.TRS( Vector3.zero,
												Quaternion.identity, 
												new Vector3(Screen.width / 1024.0f, Screen.height / 768.0f, 1.0f ) );
		}
	
	
}
