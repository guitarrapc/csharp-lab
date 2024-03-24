```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **771.1 ns** |   **128.11 ns** |  **7.02 ns** |   **763.4 ns** |   **777.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   727.2 ns |   487.87 ns | 26.74 ns |   705.8 ns |   757.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   716.6 ns |    29.14 ns |  1.60 ns |   715.0 ns |   718.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   753.4 ns |   285.65 ns | 15.66 ns |   737.5 ns |   768.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.0 ns |   414.65 ns | 22.73 ns |   707.5 ns |   752.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,242.1 ns** | **1,632.16 ns** | **89.46 ns** | **2,158.3 ns** | **2,336.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,161.4 ns | 1,130.01 ns | 61.94 ns | 2,111.4 ns | 2,230.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,084.9 ns |   877.23 ns | 48.08 ns | 2,040.6 ns | 2,136.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,192.6 ns |   929.82 ns | 50.97 ns | 2,140.9 ns | 2,242.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,208.2 ns |   918.34 ns | 50.34 ns | 2,175.9 ns | 2,266.2 ns | 0.0343 | 0.0305 |   3.07 KB |
