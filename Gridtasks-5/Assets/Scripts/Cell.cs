using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    // Start is called before the first frame update
    private int X;
    private int Y;
   
 
    public void setValues(int row,int col)
    {
        X= row;
    

    }

    public int getRow()
    {
    
        return X;
    }
    public int getColumn()
    {
        return Y;

    }


}
