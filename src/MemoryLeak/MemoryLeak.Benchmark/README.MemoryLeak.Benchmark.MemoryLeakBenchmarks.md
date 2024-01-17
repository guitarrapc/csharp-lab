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
| **AllocateStringStatic** | **1**      |   **774.3 ns** |   **544.8 ns** |  **29.86 ns** |   **744.1 ns** |   **803.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   737.6 ns |   286.9 ns |  15.72 ns |   721.5 ns |   752.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.9 ns |   534.6 ns |  29.30 ns |   677.2 ns |   729.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   744.8 ns |   391.3 ns |  21.45 ns |   720.0 ns |   758.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   734.8 ns |   416.7 ns |  22.84 ns |   709.0 ns |   752.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,714.7 ns** | **2,771.4 ns** | **151.91 ns** | **7,571.5 ns** | **7,874.0 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,322.4 ns | 1,270.8 ns |  69.66 ns | 7,250.5 ns | 7,389.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,051.3 ns | 3,124.0 ns | 171.24 ns | 6,855.5 ns | 7,173.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,250.6 ns | 3,070.8 ns | 168.32 ns | 7,074.8 ns | 7,410.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,103.4 ns | 2,041.5 ns | 111.90 ns | 6,998.2 ns | 7,221.0 ns | 0.1221 | 0.1144 |  10.23 KB |
