```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **724.2 ns** |   **688.4 ns** | **37.74 ns** |   **688.5 ns** |   **763.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   719.2 ns |   258.0 ns | 14.14 ns |   703.0 ns |   728.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   681.6 ns |   460.5 ns | 25.24 ns |   657.6 ns |   707.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   710.4 ns |   564.4 ns | 30.94 ns |   690.9 ns |   746.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   694.6 ns |   477.2 ns | 26.16 ns |   664.4 ns |   710.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,171.6 ns** |   **313.5 ns** | **17.18 ns** | **2,154.8 ns** | **2,189.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,131.2 ns | 1,061.9 ns | 58.20 ns | 2,080.5 ns | 2,194.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,054.8 ns |   308.3 ns | 16.90 ns | 2,037.1 ns | 2,070.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,114.7 ns | 1,537.5 ns | 84.28 ns | 2,020.3 ns | 2,182.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,077.3 ns | 1,151.5 ns | 63.12 ns | 2,009.3 ns | 2,133.9 ns | 0.0343 | 0.0305 |   3.07 KB |
