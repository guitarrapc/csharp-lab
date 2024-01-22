```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **743.2 ns** |   **292.96 ns** |  **16.06 ns** |   **725.1 ns** |   **755.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   731.4 ns |   183.96 ns |  10.08 ns |   719.8 ns |   737.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   678.2 ns |    70.33 ns |   3.85 ns |   673.8 ns |   680.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   714.4 ns |   331.96 ns |  18.20 ns |   703.3 ns |   735.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   708.8 ns |   400.78 ns |  21.97 ns |   694.4 ns |   734.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,591.1 ns** | **2,475.77 ns** | **135.71 ns** | **7,435.2 ns** | **7,682.3 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,317.6 ns | 1,599.45 ns |  87.67 ns | 7,246.2 ns | 7,415.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,075.1 ns | 1,694.55 ns |  92.88 ns | 6,990.9 ns | 7,174.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,324.3 ns |   639.21 ns |  35.04 ns | 7,286.2 ns | 7,355.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,266.6 ns | 2,543.97 ns | 139.44 ns | 7,118.7 ns | 7,395.7 ns | 0.1221 | 0.1144 |  10.23 KB |
