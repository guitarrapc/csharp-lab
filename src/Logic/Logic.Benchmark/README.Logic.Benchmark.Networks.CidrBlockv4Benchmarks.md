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
| **CidrBlockV4NewString**      | **1**      |  **65.6420 ns** |  **4.0898 ns** | **0.2242 ns** |  **65.4858 ns** |  **65.8989 ns** |         **-** |
| CidrBlockV4NewBytes       | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| CidrBlockV4TryParseString | 1      |  74.0743 ns |  3.6561 ns | 0.2004 ns |  73.9383 ns |  74.3044 ns |         - |
| CidrBlockV4TryParseBytes  | 1      |   3.0585 ns |  0.7116 ns | 0.0390 ns |   3.0359 ns |   3.1036 ns |         - |
| **CidrBlockV4NewString**      | **10**     | **663.6370 ns** | **34.6663 ns** | **1.9002 ns** | **661.5954 ns** | **665.3538 ns** |         **-** |
| CidrBlockV4NewBytes       | 10     |   3.3122 ns |  0.1850 ns | 0.0101 ns |   3.3008 ns |   3.3203 ns |         - |
| CidrBlockV4TryParseString | 10     | 698.6010 ns |  1.1204 ns | 0.0614 ns | 698.5343 ns | 698.6553 ns |         - |
| CidrBlockV4TryParseBytes  | 10     |  28.4813 ns |  2.7378 ns | 0.1501 ns |  28.3542 ns |  28.6468 ns |         - |
