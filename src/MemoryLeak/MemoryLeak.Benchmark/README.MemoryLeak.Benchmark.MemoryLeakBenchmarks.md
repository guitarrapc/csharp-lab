```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **730.6 ns** |   **226.2 ns** |  **12.40 ns** |   **723.1 ns** |   **744.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   729.0 ns |   403.5 ns |  22.12 ns |   704.1 ns |   746.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   718.2 ns |   173.4 ns |   9.50 ns |   708.9 ns |   727.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   719.7 ns |   478.7 ns |  26.24 ns |   696.0 ns |   747.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   706.7 ns |   325.5 ns |  17.84 ns |   694.7 ns |   727.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,614.5 ns** | **4,096.7 ns** | **224.55 ns** | **7,394.9 ns** | **7,843.7 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,235.4 ns | 2,975.6 ns | 163.10 ns | 7,055.8 ns | 7,374.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,209.1 ns |   685.0 ns |  37.55 ns | 7,167.7 ns | 7,240.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,445.8 ns | 2,697.8 ns | 147.88 ns | 7,338.6 ns | 7,614.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,364.8 ns | 4,396.2 ns | 240.97 ns | 7,127.9 ns | 7,609.7 ns | 0.1221 | 0.1144 |  10.23 KB |
