```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **753.7 ns** |   **223.7 ns** | **12.26 ns** |   **743.8 ns** |   **767.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   716.9 ns |   401.6 ns | 22.02 ns |   695.3 ns |   739.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   702.9 ns |   327.9 ns | 17.97 ns |   682.2 ns |   714.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   731.7 ns |   496.7 ns | 27.22 ns |   710.4 ns |   762.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   721.8 ns |   357.4 ns | 19.59 ns |   699.2 ns |   734.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,230.2 ns** | **1,317.0 ns** | **72.19 ns** | **2,151.7 ns** | **2,293.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,114.1 ns | 1,537.1 ns | 84.25 ns | 2,026.5 ns | 2,194.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,116.3 ns |   872.1 ns | 47.80 ns | 2,087.4 ns | 2,171.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,148.9 ns | 1,534.6 ns | 84.12 ns | 2,059.9 ns | 2,227.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,122.1 ns | 1,058.8 ns | 58.03 ns | 2,085.5 ns | 2,189.0 ns | 0.0343 | 0.0305 |   3.07 KB |
