using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    public Texture2D buttonimage;
    public Vector2 position = new Vector2(500, 50);
    public Vector2 size = new Vector2(2000, 2000);
    public string labelText = "Player Stat Here";




    private void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 1370, 620), "NIGHTFIX SURVIVORS");

        if (GUI.Button(new Rect(100, 100, 100, 100), "Player 1 Stats"))

        {
            print("Player 1");
            labelText = "Name: Enzo\r\nAttack: 50\r\nDefense: 70\r\nSpeed: 70\r\nLuck: 5\r\nIntelligence: 90\r\nSpecial: 10";

        }

        if (GUI.Button(new Rect(100, 250, 100, 100), "Player 2 Stats"))

        {
            print("Player 2");
            labelText = "Name: Theo\r\nAttack: 25\r\nDefense: 100\r\nSpeed: 50\r\nLuck: 6\r\nIntelligence: 80\r\nSpecial: 15";

        }

        if (GUI.Button(new Rect(100, 400, 100, 100), "Player 3 Stats"))

        {
            print("Player 3");
            labelText = "Name: Mateo\r\nAttack: 100\r\nDefense: 40\r\nSpeed: 150\r\nLuck: 3\r\nIntelligence: 150\r\nSpecial: 20";
        }

        if (GUI.Button(new Rect(100, 550, 100, 100), "Player 4 Stats"))

        {
            print("Player 4");
            labelText = "Name: Warleyne\r\nAttack:200\r\nDefense: 100\r\nSpeed: 20\r\nLuck: 6\r\nIntelligence: 150\r\nSpecial: 17";
        }

        GUI.Label(new Rect(800, 300, 200, 200), labelText);
    }
}
