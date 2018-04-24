using System.Collections.Generic;
using System;

namespace QueenAttackApp
{
  public class QueenAttack
  {
    public bool ChackLeftToRightDownDiagonal(int row1, int col1, int row2, int col2)
    {
        if (row1 + col1 == row2 + col2) {
          return true;
        }
        return false;
    }

    public bool ChackRightToLeftDownDiagonal(int row1, int col1, int row2, int col2)
    {
        col1 = 9 - col1;
        col2 = 9 - col2;
        if (row1 + col1 == row2 + col2) {
          return true;
        }
        return false;
    }

    public bool CheckRowAndColumn(int row1, int col1, int row2, int col2)
    {
        if (row1 == row2 || col1 == col2) {
            return true;
        }
        return false;
    }

    public bool CheckAll(int row1, int col1, int row2, int col2)
    {
        if (ChackRightToLeftDownDiagonal(row1,col1,row2,col2) || ChackLeftToRightDownDiagonal(row1,col1,row2,col2) || CheckRowAndColumn(row1,col1,row2,col2)) {
          return true;
        } else {
          return false;
        }
    }
  }
}
