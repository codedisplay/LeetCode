using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TaskSchedulerTests
    {
        [TestMethod]
        public void LeastIntervalTests()
        {
            TaskScheduler obj = new TaskScheduler();

            char[] tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            int n = 2;

            var x = obj.LeastInterval(tasks, n);

            //A->B->idle->A->B->idle->A->B
            //There is at least 2 units of time between any two same tasks.

            tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            n = 0;

            x = obj.LeastInterval(tasks, n);

            //Explanation: On this case any permutation of size 6 would work since n = 0.
            //['A', 'A', 'A', 'B', 'B', 'B']
            //['A', 'B', 'A', 'B', 'A', 'B']
            //['B', 'B', 'B', 'A', 'A', 'A']...
            //And so on.

            tasks = new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            n = 2;

            x = obj.LeastInterval(tasks, n);
            //One possible solution is
            //A -> B->C->A->D->E->A->F->G->A->idle->idle->A->idle->idle->A
        }
    }
}
