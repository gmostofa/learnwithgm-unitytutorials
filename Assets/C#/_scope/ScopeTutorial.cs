using UnityEngine;

public class ScopeTutorial : MonoBehaviour
{
   int globalVariable = 0;

   void testFuntion()
   {
      globalVariable++;
   }

   void TestFuction2()
   {
      int a;

      a = 10;
      globalVariable = a;
   }
   
   void TestFuction3()
   {
      int b;
      b = 10;
      globalVariable = b;
   }
}

public class TestClass
{
   int globalVariable = 0;
}
