```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.0920 ns** | **0.7117 ns** | **0.0390 ns** |  **50.0477 ns** |  **50.1215 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6243 ns | 0.1196 ns | 0.0066 ns |   0.6182 ns |   0.6312 ns |         - |
| TryParseCidrString | 1      |  52.3427 ns | 2.0563 ns | 0.1127 ns |  52.2625 ns |  52.4716 ns |         - |
| TryParseCidrBytes  | 1      |   3.0196 ns | 0.0891 ns | 0.0049 ns |   3.0164 ns |   3.0253 ns |         - |
| **NewFromCidrString**  | **3**      | **148.1681 ns** | **4.0156 ns** | **0.2201 ns** | **147.9931 ns** | **148.4153 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6196 ns | 0.0416 ns | 0.0023 ns |   0.6178 ns |   0.6222 ns |         - |
| TryParseCidrString | 3      | 154.5754 ns | 2.4965 ns | 0.1368 ns | 154.4907 ns | 154.7333 ns |         - |
| TryParseCidrBytes  | 3      |   8.9424 ns | 0.9911 ns | 0.0543 ns |   8.8801 ns |   8.9801 ns |         - |
