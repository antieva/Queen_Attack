using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttackApp;

namespace QueenAttackApp.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void ChackLeftToRightDownDiagonal_QueenIn3AFigure1C_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.ChackLeftToRightDownDiagonal(3,1,1,3));
    }

    [TestMethod]
    public void ChackRightToLeftDownDiagonal_QueenIn8HFigure2B_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.ChackRightToLeftDownDiagonal(8,8,2,2));
    }

    [TestMethod]
    public void CheckRowAndColumn_QueenIn2EFigure2H_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CheckRowAndColumn(2,5,2,8));
    }

    [TestMethod]
    public void CheckAll_QueenIn2EFigure5H_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CheckAll(2,5,5,8));
    }

  }
}
