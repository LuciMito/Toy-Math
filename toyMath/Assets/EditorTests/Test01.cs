using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test01
{

    [Test]
    public void TestarSeNaoVaiHaverMovimentoNaHorizontal()
    {
        Player p = new Player();
        ArrayList jumpVector = p.JumpTest("Jump", false);
        Assert.AreEqual(0f, jumpVector[0]);
    }

    [Test]
    public void TestarValorDaForcaDoPulo()
    {
        Player p = new Player();
        ArrayList jumpVector = p.JumpTest("Jump", false);
        Assert.AreEqual(20f, jumpVector[1]);
    }

    [Test]
    public void TestarValorDaVelocidade()
    {
        Player p = new Player();
        ArrayList moveVector = p.MoveTest("Horizontal");
        Assert.AreEqual(8f, moveVector[0]);
    }

    [Test]
    public void TestarSeNaoVaiHaverMovimentoNaVertical()
    {
        Player p = new Player();
        ArrayList moveVector = p.MoveTest("Horizontal");
        Assert.AreEqual(0f, moveVector[1]);
    }

    [Test]
    public void TestarSeNaoVaiHaverMovimentoNoEixoZ()
    {
        Player p = new Player();
        ArrayList moveVector = p.MoveTest("Horizontal");
        Assert.AreEqual(0f, moveVector[2]);
    }

    [Test]
    public void TestarSeObjetoEhUmBrinquedo()
    {
        BoxDetecter bd = new BoxDetecter();
        ArrayList colliderVector = bd.ColliderTest("toy");
        Assert.AreEqual(true, colliderVector[0]);
    }

}
