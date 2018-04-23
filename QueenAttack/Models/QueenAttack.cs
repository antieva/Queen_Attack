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
            if (i == row2 && tmp == col2) {
              return true;
            }
            tmp--;
        }
        return false;
    }
  }
}
