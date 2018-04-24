using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttackApp;

namespace QueenAttackApp.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void CanAttackUpperRightDiagonal_QueenIn1AFigure7G_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CanAttackUpperRightDiagonal(1,1,7,7));
    }

    [TestMethod]
    public void CanAttackLowerLeftDiagonal_QueenIn8HFigure2B_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CanAttackLowerLeftDiagonal(8,8,2,2));
    }

    [TestMethod]
    public void CanAttackUpperLeftDiagonal_QueenIn3CFigure5A_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CanAttackUpperLeftDiagonal(3,3,5,1));//coordinates passed in a reversed manner;
    }
// Testing the same function on different diagonals.
    [TestMethod]
    public void CheckAllDiagonals_QueenIn3CFigure5A_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CheckAllDiagonals(3,3,5,1));
    }

    [TestMethod]
    public void CheckAllDiagonals_QueenIn2EFigure5H_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CheckAllDiagonals(2,5,5,8));
    }

    [TestMethod]
    public void CheckRowAndColumn_QueenIn2EFigure2H_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CheckRowAndColumn(2,5,2,8));
    }

  }
}
