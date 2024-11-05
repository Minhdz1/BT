using System;

[Serializable]
public class HighSocreElement
{
    public string playerName;
    public int point;

    public HighSocreElement(string name, int point){

        playerName = name;
        this.point = point;
        }

}
