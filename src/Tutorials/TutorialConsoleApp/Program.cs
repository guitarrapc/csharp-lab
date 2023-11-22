using TutorialConsoleApp;

// ThreadPool
Console.WriteLine("# STEP1. ThreadPool configuration.");
AppThreadPool.ShowCurrent(); // before
AppThreadPool.Configure();   // set
AppThreadPool.ShowCurrent(); // after

// DoubleLoopBreak
Console.WriteLine("# STEP2. Double Loop Break.");
var doubleLoop = new DoubleLookBreak();
doubleLoop.BreakCantJumpDoubleLoop();
doubleLoop.DoubleLoopGoto();
doubleLoop.DoubleLoopReturn();
doubleLoop.DoubleLoopSplitMethod();
