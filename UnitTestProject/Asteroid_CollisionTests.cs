using LeetCode;
using LeetCode.Model;
using LeetCode.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class Asteroid_CollisionTests
    {
        [TestMethod]
        public void AsteroidCollisionTests()
        {
            Asteroid_Collision obj = new Asteroid_Collision();

            var asteroids = new int[] { 5, 10, -5 };
            var x = obj.AsteroidCollision(asteroids);//[5, 10]

            asteroids = new int[] { 8, -8 };
            x = obj.AsteroidCollision(asteroids);// []

            asteroids = new int[] { 10, 2, -5 };
            x = obj.AsteroidCollision(asteroids);//[10]

            asteroids = new int[] { -2, -1, 1, 2 };
            x = obj.AsteroidCollision(asteroids);//[-2, -1, 1, 2]


            asteroids = new int[] { 1,-2,-2,-2 };
            x = obj.AsteroidCollision(asteroids);//[-2,-2]

    }

    }

}
