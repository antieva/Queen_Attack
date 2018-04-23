using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttackApp;

namespace QueenAttackApp.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void CanAttackUpperRightDiagonal_QueenInLeftLowerCorner_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CanAttackUpperRightDiagonal(2,3,6,7));
    }

    [TestMethod]
    public void CanAttackLowerLeftDiagonal_QueenInRightUpperCorner_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CanAttackLowerLeftDiagonal(2,3,1,2));
    }

    [TestMethod]
    public void CanAttackUpperLeftDiagonal_QueenInRightUpperCorner_True()
    {
        QueenAttack testQueenAttack = new QueenAttack();
        Assert.AreEqual(true, testQueenAttack.CanAttackUpperLeftDiagonal(1,8,4,5));
    }
  }
}
