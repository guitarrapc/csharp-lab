```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.64 ns** | **2.623 ns** | **0.144 ns** |  **61.55 ns** |  **61.81 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.14 ns | 0.318 ns | 0.017 ns |  57.12 ns |  57.16 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.71 ns** | **4.338 ns** | **0.238 ns** | **119.52 ns** | **119.97 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.65 ns | 0.755 ns | 0.041 ns | 114.61 ns | 114.69 ns |      - |         - |
