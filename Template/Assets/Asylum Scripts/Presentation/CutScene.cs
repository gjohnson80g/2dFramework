using UnityEngine;
using System.Collections;


public class CutScene : MonoBehaviour 
{
	
	public float delay;
	public Texture2D[] images;
	public bool showButtons;
	public GUITexture container;
	public string nextScene;
	
	private int currentImage = 0;
	private int savedTime = 0;

	// Use this for initialization
	void Start ()
	{

		
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		int seconds = (int)Time.time;
		
			container.texture = images[currentImage];
		
		if (!showButtons)
		{
			if(seconds % delay == 0 && seconds != 0)
			{
				if(seconds != savedTime)
				{
					currentImage++;
				
					savedTime = seconds;
				}
				
				if (currentImage > images.Length - 1)
				{
					Application.LoadLevel(nextScene);
				}
			}
			
		}
		
	}
	
	void OnGUI()
	{
		if(showButtons)
		{
			float screenX = (float)((Screen.width * 0.5) - (200 * 0.5));
			float screenY = (float)((Screen.height) - (400 * 0.15));
			
			
		GUILayout.BeginArea (new Rect (screenX, screenY, 200.0f, 400.0f));  
		if(GUILayout.Button ("Next"))
		{
			
			currentImage++;
			
			if (currentImage == images.Length )
				{
					Application.LoadLevel(nextScene);
					
				}
				
			
		}	 
		
		if(GUILayout.Button ("Finish"))
		{
			Application.LoadLevel(nextScene);
		} 
		
		GUILayout.EndArea();
		}
	}
}
