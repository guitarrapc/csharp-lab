```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **62.74 ns** | **4.115 ns** | **0.226 ns** |  **62.48 ns** |  **62.91 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.48 ns | 1.652 ns | 0.091 ns |  57.41 ns |  57.58 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.73 ns** | **4.399 ns** | **0.241 ns** | **120.55 ns** | **121.00 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.58 ns | 0.521 ns | 0.029 ns | 114.56 ns | 114.61 ns |      - |         - |
