
var areaWidth : float;

var areaHeight : float;

function OnGUI()
{
	//GUI.skin = mainmenuSkin;
	
	var ScreenX = ((Screen.width * 0.5) - (areaWidth * 0.5));
	var ScreenY = ((Screen.height) - (areaHeight * 0.5)); 
	
	GUILayout.BeginArea (Rect (ScreenX, ScreenY, areaWidth, areaHeight));  
	
		GUILayout.Label("Winnar");
		if(GUILayout.Button ("Menu"))
		{
			Application.LoadLevel("Menu");
		}	 
		
		
		GUILayout.EndArea();
}