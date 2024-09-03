```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **757.1 ns** |   **556.8 ns** | **30.52 ns** |   **721.9 ns** |   **774.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   739.8 ns |   551.3 ns | 30.22 ns |   717.1 ns |   774.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   718.7 ns |   110.1 ns |  6.04 ns |   712.0 ns |   723.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   747.8 ns |   248.9 ns | 13.64 ns |   737.9 ns |   763.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   720.0 ns |   344.0 ns | 18.86 ns |   698.2 ns |   731.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,238.5 ns** | **1,200.9 ns** | **65.83 ns** | **2,181.7 ns** | **2,310.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,177.0 ns |   803.5 ns | 44.04 ns | 2,146.5 ns | 2,227.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,223.6 ns | 1,658.9 ns | 90.93 ns | 2,163.6 ns | 2,328.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,207.8 ns |   342.1 ns | 18.75 ns | 2,187.3 ns | 2,224.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,129.7 ns |   464.9 ns | 25.49 ns | 2,103.1 ns | 2,153.9 ns | 0.0343 | 0.0305 |   3.07 KB |
