```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **766.2 ns** |   **422.40 ns** |  **23.15 ns** |   **741.7 ns** |   **787.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   720.1 ns |   286.59 ns |  15.71 ns |   703.6 ns |   734.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   724.6 ns |    52.46 ns |   2.88 ns |   721.4 ns |   726.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   760.0 ns |   132.36 ns |   7.26 ns |   752.4 ns |   766.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   727.0 ns |   206.61 ns |  11.33 ns |   717.2 ns |   739.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,264.5 ns** | **1,881.25 ns** | **103.12 ns** | **2,159.9 ns** | **2,366.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,197.7 ns | 1,551.08 ns |  85.02 ns | 2,101.1 ns | 2,261.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,152.8 ns |   341.23 ns |  18.70 ns | 2,139.5 ns | 2,174.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,202.2 ns | 1,540.24 ns |  84.43 ns | 2,110.9 ns | 2,277.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,161.5 ns | 1,433.73 ns |  78.59 ns | 2,076.7 ns | 2,231.8 ns | 0.0343 | 0.0305 |   3.07 KB |
