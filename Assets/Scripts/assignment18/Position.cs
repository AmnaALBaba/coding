using UnityEngine;

namespace Assignment18
{
public struct Position
{
    public float x;
    public float y;
    public float z;
    public Position(float x , float y , float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }
    public void PrintPosition(){
        Debug.Log("Position(X = "+this.x + ",Y = "+this.y + ",Z) = "+this.z);
        

    }

  
}
}