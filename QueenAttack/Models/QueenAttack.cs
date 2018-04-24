using System.Collections.Generic;
using System;

namespace QueenAttackApp
{
  public class QueenAttack
  {
    public bool CanAttackUpperRightDiagonal(int row1, int col1, int row2, int col2)
    {
        int tmp = col1 +1;
        for (int i = row1 + 1; i <= 8; i++) {
            if (tmp == 9) {
              break;
            }
            if (i == row2 && tmp == col2) {
              return true;
            }
            tmp++;
        }
        return false;
    }

    public bool CanAttackLowerLeftDiagonal(int row1, int col1, int row2, int col2)
    {
        int tmp = col1 - 1;
        for (int i = row1 - 1; i >= 1; i--) {
            if (tmp == 0) {
              break;
            }
            if (i == row2 && tmp == col2) {
              return true;
            }
            tmp--;
        }
        return false;
    }
    public bool CanAttackUpperLeftDiagonal(int row1, int col1, int row2, int col2)
    {
        int tmp = col1 - 1;
        for (int i = row1 + 1; i <= 8; i++) {
            if (tmp == 0) {
              break;
            }
            if (i == row2 && tmp == col2) {
              return true;
            }
            tmp--;
        }
        return false;
    }

    public bool CheckAllDiagonals(int row1, int col1, int row2, int col2)
    {
        if (CanAttackUpperRightDiagonal(row1, col1, row2, col2) || CanAttackLowerLeftDiagonal(row1, col1, row2, col2) || CanAttackUpperLeftDiagonal(row1, col1, row2, col2) || CanAttackUpperLeftDiagonal(col1, row1, col2, row2)) {
            return true;
        } else {
            return false;
        }
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
        if (CheckAllDiagonals(row1,col1,row2,col2) || CheckRowAndColumn(row1,col1,row2,col2)) {
          return true;
        } else {
          return false;
        }
    }
  }
}
