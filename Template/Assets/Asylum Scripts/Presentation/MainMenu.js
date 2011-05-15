//var mainmenuSkin : GUISkin;

var areaWidth : float;

var areaHeight : float;

function OnGUI()
{
	//GUI.skin = mainmenuSkin;
	
	var ScreenX = ((Screen.width * 0.5) - (areaWidth * 0.5));
	var ScreenY = ((Screen.height) - (areaHeight * 0.5)); 
	
	GUILayout.BeginArea (Rect (ScreenX, ScreenY, areaWidth, areaHeight));  
		if(GUILayout.Button ("Splash Screen Demo"))
		{
			Application.LoadLevel("Splash");
		}	 
		
		if(GUILayout.Button ("Timer Controlled Cutscene Demo"))
		{
			Application.LoadLevel("Cutscene");
		} 
		if(GUILayout.Button ("Cutscene w/ Buttons Demo"))
		{
			Application.LoadLevel("CutsceneButtons");
		} 
		if(GUILayout.Button ("Cuberunner Demo"))
		{
			Application.LoadLevel("Cuberunner");
		} 
		
		GUILayout.EndArea();
}