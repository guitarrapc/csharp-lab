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
| **AllocateStringStatic** | **1**      |   **749.3 ns** |   **460.8 ns** | **25.26 ns** |   **734.4 ns** |   **778.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   737.3 ns |   548.0 ns | 30.04 ns |   704.9 ns |   764.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   711.7 ns |   466.1 ns | 25.55 ns |   693.2 ns |   740.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   744.2 ns |   264.3 ns | 14.49 ns |   727.5 ns |   753.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.8 ns |   518.8 ns | 28.44 ns |   707.3 ns |   756.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,234.8 ns** | **1,095.2 ns** | **60.03 ns** | **2,172.3 ns** | **2,292.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,166.6 ns |   801.5 ns | 43.93 ns | 2,115.9 ns | 2,192.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,155.2 ns | 1,142.6 ns | 62.63 ns | 2,084.3 ns | 2,203.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,232.4 ns |   920.5 ns | 50.45 ns | 2,183.0 ns | 2,283.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,230.2 ns | 1,208.3 ns | 66.23 ns | 2,173.1 ns | 2,302.8 ns | 0.0343 | 0.0305 |   3.07 KB |
