using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
   public Grid grid;
    private int row,col;
    int currrow, currcol;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("PlayerIntializer",1);
      
       
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currcol >=0 && currcol < col)
            {
               
                if (currcol != 0)
                {
                    currcol--;
                }
                this.transform.position = grid.cells[currrow][currcol].transform.position + new Vector3(0, 1f, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (currcol >=0 && currcol < col)
            {
                if (currcol < col-1)
                {
                    currcol++;
                }
                
                this.transform.position = grid.cells[currrow][currcol].transform.position + new Vector3(0, 1f, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (currrow >=0 && currrow < row)
            {
                if (currrow != 0)
                {
                    currrow--;
                }
               
                this.transform.position = grid.cells[currrow][currcol].transform.position + new Vector3(0, 1f, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (currrow >=0 && currrow < row)
            {
                if (currrow < row - 1)
                {
                    currrow++;
                }
               
                this.transform.position = grid.cells[currrow][currcol].transform.position + new Vector3(0, 1f, 0);
            }
        }
    }
    //void VerticalMovementUpward()
    //{
    //    transform.position = new Vector3();
    //}
    //void VerticalMovementDownward()
    //{
    //    transform.position = new Vector3();
    //}
    //void HorizonalMovementleft()
    //{

    //}
    //void HorizonalMovementRight()
    //{

    //}
   void PlayerIntializer()
    {
        int a = grid.Initializer();
        currrow = a;
        currcol = a;
        this.transform.position = grid.cells[a][a].transform.position + new Vector3(0,1f,0);
        row = grid.rows;
        col = grid.Columns;
    }
}
