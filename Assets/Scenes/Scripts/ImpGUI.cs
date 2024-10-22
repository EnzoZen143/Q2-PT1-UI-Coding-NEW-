using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    public Texture2D buttonimage;
    public Vector2 position = new Vector2(500, 50);
    public Vector2 size = new Vector2(2000, 2000);
    public string labelText = "Player Stat Here";

    public int Player1Attack;
    public int Player1Defense;
    public int Player1Speed;
    public int Player1Luck;
    public int Player1Intelligence;
    public int Player1Special;

    public int Player2Attack;
    public int Player2Defense;
    public int Player2Speed;
    public int Player2Luck;
    public int Player2Intelligence;
    public int Player2Special;

    public int Player3Attack;
    public int Player3Defense;
    public int Player3Speed;
    public int Player3Luck;
    public int Player3Intelligence;
    public int Player3Special;

    public int Player4Attack;
    public int Player4Defense;
    public int Player4Speed;
    public int Player4Luck;
    public int Player4Intelligence;
    public int Player4Special;

    private void OnGUI()
    {
        GUI.Box(new Rect(50, 50, 600, 620), "NIGHTFIX SURVIVORS");

        if (GUI.Button(new Rect(100, 100, 150, 100), "Enzo Villarin"))

        {
            print("Player 1");

            Player1Attack = 50;
            Player1Defense = 70;
            Player1Speed = 70;
            Player1Luck = 5;
            Player1Intelligence = 90;
            Player1Special = 10;

            labelText = $"Name: Enzo\r\nAttack: {Player1Attack}\r\nDefense: {Player1Defense}\r\nSpeed: {Player1Speed}\r\nLuck: {Player1Luck}\r\nIntelligence: {Player1Intelligence}\r\nSpecial: {Player1Special}";

        }

        if (GUI.Button(new Rect(100, 250, 150, 100), "Theo Baja"))

        {
            print("Player 2");

            Player2Attack = 25;
            Player2Defense = 100;
            Player2Speed = 50;
            Player2Luck = 6;
            Player2Intelligence = 80;
            Player2Special = 15;

            labelText = $"Name: Theo\r\nAttack: {Player2Attack}\r\nDefense: {Player2Defense}\r\nSpeed: {Player2Speed}\r\nLuck: {Player2Luck}\r\nIntelligence: {Player2Attack}\r\nSpecial: {Player2Attack}";

        }

        if (GUI.Button(new Rect(100, 400, 150, 100), "Mateo Adora"))

        {
            print("Player 3");

            Player3Attack = 100;
            Player3Defense = 40;
            Player3Speed = 150;
            Player3Luck = 3;
            Player3Intelligence = 150;
            Player3Special = 20;

            labelText = $"Name: Mateo\r\nAttack: {Player3Attack}\r\nDefense: {Player3Defense}\r\nSpeed: {Player3Speed}\r\nLuck: {Player3Luck}\r\nIntelligence: {Player3Intelligence}\r\nSpecial: {Player3Special}";
        }

        if (GUI.Button(new Rect(100, 550, 150, 100), "Warleyne Casanova"))

        {
            print("Player 4");

            Player4Attack = 200;
            Player4Defense = 100;
            Player4Speed = 20;
            Player4Luck = 6;
            Player4Intelligence = 150;
            Player4Special = 17;

            labelText = $"Name: Warleyne\r\nAttack:{Player4Attack}\r\nDefense: {Player4Defense}\r\nSpeed: {Player4Speed}\r\nLuck: {Player4Luck}\r\nIntelligence: {Player4Intelligence}\r\nSpecial: {Player4Special}";
        }

            GUI.Label(new Rect(400, 300, 200, 200), labelText);
    }
}
