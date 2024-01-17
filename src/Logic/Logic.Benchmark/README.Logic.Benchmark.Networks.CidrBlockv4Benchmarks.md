```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                    | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|-------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **CidrBlockV4NewString**      | **1**      |  **67.5462 ns** |  **3.5111 ns** | **0.1925 ns** |  **67.4217 ns** |  **67.7679 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  73.6184 ns |  1.1749 ns | 0.0644 ns |  73.5700 ns |  73.6915 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0435 ns |  0.1929 ns | 0.0106 ns |   3.0364 ns |   3.0556 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **662.8892 ns** | **31.3493 ns** | **1.7184 ns** | **661.3583 ns** | **664.7479 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3112 ns |  0.2781 ns | 0.0152 ns |   3.3014 ns |   3.3287 ns |         - |
| CidrBlockV4TryParseString | 10     | 720.9207 ns | 20.2415 ns | 1.1095 ns | 720.0212 ns | 722.1605 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.4198 ns |  1.9437 ns | 0.1065 ns |  28.3489 ns |  28.5423 ns |         - |
