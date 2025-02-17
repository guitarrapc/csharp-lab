namespace TutorialConsoleApp;

public class DoubleLookBreak
{
    /// <summary>
    /// break can't be non-local exit.
    /// </summary>
    public void BreakCantJumpDoubleLoop()
    {
        Console.WriteLine($"  DONT: {nameof(BreakCantJumpDoubleLoop)}");
        var range = Enumerable.Range(0, 2);
        foreach (var outer in range)
        {
            Console.WriteLine($"    1st Loop {outer}");
            foreach (var inner in range)
            {
                Console.WriteLine($"      2nd Loop {inner} ({outer})");
                if (inner == 1)
                {
                    Console.WriteLine("        Break");
                    break;
                }
            }
        }
        Console.WriteLine("  End loop\n");

        /*
         * 1st Loop 0
         *   2nd Loop 0 (0)
         *   2nd Loop 1 (0)
         *     Break           <- Break from inside loop.
         * 1st Loop 1          <- break can't be non-local exits.
         *   2nd Loop 0 (1)
         *   2nd Loop 1 (1)
         *     Break
         * End loop
         */
    }

    /// <summary>
    /// Goto can be non-local exists.
    /// </summary>
    public void DoubleLoopGoto()
    {
        Console.WriteLine($"  DO: {nameof(DoubleLoopGoto)}");
        var range = Enumerable.Range(0, 2);
        foreach (var outer in range)
        {
            Console.WriteLine($"    1st Loop {outer}");
            foreach (var inner in range)
            {
                Console.WriteLine($"      2nd Loop {inner} ({outer})");
                if (inner == 1)
                {
                    Console.WriteLine("        Break");
                    goto End;
                }
            }
        }

    End:
        Console.WriteLine("  End loop\n");

        /*
         * 1st Loop 0
         *   2nd Loop 0 (0)
         *   2nd Loop 1 (0)
         *     Break          <- Break from inside and outside loop.
         * End loop           <- goto can be non-local exits.
         */
    }

    /// <summary>
    /// Return can exit from double loop.
    /// </summary>
    public void DoubleLoopReturn()
    {
        Console.WriteLine($"  WARN: {nameof(DoubleLoopReturn)}");
        var range = Enumerable.Range(0, 2);
        foreach (var outer in range)
        {
            Console.WriteLine($"    1st Loop {outer}");
            foreach (var innner in range)
            {
                Console.WriteLine($"      2nd Loop {innner} ({outer})");
                if (innner == 1)
                {
                    Console.WriteLine("        Break\n");
                    return;
                }
            }
        }
        Console.WriteLine("  End loop");

        /*
         * 1st Loop 0
         *     2nd Loop 0 (0)
         *     2nd Loop 1 (0)
         *       Break          <- Break from inside and outside loop.
         *                      <- return can't call least expression without finally.
         */
    }

    /// <summary>
    /// Split loop method to each can exit from double loop.
    /// </summary>
    public void DoubleLoopSplitMethod()
    {
        Console.WriteLine($"  DO: {nameof(DoubleLoopSplitMethod)}");
        var range = Enumerable.Range(0, 2);
        foreach (var outer in range)
        {
            Console.WriteLine($"    1st Loop {outer}");
            if (!TryInsideLoop(outer, range))
            {
                break;
            }
        }
        Console.WriteLine("  End loop\n");

        bool TryInsideLoop(int element, IEnumerable<int> range)
        {
            foreach (var inner in range)
            {
                Console.WriteLine($"      2nd Loop {inner} ({element})");
                if (inner == 1)
                {
                    Console.WriteLine("        Break");
                    return false;
                }
            }
            return true;
        }

        /*
         * 1st Loop 0
         *   2nd Loop 0 (0)
         *   2nd Loop 1 (0)
         *     Break          <- Break from inside and outside loop.
         * End loop           <- Spliting method can handle return.
         */
    }
}
